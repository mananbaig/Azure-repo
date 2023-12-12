// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Chaos
{
    /// <summary>
    /// A Class representing a TargetType along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="TargetTypeResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetTargetTypeResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource"/> using the GetTargetType method.
    /// </summary>
    public partial class TargetTypeResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="TargetTypeResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="locationName"> The locationName. </param>
        /// <param name="targetTypeName"> The targetTypeName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string locationName, string targetTypeName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/locations/{locationName}/targetTypes/{targetTypeName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _targetTypeClientDiagnostics;
        private readonly TargetTypesRestOperations _targetTypeRestClient;
        private readonly TargetTypeData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Chaos/locations/targetTypes";

        /// <summary> Initializes a new instance of the <see cref="TargetTypeResource"/> class for mocking. </summary>
        protected TargetTypeResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TargetTypeResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal TargetTypeResource(ArmClient client, TargetTypeData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="TargetTypeResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TargetTypeResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _targetTypeClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Chaos", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string targetTypeApiVersion);
            _targetTypeRestClient = new TargetTypesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, targetTypeApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual TargetTypeData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of CapabilityTypeResources in the TargetType. </summary>
        /// <returns> An object representing collection of CapabilityTypeResources and their operations over a CapabilityTypeResource. </returns>
        public virtual CapabilityTypeCollection GetCapabilityTypes()
        {
            return GetCachedClient(client => new CapabilityTypeCollection(client, Id));
        }

        /// <summary>
        /// Get a Capability Type resource for given Target Type and location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/locations/{locationName}/targetTypes/{targetTypeName}/capabilityTypes/{capabilityTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CapabilityTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="capabilityTypeName"> String that represents a Capability Type resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilityTypeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="capabilityTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<CapabilityTypeResource>> GetCapabilityTypeAsync(string capabilityTypeName, CancellationToken cancellationToken = default)
        {
            return await GetCapabilityTypes().GetAsync(capabilityTypeName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a Capability Type resource for given Target Type and location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/locations/{locationName}/targetTypes/{targetTypeName}/capabilityTypes/{capabilityTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CapabilityTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="capabilityTypeName"> String that represents a Capability Type resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="capabilityTypeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="capabilityTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<CapabilityTypeResource> GetCapabilityType(string capabilityTypeName, CancellationToken cancellationToken = default)
        {
            return GetCapabilityTypes().Get(capabilityTypeName, cancellationToken);
        }

        /// <summary>
        /// Get a Target Type resources for given location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/locations/{locationName}/targetTypes/{targetTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TargetTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TargetTypeResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _targetTypeClientDiagnostics.CreateScope("TargetTypeResource.Get");
            scope.Start();
            try
            {
                var response = await _targetTypeRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TargetTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Target Type resources for given location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/locations/{locationName}/targetTypes/{targetTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TargetTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TargetTypeResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _targetTypeClientDiagnostics.CreateScope("TargetTypeResource.Get");
            scope.Start();
            try
            {
                var response = _targetTypeRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TargetTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
