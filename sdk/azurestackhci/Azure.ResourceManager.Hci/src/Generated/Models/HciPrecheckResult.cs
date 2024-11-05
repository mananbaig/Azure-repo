// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> The HciPrecheckResult. </summary>
    public partial class HciPrecheckResult
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

        /// <summary> Initializes a new instance of <see cref="HciPrecheckResult"/>. </summary>
        public HciPrecheckResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HciPrecheckResult"/>. </summary>
        /// <param name="name"> Name of the individual test/rule/alert that was executed. Unique, not exposed to the customer. </param>
        /// <param name="displayName"> The health check DisplayName localized of the individual test executed. </param>
        /// <param name="tags"> Key-value pairs that allow grouping/filtering individual tests. </param>
        /// <param name="healthCheckTags"> Key-value pairs that allow grouping/filtering individual tests. </param>
        /// <param name="title"> User-facing name; one or more sentences indicating the direct issue. </param>
        /// <param name="status"> The status of the check running (i.e. Failed, Succeeded, In Progress). This answers whether the check ran, and passed or failed. </param>
        /// <param name="severity"> Severity of the result (Critical, Warning, Informational, Hidden). This answers how important the result is. Critical is the only update-blocking severity. </param>
        /// <param name="description"> Detailed overview of the issue and what impact the issue has on the stamp. </param>
        /// <param name="remediation"> Set of steps that can be taken to resolve the issue found. </param>
        /// <param name="targetResourceId"> The unique identifier for the affected resource (such as a node or drive). </param>
        /// <param name="targetResourceName"> The name of the affected resource. </param>
        /// <param name="targetResourceType"> The type of resource being referred to (well-known set of nouns in infrastructure, aligning with Monitoring). </param>
        /// <param name="timestamp"> The time in which the HealthCheck was called. </param>
        /// <param name="additionalData"> Property bag of key value pairs for additional information. </param>
        /// <param name="healthCheckSource"> The name of the services called for the HealthCheck (I.E. Test-AzureStack, Test-Cluster). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HciPrecheckResult(string name, string displayName, HciPrecheckResultTags tags, BinaryData healthCheckTags, string title, HciClusterStatus? status, UpdateSeverity? severity, string description, string remediation, string targetResourceId, string targetResourceName, string targetResourceType, DateTimeOffset? timestamp, string additionalData, string healthCheckSource, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            DisplayName = displayName;
            Tags = tags;
            HealthCheckTags = healthCheckTags;
            Title = title;
            Status = status;
            Severity = severity;
            Description = description;
            Remediation = remediation;
            TargetResourceId = targetResourceId;
            TargetResourceName = targetResourceName;
            TargetResourceType = targetResourceType;
            Timestamp = timestamp;
            AdditionalData = additionalData;
            HealthCheckSource = healthCheckSource;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of the individual test/rule/alert that was executed. Unique, not exposed to the customer. </summary>
        [WirePath("name")]
        public string Name { get; set; }
        /// <summary> The health check DisplayName localized of the individual test executed. </summary>
        [WirePath("displayName")]
        public string DisplayName { get; set; }
        /// <summary> Key-value pairs that allow grouping/filtering individual tests. </summary>
        [WirePath("tags")]
        public HciPrecheckResultTags Tags { get; set; }
        /// <summary>
        /// Key-value pairs that allow grouping/filtering individual tests.
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
        [WirePath("healthCheckTags")]
        public BinaryData HealthCheckTags { get; set; }
        /// <summary> User-facing name; one or more sentences indicating the direct issue. </summary>
        [WirePath("title")]
        public string Title { get; set; }
        /// <summary> The status of the check running (i.e. Failed, Succeeded, In Progress). This answers whether the check ran, and passed or failed. </summary>
        [WirePath("status")]
        public HciClusterStatus? Status { get; set; }
        /// <summary> Severity of the result (Critical, Warning, Informational, Hidden). This answers how important the result is. Critical is the only update-blocking severity. </summary>
        [WirePath("severity")]
        public UpdateSeverity? Severity { get; set; }
        /// <summary> Detailed overview of the issue and what impact the issue has on the stamp. </summary>
        [WirePath("description")]
        public string Description { get; set; }
        /// <summary> Set of steps that can be taken to resolve the issue found. </summary>
        [WirePath("remediation")]
        public string Remediation { get; set; }
        /// <summary> The unique identifier for the affected resource (such as a node or drive). </summary>
        [WirePath("targetResourceID")]
        public string TargetResourceId { get; set; }
        /// <summary> The name of the affected resource. </summary>
        [WirePath("targetResourceName")]
        public string TargetResourceName { get; set; }
        /// <summary> The type of resource being referred to (well-known set of nouns in infrastructure, aligning with Monitoring). </summary>
        [WirePath("targetResourceType")]
        public string TargetResourceType { get; set; }
        /// <summary> The time in which the HealthCheck was called. </summary>
        [WirePath("timestamp")]
        public DateTimeOffset? Timestamp { get; set; }
        /// <summary> Property bag of key value pairs for additional information. </summary>
        [WirePath("additionalData")]
        public string AdditionalData { get; set; }
        /// <summary> The name of the services called for the HealthCheck (I.E. Test-AzureStack, Test-Cluster). </summary>
        [WirePath("healthCheckSource")]
        public string HealthCheckSource { get; set; }
    }
}
