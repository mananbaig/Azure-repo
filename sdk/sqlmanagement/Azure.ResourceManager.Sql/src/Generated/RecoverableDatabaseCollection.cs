// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="RecoverableDatabaseResource" /> and their operations.
    /// Each <see cref="RecoverableDatabaseResource" /> in the collection will belong to the same instance of <see cref="SqlServerResource" />.
    /// To get a <see cref="RecoverableDatabaseCollection" /> instance call the GetRecoverableDatabases method from an instance of <see cref="SqlServerResource" />.
    /// </summary>
    public partial class RecoverableDatabaseCollection : ArmCollection, IEnumerable<RecoverableDatabaseResource>, IAsyncEnumerable<RecoverableDatabaseResource>
    {
        private readonly ClientDiagnostics _recoverableDatabaseClientDiagnostics;
        private readonly RecoverableDatabasesRestOperations _recoverableDatabaseRestClient;

        /// <summary> Initializes a new instance of the <see cref="RecoverableDatabaseCollection"/> class for mocking. </summary>
        protected RecoverableDatabaseCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RecoverableDatabaseCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RecoverableDatabaseCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _recoverableDatabaseClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", RecoverableDatabaseResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RecoverableDatabaseResource.ResourceType, out string recoverableDatabaseApiVersion);
            _recoverableDatabaseRestClient = new RecoverableDatabasesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, recoverableDatabaseApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a list of recoverable databases.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/recoverableDatabases</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoverableDatabases_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RecoverableDatabaseResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RecoverableDatabaseResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _recoverableDatabaseRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _recoverableDatabaseRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new RecoverableDatabaseResource(Client, RecoverableDatabaseData.DeserializeRecoverableDatabaseData(e)), _recoverableDatabaseClientDiagnostics, Pipeline, "RecoverableDatabaseCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of recoverable databases.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/recoverableDatabases</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoverableDatabases_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RecoverableDatabaseResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RecoverableDatabaseResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _recoverableDatabaseRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _recoverableDatabaseRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new RecoverableDatabaseResource(Client, RecoverableDatabaseData.DeserializeRecoverableDatabaseData(e)), _recoverableDatabaseClientDiagnostics, Pipeline, "RecoverableDatabaseCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        IEnumerator<RecoverableDatabaseResource> IEnumerable<RecoverableDatabaseResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RecoverableDatabaseResource> IAsyncEnumerable<RecoverableDatabaseResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
