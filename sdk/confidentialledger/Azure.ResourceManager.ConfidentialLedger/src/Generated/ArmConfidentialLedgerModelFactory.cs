// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.ConfidentialLedger;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ConfidentialLedger.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmConfidentialLedgerModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Models.ConfidentialLedgerNameAvailabilityResult"/>. </summary>
        /// <param name="isNameAvailable"> Indicates if the resource name is available. </param>
        /// <param name="reason"> The reason why the given name is not available. </param>
        /// <param name="message"> Detailed reason why the given name is available. </param>
        /// <returns> A new <see cref="Models.ConfidentialLedgerNameAvailabilityResult"/> instance for mocking. </returns>
        public static ConfidentialLedgerNameAvailabilityResult ConfidentialLedgerNameAvailabilityResult(bool? isNameAvailable = null, ConfidentialLedgerNameUnavailableReason? reason = null, string message = null)
        {
            return new ConfidentialLedgerNameAvailabilityResult(isNameAvailable, reason, message, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ConfidentialLedger.ConfidentialLedgerData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> Properties of Confidential Ledger Resource. </param>
        /// <returns> A new <see cref="ConfidentialLedger.ConfidentialLedgerData"/> instance for mocking. </returns>
        public static ConfidentialLedgerData ConfidentialLedgerData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ConfidentialLedgerProperties properties = null)
        {
            tags ??= new Dictionary<string, string>();

            return new ConfidentialLedgerData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ConfidentialLedgerProperties"/>. </summary>
        /// <param name="ledgerName"> Unique name for the Confidential Ledger. </param>
        /// <param name="ledgerUri"> Endpoint for calling Ledger Service. </param>
        /// <param name="identityServiceUri"> Endpoint for accessing network identity. </param>
        /// <param name="ledgerInternalNamespace"> Internal namespace for the Ledger. </param>
        /// <param name="runningState"> Object representing RunningState for Ledger. </param>
        /// <param name="ledgerType"> Type of Confidential Ledger. </param>
        /// <param name="provisioningState"> Provisioning state of Ledger Resource. </param>
        /// <param name="aadBasedSecurityPrincipals"> Array of all AAD based Security Principals. </param>
        /// <param name="certBasedSecurityPrincipals"> Array of all cert based Security Principals. </param>
        /// <returns> A new <see cref="Models.ConfidentialLedgerProperties"/> instance for mocking. </returns>
        public static ConfidentialLedgerProperties ConfidentialLedgerProperties(string ledgerName = null, Uri ledgerUri = null, Uri identityServiceUri = null, string ledgerInternalNamespace = null, ConfidentialLedgerRunningState? runningState = null, ConfidentialLedgerType? ledgerType = null, ConfidentialLedgerProvisioningState? provisioningState = null, IEnumerable<AadBasedSecurityPrincipal> aadBasedSecurityPrincipals = null, IEnumerable<CertBasedSecurityPrincipal> certBasedSecurityPrincipals = null)
        {
            aadBasedSecurityPrincipals ??= new List<AadBasedSecurityPrincipal>();
            certBasedSecurityPrincipals ??= new List<CertBasedSecurityPrincipal>();

            return new ConfidentialLedgerProperties(
                ledgerName,
                ledgerUri,
                identityServiceUri,
                ledgerInternalNamespace,
                runningState,
                ledgerType,
                provisioningState,
                aadBasedSecurityPrincipals?.ToList(),
                certBasedSecurityPrincipals?.ToList(),
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ConfidentialLedger.ManagedCcfData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> Properties of Managed CCF Resource. </param>
        /// <returns> A new <see cref="ConfidentialLedger.ManagedCcfData"/> instance for mocking. </returns>
        public static ManagedCcfData ManagedCcfData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ManagedCcfProperties properties = null)
        {
            tags ??= new Dictionary<string, string>();

            return new ManagedCcfData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ManagedCcfProperties"/>. </summary>
        /// <param name="appName"> Unique name for the Managed CCF. </param>
        /// <param name="appUri"> Endpoint for calling Managed CCF Service. </param>
        /// <param name="identityServiceUri"> Endpoint for accessing network identity. </param>
        /// <param name="memberIdentityCertificates"> List of member identity certificates for  Managed CCF. </param>
        /// <param name="deploymentType"> Deployment Type of Managed CCF. </param>
        /// <param name="provisioningState"> Provisioning state of Ledger Resource. </param>
        /// <param name="nodeCount"> Number of CCF nodes in the Managed CCF. </param>
        /// <returns> A new <see cref="Models.ManagedCcfProperties"/> instance for mocking. </returns>
        public static ManagedCcfProperties ManagedCcfProperties(string appName = null, Uri appUri = null, Uri identityServiceUri = null, IEnumerable<ConfidentialLedgerMemberIdentityCertificate> memberIdentityCertificates = null, ConfidentialLedgerDeploymentType deploymentType = null, ConfidentialLedgerProvisioningState? provisioningState = null, int? nodeCount = null)
        {
            memberIdentityCertificates ??= new List<ConfidentialLedgerMemberIdentityCertificate>();

            return new ManagedCcfProperties(
                appName,
                appUri,
                identityServiceUri,
                memberIdentityCertificates?.ToList(),
                deploymentType,
                provisioningState,
                nodeCount,
                serializedAdditionalRawData: null);
        }
    }
}
