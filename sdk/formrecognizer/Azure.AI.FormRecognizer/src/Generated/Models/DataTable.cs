// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Information about the extracted table contained in a page. </summary>
    internal partial class DataTable
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DataTable"/>. </summary>
        /// <param name="rows"> Number of rows. </param>
        /// <param name="columns"> Number of columns. </param>
        /// <param name="cells"> List of cells contained in the table. </param>
        /// <param name="boundingBox"> Bounding box of the table. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cells"/> or <paramref name="boundingBox"/> is null. </exception>
        internal DataTable(int rows, int columns, IEnumerable<DataTableCell> cells, IEnumerable<float> boundingBox)
        {
            Argument.AssertNotNull(cells, nameof(cells));
            Argument.AssertNotNull(boundingBox, nameof(boundingBox));

            Rows = rows;
            Columns = columns;
            Cells = cells.ToList();
            BoundingBox = boundingBox.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="DataTable"/>. </summary>
        /// <param name="rows"> Number of rows. </param>
        /// <param name="columns"> Number of columns. </param>
        /// <param name="cells"> List of cells contained in the table. </param>
        /// <param name="boundingBox"> Bounding box of the table. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataTable(int rows, int columns, IReadOnlyList<DataTableCell> cells, IReadOnlyList<float> boundingBox, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Rows = rows;
            Columns = columns;
            Cells = cells;
            BoundingBox = boundingBox;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataTable"/> for deserialization. </summary>
        internal DataTable()
        {
        }

        /// <summary> Number of rows. </summary>
        public int Rows { get; }
        /// <summary> Number of columns. </summary>
        public int Columns { get; }
        /// <summary> List of cells contained in the table. </summary>
        public IReadOnlyList<DataTableCell> Cells { get; }
        /// <summary> Bounding box of the table. </summary>
        public IReadOnlyList<float> BoundingBox { get; }
    }
}
