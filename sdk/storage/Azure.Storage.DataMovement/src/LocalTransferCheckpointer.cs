﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.Storage.DataMovement
{
    /// <summary>
    /// Creates a checkpointer which uses a locally stored file to obtain
    /// the information in order to resume transfers in the future.
    /// </summary>
    public class LocalTransferCheckpointer : TransferCheckpointer
    {
        internal string _pathToCheckpointer;
        /// <summary>
        /// Stores references to the memory mapped files stored by ids
        /// </summary>
        internal Dictionary<string, Dictionary<int, MemoryMappedPlanFile>> _memoryMappedFiles;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="folderPath">Path to the file containing the checkpointing information to resume from.</param>
        public LocalTransferCheckpointer(string folderPath)
        {
            Argument.CheckNotNullOrEmpty(folderPath, nameof(folderPath));
            if (!Directory.Exists(folderPath))
            {
                throw new DirectoryNotFoundException($"The following directory path, \"{folderPath}\" was not found.");
            }
            FileAttributes attributes = File.GetAttributes(folderPath);
            if (attributes != FileAttributes.Directory)
            {
                throw new DirectoryNotFoundException($"The following directory path, \"{folderPath}\" was not found not to have the attributes of a Directory but of ${attributes}");
            }
            _pathToCheckpointer = folderPath;

            _memoryMappedFiles = new Dictionary<string, Dictionary<int, MemoryMappedPlanFile>>();
        }

        /// <summary>
        /// Adds a new transfer to the checkpointer.
        ///
        /// If the transfer id already exists, this method will throw.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override Task TryAddTransferAsync(string id)
        {
            if (!_memoryMappedFiles.ContainsKey(id))
            {
                // Create empty list of memory mapped job parts
                Dictionary<int, MemoryMappedPlanFile> tempJobParts = new Dictionary<int, MemoryMappedPlanFile>();
                _memoryMappedFiles.Add(id, tempJobParts);
            }
            else
            {
                throw new ArgumentException($"Transfer id {id} already has existing checkpoint information associated with the id. Consider cleaning out where the transfer information is stored.");
            }
            return Task.CompletedTask;
        }

        /// <summary>
        /// Creates a stream to the stored memory stored checkpointing information.
        /// </summary>
        /// <returns></returns>
        public override Task<Stream> ReadCheckPointStreamAsync(string id, int partNumber)
        {
            if (_memoryMappedFiles.TryGetValue(id, out Dictionary<int, MemoryMappedPlanFile> jobPartFiles))
            {
                if (!jobPartFiles.ContainsKey(partNumber))
                {
                    throw new ArgumentException($"Checkpointer information from Transfer id \"{id}\", at part number \"{partNumber}\" was not found. Cannot read from plan file");
                }
                return Task.FromResult<Stream>(jobPartFiles[partNumber].MemoryMappedFileReference.CreateViewStream());
            }
            else
            {
                throw new ArgumentException($"Checkpointer information from Transfer id \"{id}\", at part number \"{partNumber}\" was not found. Cannot read from plan file");
            }
        }

        /// <summary>
        /// Writes to the checkpointer to the stored memory checkpointing information.
        ///
        /// Creates the checkpoint file for the respective id if it does not currently exist
        /// </summary>
        /// <param name="id"></param>
        /// <param name="partNumber"></param>
        /// <param name="offset"></param>
        /// <param name="buffer"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public override async Task WriteToCheckpointAsync(
            string id,
            int partNumber,
            long offset,
            byte[] buffer,
            CancellationToken cancellationToken)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));
            Argument.AssertNotDefault(ref partNumber, nameof(partNumber));
            if (buffer?.Length == 0)
            {
                throw new ArgumentException("Buffer cannot be empty");
            }
            if (_memoryMappedFiles.TryGetValue(id, out Dictionary<int, MemoryMappedPlanFile> jobPartFiles))
            {
                if (!jobPartFiles.ContainsKey(partNumber))
                {
                    MemoryMappedPlanFile mappedFile = new MemoryMappedPlanFile(id, partNumber);
                    _memoryMappedFiles[id].Add(partNumber, mappedFile);
                }
                else
                {
                    // partNumber file already exists
                    // lock file
                    await _memoryMappedFiles[id][partNumber].Semaphore.WaitAsync(cancellationToken).ConfigureAwait(false);

                    using (MemoryMappedViewAccessor accessor = _memoryMappedFiles[id][partNumber].MemoryMappedFileReference
                    .CreateViewAccessor(offset, buffer.Length, MemoryMappedFileAccess.Write))
                    {
                        accessor.WriteArray(0, buffer, 0, buffer.Length);
                        // to flush to the underlying file that supports the mmf
                        accessor.Flush();
                    }
                    // unlock file
                    _memoryMappedFiles[id][partNumber].Semaphore.Release();
                }
            }
            else
            {
                throw new ArgumentException($"Checkpointer information from Transfer id \"{id}\" was not found. Call TryAddTransferAsync before attempting to add transfer information");
            }
        }

        /// <summary>
        /// Removes transfer information of the respective id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override Task<bool> TryRemoveStoredTransferAsync(string id)
        {
            bool result = true;
            Argument.AssertNotNullOrWhiteSpace(id, nameof(id));
            if (!_memoryMappedFiles.TryGetValue(id, out Dictionary<int, MemoryMappedPlanFile> jobPartFiles))
            {
                throw new ArgumentException($"Checkpointer information from Transfer id \"{id}\" was not found. Call TryAddTransferAsync before attempting to add transfer information");
            }
            foreach (MemoryMappedPlanFile jobPartPair in jobPartFiles.Values)
            {
                try
                {
                    File.Delete(jobPartPair.FilePath);
                }
                catch (FileNotFoundException)
                {
                    // If we cannot find the file, it's either we deleted
                    // we have not created this job part yet.
                }
                catch
                {
                    // If we run into an issue attempting to delete we should
                    // keep track that we could not at least delete one of files
                    // TODO: change return type to better show which files we
                    // were unable to remove
                    result = false;
                }
            }
            return Task.FromResult(result);
        }

        /// <summary>
        /// Lists all the transfers contained in the checkpointer.
        /// </summary>
        /// <returns></returns>
        public override Task<List<string>> GetStoredTransfersAsync()
        {
            return Task.FromResult(_memoryMappedFiles.Keys.ToList());
        }
    }
}
