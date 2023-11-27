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

namespace Azure.ResourceManager.Monitor
{
    /// <summary>
    /// A Class representing a VmInsightsOnboardingStatus along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="VmInsightsOnboardingStatusResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetVmInsightsOnboardingStatusResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource"/> using the GetVmInsightsOnboardingStatus method.
    /// </summary>
    public partial class VmInsightsOnboardingStatusResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="VmInsightsOnboardingStatusResource"/> instance. </summary>
        /// <param name="resourceUri"> The resourceUri. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string resourceUri)
        {
            var resourceId = $"{resourceUri}/providers/Microsoft.Insights/vmInsightsOnboardingStatuses/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _vmInsightsOnboardingStatusVmInsightsClientDiagnostics;
        private readonly VMInsightsRestOperations _vmInsightsOnboardingStatusVmInsightsRestClient;
        private readonly VmInsightsOnboardingStatusData _data;

        /// <summary> Initializes a new instance of the <see cref="VmInsightsOnboardingStatusResource"/> class for mocking. </summary>
        protected VmInsightsOnboardingStatusResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VmInsightsOnboardingStatusResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal VmInsightsOnboardingStatusResource(ArmClient client, VmInsightsOnboardingStatusData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="VmInsightsOnboardingStatusResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal VmInsightsOnboardingStatusResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _vmInsightsOnboardingStatusVmInsightsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Monitor", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string vmInsightsOnboardingStatusVmInsightsApiVersion);
            _vmInsightsOnboardingStatusVmInsightsRestClient = new VMInsightsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, vmInsightsOnboardingStatusVmInsightsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Insights/vmInsightsOnboardingStatuses";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual VmInsightsOnboardingStatusData Data
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
        /// Retrieves the VM Insights onboarding status for the specified resource or resource scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Insights/vmInsightsOnboardingStatuses/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VMInsights_GetOnboardingStatus</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<VmInsightsOnboardingStatusResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _vmInsightsOnboardingStatusVmInsightsClientDiagnostics.CreateScope("VmInsightsOnboardingStatusResource.Get");
            scope.Start();
            try
            {
                var response = await _vmInsightsOnboardingStatusVmInsightsRestClient.GetOnboardingStatusAsync(Id.Parent, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VmInsightsOnboardingStatusResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the VM Insights onboarding status for the specified resource or resource scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Insights/vmInsightsOnboardingStatuses/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VMInsights_GetOnboardingStatus</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VmInsightsOnboardingStatusResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _vmInsightsOnboardingStatusVmInsightsClientDiagnostics.CreateScope("VmInsightsOnboardingStatusResource.Get");
            scope.Start();
            try
            {
                var response = _vmInsightsOnboardingStatusVmInsightsRestClient.GetOnboardingStatus(Id.Parent, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VmInsightsOnboardingStatusResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
