// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ReportsOperations.
    /// </summary>
    public static partial class ReportsOperationsExtensions
    {
            /// <summary>
            /// Lists report records by API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            public static IPage<ReportRecordContract> ListByApi(this IReportsOperations operations, ODataQuery<ReportRecordContract> odataQuery, string resourceGroupName, string serviceName)
            {
                return operations.ListByApiAsync(odataQuery, resourceGroupName, serviceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists report records by API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ReportRecordContract>> ListByApiAsync(this IReportsOperations operations, ODataQuery<ReportRecordContract> odataQuery, string resourceGroupName, string serviceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByApiWithHttpMessagesAsync(odataQuery, resourceGroupName, serviceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists report records by User.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            public static IPage<ReportRecordContract> ListByUser(this IReportsOperations operations, ODataQuery<ReportRecordContract> odataQuery, string resourceGroupName, string serviceName)
            {
                return operations.ListByUserAsync(odataQuery, resourceGroupName, serviceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists report records by User.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ReportRecordContract>> ListByUserAsync(this IReportsOperations operations, ODataQuery<ReportRecordContract> odataQuery, string resourceGroupName, string serviceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByUserWithHttpMessagesAsync(odataQuery, resourceGroupName, serviceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists report records by API Operations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            public static IPage<ReportRecordContract> ListByOperation(this IReportsOperations operations, ODataQuery<ReportRecordContract> odataQuery, string resourceGroupName, string serviceName)
            {
                return operations.ListByOperationAsync(odataQuery, resourceGroupName, serviceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists report records by API Operations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ReportRecordContract>> ListByOperationAsync(this IReportsOperations operations, ODataQuery<ReportRecordContract> odataQuery, string resourceGroupName, string serviceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByOperationWithHttpMessagesAsync(odataQuery, resourceGroupName, serviceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists report records by Product.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            public static IPage<ReportRecordContract> ListByProduct(this IReportsOperations operations, ODataQuery<ReportRecordContract> odataQuery, string resourceGroupName, string serviceName)
            {
                return operations.ListByProductAsync(odataQuery, resourceGroupName, serviceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists report records by Product.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ReportRecordContract>> ListByProductAsync(this IReportsOperations operations, ODataQuery<ReportRecordContract> odataQuery, string resourceGroupName, string serviceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByProductWithHttpMessagesAsync(odataQuery, resourceGroupName, serviceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists report records by geography.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            public static IPage<ReportRecordContract> ListByGeo(this IReportsOperations operations, ODataQuery<ReportRecordContract> odataQuery, string resourceGroupName, string serviceName)
            {
                return operations.ListByGeoAsync(odataQuery, resourceGroupName, serviceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists report records by geography.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ReportRecordContract>> ListByGeoAsync(this IReportsOperations operations, ODataQuery<ReportRecordContract> odataQuery, string resourceGroupName, string serviceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByGeoWithHttpMessagesAsync(odataQuery, resourceGroupName, serviceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists report records by subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            public static IPage<ReportRecordContract> ListBySubscription(this IReportsOperations operations, ODataQuery<ReportRecordContract> odataQuery, string resourceGroupName, string serviceName)
            {
                return operations.ListBySubscriptionAsync(odataQuery, resourceGroupName, serviceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists report records by subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ReportRecordContract>> ListBySubscriptionAsync(this IReportsOperations operations, ODataQuery<ReportRecordContract> odataQuery, string resourceGroupName, string serviceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(odataQuery, resourceGroupName, serviceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists report records by Time.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='interval'>
            /// By time interval. Interval must be multiple of 15 minutes and may not be
            /// zero. The value should be in ISO  8601 format
            /// (http://en.wikipedia.org/wiki/ISO_8601#Durations).This code can be used to
            /// convert TimeSpan to a valid interval string: XmlConvert.ToString(new
            /// TimeSpan(hours, minutes, seconds)).
            /// </param>
            public static IPage<ReportRecordContract> ListByTime(this IReportsOperations operations, ODataQuery<ReportRecordContract> odataQuery, string resourceGroupName, string serviceName, System.TimeSpan interval)
            {
                return operations.ListByTimeAsync(odataQuery, resourceGroupName, serviceName, interval).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists report records by Time.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='interval'>
            /// By time interval. Interval must be multiple of 15 minutes and may not be
            /// zero. The value should be in ISO  8601 format
            /// (http://en.wikipedia.org/wiki/ISO_8601#Durations).This code can be used to
            /// convert TimeSpan to a valid interval string: XmlConvert.ToString(new
            /// TimeSpan(hours, minutes, seconds)).
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ReportRecordContract>> ListByTimeAsync(this IReportsOperations operations, ODataQuery<ReportRecordContract> odataQuery, string resourceGroupName, string serviceName, System.TimeSpan interval, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByTimeWithHttpMessagesAsync(odataQuery, resourceGroupName, serviceName, interval, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists report records by Request.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            public static IEnumerable<RequestReportRecordContract> ListByRequest(this IReportsOperations operations, ODataQuery<RequestReportRecordContract> odataQuery, string resourceGroupName, string serviceName)
            {
                return operations.ListByRequestAsync(odataQuery, resourceGroupName, serviceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists report records by Request.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<RequestReportRecordContract>> ListByRequestAsync(this IReportsOperations operations, ODataQuery<RequestReportRecordContract> odataQuery, string resourceGroupName, string serviceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByRequestWithHttpMessagesAsync(odataQuery, resourceGroupName, serviceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists report records by API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ReportRecordContract> ListByApiNext(this IReportsOperations operations, string nextPageLink)
            {
                return operations.ListByApiNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists report records by API.
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
            public static async Task<IPage<ReportRecordContract>> ListByApiNextAsync(this IReportsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByApiNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists report records by User.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ReportRecordContract> ListByUserNext(this IReportsOperations operations, string nextPageLink)
            {
                return operations.ListByUserNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists report records by User.
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
            public static async Task<IPage<ReportRecordContract>> ListByUserNextAsync(this IReportsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByUserNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists report records by API Operations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ReportRecordContract> ListByOperationNext(this IReportsOperations operations, string nextPageLink)
            {
                return operations.ListByOperationNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists report records by API Operations.
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
            public static async Task<IPage<ReportRecordContract>> ListByOperationNextAsync(this IReportsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByOperationNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists report records by Product.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ReportRecordContract> ListByProductNext(this IReportsOperations operations, string nextPageLink)
            {
                return operations.ListByProductNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists report records by Product.
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
            public static async Task<IPage<ReportRecordContract>> ListByProductNextAsync(this IReportsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByProductNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists report records by geography.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ReportRecordContract> ListByGeoNext(this IReportsOperations operations, string nextPageLink)
            {
                return operations.ListByGeoNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists report records by geography.
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
            public static async Task<IPage<ReportRecordContract>> ListByGeoNextAsync(this IReportsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByGeoNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists report records by subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ReportRecordContract> ListBySubscriptionNext(this IReportsOperations operations, string nextPageLink)
            {
                return operations.ListBySubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists report records by subscription.
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
            public static async Task<IPage<ReportRecordContract>> ListBySubscriptionNextAsync(this IReportsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists report records by Time.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ReportRecordContract> ListByTimeNext(this IReportsOperations operations, string nextPageLink)
            {
                return operations.ListByTimeNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists report records by Time.
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
            public static async Task<IPage<ReportRecordContract>> ListByTimeNextAsync(this IReportsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByTimeNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
