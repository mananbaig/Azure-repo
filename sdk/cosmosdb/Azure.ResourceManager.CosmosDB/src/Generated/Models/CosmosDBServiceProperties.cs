// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary>
    /// Services response resource.
    /// Please note <see cref="CosmosDBServiceProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="DataTransferServiceProperties"/>, <see cref="GraphApiComputeServiceProperties"/>, <see cref="MaterializedViewsBuilderServiceProperties"/> and <see cref="SqlDedicatedGatewayServiceProperties"/>.
    /// </summary>
    public partial class CosmosDBServiceProperties
    {
        /// <summary> Initializes a new instance of <see cref="CosmosDBServiceProperties"/>. </summary>
        public CosmosDBServiceProperties()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBServiceProperties"/>. </summary>
        /// <param name="createdOn"> Time of the last state change (ISO-8601 format). </param>
        /// <param name="instanceSize"> Instance type for the service. </param>
        /// <param name="instanceCount"> Instance count for the service. </param>
        /// <param name="serviceType"> ServiceType for the service. </param>
        /// <param name="status"> Describes the status of a service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal CosmosDBServiceProperties(DateTimeOffset? createdOn, CosmosDBServiceSize? instanceSize, int? instanceCount, CosmosDBServiceType serviceType, CosmosDBServiceStatus? status, IDictionary<string, BinaryData> additionalProperties)
        {
            CreatedOn = createdOn;
            InstanceSize = instanceSize;
            InstanceCount = instanceCount;
            ServiceType = serviceType;
            Status = status;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Time of the last state change (ISO-8601 format). </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Instance type for the service. </summary>
        public CosmosDBServiceSize? InstanceSize { get; set; }
        /// <summary> Instance count for the service. </summary>
        public int? InstanceCount { get; set; }
        /// <summary> ServiceType for the service. </summary>
        internal CosmosDBServiceType ServiceType { get; set; }
        /// <summary> Describes the status of a service. </summary>
        public CosmosDBServiceStatus? Status { get; }
        /// <summary>
        /// Additional Properties
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
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
