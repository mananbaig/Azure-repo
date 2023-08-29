// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automanage.Models
{
    /// <summary> Details about the resource processed by the configuration profile assignment. </summary>
    public partial class ConfigurationProfileAssignmentReportResourceDetails : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ConfigurationProfileAssignmentReportResourceDetails"/>. </summary>
        internal ConfigurationProfileAssignmentReportResourceDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ConfigurationProfileAssignmentReportResourceDetails"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="status"> Status of the resource. </param>
        /// <param name="error"> Error message, if any, returned when deploying the resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ConfigurationProfileAssignmentReportResourceDetails(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string status, ResponseError error, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Status = status;
            Error = error;
            _rawData = rawData;
        }

        /// <summary> Status of the resource. </summary>
        public string Status { get; }
        /// <summary> Error message, if any, returned when deploying the resource. </summary>
        public ResponseError Error { get; }
    }
}
