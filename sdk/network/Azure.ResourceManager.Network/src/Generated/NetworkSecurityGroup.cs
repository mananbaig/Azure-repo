// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Network
{
    /// <summary> A Class representing a NetworkSecurityGroup along with the instance operations that can be performed on it. </summary>
    public partial class NetworkSecurityGroup : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="NetworkSecurityGroup"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string networkSecurityGroupName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _networkSecurityGroupClientDiagnostics;
        private readonly NetworkSecurityGroupsRestOperations _networkSecurityGroupRestClient;
        private readonly NetworkSecurityGroupData _data;

        /// <summary> Initializes a new instance of the <see cref="NetworkSecurityGroup"/> class for mocking. </summary>
        protected NetworkSecurityGroup()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "NetworkSecurityGroup"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal NetworkSecurityGroup(ArmClient client, NetworkSecurityGroupData data) : this(client, new ResourceIdentifier(data.Id))
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkSecurityGroup"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal NetworkSecurityGroup(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkSecurityGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string networkSecurityGroupApiVersion);
            _networkSecurityGroupRestClient = new NetworkSecurityGroupsRestOperations(_networkSecurityGroupClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, networkSecurityGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/networkSecurityGroups";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual NetworkSecurityGroupData Data
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

        /// <summary> Gets a collection of SecurityRules in the SecurityRule. </summary>
        /// <returns> An object representing collection of SecurityRules and their operations over a SecurityRule. </returns>
        public virtual SecurityRuleCollection GetSecurityRules()
        {
            return new SecurityRuleCollection(Client, Id);
        }

        /// <summary> Gets a collection of DefaultSecurityRules in the DefaultSecurityRule. </summary>
        /// <returns> An object representing collection of DefaultSecurityRules and their operations over a DefaultSecurityRule. </returns>
        public virtual DefaultSecurityRuleCollection GetDefaultSecurityRules()
        {
            return new DefaultSecurityRuleCollection(Client, Id);
        }

        /// <summary>
        /// Gets the specified network security group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}
        /// Operation Id: NetworkSecurityGroups_Get
        /// </summary>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<NetworkSecurityGroup>> GetAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroup.Get");
            scope.Start();
            try
            {
                var response = await _networkSecurityGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _networkSecurityGroupClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new NetworkSecurityGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified network security group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}
        /// Operation Id: NetworkSecurityGroups_Get
        /// </summary>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NetworkSecurityGroup> Get(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroup.Get");
            scope.Start();
            try
            {
                var response = _networkSecurityGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken);
                if (response.Value == null)
                    throw _networkSecurityGroupClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkSecurityGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified network security group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}
        /// Operation Id: NetworkSecurityGroups_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroup.Delete");
            scope.Start();
            try
            {
                var response = await _networkSecurityGroupRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation(_networkSecurityGroupClientDiagnostics, Pipeline, _networkSecurityGroupRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified network security group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}
        /// Operation Id: NetworkSecurityGroups_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroup.Delete");
            scope.Start();
            try
            {
                var response = _networkSecurityGroupRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new NetworkArmOperation(_networkSecurityGroupClientDiagnostics, Pipeline, _networkSecurityGroupRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}
        /// Operation Id: NetworkSecurityGroups_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public async virtual Task<Response<NetworkSecurityGroup>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroup.AddTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _networkSecurityGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new NetworkSecurityGroup(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}
        /// Operation Id: NetworkSecurityGroups_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<NetworkSecurityGroup> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroup.AddTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _networkSecurityGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken);
                return Response.FromValue(new NetworkSecurityGroup(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}
        /// Operation Id: NetworkSecurityGroups_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public async virtual Task<Response<NetworkSecurityGroup>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags));
            }

            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroup.SetTags");
            scope.Start();
            try
            {
                await TagResource.DeleteAsync(true, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _networkSecurityGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new NetworkSecurityGroup(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}
        /// Operation Id: NetworkSecurityGroups_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<NetworkSecurityGroup> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags));
            }

            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroup.SetTags");
            scope.Start();
            try
            {
                TagResource.Delete(true, cancellationToken: cancellationToken);
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _networkSecurityGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken);
                return Response.FromValue(new NetworkSecurityGroup(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}
        /// Operation Id: NetworkSecurityGroups_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public async virtual Task<Response<NetworkSecurityGroup>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroup.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _networkSecurityGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new NetworkSecurityGroup(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}
        /// Operation Id: NetworkSecurityGroups_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<NetworkSecurityGroup> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroup.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _networkSecurityGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken);
                return Response.FromValue(new NetworkSecurityGroup(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
