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
using Azure.ResourceManager.EdgeOrder.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.EdgeOrder
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.EdgeOrder. </summary>
    public static partial class EdgeOrderExtensions
    {
        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// Lists all the addresses available under the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/addresses
        /// Operation Id: ListAddressesAtSubscriptionLevel
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="filter"> $filter is supported to filter based on shipping address properties. Filter supports only equals operation. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of addresses, which provides the next page in the list of addresses. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AddressResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<AddressResource> GetAddressResourcesAsync(this SubscriptionResource subscriptionResource, string filter = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetAddressResourcesAsync(filter, skipToken, cancellationToken);
        }

        /// <summary>
        /// Lists all the addresses available under the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/addresses
        /// Operation Id: ListAddressesAtSubscriptionLevel
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="filter"> $filter is supported to filter based on shipping address properties. Filter supports only equals operation. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of addresses, which provides the next page in the list of addresses. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AddressResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<AddressResource> GetAddressResources(this SubscriptionResource subscriptionResource, string filter = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetAddressResources(filter, skipToken, cancellationToken);
        }

        /// <summary>
        /// This method provides the list of product families for the given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/listProductFamilies
        /// Operation Id: ListProductFamilies
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Filters for showing the product families. </param>
        /// <param name="expand"> $expand is supported on configurations parameter for product, which provides details on the configurations for the product. </param>
        /// <param name="skipToken"> $skipToken is supported on list of product families, which provides the next page in the list of product families. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <returns> An async collection of <see cref="ProductFamily" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ProductFamily> GetProductFamiliesAsync(this SubscriptionResource subscriptionResource, ProductFamiliesContent content, string expand = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(subscriptionResource).GetProductFamiliesAsync(content, expand, skipToken, cancellationToken);
        }

        /// <summary>
        /// This method provides the list of product families for the given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/listProductFamilies
        /// Operation Id: ListProductFamilies
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Filters for showing the product families. </param>
        /// <param name="expand"> $expand is supported on configurations parameter for product, which provides details on the configurations for the product. </param>
        /// <param name="skipToken"> $skipToken is supported on list of product families, which provides the next page in the list of product families. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <returns> A collection of <see cref="ProductFamily" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ProductFamily> GetProductFamilies(this SubscriptionResource subscriptionResource, ProductFamiliesContent content, string expand = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(subscriptionResource).GetProductFamilies(content, expand, skipToken, cancellationToken);
        }

        /// <summary>
        /// This method provides the list of configurations for the given product family, product line and product under subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/listConfigurations
        /// Operation Id: ListConfigurations
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Filters for showing the configurations. </param>
        /// <param name="skipToken"> $skipToken is supported on list of configurations, which provides the next page in the list of configurations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <returns> An async collection of <see cref="ProductConfiguration" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ProductConfiguration> GetConfigurationsAsync(this SubscriptionResource subscriptionResource, ConfigurationsContent content, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(subscriptionResource).GetConfigurationsAsync(content, skipToken, cancellationToken);
        }

        /// <summary>
        /// This method provides the list of configurations for the given product family, product line and product under subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/listConfigurations
        /// Operation Id: ListConfigurations
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Filters for showing the configurations. </param>
        /// <param name="skipToken"> $skipToken is supported on list of configurations, which provides the next page in the list of configurations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <returns> A collection of <see cref="ProductConfiguration" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ProductConfiguration> GetConfigurations(this SubscriptionResource subscriptionResource, ConfigurationsContent content, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(subscriptionResource).GetConfigurations(content, skipToken, cancellationToken);
        }

        /// <summary>
        /// This method provides the list of product families metadata for the given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/productFamiliesMetadata
        /// Operation Id: ListProductFamiliesMetadata
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skipToken"> $skipToken is supported on list of product families metadata, which provides the next page in the list of product families metadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ProductFamiliesMetadataDetails" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ProductFamiliesMetadataDetails> GetProductFamiliesMetadataAsync(this SubscriptionResource subscriptionResource, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetProductFamiliesMetadataAsync(skipToken, cancellationToken);
        }

        /// <summary>
        /// This method provides the list of product families metadata for the given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/productFamiliesMetadata
        /// Operation Id: ListProductFamiliesMetadata
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skipToken"> $skipToken is supported on list of product families metadata, which provides the next page in the list of product families metadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ProductFamiliesMetadataDetails" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ProductFamiliesMetadataDetails> GetProductFamiliesMetadata(this SubscriptionResource subscriptionResource, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetProductFamiliesMetadata(skipToken, cancellationToken);
        }

        /// <summary>
        /// Lists order at subscription level.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/orders
        /// Operation Id: ListOrderAtSubscriptionLevel
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of order, which provides the next page in the list of order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OrderResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<OrderResource> GetOrderResourcesAsync(this SubscriptionResource subscriptionResource, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetOrderResourcesAsync(skipToken, cancellationToken);
        }

        /// <summary>
        /// Lists order at subscription level.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/orders
        /// Operation Id: ListOrderAtSubscriptionLevel
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of order, which provides the next page in the list of order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OrderResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<OrderResource> GetOrderResources(this SubscriptionResource subscriptionResource, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetOrderResources(skipToken, cancellationToken);
        }

        /// <summary>
        /// Lists order item at subscription level.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/orderItems
        /// Operation Id: ListOrderItemsAtSubscriptionLevel
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="options"> A class representing the optional parameters in GetOrderItemResources method. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OrderItemResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<OrderItemResource> GetOrderItemResourcesAsync(this SubscriptionResource subscriptionResource, EdgeOrderGetOrderItemResourcesOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new EdgeOrderGetOrderItemResourcesOptions();

            return GetExtensionClient(subscriptionResource).GetOrderItemResourcesAsync(options, cancellationToken);
        }

        /// <summary>
        /// Lists order item at subscription level.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/orderItems
        /// Operation Id: ListOrderItemsAtSubscriptionLevel
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="options"> A class representing the optional parameters in GetOrderItemResources method. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OrderItemResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<OrderItemResource> GetOrderItemResources(this SubscriptionResource subscriptionResource, EdgeOrderGetOrderItemResourcesOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new EdgeOrderGetOrderItemResourcesOptions();

            return GetExtensionClient(subscriptionResource).GetOrderItemResources(options, cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of AddressResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of AddressResources and their operations over a AddressResource. </returns>
        public static AddressResourceCollection GetAddressResources(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetAddressResources();
        }

        /// <summary>
        /// Gets information about the specified address.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/addresses/{addressName}
        /// Operation Id: GetAddressByName
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="addressName"> The name of the address Resource within the specified resource group. address names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="addressName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="addressName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<AddressResource>> GetAddressResourceAsync(this ResourceGroupResource resourceGroupResource, string addressName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetAddressResources().GetAsync(addressName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about the specified address.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/addresses/{addressName}
        /// Operation Id: GetAddressByName
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="addressName"> The name of the address Resource within the specified resource group. address names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="addressName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="addressName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<AddressResource> GetAddressResource(this ResourceGroupResource resourceGroupResource, string addressName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetAddressResources().Get(addressName, cancellationToken);
        }

        /// <summary> Gets a collection of OrderResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of OrderResources and their operations over a OrderResource. </returns>
        public static OrderResourceCollection GetOrderResources(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetOrderResources();
        }

        /// <summary>
        /// Gets an order.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/locations/{location}/orders/{orderName}
        /// Operation Id: GetOrderByName
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="orderName"> The name of the order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="orderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="orderName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<OrderResource>> GetOrderResourceAsync(this ResourceGroupResource resourceGroupResource, string location, string orderName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetOrderResources().GetAsync(location, orderName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an order.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/locations/{location}/orders/{orderName}
        /// Operation Id: GetOrderByName
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="orderName"> The name of the order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="orderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="orderName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<OrderResource> GetOrderResource(this ResourceGroupResource resourceGroupResource, string location, string orderName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetOrderResources().Get(location, orderName, cancellationToken);
        }

        /// <summary> Gets a collection of OrderItemResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of OrderItemResources and their operations over a OrderItemResource. </returns>
        public static OrderItemResourceCollection GetOrderItemResources(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetOrderItemResources();
        }

        /// <summary>
        /// Gets an order item.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/orderItems/{orderItemName}
        /// Operation Id: GetOrderItemByName
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="orderItemName"> The name of the order item. </param>
        /// <param name="expand"> $expand is supported on device details, forward shipping details and reverse shipping details parameters. Each of these can be provided as a comma separated list. Device Details for order item provides details on the devices of the product, Forward and Reverse Shipping details provide forward and reverse shipping details respectively. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="orderItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="orderItemName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<OrderItemResource>> GetOrderItemResourceAsync(this ResourceGroupResource resourceGroupResource, string orderItemName, string expand = null, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetOrderItemResources().GetAsync(orderItemName, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an order item.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/orderItems/{orderItemName}
        /// Operation Id: GetOrderItemByName
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="orderItemName"> The name of the order item. </param>
        /// <param name="expand"> $expand is supported on device details, forward shipping details and reverse shipping details parameters. Each of these can be provided as a comma separated list. Device Details for order item provides details on the devices of the product, Forward and Reverse Shipping details provide forward and reverse shipping details respectively. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="orderItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="orderItemName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<OrderItemResource> GetOrderItemResource(this ResourceGroupResource resourceGroupResource, string orderItemName, string expand = null, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetOrderItemResources().Get(orderItemName, expand, cancellationToken);
        }

        /// <summary>
        /// Lists order at resource group level.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/orders
        /// Operation Id: ListOrderAtResourceGroupLevel
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of order, which provides the next page in the list of order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OrderResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<OrderResource> GetOrderResourcesAsync(this ResourceGroupResource resourceGroupResource, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(resourceGroupResource).GetOrderResourcesAsync(skipToken, cancellationToken);
        }

        /// <summary>
        /// Lists order at resource group level.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/orders
        /// Operation Id: ListOrderAtResourceGroupLevel
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of order, which provides the next page in the list of order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OrderResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<OrderResource> GetOrderResources(this ResourceGroupResource resourceGroupResource, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(resourceGroupResource).GetOrderResources(skipToken, cancellationToken);
        }

        #region AddressResource
        /// <summary>
        /// Gets an object representing an <see cref="AddressResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AddressResource.CreateResourceIdentifier" /> to create an <see cref="AddressResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AddressResource" /> object. </returns>
        public static AddressResource GetAddressResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                AddressResource.ValidateResourceId(id);
                return new AddressResource(client, id);
            }
            );
        }
        #endregion

        #region OrderResource
        /// <summary>
        /// Gets an object representing an <see cref="OrderResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OrderResource.CreateResourceIdentifier" /> to create an <see cref="OrderResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OrderResource" /> object. </returns>
        public static OrderResource GetOrderResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                OrderResource.ValidateResourceId(id);
                return new OrderResource(client, id);
            }
            );
        }
        #endregion

        #region OrderItemResource
        /// <summary>
        /// Gets an object representing an <see cref="OrderItemResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OrderItemResource.CreateResourceIdentifier" /> to create an <see cref="OrderItemResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OrderItemResource" /> object. </returns>
        public static OrderItemResource GetOrderItemResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                OrderItemResource.ValidateResourceId(id);
                return new OrderItemResource(client, id);
            }
            );
        }
        #endregion
    }
}
