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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a RecoverableDatabase along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="RecoverableDatabaseResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetRecoverableDatabaseResource method.
    /// Otherwise you can get one from its parent resource <see cref="SqlServerResource" /> using the GetRecoverableDatabase method.
    /// </summary>
    public partial class RecoverableDatabaseResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="RecoverableDatabaseResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string databaseName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/recoverableDatabases/{databaseName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _recoverableDatabaseClientDiagnostics;
        private readonly RecoverableDatabasesRestOperations _recoverableDatabaseRestClient;
        private readonly RecoverableDatabaseData _data;

        /// <summary> Initializes a new instance of the <see cref="RecoverableDatabaseResource"/> class for mocking. </summary>
        protected RecoverableDatabaseResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "RecoverableDatabaseResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal RecoverableDatabaseResource(ArmClient client, RecoverableDatabaseData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="RecoverableDatabaseResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal RecoverableDatabaseResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _recoverableDatabaseClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string recoverableDatabaseApiVersion);
            _recoverableDatabaseRestClient = new RecoverableDatabasesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, recoverableDatabaseApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/recoverableDatabases";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual RecoverableDatabaseData Data
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
    }
}
