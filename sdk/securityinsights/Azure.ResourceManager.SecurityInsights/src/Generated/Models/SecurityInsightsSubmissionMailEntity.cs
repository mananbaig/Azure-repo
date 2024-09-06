// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// Represents a submission mail entity.
    /// Serialized Name: SubmissionMailEntity
    /// </summary>
    public partial class SecurityInsightsSubmissionMailEntity : SecurityInsightsEntity
    {
        /// <summary> Initializes a new instance of <see cref="SecurityInsightsSubmissionMailEntity"/>. </summary>
        public SecurityInsightsSubmissionMailEntity()
        {
            AdditionalData = new ChangeTrackingDictionary<string, BinaryData>();
            Kind = SecurityInsightsEntityKind.SubmissionMail;
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsSubmissionMailEntity"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind">
        /// The kind of the entity.
        /// Serialized Name: Entity.kind
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="additionalData">
        /// A bag of custom fields that should be part of the entity and will be presented to the user.
        /// Serialized Name: SubmissionMailEntity.properties.additionalData
        /// </param>
        /// <param name="friendlyName">
        /// The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated.
        /// Serialized Name: SubmissionMailEntity.properties.friendlyName
        /// </param>
        /// <param name="networkMessageId">
        /// The network message id of email to which submission belongs
        /// Serialized Name: SubmissionMailEntity.properties.networkMessageId
        /// </param>
        /// <param name="submissionId">
        /// The submission id
        /// Serialized Name: SubmissionMailEntity.properties.submissionId
        /// </param>
        /// <param name="submitter">
        /// The submitter
        /// Serialized Name: SubmissionMailEntity.properties.submitter
        /// </param>
        /// <param name="submitOn">
        /// The submission date
        /// Serialized Name: SubmissionMailEntity.properties.submissionDate
        /// </param>
        /// <param name="messageReceivedOn">
        /// The Time stamp when the message is received (Mail)
        /// Serialized Name: SubmissionMailEntity.properties.timestamp
        /// </param>
        /// <param name="recipient">
        /// The recipient of the mail
        /// Serialized Name: SubmissionMailEntity.properties.recipient
        /// </param>
        /// <param name="sender">
        /// The sender of the mail
        /// Serialized Name: SubmissionMailEntity.properties.sender
        /// </param>
        /// <param name="senderIP">
        /// The sender's IP
        /// Serialized Name: SubmissionMailEntity.properties.senderIp
        /// </param>
        /// <param name="subject">
        /// The subject of submission mail
        /// Serialized Name: SubmissionMailEntity.properties.subject
        /// </param>
        /// <param name="reportType">
        /// The submission type for the given instance. This maps to Junk, Phish, Malware or NotJunk.
        /// Serialized Name: SubmissionMailEntity.properties.reportType
        /// </param>
        internal SecurityInsightsSubmissionMailEntity(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SecurityInsightsEntityKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, IReadOnlyDictionary<string, BinaryData> additionalData, string friendlyName, Guid? networkMessageId, Guid? submissionId, string submitter, DateTimeOffset? submitOn, DateTimeOffset? messageReceivedOn, string recipient, string sender, IPAddress senderIP, string subject, string reportType) : base(id, name, resourceType, systemData, kind, serializedAdditionalRawData)
        {
            AdditionalData = additionalData;
            FriendlyName = friendlyName;
            NetworkMessageId = networkMessageId;
            SubmissionId = submissionId;
            Submitter = submitter;
            SubmitOn = submitOn;
            MessageReceivedOn = messageReceivedOn;
            Recipient = recipient;
            Sender = sender;
            SenderIP = senderIP;
            Subject = subject;
            ReportType = reportType;
            Kind = kind;
        }

        /// <summary>
        /// A bag of custom fields that should be part of the entity and will be presented to the user.
        /// Serialized Name: SubmissionMailEntity.properties.additionalData
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
        public IReadOnlyDictionary<string, BinaryData> AdditionalData { get; }
        /// <summary>
        /// The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated.
        /// Serialized Name: SubmissionMailEntity.properties.friendlyName
        /// </summary>
        public string FriendlyName { get; }
        /// <summary>
        /// The network message id of email to which submission belongs
        /// Serialized Name: SubmissionMailEntity.properties.networkMessageId
        /// </summary>
        public Guid? NetworkMessageId { get; }
        /// <summary>
        /// The submission id
        /// Serialized Name: SubmissionMailEntity.properties.submissionId
        /// </summary>
        public Guid? SubmissionId { get; }
        /// <summary>
        /// The submitter
        /// Serialized Name: SubmissionMailEntity.properties.submitter
        /// </summary>
        public string Submitter { get; }
        /// <summary>
        /// The submission date
        /// Serialized Name: SubmissionMailEntity.properties.submissionDate
        /// </summary>
        public DateTimeOffset? SubmitOn { get; }
        /// <summary>
        /// The Time stamp when the message is received (Mail)
        /// Serialized Name: SubmissionMailEntity.properties.timestamp
        /// </summary>
        public DateTimeOffset? MessageReceivedOn { get; }
        /// <summary>
        /// The recipient of the mail
        /// Serialized Name: SubmissionMailEntity.properties.recipient
        /// </summary>
        public string Recipient { get; }
        /// <summary>
        /// The sender of the mail
        /// Serialized Name: SubmissionMailEntity.properties.sender
        /// </summary>
        public string Sender { get; }
        /// <summary>
        /// The sender's IP
        /// Serialized Name: SubmissionMailEntity.properties.senderIp
        /// </summary>
        public IPAddress SenderIP { get; }
        /// <summary>
        /// The subject of submission mail
        /// Serialized Name: SubmissionMailEntity.properties.subject
        /// </summary>
        public string Subject { get; }
        /// <summary>
        /// The submission type for the given instance. This maps to Junk, Phish, Malware or NotJunk.
        /// Serialized Name: SubmissionMailEntity.properties.reportType
        /// </summary>
        public string ReportType { get; }
    }
}
