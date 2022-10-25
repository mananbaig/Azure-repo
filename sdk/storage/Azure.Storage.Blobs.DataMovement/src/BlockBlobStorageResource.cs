﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs.Specialized;
using Azure.Storage.DataMovement;
using Azure.Storage.DataMovement.Models;
using Azure.Storage.Shared;

namespace Azure.Storage.Blobs.DataMovement
{
    /// <summary>
    /// Blob Storage Resource
    /// </summary>
    public class BlockBlobStorageResource : StorageResource
    {
        private BlockBlobClient _blobClient;
        private List<string> _blocks;
        private BlockBlobStorageResourceOptions _options;

        /// <summary>
        /// Returns URL
        /// </summary>
        /// <returns></returns>
        public override Uri Uri => _blobClient.Uri;

        /// <summary>
        /// Gets the path of the resource.
        /// </summary>
        public override List<string> Path => _blobClient.Name.Split('/').ToList();

        /// <summary>
        /// Defines whether the object can produce a SAS URL
        /// </summary>
        /// <returns></returns>
        public override ProduceUriType CanProduceUri => ProduceUriType.ProducesUri;

        /// <summary>
        /// Does not require Commit List operation.
        /// </summary>
        /// <returns></returns>
        public override RequiresCompleteTransferType RequiresCompleteTransfer => RequiresCompleteTransferType.RequiresCompleteCall;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="blobClient"></param>
        /// <param name="options"></param>
        public BlockBlobStorageResource(
            BlockBlobClient blobClient,
            BlockBlobStorageResourceOptions options = default)
        {
            _blobClient = blobClient;
            _blocks = new List<string>();
            _options = options;
        }

        /// <summary>
        /// Creates readable stream to download
        /// </summary>
        /// <returns></returns>
        public override async Task<ReadStreamStorageResourceInfo> ReadStreamAsync(
            long? position = default,
            CancellationToken cancellationToken = default)
        {
            Response<BlobDownloadStreamingResult> response = await _blobClient.DownloadStreamingAsync(
                new HttpRange(position ?? 0, Constants.LargeBufferSize), // TODO: convert to take in max size
                default, // TODO: convert options to conditions
                false,
                cancellationToken).ConfigureAwait(false);
            return response.Value.ToReadStreamStorageResourceInfo();
        }

        /// <summary>
        /// Consumes the readable stream to upload
        /// </summary>
        /// <param name="offset">
        /// The offset which the stream will be copied to.
        /// </param>
        /// <param name="length">
        /// The length of the stream.
        /// </param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override async Task<ReadStreamStorageResourceInfo> ReadPartialStreamAsync(
            long offset,
            long length,
            CancellationToken cancellationToken = default)
        {
            Response<BlobDownloadStreamingResult> response = await _blobClient.DownloadStreamingAsync(
                new HttpRange(offset, length),
                default, // TODO: convert options to conditions
                false,
                cancellationToken).ConfigureAwait(false);
            return response.Value.ToReadStreamStorageResourceInfo();
        }

        /// <summary>
        /// Consumes stream to upload
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public override async Task WriteFromStreamAsync(
            Stream stream,
            CancellationToken token = default)
        {
            // TODO: change depending on type of blob and type single shot or parallel transfer
            await _blobClient.UploadAsync(stream, default, cancellationToken:token).ConfigureAwait(false);
        }

        /// <summary>
        /// Consumes the readable stream to upload
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="length"></param>
        /// <param name="stream"></param>
        /// <param name="options"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override async Task WriteStreamToOffsetAsync(
            long offset,
            long length,
            Stream stream,
            StorageResourceWriteToOffsetOptions options,
            CancellationToken cancellationToken = default)
        {
            string id = Shared.StorageExtensions.GenerateBlockId(offset);
            _blocks.Add(id);
            await _blobClient.StageBlockAsync(
                id,
                stream,
                // TODO #27253
                //new BlockBlobStageBlockOptions()
                //{
                //    TransactionalHashingOptions = hashingOptions,
                //    Conditions = conditions,
                //    ProgressHandler = progressHandler
                //},
                transactionalContentHash: default,
                default,
                default,
                cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Consumes blob Url to upload / copy
        /// </summary>
        /// <param name="sourceUri"></param>
        /// <param name="sourceAuthorization"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override async Task CopyFromUriAsync(
            Uri sourceUri,
            StorageResourceCopyFromUriOptions sourceAuthorization = default,
            CancellationToken cancellationToken = default)
        {
            // Change depending on type of copy
            await _blobClient.SyncUploadFromUriAsync(sourceUri, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Uploads/copy the blob from a url
        /// </summary>
        /// <param name="sourceUri"></param>
        /// <param name="range"></param>
        /// <param name="options"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override async Task CopyBlockFromUriAsync(
            Uri sourceUri,
            HttpRange range,
            StorageResourceCopyFromUriOptions options = default,
            CancellationToken cancellationToken = default)
        {
            string id = options?.BlockId ?? Shared.StorageExtensions.GenerateBlockId(range.Offset);
            _blocks.Add(id);
            await _blobClient.StageBlockFromUriAsync(
                sourceUri,
                id,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get properties of the resource.
        /// </summary>
        /// <returns>Returns the length of the storage resource</returns>
        public override async Task<StorageResourceProperties> GetPropertiesAsync(CancellationToken cancellationToken)
        {
            BlobProperties properties = await _blobClient.GetPropertiesAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
            return properties.ToStorageResourceProperties();
        }

        /// <summary>
        /// Commits the block list given.
        /// </summary>
        public override async Task CompleteTransferAsync(CancellationToken cancellationToken)
        {
            if (_blocks != null && _blocks.Count > 0)
            {
                await _blobClient.CommitBlockListAsync(
                    _blocks,
                    default,
                    cancellationToken).ConfigureAwait(false);
                _blocks.Clear();
            }
        }
    }
}
