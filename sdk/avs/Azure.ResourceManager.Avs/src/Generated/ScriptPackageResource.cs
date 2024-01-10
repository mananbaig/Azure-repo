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

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A Class representing a ScriptPackage along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ScriptPackageResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetScriptPackageResource method.
    /// Otherwise you can get one from its parent resource <see cref="AvsPrivateCloudResource"/> using the GetScriptPackage method.
    /// </summary>
    public partial class ScriptPackageResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ScriptPackageResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="privateCloudName"> The privateCloudName. </param>
        /// <param name="scriptPackageName"> The scriptPackageName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string privateCloudName, string scriptPackageName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/scriptPackages/{scriptPackageName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _scriptPackageClientDiagnostics;
        private readonly ScriptPackagesRestOperations _scriptPackageRestClient;
        private readonly ScriptPackageData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.AVS/privateClouds/scriptPackages";

        /// <summary> Initializes a new instance of the <see cref="ScriptPackageResource"/> class for mocking. </summary>
        protected ScriptPackageResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ScriptPackageResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ScriptPackageResource(ArmClient client, ScriptPackageData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ScriptPackageResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ScriptPackageResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _scriptPackageClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Avs", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string scriptPackageApiVersion);
            _scriptPackageRestClient = new ScriptPackagesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, scriptPackageApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ScriptPackageData Data
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

        /// <summary> Gets a collection of ScriptCmdletResources in the ScriptPackage. </summary>
        /// <returns> An object representing collection of ScriptCmdletResources and their operations over a ScriptCmdletResource. </returns>
        public virtual ScriptCmdletCollection GetScriptCmdlets()
        {
            return GetCachedClient(client => new ScriptCmdletCollection(client, Id));
        }

        /// <summary>
        /// Return information about a script cmdlet resource in a specific package on a private cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/scriptPackages/{scriptPackageName}/scriptCmdlets/{scriptCmdletName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScriptCmdlets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScriptCmdletResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scriptCmdletName"> Name of the script cmdlet resource in the script package in the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptCmdletName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="scriptCmdletName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ScriptCmdletResource>> GetScriptCmdletAsync(string scriptCmdletName, CancellationToken cancellationToken = default)
        {
            return await GetScriptCmdlets().GetAsync(scriptCmdletName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Return information about a script cmdlet resource in a specific package on a private cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/scriptPackages/{scriptPackageName}/scriptCmdlets/{scriptCmdletName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScriptCmdlets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScriptCmdletResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scriptCmdletName"> Name of the script cmdlet resource in the script package in the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptCmdletName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="scriptCmdletName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ScriptCmdletResource> GetScriptCmdlet(string scriptCmdletName, CancellationToken cancellationToken = default)
        {
            return GetScriptCmdlets().Get(scriptCmdletName, cancellationToken);
        }

        /// <summary>
        /// Get a script package available to run on a private cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/scriptPackages/{scriptPackageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScriptPackages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScriptPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ScriptPackageResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _scriptPackageClientDiagnostics.CreateScope("ScriptPackageResource.Get");
            scope.Start();
            try
            {
                var response = await _scriptPackageRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScriptPackageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a script package available to run on a private cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/scriptPackages/{scriptPackageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScriptPackages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScriptPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ScriptPackageResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _scriptPackageClientDiagnostics.CreateScope("ScriptPackageResource.Get");
            scope.Start();
            try
            {
                var response = _scriptPackageRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScriptPackageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
