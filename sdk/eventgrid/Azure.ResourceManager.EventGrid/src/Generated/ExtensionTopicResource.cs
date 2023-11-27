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

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A Class representing an ExtensionTopic along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="ExtensionTopicResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetExtensionTopicResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource"/> using the GetExtensionTopic method.
    /// </summary>
    public partial class ExtensionTopicResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ExtensionTopicResource"/> instance. </summary>
        /// <param name="scope"> The scope. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string scope)
        {
            var resourceId = $"{scope}/providers/Microsoft.EventGrid/extensionTopics/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _extensionTopicClientDiagnostics;
        private readonly ExtensionTopicsRestOperations _extensionTopicRestClient;
        private readonly ExtensionTopicData _data;

        /// <summary> Initializes a new instance of the <see cref="ExtensionTopicResource"/> class for mocking. </summary>
        protected ExtensionTopicResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExtensionTopicResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ExtensionTopicResource(ArmClient client, ExtensionTopicData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ExtensionTopicResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ExtensionTopicResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _extensionTopicClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventGrid", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string extensionTopicApiVersion);
            _extensionTopicRestClient = new ExtensionTopicsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, extensionTopicApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.EventGrid/extensionTopics";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ExtensionTopicData Data
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
        /// Get the properties of an extension topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.EventGrid/extensionTopics/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExtensionTopics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ExtensionTopicResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _extensionTopicClientDiagnostics.CreateScope("ExtensionTopicResource.Get");
            scope.Start();
            try
            {
                var response = await _extensionTopicRestClient.GetAsync(Id.Parent, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExtensionTopicResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the properties of an extension topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.EventGrid/extensionTopics/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExtensionTopics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExtensionTopicResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _extensionTopicClientDiagnostics.CreateScope("ExtensionTopicResource.Get");
            scope.Start();
            try
            {
                var response = _extensionTopicRestClient.Get(Id.Parent, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExtensionTopicResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
