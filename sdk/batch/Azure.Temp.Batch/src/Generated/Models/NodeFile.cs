// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Temp.Batch.Models
{
    /// <summary> Information about a file or directory on a Compute Node. </summary>
    public partial class NodeFile
    {
        /// <summary> Initializes a new instance of NodeFile. </summary>
        internal NodeFile()
        {
        }

        /// <summary> Initializes a new instance of NodeFile. </summary>
        /// <param name="name"> The file path. </param>
        /// <param name="url"> The URL of the file. </param>
        /// <param name="isDirectory"> Whether the object represents a directory. </param>
        /// <param name="properties"> The properties of a file on a Compute Node. </param>
        internal NodeFile(string name, string url, bool? isDirectory, FileProperties properties)
        {
            Name = name;
            Url = url;
            IsDirectory = isDirectory;
            Properties = properties;
        }

        /// <summary> The file path. </summary>
        public string Name { get; }
        /// <summary> The URL of the file. </summary>
        public string Url { get; }
        /// <summary> Whether the object represents a directory. </summary>
        public bool? IsDirectory { get; }
        /// <summary> The properties of a file on a Compute Node. </summary>
        public FileProperties Properties { get; }
    }
}
