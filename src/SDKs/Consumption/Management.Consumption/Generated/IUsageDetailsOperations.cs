// MICROSOFT_MIT┬á

namespace Microsoft.Azure.Management.Consumption
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// UsageDetailsOperations operations.
    /// </summary>
    public partial interface IUsageDetailsOperations
    {
        /// <summary>
        /// Lists the usage details for a scope in reverse chronological order
        /// by billing period. Usage details are available via this API only
        /// for January 1, 2017 or later.
        /// <see href="https://go.microsoft.com/fwlink/?linkid=845275" />
        /// </summary>
        /// <param name='scope'>
        /// The scope of the usage details. The scope can be
        /// '/subscriptions/{subscriptionId}/' for a subscription, or
        /// '/subscriptions/{subscriptionId}/providers/Microsoft.Billing/invoices/{invoiceName}'
        /// for an invoice or
        /// '/subscriptions/{subscriptionId}/providers/Microsoft.Billing/billingPeriods/{billingPeriodName}'
        /// for a billing perdiod.
        /// </param>
        /// <param name='expand'>
        /// May be used to expand the additionalProperties or meterDetails
        /// property within a list of usage details. By default, these fields
        /// are not included when listing usage details.
        /// </param>
        /// <param name='filter'>
        /// May be used to filter usageDetails by usageEnd (Utc time). The
        /// filter supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does
        /// not currently support 'ne', 'or', or 'not'.
        /// </param>
        /// <param name='skiptoken'>
        /// Skiptoken is only used if a previous operation returned a partial
        /// result. If a previous response contains a nextLink element, the
        /// value of the nextLink element will include a skiptoken parameter
        /// that specifies a starting point to use for subsequent calls.
        /// </param>
        /// <param name='top'>
        /// May be used to limit the number of results to the most recent N
        /// usageDetails.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<UsageDetail>>> ListWithHttpMessagesAsync(string scope, string expand = default(string), string filter = default(string), string skiptoken = default(string), int? top = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the usage details for a scope in reverse chronological order
        /// by billing period. Usage details are available via this API only
        /// for January 1, 2017 or later.
        /// <see href="https://go.microsoft.com/fwlink/?linkid=845275" />
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<UsageDetail>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
