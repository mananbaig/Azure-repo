// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Represents an index alias, which describes a mapping from the alias name to an index. The alias name can be used in place of the index name for supported operations. </summary>
    public partial class SearchAlias
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SearchAlias"/>. </summary>
        /// <param name="name"> The name of the alias. </param>
        /// <param name="indexes"> The name of the index this alias maps to. Only one index name may be specified. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="indexes"/> is null. </exception>
        public SearchAlias(string name, IEnumerable<string> indexes)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(indexes, nameof(indexes));

            Name = name;
            Indexes = indexes.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="SearchAlias"/>. </summary>
        /// <param name="name"> The name of the alias. </param>
        /// <param name="indexes"> The name of the index this alias maps to. Only one index name may be specified. </param>
        /// <param name="etag"> The ETag of the alias. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SearchAlias(string name, IList<string> indexes, string etag, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Indexes = indexes;
            _etag = etag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SearchAlias"/> for deserialization. </summary>
        internal SearchAlias()
        {
        }

        /// <summary> The name of the alias. </summary>
        public string Name { get; set; }
        /// <summary> The name of the index this alias maps to. Only one index name may be specified. </summary>
        public IList<string> Indexes { get; }
    }
}
