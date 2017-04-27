// MICROSOFT_MIT┬á

namespace Microsoft.Azure.Management.Consumption
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for UsageDetailsOperations.
    /// </summary>
    public static partial class UsageDetailsOperationsExtensions
    {
            /// <summary>
            /// Lists the usage details for a scope in reverse chronological order by
            /// billing period. Usage details are available via this API only for January
            /// 1, 2017 or later.
            /// <see href="https://go.microsoft.com/fwlink/?linkid=845275" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the usage details. The scope can be
            /// '/subscriptions/{subscriptionId}/' for a subscription, or
            /// '/subscriptions/{subscriptionId}/providers/Microsoft.Billing/invoices/{invoiceName}'
            /// for an invoice or
            /// '/subscriptions/{subscriptionId}/providers/Microsoft.Billing/billingPeriods/{billingPeriodName}'
            /// for a billing perdiod.
            /// </param>
            /// <param name='expand'>
            /// May be used to expand the additionalProperties or meterDetails property
            /// within a list of usage details. By default, these fields are not included
            /// when listing usage details.
            /// </param>
            /// <param name='filter'>
            /// May be used to filter usageDetails by usageEnd (Utc time). The filter
            /// supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently
            /// support 'ne', 'or', or 'not'.
            /// </param>
            /// <param name='skiptoken'>
            /// Skiptoken is only used if a previous operation returned a partial result.
            /// If a previous response contains a nextLink element, the value of the
            /// nextLink element will include a skiptoken parameter that specifies a
            /// starting point to use for subsequent calls.
            /// </param>
            /// <param name='top'>
            /// May be used to limit the number of results to the most recent N
            /// usageDetails.
            /// </param>
            public static IPage<UsageDetail> List(this IUsageDetailsOperations operations, string scope, string expand = default(string), string filter = default(string), string skiptoken = default(string), int? top = default(int?))
            {
                return operations.ListAsync(scope, expand, filter, skiptoken, top).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the usage details for a scope in reverse chronological order by
            /// billing period. Usage details are available via this API only for January
            /// 1, 2017 or later.
            /// <see href="https://go.microsoft.com/fwlink/?linkid=845275" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the usage details. The scope can be
            /// '/subscriptions/{subscriptionId}/' for a subscription, or
            /// '/subscriptions/{subscriptionId}/providers/Microsoft.Billing/invoices/{invoiceName}'
            /// for an invoice or
            /// '/subscriptions/{subscriptionId}/providers/Microsoft.Billing/billingPeriods/{billingPeriodName}'
            /// for a billing perdiod.
            /// </param>
            /// <param name='expand'>
            /// May be used to expand the additionalProperties or meterDetails property
            /// within a list of usage details. By default, these fields are not included
            /// when listing usage details.
            /// </param>
            /// <param name='filter'>
            /// May be used to filter usageDetails by usageEnd (Utc time). The filter
            /// supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently
            /// support 'ne', 'or', or 'not'.
            /// </param>
            /// <param name='skiptoken'>
            /// Skiptoken is only used if a previous operation returned a partial result.
            /// If a previous response contains a nextLink element, the value of the
            /// nextLink element will include a skiptoken parameter that specifies a
            /// starting point to use for subsequent calls.
            /// </param>
            /// <param name='top'>
            /// May be used to limit the number of results to the most recent N
            /// usageDetails.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<UsageDetail>> ListAsync(this IUsageDetailsOperations operations, string scope, string expand = default(string), string filter = default(string), string skiptoken = default(string), int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(scope, expand, filter, skiptoken, top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the usage details for a scope in reverse chronological order by
            /// billing period. Usage details are available via this API only for January
            /// 1, 2017 or later.
            /// <see href="https://go.microsoft.com/fwlink/?linkid=845275" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<UsageDetail> ListNext(this IUsageDetailsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the usage details for a scope in reverse chronological order by
            /// billing period. Usage details are available via this API only for January
            /// 1, 2017 or later.
            /// <see href="https://go.microsoft.com/fwlink/?linkid=845275" />
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
            public static async Task<IPage<UsageDetail>> ListNextAsync(this IUsageDetailsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
