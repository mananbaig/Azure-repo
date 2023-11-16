// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ResourceProviderManifestProperties. </summary>
    public partial class ResourceProviderManifestProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ResourceProviderManifestProperties"/>. </summary>
        public ResourceProviderManifestProperties()
        {
            ProviderAuthorizations = new ChangeTrackingList<ResourceProviderAuthorization>();
            RequiredFeatures = new ChangeTrackingList<string>();
            Capabilities = new ChangeTrackingList<ResourceProviderCapabilities>();
        }

        /// <summary> Initializes a new instance of <see cref="ResourceProviderManifestProperties"/>. </summary>
        /// <param name="providerAuthentication"></param>
        /// <param name="providerAuthorizations"></param>
        /// <param name="namespace"></param>
        /// <param name="providerVersion"></param>
        /// <param name="providerType"></param>
        /// <param name="requiredFeatures"></param>
        /// <param name="featuresRule"></param>
        /// <param name="requestHeaderOptions"></param>
        /// <param name="management"></param>
        /// <param name="capabilities"></param>
        /// <param name="metadata"> Anything. </param>
        /// <param name="templateDeploymentOptions"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceProviderManifestProperties(ResourceProviderAuthentication providerAuthentication, IList<ResourceProviderAuthorization> providerAuthorizations, string @namespace, string providerVersion, ResourceProviderType? providerType, IList<string> requiredFeatures, FeaturesRule featuresRule, RequestHeaderOptions requestHeaderOptions, ResourceProviderManagement management, IList<ResourceProviderCapabilities> capabilities, BinaryData metadata, TemplateDeploymentOptions templateDeploymentOptions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProviderAuthentication = providerAuthentication;
            ProviderAuthorizations = providerAuthorizations;
            Namespace = @namespace;
            ProviderVersion = providerVersion;
            ProviderType = providerType;
            RequiredFeatures = requiredFeatures;
            FeaturesRule = featuresRule;
            RequestHeaderOptions = requestHeaderOptions;
            Management = management;
            Capabilities = capabilities;
            Metadata = metadata;
            TemplateDeploymentOptions = templateDeploymentOptions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the provider authentication. </summary>
        internal ResourceProviderAuthentication ProviderAuthentication { get; set; }
        /// <summary> Gets or sets the provider authentication allowed audiences. </summary>
        public IList<string> ProviderAuthenticationAllowedAudiences
        {
            get => ProviderAuthentication is null ? default : ProviderAuthentication.AllowedAudiences;
            set => ProviderAuthentication = new ResourceProviderAuthentication(value);
        }

        /// <summary> Gets the provider authorizations. </summary>
        public IList<ResourceProviderAuthorization> ProviderAuthorizations { get; }
        /// <summary> Gets or sets the namespace. </summary>
        public string Namespace { get; set; }
        /// <summary> Gets or sets the provider version. </summary>
        public string ProviderVersion { get; set; }
        /// <summary> Gets or sets the provider type. </summary>
        public ResourceProviderType? ProviderType { get; set; }
        /// <summary> Gets the required features. </summary>
        public IList<string> RequiredFeatures { get; }
        /// <summary> Gets or sets the features rule. </summary>
        internal FeaturesRule FeaturesRule { get; set; }
        /// <summary> Gets or sets the required features policy. </summary>
        public FeaturesPolicy? RequiredFeaturesPolicy
        {
            get => FeaturesRule is null ? default(FeaturesPolicy?) : FeaturesRule.RequiredFeaturesPolicy;
            set
            {
                FeaturesRule = value.HasValue ? new FeaturesRule(value.Value) : null;
            }
        }

        /// <summary> Gets or sets the request header options. </summary>
        internal RequestHeaderOptions RequestHeaderOptions { get; set; }
        /// <summary> Gets or sets the opt in headers. </summary>
        public OptInHeaderType? OptInHeaders
        {
            get => RequestHeaderOptions is null ? default : RequestHeaderOptions.OptInHeaders;
            set
            {
                if (RequestHeaderOptions is null)
                    RequestHeaderOptions = new RequestHeaderOptions();
                RequestHeaderOptions.OptInHeaders = value;
            }
        }

        /// <summary> Gets or sets the management. </summary>
        public ResourceProviderManagement Management { get; set; }
        /// <summary> Gets the capabilities. </summary>
        public IList<ResourceProviderCapabilities> Capabilities { get; }
        /// <summary>
        /// Anything
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData Metadata { get; set; }
        /// <summary> Gets or sets the template deployment options. </summary>
        public TemplateDeploymentOptions TemplateDeploymentOptions { get; set; }
    }
}
