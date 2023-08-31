// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Details on progress of ADF copy activity. </summary>
    public partial class CopyProgressDetails
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CopyProgressDetails"/>. </summary>
        internal CopyProgressDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CopyProgressDetails"/>. </summary>
        /// <param name="tableName"> Table Name. </param>
        /// <param name="status"> Status of the Copy activity (InProgress, Succeeded, Failed, Canceled). </param>
        /// <param name="parallelCopyType"> Type of parallel copy (Dynamic range, Physical partition, none). </param>
        /// <param name="usedParallelCopies"> The degree of parallelization. </param>
        /// <param name="dataRead"> Bytes read. </param>
        /// <param name="dataWritten"> Bytes written. </param>
        /// <param name="rowsRead"> Rows read. </param>
        /// <param name="rowsCopied"> Rows Copied. </param>
        /// <param name="copyStart"> Copy Start. </param>
        /// <param name="copyThroughput"> Copy throughput in KBps. </param>
        /// <param name="copyDuration"> Copy Duration in seconds. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CopyProgressDetails(string tableName, string status, string parallelCopyType, int? usedParallelCopies, long? dataRead, long? dataWritten, long? rowsRead, long? rowsCopied, DateTimeOffset? copyStart, double? copyThroughput, int? copyDuration, Dictionary<string, BinaryData> rawData)
        {
            TableName = tableName;
            Status = status;
            ParallelCopyType = parallelCopyType;
            UsedParallelCopies = usedParallelCopies;
            DataRead = dataRead;
            DataWritten = dataWritten;
            RowsRead = rowsRead;
            RowsCopied = rowsCopied;
            CopyStart = copyStart;
            CopyThroughput = copyThroughput;
            CopyDuration = copyDuration;
            _rawData = rawData;
        }

        /// <summary> Table Name. </summary>
        public string TableName { get; }
        /// <summary> Status of the Copy activity (InProgress, Succeeded, Failed, Canceled). </summary>
        public string Status { get; }
        /// <summary> Type of parallel copy (Dynamic range, Physical partition, none). </summary>
        public string ParallelCopyType { get; }
        /// <summary> The degree of parallelization. </summary>
        public int? UsedParallelCopies { get; }
        /// <summary> Bytes read. </summary>
        public long? DataRead { get; }
        /// <summary> Bytes written. </summary>
        public long? DataWritten { get; }
        /// <summary> Rows read. </summary>
        public long? RowsRead { get; }
        /// <summary> Rows Copied. </summary>
        public long? RowsCopied { get; }
        /// <summary> Copy Start. </summary>
        public DateTimeOffset? CopyStart { get; }
        /// <summary> Copy throughput in KBps. </summary>
        public double? CopyThroughput { get; }
        /// <summary> Copy Duration in seconds. </summary>
        public int? CopyDuration { get; }
    }
}
