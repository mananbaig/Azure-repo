// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Declaration of a custom stream. </summary>
    public partial class DataStreamDeclaration
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataStreamDeclaration"/>. </summary>
        public DataStreamDeclaration()
        {
            Columns = new ChangeTrackingList<DataColumnDefinition>();
        }

        /// <summary> Initializes a new instance of <see cref="DataStreamDeclaration"/>. </summary>
        /// <param name="columns"> List of columns used by data in this stream. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataStreamDeclaration(IList<DataColumnDefinition> columns, Dictionary<string, BinaryData> rawData)
        {
            Columns = columns;
            _rawData = rawData;
        }

        /// <summary> List of columns used by data in this stream. </summary>
        public IList<DataColumnDefinition> Columns { get; }
    }
}
