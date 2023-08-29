// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> Properties that define an API key of an Application Insights Component. </summary>
    public partial class ApplicationInsightsComponentAPIKey
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ApplicationInsightsComponentAPIKey"/>. </summary>
        internal ApplicationInsightsComponentAPIKey()
        {
            LinkedReadProperties = new ChangeTrackingList<string>();
            LinkedWriteProperties = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationInsightsComponentAPIKey"/>. </summary>
        /// <param name="id"> The unique ID of the API key inside an Application Insights component. It is auto generated when the API key is created. </param>
        /// <param name="apiKey"> The API key value. It will be only return once when the API Key was created. </param>
        /// <param name="createdDate"> The create date of this API key. </param>
        /// <param name="name"> The name of the API key. </param>
        /// <param name="linkedReadProperties"> The read access rights of this API Key. </param>
        /// <param name="linkedWriteProperties"> The write access rights of this API Key. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationInsightsComponentAPIKey(string id, string apiKey, string createdDate, string name, IReadOnlyList<string> linkedReadProperties, IReadOnlyList<string> linkedWriteProperties, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            ApiKey = apiKey;
            CreatedDate = createdDate;
            Name = name;
            LinkedReadProperties = linkedReadProperties;
            LinkedWriteProperties = linkedWriteProperties;
            _rawData = rawData;
        }

        /// <summary> The unique ID of the API key inside an Application Insights component. It is auto generated when the API key is created. </summary>
        public string Id { get; }
        /// <summary> The API key value. It will be only return once when the API Key was created. </summary>
        public string ApiKey { get; }
        /// <summary> The create date of this API key. </summary>
        public string CreatedDate { get; }
        /// <summary> The name of the API key. </summary>
        public string Name { get; }
        /// <summary> The read access rights of this API Key. </summary>
        public IReadOnlyList<string> LinkedReadProperties { get; }
        /// <summary> The write access rights of this API Key. </summary>
        public IReadOnlyList<string> LinkedWriteProperties { get; }
    }
}
