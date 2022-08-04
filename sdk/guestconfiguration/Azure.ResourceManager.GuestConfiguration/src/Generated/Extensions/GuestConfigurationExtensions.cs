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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.GuestConfiguration
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.GuestConfiguration. </summary>
    public static partial class GuestConfigurationExtensions
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
        /// List all guest configuration assignments for a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments
        /// Operation Id: GuestConfigurationAssignments_SubscriptionList
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GuestConfigurationAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<GuestConfigurationAssignmentResource> GetGuestConfigurationAssignmentsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetGuestConfigurationAssignmentsAsync(cancellationToken);
        }

        /// <summary>
        /// List all guest configuration assignments for a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments
        /// Operation Id: GuestConfigurationAssignments_SubscriptionList
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GuestConfigurationAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<GuestConfigurationAssignmentResource> GetGuestConfigurationAssignments(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetGuestConfigurationAssignments(cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of GuestConfigurationAssignmentResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmName"/> is null. </exception>
        /// <returns> An object representing collection of GuestConfigurationAssignmentResources and their operations over a GuestConfigurationAssignmentResource. </returns>
        public static GuestConfigurationAssignmentCollection GetGuestConfigurationAssignments(this ResourceGroupResource resourceGroupResource, string vmName)
        {
            Argument.AssertNotNullOrEmpty(vmName, nameof(vmName));

            return GetExtensionClient(resourceGroupResource).GetGuestConfigurationAssignments(vmName);
        }

        /// <summary>
        /// Get information about a guest configuration assignment
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{guestConfigurationAssignmentName}
        /// Operation Id: GuestConfigurationAssignments_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="guestConfigurationAssignmentName"> The guest configuration assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmName"/> or <paramref name="guestConfigurationAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmName"/> or <paramref name="guestConfigurationAssignmentName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<GuestConfigurationAssignmentResource>> GetGuestConfigurationAssignmentAsync(this ResourceGroupResource resourceGroupResource, string vmName, string guestConfigurationAssignmentName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetGuestConfigurationAssignments(vmName).GetAsync(guestConfigurationAssignmentName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get information about a guest configuration assignment
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{guestConfigurationAssignmentName}
        /// Operation Id: GuestConfigurationAssignments_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="guestConfigurationAssignmentName"> The guest configuration assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmName"/> or <paramref name="guestConfigurationAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmName"/> or <paramref name="guestConfigurationAssignmentName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<GuestConfigurationAssignmentResource> GetGuestConfigurationAssignment(this ResourceGroupResource resourceGroupResource, string vmName, string guestConfigurationAssignmentName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetGuestConfigurationAssignments(vmName).Get(guestConfigurationAssignmentName, cancellationToken);
        }

        /// <summary>
        /// List all guest configuration assignments for a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments
        /// Operation Id: GuestConfigurationAssignments_RGList
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GuestConfigurationAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<GuestConfigurationAssignmentResource> GetGuestConfigurationAssignmentsAsync(this ResourceGroupResource resourceGroupResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(resourceGroupResource).GetGuestConfigurationAssignmentsAsync(cancellationToken);
        }

        /// <summary>
        /// List all guest configuration assignments for a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments
        /// Operation Id: GuestConfigurationAssignments_RGList
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GuestConfigurationAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<GuestConfigurationAssignmentResource> GetGuestConfigurationAssignments(this ResourceGroupResource resourceGroupResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(resourceGroupResource).GetGuestConfigurationAssignments(cancellationToken);
        }

        #region GuestConfigurationAssignmentResource
        /// <summary>
        /// Gets an object representing a <see cref="GuestConfigurationAssignmentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="GuestConfigurationAssignmentResource.CreateResourceIdentifier" /> to create a <see cref="GuestConfigurationAssignmentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GuestConfigurationAssignmentResource" /> object. </returns>
        public static GuestConfigurationAssignmentResource GetGuestConfigurationAssignmentResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                GuestConfigurationAssignmentResource.ValidateResourceId(id);
                return new GuestConfigurationAssignmentResource(client, id);
            }
            );
        }
        #endregion
    }
}
