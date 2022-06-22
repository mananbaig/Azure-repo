// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Resource upload definition payload. </summary>
    public partial class ResourceUploadResult
    {
        /// <summary> Initializes a new instance of ResourceUploadResult. </summary>
        internal ResourceUploadResult()
        {
        }

        /// <summary> Initializes a new instance of ResourceUploadResult. </summary>
        /// <param name="relativePath"> Source relative path. </param>
        /// <param name="uploadUri"> Upload URL. </param>
        internal ResourceUploadResult(string relativePath, string uploadUri)
        {
            RelativePath = relativePath;
            UploadUri = uploadUri;
        }

        /// <summary> Source relative path. </summary>
        public string RelativePath { get; }
        /// <summary> Upload URL. </summary>
        public string UploadUri { get; }
    }
}
