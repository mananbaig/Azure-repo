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

namespace Azure.ResourceManager.Logic
{
    /// <summary> TODO. </summary>
    public abstract partial class LogicWorkflowRunActionRepetitionDefinitionResource : ArmResource
    {
        internal static LogicWorkflowRunActionRepetitionDefinitionResource GetResource(ArmClient client, LogicWorkflowRunActionRepetitionDefinitionData data)
        {
            if (IsLogicWorkflowRunActionRepetitionResource(data.Id))
            {
                return new LogicWorkflowRunActionRepetitionResource(client, data);
            }
            if (IsLogicWorkflowRunActionScopeRepetitionResource(data.Id))
            {
                return new LogicWorkflowRunActionScopeRepetitionResource(client, data);
            }
            // TODO -- should we throw or return an UnknownResource?
            throw new InvalidOperationException();
        }

        internal static bool IsLogicWorkflowRunActionRepetitionResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != LogicWorkflowRunActionRepetitionResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.Parent.Parent.ResourceType != "Microsoft.Resources/resourceGroups")
            {
                return false;
            }
            return true;
        }

        internal static bool IsLogicWorkflowRunActionScopeRepetitionResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != LogicWorkflowRunActionScopeRepetitionResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.Parent.Parent.ResourceType != "Microsoft.Resources/resourceGroups")
            {
                return false;
            }
            return true;
        }

        private readonly LogicWorkflowRunActionRepetitionDefinitionData _data;

        /// <summary> Initializes a new instance of the <see cref="LogicWorkflowRunActionRepetitionDefinitionResource"/> class for mocking. </summary>
        protected LogicWorkflowRunActionRepetitionDefinitionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "LogicWorkflowRunActionRepetitionDefinitionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal LogicWorkflowRunActionRepetitionDefinitionResource(ArmClient client, LogicWorkflowRunActionRepetitionDefinitionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="LogicWorkflowRunActionRepetitionDefinitionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal LogicWorkflowRunActionRepetitionDefinitionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual LogicWorkflowRunActionRepetitionDefinitionData Data
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
        protected abstract Task<Response<LogicWorkflowRunActionRepetitionDefinitionResource>> GetCoreAsync(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public async Task<Response<LogicWorkflowRunActionRepetitionDefinitionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await GetCoreAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The core implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected abstract Response<LogicWorkflowRunActionRepetitionDefinitionResource> GetCore(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public Response<LogicWorkflowRunActionRepetitionDefinitionResource> Get(CancellationToken cancellationToken = default)
        {
            return GetCore(cancellationToken);
        }
    }
}
