// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Files.Shares.Models
{
    /// <summary> File properties. </summary>
    internal partial class FileProperty
    {
        /// <summary> Initializes a new instance of FileProperty. </summary>
        /// <param name="contentLength"> Content length of the file. This value may not be up-to-date since an SMB client may have modified the file locally. The value of Content-Length may not reflect that fact until the handle is closed or the op-lock is broken. To retrieve current property values, call Get File Properties. </param>
        internal FileProperty(long contentLength)
        {
            ContentLength = contentLength;
        }

        /// <summary> Initializes a new instance of FileProperty. </summary>
        /// <param name="contentLength"> Content length of the file. This value may not be up-to-date since an SMB client may have modified the file locally. The value of Content-Length may not reflect that fact until the handle is closed or the op-lock is broken. To retrieve current property values, call Get File Properties. </param>
        /// <param name="creationTime"></param>
        /// <param name="lastAccessTime"></param>
        /// <param name="lastWriteTime"></param>
        /// <param name="changeTime"></param>
        /// <param name="lastModified"></param>
        /// <param name="etag"></param>
        internal FileProperty(long contentLength, DateTimeOffset? creationTime, DateTimeOffset? lastAccessTime, DateTimeOffset? lastWriteTime, DateTimeOffset? changeTime, DateTimeOffset? lastModified, string etag)
        {
            ContentLength = contentLength;
            CreationTime = creationTime;
            LastAccessTime = lastAccessTime;
            LastWriteTime = lastWriteTime;
            ChangeTime = changeTime;
            LastModified = lastModified;
            Etag = etag;
        }

        /// <summary> Content length of the file. This value may not be up-to-date since an SMB client may have modified the file locally. The value of Content-Length may not reflect that fact until the handle is closed or the op-lock is broken. To retrieve current property values, call Get File Properties. </summary>
        public long ContentLength { get; }
        public DateTimeOffset? CreationTime { get; }
        public DateTimeOffset? LastAccessTime { get; }
        public DateTimeOffset? LastWriteTime { get; }
        public DateTimeOffset? ChangeTime { get; }
        public DateTimeOffset? LastModified { get; }
        public string Etag { get; }
    }
}
