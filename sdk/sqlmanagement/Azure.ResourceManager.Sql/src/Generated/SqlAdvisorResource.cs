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

namespace Azure.ResourceManager.Sql
{
    /// <summary> TODO. </summary>
    public abstract partial class SqlAdvisorResource : ArmResource
    {
        internal static SqlAdvisorResource GetResource(ArmClient client, SqlAdvisorData data)
        {
            if (IsSqlDatabaseAdvisorResource(data.Id))
            {
                return new SqlDatabaseAdvisorResource(client, data);
            }
            if (IsSqlServerAdvisorResource(data.Id))
            {
                return new SqlServerAdvisorResource(client, data);
            }
            // TODO -- should we throw or return an UnknownResource?
            throw new InvalidOperationException();
        }

        internal static bool IsSqlDatabaseAdvisorResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != SqlDatabaseAdvisorResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.Parent.ResourceType != "Microsoft.Resources/resourceGroups")
            {
                return false;
            }
            return true;
        }

        internal static bool IsSqlServerAdvisorResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != SqlServerAdvisorResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.ResourceType != "Microsoft.Resources/resourceGroups")
            {
                return false;
            }
            return true;
        }

        private readonly SqlAdvisorData _data;

        /// <summary> Initializes a new instance of the <see cref="SqlAdvisorResource"/> class for mocking. </summary>
        protected SqlAdvisorResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SqlAdvisorResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SqlAdvisorResource(ArmClient client, SqlAdvisorData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SqlAdvisorResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SqlAdvisorResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SqlAdvisorData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// <summary> The core implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected abstract Task<Response<SqlAdvisorResource>> GetCoreAsync(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public async Task<Response<SqlAdvisorResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await GetCoreAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The core implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected abstract Response<SqlAdvisorResource> GetCore(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public Response<SqlAdvisorResource> Get(CancellationToken cancellationToken = default)
        {
            return GetCore(cancellationToken);
        }

        /// <summary> The core implementation for operation Update. </summary>
        /// <param name="data"> The requested advisor resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        protected abstract Task<Response<SqlAdvisorResource>> UpdateCoreAsync(SqlAdvisorData data, CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Update. </summary>
        /// <param name="data"> The requested advisor resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public async Task<Response<SqlAdvisorResource>> UpdateAsync(SqlAdvisorData data, CancellationToken cancellationToken = default)
        {
            return await UpdateCoreAsync(data, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The core implementation for operation Update. </summary>
        /// <param name="data"> The requested advisor resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        protected abstract Response<SqlAdvisorResource> UpdateCore(SqlAdvisorData data, CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Update. </summary>
        /// <param name="data"> The requested advisor resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public Response<SqlAdvisorResource> Update(SqlAdvisorData data, CancellationToken cancellationToken = default)
        {
            return UpdateCore(data, cancellationToken);
        }
    }
}
