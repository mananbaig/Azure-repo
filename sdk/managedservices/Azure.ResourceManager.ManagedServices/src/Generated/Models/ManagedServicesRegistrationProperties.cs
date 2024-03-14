// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.ManagedServices;

namespace Azure.ResourceManager.ManagedServices.Models
{
    /// <summary> The properties of a registration definition. </summary>
    public partial class ManagedServicesRegistrationProperties
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

        /// <summary> Initializes a new instance of <see cref="ManagedServicesRegistrationProperties"/>. </summary>
        /// <param name="authorizations"> The collection of authorization objects describing the access Azure Active Directory principals in the managedBy tenant will receive on the delegated resource in the managed tenant. </param>
        /// <param name="managedByTenantId"> The identifier of the managedBy tenant. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizations"/> is null. </exception>
        public ManagedServicesRegistrationProperties(IEnumerable<ManagedServicesAuthorization> authorizations, Guid managedByTenantId)
        {
            Argument.AssertNotNull(authorizations, nameof(authorizations));

            Authorizations = authorizations.ToList();
            EligibleAuthorizations = new ChangeTrackingList<ManagedServicesEligibleAuthorization>();
            ManagedByTenantId = managedByTenantId;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedServicesRegistrationProperties"/>. </summary>
        /// <param name="description"> The description of the registration definition. </param>
        /// <param name="authorizations"> The collection of authorization objects describing the access Azure Active Directory principals in the managedBy tenant will receive on the delegated resource in the managed tenant. </param>
        /// <param name="eligibleAuthorizations"> The collection of eligible authorization objects describing the just-in-time access Azure Active Directory principals in the managedBy tenant will receive on the delegated resource in the managed tenant. </param>
        /// <param name="registrationDefinitionName"> The name of the registration definition. </param>
        /// <param name="managedByTenantId"> The identifier of the managedBy tenant. </param>
        /// <param name="provisioningState"> The current provisioning state of the registration definition. </param>
        /// <param name="manageeTenantId"> The identifier of the managed tenant. </param>
        /// <param name="manageeTenantName"> The name of the managed tenant. </param>
        /// <param name="managedByTenantName"> The name of the managedBy tenant. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedServicesRegistrationProperties(string description, IList<ManagedServicesAuthorization> authorizations, IList<ManagedServicesEligibleAuthorization> eligibleAuthorizations, string registrationDefinitionName, Guid managedByTenantId, ManagedServicesProvisioningState? provisioningState, Guid? manageeTenantId, string manageeTenantName, string managedByTenantName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Description = description;
            Authorizations = authorizations;
            EligibleAuthorizations = eligibleAuthorizations;
            RegistrationDefinitionName = registrationDefinitionName;
            ManagedByTenantId = managedByTenantId;
            ProvisioningState = provisioningState;
            ManageeTenantId = manageeTenantId;
            ManageeTenantName = manageeTenantName;
            ManagedByTenantName = managedByTenantName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedServicesRegistrationProperties"/> for deserialization. </summary>
        internal ManagedServicesRegistrationProperties()
        {
        }

        /// <summary> The description of the registration definition. </summary>
        public string Description { get; set; }
        /// <summary> The collection of authorization objects describing the access Azure Active Directory principals in the managedBy tenant will receive on the delegated resource in the managed tenant. </summary>
        public IList<ManagedServicesAuthorization> Authorizations { get; }
        /// <summary> The collection of eligible authorization objects describing the just-in-time access Azure Active Directory principals in the managedBy tenant will receive on the delegated resource in the managed tenant. </summary>
        public IList<ManagedServicesEligibleAuthorization> EligibleAuthorizations { get; }
        /// <summary> The name of the registration definition. </summary>
        public string RegistrationDefinitionName { get; set; }
        /// <summary> The identifier of the managedBy tenant. </summary>
        public Guid ManagedByTenantId { get; set; }
        /// <summary> The current provisioning state of the registration definition. </summary>
        public ManagedServicesProvisioningState? ProvisioningState { get; }
        /// <summary> The identifier of the managed tenant. </summary>
        public Guid? ManageeTenantId { get; }
        /// <summary> The name of the managed tenant. </summary>
        public string ManageeTenantName { get; }
        /// <summary> The name of the managedBy tenant. </summary>
        public string ManagedByTenantName { get; }
    }
}
