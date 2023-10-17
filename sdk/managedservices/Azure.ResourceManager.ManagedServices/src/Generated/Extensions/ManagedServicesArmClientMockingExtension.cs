// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.ManagedServices;

namespace Azure.ResourceManager.ManagedServices.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class ManagedServicesArmClientMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="ManagedServicesArmClientMockingExtension"/> class for mocking. </summary>
        protected ManagedServicesArmClientMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedServicesArmClientMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagedServicesArmClientMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal ManagedServicesArmClientMockingExtension(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ManagedServicesRegistrationResources in the ArmClient. </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <returns> An object representing collection of ManagedServicesRegistrationResources and their operations over a ManagedServicesRegistrationResource. </returns>
        public virtual ManagedServicesRegistrationCollection GetManagedServicesRegistrations(ResourceIdentifier scope)
        {
            return new ManagedServicesRegistrationCollection(Client, scope);
        }

        /// <summary>
        /// Gets the registration definition details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.ManagedServices/registrationDefinitions/{registrationDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistrationDefinitions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="registrationId"> The GUID of the registration definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="registrationId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="registrationId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ManagedServicesRegistrationResource>> GetManagedServicesRegistrationAsync(ResourceIdentifier scope, string registrationId, CancellationToken cancellationToken = default)
        {
            return await GetManagedServicesRegistrations(scope).GetAsync(registrationId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the registration definition details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.ManagedServices/registrationDefinitions/{registrationDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistrationDefinitions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="registrationId"> The GUID of the registration definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="registrationId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="registrationId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ManagedServicesRegistrationResource> GetManagedServicesRegistration(ResourceIdentifier scope, string registrationId, CancellationToken cancellationToken = default)
        {
            return GetManagedServicesRegistrations(scope).Get(registrationId, cancellationToken);
        }

        /// <summary> Gets a collection of ManagedServicesRegistrationAssignmentResources in the ArmClient. </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <returns> An object representing collection of ManagedServicesRegistrationAssignmentResources and their operations over a ManagedServicesRegistrationAssignmentResource. </returns>
        public virtual ManagedServicesRegistrationAssignmentCollection GetManagedServicesRegistrationAssignments(ResourceIdentifier scope)
        {
            return new ManagedServicesRegistrationAssignmentCollection(Client, scope);
        }

        /// <summary>
        /// Gets the details of the specified registration assignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.ManagedServices/registrationAssignments/{registrationAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistrationAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="registrationAssignmentId"> The GUID of the registration assignment. </param>
        /// <param name="expandRegistrationDefinition"> The flag indicating whether to return the registration definition details along with the registration assignment details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="registrationAssignmentId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="registrationAssignmentId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ManagedServicesRegistrationAssignmentResource>> GetManagedServicesRegistrationAssignmentAsync(ResourceIdentifier scope, string registrationAssignmentId, bool? expandRegistrationDefinition = null, CancellationToken cancellationToken = default)
        {
            return await GetManagedServicesRegistrationAssignments(scope).GetAsync(registrationAssignmentId, expandRegistrationDefinition, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the details of the specified registration assignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.ManagedServices/registrationAssignments/{registrationAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistrationAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="registrationAssignmentId"> The GUID of the registration assignment. </param>
        /// <param name="expandRegistrationDefinition"> The flag indicating whether to return the registration definition details along with the registration assignment details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="registrationAssignmentId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="registrationAssignmentId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ManagedServicesRegistrationAssignmentResource> GetManagedServicesRegistrationAssignment(ResourceIdentifier scope, string registrationAssignmentId, bool? expandRegistrationDefinition = null, CancellationToken cancellationToken = default)
        {
            return GetManagedServicesRegistrationAssignments(scope).Get(registrationAssignmentId, expandRegistrationDefinition, cancellationToken);
        }

        /// <summary> Gets a collection of ManagedServicesMarketplaceRegistrationResources in the ArmClient. </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <returns> An object representing collection of ManagedServicesMarketplaceRegistrationResources and their operations over a ManagedServicesMarketplaceRegistrationResource. </returns>
        public virtual ManagedServicesMarketplaceRegistrationCollection GetManagedServicesMarketplaceRegistrations(ResourceIdentifier scope)
        {
            return new ManagedServicesMarketplaceRegistrationCollection(Client, scope);
        }

        /// <summary>
        /// Get the marketplace registration definition for the marketplace identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.ManagedServices/marketplaceRegistrationDefinitions/{marketplaceIdentifier}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceRegistrationDefinitions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="marketplaceIdentifier"> The Azure Marketplace identifier. Expected formats: {publisher}.{product[-preview]}.{planName}.{version} or {publisher}.{product[-preview]}.{planName} or {publisher}.{product[-preview]} or {publisher}). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="marketplaceIdentifier"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="marketplaceIdentifier"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ManagedServicesMarketplaceRegistrationResource>> GetManagedServicesMarketplaceRegistrationAsync(ResourceIdentifier scope, string marketplaceIdentifier, CancellationToken cancellationToken = default)
        {
            return await GetManagedServicesMarketplaceRegistrations(scope).GetAsync(marketplaceIdentifier, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the marketplace registration definition for the marketplace identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.ManagedServices/marketplaceRegistrationDefinitions/{marketplaceIdentifier}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceRegistrationDefinitions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="marketplaceIdentifier"> The Azure Marketplace identifier. Expected formats: {publisher}.{product[-preview]}.{planName}.{version} or {publisher}.{product[-preview]}.{planName} or {publisher}.{product[-preview]} or {publisher}). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="marketplaceIdentifier"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="marketplaceIdentifier"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ManagedServicesMarketplaceRegistrationResource> GetManagedServicesMarketplaceRegistration(ResourceIdentifier scope, string marketplaceIdentifier, CancellationToken cancellationToken = default)
        {
            return GetManagedServicesMarketplaceRegistrations(scope).Get(marketplaceIdentifier, cancellationToken);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ManagedServicesRegistrationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ManagedServicesRegistrationResource.CreateResourceIdentifier" /> to create a <see cref="ManagedServicesRegistrationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ManagedServicesRegistrationResource" /> object. </returns>
        public virtual ManagedServicesRegistrationResource GetManagedServicesRegistrationResource(ResourceIdentifier id)
        {
            ManagedServicesRegistrationResource.ValidateResourceId(id);
            return new ManagedServicesRegistrationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ManagedServicesRegistrationAssignmentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ManagedServicesRegistrationAssignmentResource.CreateResourceIdentifier" /> to create a <see cref="ManagedServicesRegistrationAssignmentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ManagedServicesRegistrationAssignmentResource" /> object. </returns>
        public virtual ManagedServicesRegistrationAssignmentResource GetManagedServicesRegistrationAssignmentResource(ResourceIdentifier id)
        {
            ManagedServicesRegistrationAssignmentResource.ValidateResourceId(id);
            return new ManagedServicesRegistrationAssignmentResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ManagedServicesMarketplaceRegistrationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ManagedServicesMarketplaceRegistrationResource.CreateResourceIdentifier" /> to create a <see cref="ManagedServicesMarketplaceRegistrationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ManagedServicesMarketplaceRegistrationResource" /> object. </returns>
        public virtual ManagedServicesMarketplaceRegistrationResource GetManagedServicesMarketplaceRegistrationResource(ResourceIdentifier id)
        {
            ManagedServicesMarketplaceRegistrationResource.ValidateResourceId(id);
            return new ManagedServicesMarketplaceRegistrationResource(Client, id);
        }
    }
}
