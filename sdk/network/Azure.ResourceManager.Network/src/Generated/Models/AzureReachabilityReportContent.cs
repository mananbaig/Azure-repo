// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Geographic and time constraints for Azure reachability report. </summary>
    public partial class AzureReachabilityReportContent
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

        /// <summary> Initializes a new instance of <see cref="AzureReachabilityReportContent"/>. </summary>
        /// <param name="providerLocation"> Parameters that define a geographic location. </param>
        /// <param name="startOn"> The start time for the Azure reachability report. </param>
        /// <param name="endOn"> The end time for the Azure reachability report. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="providerLocation"/> is null. </exception>
        public AzureReachabilityReportContent(AzureReachabilityReportLocation providerLocation, DateTimeOffset startOn, DateTimeOffset endOn)
        {
            if (providerLocation == null)
            {
                throw new ArgumentNullException(nameof(providerLocation));
            }

            ProviderLocation = providerLocation;
            Providers = new ChangeTrackingList<string>();
            AzureLocations = new ChangeTrackingList<AzureLocation>();
            StartOn = startOn;
            EndOn = endOn;
        }

        /// <summary> Initializes a new instance of <see cref="AzureReachabilityReportContent"/>. </summary>
        /// <param name="providerLocation"> Parameters that define a geographic location. </param>
        /// <param name="providers"> List of Internet service providers. </param>
        /// <param name="azureLocations"> Optional Azure regions to scope the query to. </param>
        /// <param name="startOn"> The start time for the Azure reachability report. </param>
        /// <param name="endOn"> The end time for the Azure reachability report. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureReachabilityReportContent(AzureReachabilityReportLocation providerLocation, IList<string> providers, IList<AzureLocation> azureLocations, DateTimeOffset startOn, DateTimeOffset endOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProviderLocation = providerLocation;
            Providers = providers;
            AzureLocations = azureLocations;
            StartOn = startOn;
            EndOn = endOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AzureReachabilityReportContent"/> for deserialization. </summary>
        internal AzureReachabilityReportContent()
        {
        }

        /// <summary> Parameters that define a geographic location. </summary>
        public AzureReachabilityReportLocation ProviderLocation { get; }
        /// <summary> List of Internet service providers. </summary>
        public IList<string> Providers { get; }
        /// <summary> Optional Azure regions to scope the query to. </summary>
        public IList<AzureLocation> AzureLocations { get; }
        /// <summary> The start time for the Azure reachability report. </summary>
        public DateTimeOffset StartOn { get; }
        /// <summary> The end time for the Azure reachability report. </summary>
        public DateTimeOffset EndOn { get; }
    }
}
