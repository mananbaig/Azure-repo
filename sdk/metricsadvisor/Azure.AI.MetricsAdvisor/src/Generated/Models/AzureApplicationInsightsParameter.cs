// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AzureApplicationInsightsParameter. </summary>
    internal partial class AzureApplicationInsightsParameter
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AzureApplicationInsightsParameter"/>. </summary>
        /// <param name="query"> The statement to query this Azure Application Insights. </param>
        public AzureApplicationInsightsParameter(string query)
        {
            Query = query;
        }

        /// <summary> Initializes a new instance of <see cref="AzureApplicationInsightsParameter"/>. </summary>
        /// <param name="azureCloud"> The Azure cloud that this Azure Application Insights in. </param>
        /// <param name="applicationId"> The application id of this Azure Application Insights. </param>
        /// <param name="apiKey"> The API Key that can access this Azure Application Insights. </param>
        /// <param name="query"> The statement to query this Azure Application Insights. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureApplicationInsightsParameter(string azureCloud, string applicationId, string apiKey, string query, Dictionary<string, BinaryData> rawData)
        {
            AzureCloud = azureCloud;
            ApplicationId = applicationId;
            ApiKey = apiKey;
            Query = query;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="AzureApplicationInsightsParameter"/> for deserialization. </summary>
        internal AzureApplicationInsightsParameter()
        {
        }

        /// <summary> The Azure cloud that this Azure Application Insights in. </summary>
        public string AzureCloud { get; set; }
        /// <summary> The application id of this Azure Application Insights. </summary>
        public string ApplicationId { get; set; }
        /// <summary> The API Key that can access this Azure Application Insights. </summary>
        public string ApiKey { get; set; }
        /// <summary> The statement to query this Azure Application Insights. </summary>
        public string Query { get; set; }
    }
}
