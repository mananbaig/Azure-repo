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

namespace Azure.ResourceManager.Billing
{
    /// <summary>
    /// A Class representing a PaymentMethod along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="PaymentMethodResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetPaymentMethodResource method.
    /// Otherwise you can get one from its parent resource <see cref="TenantResource" /> using the GetPaymentMethod method.
    /// </summary>
    public partial class PaymentMethodResource : BasePaymentMethodResource
    {
        /// <summary> Generate the resource identifier of a <see cref="PaymentMethodResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string paymentMethodName)
        {
            var resourceId = $"/providers/Microsoft.Billing/paymentMethods/{paymentMethodName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _paymentMethodClientDiagnostics;
        private readonly PaymentMethodsRestOperations _paymentMethodRestClient;

        /// <summary> Initializes a new instance of the <see cref="PaymentMethodResource"/> class for mocking. </summary>
        protected PaymentMethodResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "PaymentMethodResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal PaymentMethodResource(ArmClient client, PaymentMethodData data) : base(client, data)
        {
            _paymentMethodClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Billing", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string paymentMethodApiVersion);
            _paymentMethodRestClient = new PaymentMethodsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, paymentMethodApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="PaymentMethodResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PaymentMethodResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _paymentMethodClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Billing", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string paymentMethodApiVersion);
            _paymentMethodRestClient = new PaymentMethodsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, paymentMethodApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Billing/paymentMethods";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Gets a payment method owned by the caller.
        /// Request Path: /providers/Microsoft.Billing/paymentMethods/{paymentMethodName}
        /// Operation Id: PaymentMethods_GetByUser
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<BasePaymentMethodResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _paymentMethodClientDiagnostics.CreateScope("PaymentMethodResource.GetCore");
            scope.Start();
            try
            {
                var response = await _paymentMethodRestClient.GetByUserAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a payment method owned by the caller.
        /// Request Path: /providers/Microsoft.Billing/paymentMethods/{paymentMethodName}
        /// Operation Id: PaymentMethods_GetByUser
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual async Task<Response<PaymentMethodResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var value = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((PaymentMethodResource)value.Value, value.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Gets a payment method owned by the caller.
        /// Request Path: /providers/Microsoft.Billing/paymentMethods/{paymentMethodName}
        /// Operation Id: PaymentMethods_GetByUser
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<BasePaymentMethodResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _paymentMethodClientDiagnostics.CreateScope("PaymentMethodResource.GetCore");
            scope.Start();
            try
            {
                var response = _paymentMethodRestClient.GetByUser(Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a payment method owned by the caller.
        /// Request Path: /providers/Microsoft.Billing/paymentMethods/{paymentMethodName}
        /// Operation Id: PaymentMethods_GetByUser
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual Response<PaymentMethodResource> Get(CancellationToken cancellationToken = default)
        {
            var value = GetCore(cancellationToken);
            return Response.FromValue((PaymentMethodResource)value.Value, value.GetRawResponse());
        }

        /// <summary>
        /// Deletes a payment method owned by the caller.
        /// Request Path: /providers/Microsoft.Billing/paymentMethods/{paymentMethodName}
        /// Operation Id: PaymentMethods_DeleteByUser
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _paymentMethodClientDiagnostics.CreateScope("PaymentMethodResource.Delete");
            scope.Start();
            try
            {
                var response = await _paymentMethodRestClient.DeleteByUserAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new BillingArmOperation(response);
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
        /// Deletes a payment method owned by the caller.
        /// Request Path: /providers/Microsoft.Billing/paymentMethods/{paymentMethodName}
        /// Operation Id: PaymentMethods_DeleteByUser
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _paymentMethodClientDiagnostics.CreateScope("PaymentMethodResource.Delete");
            scope.Start();
            try
            {
                var response = _paymentMethodRestClient.DeleteByUser(Id.Name, cancellationToken);
                var operation = new BillingArmOperation(response);
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
    }
}
