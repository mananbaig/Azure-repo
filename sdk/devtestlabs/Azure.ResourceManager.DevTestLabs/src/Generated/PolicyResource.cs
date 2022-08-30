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
using Azure.ResourceManager.DevTestLabs.Models;

namespace Azure.ResourceManager.DevTestLabs
{
    /// <summary>
    /// A Class representing a Policy along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="PolicyResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetPolicyResource method.
    /// Otherwise you can get one from its parent resource <see cref="LabResource" /> using the GetPolicy method.
    /// </summary>
    public partial class PolicyResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="PolicyResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string labName, string policySetName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/policysets/{policySetName}/policies/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _policyClientDiagnostics;
        private readonly PoliciesRestOperations _policyRestClient;
        private readonly PolicyData _data;

        /// <summary> Initializes a new instance of the <see cref="PolicyResource"/> class for mocking. </summary>
        protected PolicyResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "PolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal PolicyResource(ArmClient client, PolicyData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="PolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PolicyResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _policyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevTestLabs", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string policyApiVersion);
            _policyRestClient = new PoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, policyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DevTestLab/labs/policysets/policies";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PolicyData Data
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

        /// <summary>
        /// Get policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/policysets/{policySetName}/policies/{name}
        /// Operation Id: Policies_Get
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: &apos;properties($select=description)&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PolicyResource>> GetAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _policyClientDiagnostics.CreateScope("PolicyResource.Get");
            scope.Start();
            try
            {
                var response = await _policyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/policysets/{policySetName}/policies/{name}
        /// Operation Id: Policies_Get
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: &apos;properties($select=description)&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PolicyResource> Get(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _policyClientDiagnostics.CreateScope("PolicyResource.Get");
            scope.Start();
            try
            {
                var response = _policyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/policysets/{policySetName}/policies/{name}
        /// Operation Id: Policies_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _policyClientDiagnostics.CreateScope("PolicyResource.Delete");
            scope.Start();
            try
            {
                var response = await _policyRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DevTestLabsArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
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
        /// Delete policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/policysets/{policySetName}/policies/{name}
        /// Operation Id: Policies_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _policyClientDiagnostics.CreateScope("PolicyResource.Delete");
            scope.Start();
            try
            {
                var response = _policyRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new DevTestLabsArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
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
        /// Allows modifying tags of policies. All other properties will be ignored.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/policysets/{policySetName}/policies/{name}
        /// Operation Id: Policies_Update
        /// </summary>
        /// <param name="patch"> A Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<Response<PolicyResource>> UpdateAsync(PolicyPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _policyClientDiagnostics.CreateScope("PolicyResource.Update");
            scope.Start();
            try
            {
                var response = await _policyRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new PolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Allows modifying tags of policies. All other properties will be ignored.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/policysets/{policySetName}/policies/{name}
        /// Operation Id: Policies_Update
        /// </summary>
        /// <param name="patch"> A Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual Response<PolicyResource> Update(PolicyPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _policyClientDiagnostics.CreateScope("PolicyResource.Update");
            scope.Start();
            try
            {
                var response = _policyRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, patch, cancellationToken);
                return Response.FromValue(new PolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/policysets/{policySetName}/policies/{name}
        /// Operation Id: Policies_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual async Task<Response<PolicyResource>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _policyClientDiagnostics.CreateScope("PolicyResource.AddTag");
            scope.Start();
            try
            {
                var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues[key] = value;
                await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _policyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new PolicyResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/policysets/{policySetName}/policies/{name}
        /// Operation Id: Policies_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<PolicyResource> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _policyClientDiagnostics.CreateScope("PolicyResource.AddTag");
            scope.Start();
            try
            {
                var originalTags = GetTagResource().Get(cancellationToken);
                originalTags.Value.Data.TagValues[key] = value;
                GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _policyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, null, cancellationToken);
                return Response.FromValue(new PolicyResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/policysets/{policySetName}/policies/{name}
        /// Operation Id: Policies_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual async Task<Response<PolicyResource>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _policyClientDiagnostics.CreateScope("PolicyResource.SetTags");
            scope.Start();
            try
            {
                await GetTagResource().DeleteAsync(WaitUntil.Completed, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _policyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new PolicyResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/policysets/{policySetName}/policies/{name}
        /// Operation Id: Policies_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<PolicyResource> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _policyClientDiagnostics.CreateScope("PolicyResource.SetTags");
            scope.Start();
            try
            {
                GetTagResource().Delete(WaitUntil.Completed, cancellationToken: cancellationToken);
                var originalTags = GetTagResource().Get(cancellationToken);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _policyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, null, cancellationToken);
                return Response.FromValue(new PolicyResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/policysets/{policySetName}/policies/{name}
        /// Operation Id: Policies_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual async Task<Response<PolicyResource>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _policyClientDiagnostics.CreateScope("PolicyResource.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.Remove(key);
                await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _policyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new PolicyResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/policysets/{policySetName}/policies/{name}
        /// Operation Id: Policies_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<PolicyResource> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _policyClientDiagnostics.CreateScope("PolicyResource.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = GetTagResource().Get(cancellationToken);
                originalTags.Value.Data.TagValues.Remove(key);
                GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _policyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, null, cancellationToken);
                return Response.FromValue(new PolicyResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
