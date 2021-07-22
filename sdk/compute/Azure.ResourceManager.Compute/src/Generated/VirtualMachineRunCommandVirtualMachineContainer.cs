// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of VirtualMachineRunCommandVirtualMachine and their operations over a VirtualMachine. </summary>
    public partial class VirtualMachineRunCommandVirtualMachineContainer : ResourceContainerBase<ResourceGroupResourceIdentifier, VirtualMachineRunCommandVirtualMachine, VirtualMachineRunCommandData>
    {
        /// <summary> Initializes a new instance of the <see cref="VirtualMachineRunCommandVirtualMachineContainer"/> class for mocking. </summary>
        protected VirtualMachineRunCommandVirtualMachineContainer()
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineRunCommandVirtualMachineContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VirtualMachineRunCommandVirtualMachineContainer(OperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private VirtualMachineRunCommandsRestOperations _restClient => new VirtualMachineRunCommandsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => VirtualMachineOperations.ResourceType;

        // Container level operations.

        /// <summary> The operation to create or update the run command. </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="runCommand"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> or <paramref name="runCommand"/> is null. </exception>
        public virtual Response<VirtualMachineRunCommandVirtualMachine> CreateOrUpdate(string runCommandName, VirtualMachineRunCommandData runCommand, CancellationToken cancellationToken = default)
        {
            if (runCommandName == null)
            {
                throw new ArgumentNullException(nameof(runCommandName));
            }
            if (runCommand == null)
            {
                throw new ArgumentNullException(nameof(runCommand));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineRunCommandVirtualMachineContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(runCommandName, runCommand, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update the run command. </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="runCommand"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> or <paramref name="runCommand"/> is null. </exception>
        public async virtual Task<Response<VirtualMachineRunCommandVirtualMachine>> CreateOrUpdateAsync(string runCommandName, VirtualMachineRunCommandData runCommand, CancellationToken cancellationToken = default)
        {
            if (runCommandName == null)
            {
                throw new ArgumentNullException(nameof(runCommandName));
            }
            if (runCommand == null)
            {
                throw new ArgumentNullException(nameof(runCommand));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineRunCommandVirtualMachineContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(runCommandName, runCommand, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update the run command. </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="runCommand"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> or <paramref name="runCommand"/> is null. </exception>
        public virtual VirtualMachineRunCommandsCreateOrUpdateOperation StartCreateOrUpdate(string runCommandName, VirtualMachineRunCommandData runCommand, CancellationToken cancellationToken = default)
        {
            if (runCommandName == null)
            {
                throw new ArgumentNullException(nameof(runCommandName));
            }
            if (runCommand == null)
            {
                throw new ArgumentNullException(nameof(runCommand));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineRunCommandVirtualMachineContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, runCommandName, runCommand, cancellationToken);
                return new VirtualMachineRunCommandsCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, runCommandName, runCommand).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update the run command. </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="runCommand"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> or <paramref name="runCommand"/> is null. </exception>
        public async virtual Task<VirtualMachineRunCommandsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string runCommandName, VirtualMachineRunCommandData runCommand, CancellationToken cancellationToken = default)
        {
            if (runCommandName == null)
            {
                throw new ArgumentNullException(nameof(runCommandName));
            }
            if (runCommand == null)
            {
                throw new ArgumentNullException(nameof(runCommand));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineRunCommandVirtualMachineContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, runCommandName, runCommand, cancellationToken).ConfigureAwait(false);
                return new VirtualMachineRunCommandsCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, runCommandName, runCommand).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<VirtualMachineRunCommandVirtualMachine> Get(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineRunCommandVirtualMachineContainer.Get");
            scope.Start();
            try
            {
                if (runCommandName == null)
                {
                    throw new ArgumentNullException(nameof(runCommandName));
                }

                var response = _restClient.GetByVirtualMachine(Id.ResourceGroupName, Id.Name, runCommandName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(new VirtualMachineRunCommandVirtualMachine(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<VirtualMachineRunCommandVirtualMachine>> GetAsync(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineRunCommandVirtualMachineContainer.Get");
            scope.Start();
            try
            {
                if (runCommandName == null)
                {
                    throw new ArgumentNullException(nameof(runCommandName));
                }

                var response = await _restClient.GetByVirtualMachineAsync(Id.ResourceGroupName, Id.Name, runCommandName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new VirtualMachineRunCommandVirtualMachine(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual VirtualMachineRunCommandVirtualMachine TryGet(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineRunCommandVirtualMachineContainer.TryGet");
            scope.Start();
            try
            {
                if (runCommandName == null)
                {
                    throw new ArgumentNullException(nameof(runCommandName));
                }

                return Get(runCommandName, expand, cancellationToken: cancellationToken).Value;
            }
            catch (RequestFailedException e) when (e.Status == 404)
            {
                return null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<VirtualMachineRunCommandVirtualMachine> TryGetAsync(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineRunCommandVirtualMachineContainer.TryGet");
            scope.Start();
            try
            {
                if (runCommandName == null)
                {
                    throw new ArgumentNullException(nameof(runCommandName));
                }

                return await GetAsync(runCommandName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            catch (RequestFailedException e) when (e.Status == 404)
            {
                return null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual bool DoesExist(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineRunCommandVirtualMachineContainer.DoesExist");
            scope.Start();
            try
            {
                if (runCommandName == null)
                {
                    throw new ArgumentNullException(nameof(runCommandName));
                }

                return TryGet(runCommandName, expand, cancellationToken: cancellationToken) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<bool> DoesExistAsync(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineRunCommandVirtualMachineContainer.DoesExist");
            scope.Start();
            try
            {
                if (runCommandName == null)
                {
                    throw new ArgumentNullException(nameof(runCommandName));
                }

                return await TryGetAsync(runCommandName, expand, cancellationToken: cancellationToken).ConfigureAwait(false) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to get all run commands of a Virtual Machine. </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualMachineRunCommandVirtualMachine" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<VirtualMachineRunCommandVirtualMachine> List(string expand = null, CancellationToken cancellationToken = default)
        {
            Page<VirtualMachineRunCommandVirtualMachine> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualMachineRunCommandVirtualMachineContainer.ListByVirtualMachine");
                scope.Start();
                try
                {
                    var response = _restClient.ListByVirtualMachine(Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineRunCommandVirtualMachine(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualMachineRunCommandVirtualMachine> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualMachineRunCommandVirtualMachineContainer.ListByVirtualMachine");
                scope.Start();
                try
                {
                    var response = _restClient.ListByVirtualMachineNextPage(nextLink, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineRunCommandVirtualMachine(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> The operation to get all run commands of a Virtual Machine. </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualMachineRunCommandVirtualMachine" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<VirtualMachineRunCommandVirtualMachine> ListAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualMachineRunCommandVirtualMachine>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualMachineRunCommandVirtualMachineContainer.ListByVirtualMachine");
                scope.Start();
                try
                {
                    var response = await _restClient.ListByVirtualMachineAsync(Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineRunCommandVirtualMachine(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualMachineRunCommandVirtualMachine>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualMachineRunCommandVirtualMachineContainer.ListByVirtualMachine");
                scope.Start();
                try
                {
                    var response = await _restClient.ListByVirtualMachineNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineRunCommandVirtualMachine(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="VirtualMachineRunCommandVirtualMachine" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> ListAsGenericResource(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineRunCommandVirtualMachineContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualMachineRunCommandVirtualMachineOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="VirtualMachineRunCommandVirtualMachine" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> ListAsGenericResourceAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineRunCommandVirtualMachineContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualMachineRunCommandVirtualMachineOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceGroupResourceIdentifier, VirtualMachineRunCommandVirtualMachine, VirtualMachineRunCommandData> Construct() { }
    }
}
