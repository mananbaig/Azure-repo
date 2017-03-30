// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Servicebus.Fluent
{
    using Topic.Definition;
    using ResourceManager.Fluent.Core.CollectionActions;
    using ResourceManager.Fluent.Core;
    using Management.Fluent.ServiceBus;

    /// <summary>
    /// Entry point to Service Bus topic management API in Azure.
    /// </summary>
    /// <remarks>
    /// (Beta: This functionality is in preview and as such is subject to change in non-backwards compatible ways in future releases, including removal, regardless of any compatibility expectations set by the containing library version number.)
    /// </remarks>
    public interface ITopics  :
        ISupportsCreating<Topic.Definition.IBlank>,
        ISupportsGettingByName<Microsoft.Azure.Management.Servicebus.Fluent.ITopic>,
        ISupportsListing<ITopic>,
        ISupportsDeletingByName,
        IHasManager<ServiceBus.Fluent.IServiceBusManager>,
        IHasInner<ITopicsOperations>
    {
    }
}