// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents an account entity. </summary>
    public partial class AccountEntity : EntityData
    {
        /// <summary> Initializes a new instance of AccountEntity. </summary>
        public AccountEntity()
        {
            AdditionalData = new ChangeTrackingDictionary<string, BinaryData>();
            Kind = EntityKind.Account;
        }

        /// <summary> Initializes a new instance of AccountEntity. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The kind of the entity. </param>
        /// <param name="additionalData"> A bag of custom fields that should be part of the entity and will be presented to the user. </param>
        /// <param name="friendlyName"> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </param>
        /// <param name="aadTenantId"> The Azure Active Directory tenant id. </param>
        /// <param name="aadUserId"> The Azure Active Directory user id. </param>
        /// <param name="accountName"> The name of the account. This field should hold only the name without any domain added to it, i.e. administrator. </param>
        /// <param name="displayName"> The display name of the account. </param>
        /// <param name="hostEntityId"> The Host entity id that contains the account in case it is a local account (not domain joined). </param>
        /// <param name="isDomainJoined"> Determines whether this is a domain account. </param>
        /// <param name="ntDomain"> The NetBIOS domain name as it appears in the alert format domain/username. Examples: NT AUTHORITY. </param>
        /// <param name="objectGuid"> The objectGUID attribute is a single-value attribute that is the unique identifier for the object, assigned by active directory. </param>
        /// <param name="puid"> The Azure Active Directory Passport User ID. </param>
        /// <param name="sid"> The account security identifier, e.g. S-1-5-18. </param>
        /// <param name="upnSuffix"> The user principal name suffix for the account, in some cases it is also the domain name. Examples: contoso.com. </param>
        /// <param name="dnsDomain"> The fully qualified domain DNS name. </param>
        internal AccountEntity(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, EntityKind kind, IReadOnlyDictionary<string, BinaryData> additionalData, string friendlyName, string aadTenantId, string aadUserId, string accountName, string displayName, string hostEntityId, bool? isDomainJoined, string ntDomain, Guid? objectGuid, string puid, string sid, string upnSuffix, string dnsDomain) : base(id, name, resourceType, systemData, kind)
        {
            AdditionalData = additionalData;
            FriendlyName = friendlyName;
            AadTenantId = aadTenantId;
            AadUserId = aadUserId;
            AccountName = accountName;
            DisplayName = displayName;
            HostEntityId = hostEntityId;
            IsDomainJoined = isDomainJoined;
            NtDomain = ntDomain;
            ObjectGuid = objectGuid;
            Puid = puid;
            Sid = sid;
            UpnSuffix = upnSuffix;
            DnsDomain = dnsDomain;
            Kind = kind;
        }

        /// <summary> A bag of custom fields that should be part of the entity and will be presented to the user. </summary>
        public IReadOnlyDictionary<string, BinaryData> AdditionalData { get; }
        /// <summary> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </summary>
        public string FriendlyName { get; }
        /// <summary> The Azure Active Directory tenant id. </summary>
        public string AadTenantId { get; }
        /// <summary> The Azure Active Directory user id. </summary>
        public string AadUserId { get; }
        /// <summary> The name of the account. This field should hold only the name without any domain added to it, i.e. administrator. </summary>
        public string AccountName { get; }
        /// <summary> The display name of the account. </summary>
        public string DisplayName { get; }
        /// <summary> The Host entity id that contains the account in case it is a local account (not domain joined). </summary>
        public string HostEntityId { get; }
        /// <summary> Determines whether this is a domain account. </summary>
        public bool? IsDomainJoined { get; }
        /// <summary> The NetBIOS domain name as it appears in the alert format domain/username. Examples: NT AUTHORITY. </summary>
        public string NtDomain { get; }
        /// <summary> The objectGUID attribute is a single-value attribute that is the unique identifier for the object, assigned by active directory. </summary>
        public Guid? ObjectGuid { get; }
        /// <summary> The Azure Active Directory Passport User ID. </summary>
        public string Puid { get; }
        /// <summary> The account security identifier, e.g. S-1-5-18. </summary>
        public string Sid { get; }
        /// <summary> The user principal name suffix for the account, in some cases it is also the domain name. Examples: contoso.com. </summary>
        public string UpnSuffix { get; }
        /// <summary> The fully qualified domain DNS name. </summary>
        public string DnsDomain { get; }
    }
}
