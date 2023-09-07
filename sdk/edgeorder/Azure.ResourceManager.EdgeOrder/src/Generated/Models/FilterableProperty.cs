// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Different types of filters supported and its values. </summary>
    public partial class FilterableProperty
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FilterableProperty"/>. </summary>
        /// <param name="supportedFilterType"> Type of product filter. </param>
        /// <param name="supportedValues"> Values to be filtered. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="supportedValues"/> is null. </exception>
        public FilterableProperty(SupportedFilterType supportedFilterType, IEnumerable<string> supportedValues)
        {
            Argument.AssertNotNull(supportedValues, nameof(supportedValues));

            SupportedFilterType = supportedFilterType;
            SupportedValues = supportedValues.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="FilterableProperty"/>. </summary>
        /// <param name="supportedFilterType"> Type of product filter. </param>
        /// <param name="supportedValues"> Values to be filtered. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FilterableProperty(SupportedFilterType supportedFilterType, IList<string> supportedValues, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SupportedFilterType = supportedFilterType;
            SupportedValues = supportedValues;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="FilterableProperty"/> for deserialization. </summary>
        internal FilterableProperty()
        {
        }

        /// <summary> Type of product filter. </summary>
        public SupportedFilterType SupportedFilterType { get; set; }
        /// <summary> Values to be filtered. </summary>
        public IList<string> SupportedValues { get; }
    }
}
