// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// Information on the user an incident is assigned to
    /// Serialized Name: IncidentOwnerInfo
    /// </summary>
    public partial class SecurityInsightsIncidentOwnerInfo
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

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsIncidentOwnerInfo"/>. </summary>
        public SecurityInsightsIncidentOwnerInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsIncidentOwnerInfo"/>. </summary>
        /// <param name="email">
        /// The email of the user the incident is assigned to.
        /// Serialized Name: IncidentOwnerInfo.email
        /// </param>
        /// <param name="assignedTo">
        /// The name of the user the incident is assigned to.
        /// Serialized Name: IncidentOwnerInfo.assignedTo
        /// </param>
        /// <param name="objectId">
        /// The object id of the user the incident is assigned to.
        /// Serialized Name: IncidentOwnerInfo.objectId
        /// </param>
        /// <param name="userPrincipalName">
        /// The user principal name of the user the incident is assigned to.
        /// Serialized Name: IncidentOwnerInfo.userPrincipalName
        /// </param>
        /// <param name="ownerType">
        /// The type of the owner the incident is assigned to.
        /// Serialized Name: IncidentOwnerInfo.ownerType
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityInsightsIncidentOwnerInfo(string email, string assignedTo, Guid? objectId, string userPrincipalName, SecurityInsightsIncidentOwnerType? ownerType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Email = email;
            AssignedTo = assignedTo;
            ObjectId = objectId;
            UserPrincipalName = userPrincipalName;
            OwnerType = ownerType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The email of the user the incident is assigned to.
        /// Serialized Name: IncidentOwnerInfo.email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// The name of the user the incident is assigned to.
        /// Serialized Name: IncidentOwnerInfo.assignedTo
        /// </summary>
        public string AssignedTo { get; set; }
        /// <summary>
        /// The object id of the user the incident is assigned to.
        /// Serialized Name: IncidentOwnerInfo.objectId
        /// </summary>
        public Guid? ObjectId { get; set; }
        /// <summary>
        /// The user principal name of the user the incident is assigned to.
        /// Serialized Name: IncidentOwnerInfo.userPrincipalName
        /// </summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// The type of the owner the incident is assigned to.
        /// Serialized Name: IncidentOwnerInfo.ownerType
        /// </summary>
        public SecurityInsightsIncidentOwnerType? OwnerType { get; set; }
    }
}
