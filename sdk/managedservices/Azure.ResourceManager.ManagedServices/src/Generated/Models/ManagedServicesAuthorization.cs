// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.ManagedServices;

namespace Azure.ResourceManager.ManagedServices.Models
{
    /// <summary> The Azure Active Directory principal identifier and Azure built-in role that describes the access the principal will receive on the delegated resource in the managed tenant. </summary>
    public partial class ManagedServicesAuthorization
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

        /// <summary> Initializes a new instance of <see cref="ManagedServicesAuthorization"/>. </summary>
        /// <param name="principalId"> The identifier of the Azure Active Directory principal. </param>
        /// <param name="roleDefinitionId"> The identifier of the Azure built-in role that defines the permissions that the Azure Active Directory principal will have on the projected scope. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionId"/> is null. </exception>
        public ManagedServicesAuthorization(Guid principalId, string roleDefinitionId)
        {
            if (roleDefinitionId == null)
            {
                throw new ArgumentNullException(nameof(roleDefinitionId));
            }

            PrincipalId = principalId;
            RoleDefinitionId = roleDefinitionId;
            DelegatedRoleDefinitionIds = new ChangeTrackingList<Guid>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedServicesAuthorization"/>. </summary>
        /// <param name="principalId"> The identifier of the Azure Active Directory principal. </param>
        /// <param name="principalIdDisplayName"> The display name of the Azure Active Directory principal. </param>
        /// <param name="roleDefinitionId"> The identifier of the Azure built-in role that defines the permissions that the Azure Active Directory principal will have on the projected scope. </param>
        /// <param name="delegatedRoleDefinitionIds"> The delegatedRoleDefinitionIds field is required when the roleDefinitionId refers to the User Access Administrator Role. It is the list of role definition ids which define all the permissions that the user in the authorization can assign to other principals. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedServicesAuthorization(Guid principalId, string principalIdDisplayName, string roleDefinitionId, IList<Guid> delegatedRoleDefinitionIds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PrincipalId = principalId;
            PrincipalIdDisplayName = principalIdDisplayName;
            RoleDefinitionId = roleDefinitionId;
            DelegatedRoleDefinitionIds = delegatedRoleDefinitionIds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedServicesAuthorization"/> for deserialization. </summary>
        internal ManagedServicesAuthorization()
        {
        }

        /// <summary> The identifier of the Azure Active Directory principal. </summary>
        public Guid PrincipalId { get; set; }
        /// <summary> The display name of the Azure Active Directory principal. </summary>
        public string PrincipalIdDisplayName { get; set; }
        /// <summary> The identifier of the Azure built-in role that defines the permissions that the Azure Active Directory principal will have on the projected scope. </summary>
        public string RoleDefinitionId { get; set; }
        /// <summary> The delegatedRoleDefinitionIds field is required when the roleDefinitionId refers to the User Access Administrator Role. It is the list of role definition ids which define all the permissions that the user in the authorization can assign to other principals. </summary>
        public IList<Guid> DelegatedRoleDefinitionIds { get; }
    }
}
