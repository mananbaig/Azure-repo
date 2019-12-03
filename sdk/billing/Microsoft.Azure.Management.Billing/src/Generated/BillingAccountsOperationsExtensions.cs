// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BillingAccountsOperations.
    /// </summary>
    public static partial class BillingAccountsOperationsExtensions
    {
            /// <summary>
            /// Lists all billing accounts for a user which he has access to.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// May be used to expand the address, invoiceSections and billingProfiles.
            /// </param>
            public static BillingAccountListResult List(this IBillingAccountsOperations operations, string expand = default(string))
            {
                return operations.ListAsync(expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all billing accounts for a user which he has access to.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// May be used to expand the address, invoiceSections and billingProfiles.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingAccountListResult> ListAsync(this IBillingAccountsOperations operations, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the billing account by id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='expand'>
            /// May be used to expand the address, invoiceSections and billingProfiles.
            /// </param>
            public static BillingAccount Get(this IBillingAccountsOperations operations, string billingAccountName, string expand = default(string))
            {
                return operations.GetAsync(billingAccountName, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the billing account by id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='expand'>
            /// May be used to expand the address, invoiceSections and billingProfiles.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingAccount> GetAsync(this IBillingAccountsOperations operations, string billingAccountName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(billingAccountName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }
        
            /// <summary>
            /// Lists all invoice sections with create subscription permission for a user.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            public static IPage<InvoiceSectionWithCreateSubPermission> ListInvoiceSectionsByCreateSubscriptionPermission(this IBillingAccountsOperations operations, string billingAccountName)
            {
                return operations.ListInvoiceSectionsByCreateSubscriptionPermissionAsync(billingAccountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all invoice sections with create subscription permission for a user.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<InvoiceSectionWithCreateSubPermission>> ListInvoiceSectionsByCreateSubscriptionPermissionAsync(this IBillingAccountsOperations operations, string billingAccountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListInvoiceSectionsByCreateSubscriptionPermissionWithHttpMessagesAsync(billingAccountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all invoice sections with create subscription permission for a user.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<InvoiceSectionWithCreateSubPermission> ListInvoiceSectionsByCreateSubscriptionPermissionNext(this IBillingAccountsOperations operations, string nextPageLink)
            {
                return operations.ListInvoiceSectionsByCreateSubscriptionPermissionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all invoice sections with create subscription permission for a user.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<InvoiceSectionWithCreateSubPermission>> ListInvoiceSectionsByCreateSubscriptionPermissionNextAsync(this IBillingAccountsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListInvoiceSectionsByCreateSubscriptionPermissionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
