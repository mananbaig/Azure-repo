// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Analytics.Synapse.Artifacts;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary>
    /// A copy activity translator.
    /// Please note <see cref="CopyTranslator"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="TabularTranslator"/>.
    /// </summary>
    public abstract partial class CopyTranslator
    {
        /// <summary> Initializes a new instance of <see cref="CopyTranslator"/>. </summary>
        protected CopyTranslator()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of <see cref="CopyTranslator"/>. </summary>
        /// <param name="type"> Copy translator type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal CopyTranslator(string type, IDictionary<string, object> additionalProperties)
        {
            Type = type;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Copy translator type. </summary>
        internal string Type { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
