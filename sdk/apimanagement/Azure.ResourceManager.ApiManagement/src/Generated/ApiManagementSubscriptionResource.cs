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
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A Class representing an ApiManagementSubscription along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="ApiManagementSubscriptionResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetApiManagementSubscriptionResource method.
    /// Otherwise you can get one from its parent resource <see cref="ApiManagementServiceResource"/> using the GetApiManagementSubscription method.
    /// </summary>
    public partial class ApiManagementSubscriptionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ApiManagementSubscriptionResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="serviceName"> The serviceName. </param>
        /// <param name="sid"> The sid. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string sid)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/subscriptions/{sid}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _apiManagementSubscriptionSubscriptionClientDiagnostics;
        private readonly SubscriptionRestOperations _apiManagementSubscriptionSubscriptionRestClient;
        private readonly SubscriptionContractData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ApiManagement/service/subscriptions";

        /// <summary> Initializes a new instance of the <see cref="ApiManagementSubscriptionResource"/> class for mocking. </summary>
        protected ApiManagementSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ApiManagementSubscriptionResource(ArmClient client, SubscriptionContractData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ApiManagementSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementSubscriptionSubscriptionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string apiManagementSubscriptionSubscriptionApiVersion);
            _apiManagementSubscriptionSubscriptionRestClient = new SubscriptionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementSubscriptionSubscriptionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SubscriptionContractData Data
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
        /// Gets the specified Subscription entity.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/subscriptions/{sid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ApiManagementSubscriptionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementSubscriptionSubscriptionClientDiagnostics.CreateScope("ApiManagementSubscriptionResource.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementSubscriptionSubscriptionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Subscription entity.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/subscriptions/{sid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApiManagementSubscriptionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementSubscriptionSubscriptionClientDiagnostics.CreateScope("ApiManagementSubscriptionResource.Get");
            scope.Start();
            try
            {
                var response = _apiManagementSubscriptionSubscriptionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/subscriptions/{sid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, ETag ifMatch, CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementSubscriptionSubscriptionClientDiagnostics.CreateScope("ApiManagementSubscriptionResource.Delete");
            scope.Start();
            try
            {
                var response = await _apiManagementSubscriptionSubscriptionRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation(response);
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
        /// Deletes the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/subscriptions/{sid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, ETag ifMatch, CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementSubscriptionSubscriptionClientDiagnostics.CreateScope("ApiManagementSubscriptionResource.Delete");
            scope.Start();
            try
            {
                var response = _apiManagementSubscriptionSubscriptionRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation(response);
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
        /// Updates the details of a subscription specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/subscriptions/{sid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="patch"> Update parameters. </param>
        /// <param name="notify">
        /// Notify change in Subscription State.
        ///  - If false, do not send any email notification for change of state of subscription
        ///  - If true, send email notification of change of state of subscription
        /// </param>
        /// <param name="appType"> Determines the type of application which send the create user request. Default is legacy publisher portal. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<Response<ApiManagementSubscriptionResource>> UpdateAsync(ETag ifMatch, ApiManagementSubscriptionPatch patch, bool? notify = null, AppType? appType = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _apiManagementSubscriptionSubscriptionClientDiagnostics.CreateScope("ApiManagementSubscriptionResource.Update");
            scope.Start();
            try
            {
                var response = await _apiManagementSubscriptionSubscriptionRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, patch, notify, appType, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ApiManagementSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates the details of a subscription specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/subscriptions/{sid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="patch"> Update parameters. </param>
        /// <param name="notify">
        /// Notify change in Subscription State.
        ///  - If false, do not send any email notification for change of state of subscription
        ///  - If true, send email notification of change of state of subscription
        /// </param>
        /// <param name="appType"> Determines the type of application which send the create user request. Default is legacy publisher portal. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual Response<ApiManagementSubscriptionResource> Update(ETag ifMatch, ApiManagementSubscriptionPatch patch, bool? notify = null, AppType? appType = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _apiManagementSubscriptionSubscriptionClientDiagnostics.CreateScope("ApiManagementSubscriptionResource.Update");
            scope.Start();
            try
            {
                var response = _apiManagementSubscriptionSubscriptionRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, patch, notify, appType, cancellationToken);
                return Response.FromValue(new ApiManagementSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Regenerates primary key of existing subscription of the API Management service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/subscriptions/{sid}/regeneratePrimaryKey</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_RegeneratePrimaryKey</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> RegeneratePrimaryKeyAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementSubscriptionSubscriptionClientDiagnostics.CreateScope("ApiManagementSubscriptionResource.RegeneratePrimaryKey");
            scope.Start();
            try
            {
                var response = await _apiManagementSubscriptionSubscriptionRestClient.RegeneratePrimaryKeyAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Regenerates primary key of existing subscription of the API Management service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/subscriptions/{sid}/regeneratePrimaryKey</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_RegeneratePrimaryKey</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response RegeneratePrimaryKey(CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementSubscriptionSubscriptionClientDiagnostics.CreateScope("ApiManagementSubscriptionResource.RegeneratePrimaryKey");
            scope.Start();
            try
            {
                var response = _apiManagementSubscriptionSubscriptionRestClient.RegeneratePrimaryKey(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Regenerates secondary key of existing subscription of the API Management service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/subscriptions/{sid}/regenerateSecondaryKey</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_RegenerateSecondaryKey</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> RegenerateSecondaryKeyAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementSubscriptionSubscriptionClientDiagnostics.CreateScope("ApiManagementSubscriptionResource.RegenerateSecondaryKey");
            scope.Start();
            try
            {
                var response = await _apiManagementSubscriptionSubscriptionRestClient.RegenerateSecondaryKeyAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Regenerates secondary key of existing subscription of the API Management service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/subscriptions/{sid}/regenerateSecondaryKey</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_RegenerateSecondaryKey</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response RegenerateSecondaryKey(CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementSubscriptionSubscriptionClientDiagnostics.CreateScope("ApiManagementSubscriptionResource.RegenerateSecondaryKey");
            scope.Start();
            try
            {
                var response = _apiManagementSubscriptionSubscriptionRestClient.RegenerateSecondaryKey(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Subscription keys.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/subscriptions/{sid}/listSecrets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_ListSecrets</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SubscriptionKeysContract>> GetSecretsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementSubscriptionSubscriptionClientDiagnostics.CreateScope("ApiManagementSubscriptionResource.GetSecrets");
            scope.Start();
            try
            {
                var response = await _apiManagementSubscriptionSubscriptionRestClient.ListSecretsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Subscription keys.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/subscriptions/{sid}/listSecrets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_ListSecrets</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SubscriptionKeysContract> GetSecrets(CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementSubscriptionSubscriptionClientDiagnostics.CreateScope("ApiManagementSubscriptionResource.GetSecrets");
            scope.Start();
            try
            {
                var response = _apiManagementSubscriptionSubscriptionRestClient.ListSecrets(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the entity state (Etag) version of the apimanagement subscription specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/subscriptions/{sid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_GetEntityTag</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> GetEntityTagAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementSubscriptionSubscriptionClientDiagnostics.CreateScope("ApiManagementSubscriptionResource.GetEntityTag");
            scope.Start();
            try
            {
                var response = await _apiManagementSubscriptionSubscriptionRestClient.GetEntityTagAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the entity state (Etag) version of the apimanagement subscription specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/subscriptions/{sid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_GetEntityTag</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> GetEntityTag(CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementSubscriptionSubscriptionClientDiagnostics.CreateScope("ApiManagementSubscriptionResource.GetEntityTag");
            scope.Start();
            try
            {
                var response = _apiManagementSubscriptionSubscriptionRestClient.GetEntityTag(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
