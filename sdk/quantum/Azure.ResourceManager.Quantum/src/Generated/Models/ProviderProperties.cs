// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Quantum;

namespace Azure.ResourceManager.Quantum.Models
{
    /// <summary> Provider properties. </summary>
    public partial class ProviderProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ProviderProperties"/>. </summary>
        internal ProviderProperties()
        {
            Targets = new ChangeTrackingList<TargetDescription>();
            Skus = new ChangeTrackingList<SkuDescription>();
            QuotaDimensions = new ChangeTrackingList<QuotaDimension>();
            PricingDimensions = new ChangeTrackingList<PricingDimension>();
        }

        /// <summary> Initializes a new instance of <see cref="ProviderProperties"/>. </summary>
        /// <param name="description"> A description about this provider. </param>
        /// <param name="providerType"> Provider type. </param>
        /// <param name="company"> Company name. </param>
        /// <param name="defaultEndpoint"> Provider's default endpoint. </param>
        /// <param name="aad"> Azure Active Directory info. </param>
        /// <param name="managedApplication"> Provider's Managed-Application info. </param>
        /// <param name="targets"> The list of targets available from this provider. </param>
        /// <param name="skus"> The list of skus available from this provider. </param>
        /// <param name="quotaDimensions"> The list of quota dimensions from the provider. </param>
        /// <param name="pricingDimensions"> The list of pricing dimensions from the provider. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ProviderProperties(string description, string providerType, string company, string defaultEndpoint, ProviderPropertiesAad aad, ProviderPropertiesManagedApplication managedApplication, IReadOnlyList<TargetDescription> targets, IReadOnlyList<SkuDescription> skus, IReadOnlyList<QuotaDimension> quotaDimensions, IReadOnlyList<PricingDimension> pricingDimensions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Description = description;
            ProviderType = providerType;
            Company = company;
            DefaultEndpoint = defaultEndpoint;
            Aad = aad;
            ManagedApplication = managedApplication;
            Targets = targets;
            Skus = skus;
            QuotaDimensions = quotaDimensions;
            PricingDimensions = pricingDimensions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A description about this provider. </summary>
        public string Description { get; }
        /// <summary> Provider type. </summary>
        public string ProviderType { get; }
        /// <summary> Company name. </summary>
        public string Company { get; }
        /// <summary> Provider's default endpoint. </summary>
        public string DefaultEndpoint { get; }
        /// <summary> Azure Active Directory info. </summary>
        public ProviderPropertiesAad Aad { get; }
        /// <summary> Provider's Managed-Application info. </summary>
        public ProviderPropertiesManagedApplication ManagedApplication { get; }
        /// <summary> The list of targets available from this provider. </summary>
        public IReadOnlyList<TargetDescription> Targets { get; }
        /// <summary> The list of skus available from this provider. </summary>
        public IReadOnlyList<SkuDescription> Skus { get; }
        /// <summary> The list of quota dimensions from the provider. </summary>
        public IReadOnlyList<QuotaDimension> QuotaDimensions { get; }
        /// <summary> The list of pricing dimensions from the provider. </summary>
        public IReadOnlyList<PricingDimension> PricingDimensions { get; }
    }
}
