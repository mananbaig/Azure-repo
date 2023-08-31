// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> Payload object for upsert offer with multiple context and plans. </summary>
    public partial class MultiContextAndPlansContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MultiContextAndPlansContent"/>. </summary>
        public MultiContextAndPlansContent()
        {
            PlansContext = new ChangeTrackingList<ContextAndPlansDetails>();
        }

        /// <summary> Initializes a new instance of <see cref="MultiContextAndPlansContent"/>. </summary>
        /// <param name="offerId"> The offer ID which contains the plans. </param>
        /// <param name="eTag"> The offer's eTag. </param>
        /// <param name="plansContext"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MultiContextAndPlansContent(string offerId, ETag? eTag, IList<ContextAndPlansDetails> plansContext, Dictionary<string, BinaryData> rawData)
        {
            OfferId = offerId;
            ETag = eTag;
            PlansContext = plansContext;
            _rawData = rawData;
        }

        /// <summary> The offer ID which contains the plans. </summary>
        public string OfferId { get; set; }
        /// <summary> The offer's eTag. </summary>
        public ETag? ETag { get; set; }
        /// <summary> Gets the plans context. </summary>
        public IList<ContextAndPlansDetails> PlansContext { get; }
    }
}
