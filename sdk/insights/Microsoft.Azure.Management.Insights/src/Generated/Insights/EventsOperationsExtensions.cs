// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Insights
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for EventsOperations.
    /// </summary>
    public static partial class EventsOperationsExtensions
    {
            /// <summary>
            /// Provides the list of events. The **$filter** is very restricted and allows
            /// only the following patterns. - List events for a resource group:
            /// $filter=eventTimestamp ge '&lt;Start Time&gt;' and eventTimestamp le
            /// '&lt;End Time&gt;' and eventChannels eq 'Admin, Operation' and
            /// resourceGroupName eq '&lt;ResourceGroupName&gt;'. - List events for
            /// resource: $filter=eventTimestamp ge '&lt;Start Time&gt;' and eventTimestamp
            /// le '&lt;End Time&gt;' and eventChannels eq 'Admin, Operation' and
            /// resourceUri eq '&lt;ResourceURI&gt;'. - List events for a subscription:
            /// $filter=eventTimestamp ge '&lt;Start Time&gt;' and eventTimestamp le
            /// '&lt;End Time&gt;' and eventChannels eq 'Admin, Operation'. -List events
            /// for a resource provider: $filter=eventTimestamp ge '&lt;Start Time&gt;' and
            /// eventTimestamp le '&lt;End Time&gt;' and eventChannels eq 'Admin,
            /// Operation' and resourceProvider eq '&lt;ResourceProviderName&gt;'. - List
            /// events for a correlation Id:
            /// api-version=2014-04-01&amp;$filter=eventTimestamp ge
            /// '2014-07-16T04:36:37.6407898Z' and eventTimestamp le
            /// '2014-07-20T04:36:37.6407898Z' and eventChannels eq 'Admin, Operation' and
            /// correlationId eq '&lt;CorrelationID&gt;'. No other syntax is allowed.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='select'>
            /// Used to fetch events with only the given properties. The filter is a comma
            /// separated list of property names to be returned. Possible values are:
            /// authorization, channels, claims, correlationId, description, eventDataId,
            /// eventName, eventTimestamp, httpRequest, level, operationId, operationName,
            /// properties, resourceGroupName, resourceProviderName, resourceId, status,
            /// submissionTimestamp, subStatus, subscriptionId
            /// </param>
            public static Microsoft.Rest.Azure.IPage<EventData> List(this IEventsOperations operations, Microsoft.Rest.Azure.OData.ODataQuery<EventData> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<EventData>), string select = default(string))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IEventsOperations)s).ListAsync(odataQuery, select), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Provides the list of events. The **$filter** is very restricted and allows
            /// only the following patterns. - List events for a resource group:
            /// $filter=eventTimestamp ge '&lt;Start Time&gt;' and eventTimestamp le
            /// '&lt;End Time&gt;' and eventChannels eq 'Admin, Operation' and
            /// resourceGroupName eq '&lt;ResourceGroupName&gt;'. - List events for
            /// resource: $filter=eventTimestamp ge '&lt;Start Time&gt;' and eventTimestamp
            /// le '&lt;End Time&gt;' and eventChannels eq 'Admin, Operation' and
            /// resourceUri eq '&lt;ResourceURI&gt;'. - List events for a subscription:
            /// $filter=eventTimestamp ge '&lt;Start Time&gt;' and eventTimestamp le
            /// '&lt;End Time&gt;' and eventChannels eq 'Admin, Operation'. -List events
            /// for a resource provider: $filter=eventTimestamp ge '&lt;Start Time&gt;' and
            /// eventTimestamp le '&lt;End Time&gt;' and eventChannels eq 'Admin,
            /// Operation' and resourceProvider eq '&lt;ResourceProviderName&gt;'. - List
            /// events for a correlation Id:
            /// api-version=2014-04-01&amp;$filter=eventTimestamp ge
            /// '2014-07-16T04:36:37.6407898Z' and eventTimestamp le
            /// '2014-07-20T04:36:37.6407898Z' and eventChannels eq 'Admin, Operation' and
            /// correlationId eq '&lt;CorrelationID&gt;'. No other syntax is allowed.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='select'>
            /// Used to fetch events with only the given properties. The filter is a comma
            /// separated list of property names to be returned. Possible values are:
            /// authorization, channels, claims, correlationId, description, eventDataId,
            /// eventName, eventTimestamp, httpRequest, level, operationId, operationName,
            /// properties, resourceGroupName, resourceProviderName, resourceId, status,
            /// submissionTimestamp, subStatus, subscriptionId
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<EventData>> ListAsync(this IEventsOperations operations, Microsoft.Rest.Azure.OData.ODataQuery<EventData> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<EventData>), string select = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(odataQuery, select, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Provides the list of events. The **$filter** is very restricted and allows
            /// only the following patterns. - List events for a resource group:
            /// $filter=eventTimestamp ge '&lt;Start Time&gt;' and eventTimestamp le
            /// '&lt;End Time&gt;' and eventChannels eq 'Admin, Operation' and
            /// resourceGroupName eq '&lt;ResourceGroupName&gt;'. - List events for
            /// resource: $filter=eventTimestamp ge '&lt;Start Time&gt;' and eventTimestamp
            /// le '&lt;End Time&gt;' and eventChannels eq 'Admin, Operation' and
            /// resourceUri eq '&lt;ResourceURI&gt;'. - List events for a subscription:
            /// $filter=eventTimestamp ge '&lt;Start Time&gt;' and eventTimestamp le
            /// '&lt;End Time&gt;' and eventChannels eq 'Admin, Operation'. -List events
            /// for a resource provider: $filter=eventTimestamp ge '&lt;Start Time&gt;' and
            /// eventTimestamp le '&lt;End Time&gt;' and eventChannels eq 'Admin,
            /// Operation' and resourceProvider eq '&lt;ResourceProviderName&gt;'. - List
            /// events for a correlation Id:
            /// api-version=2014-04-01&amp;$filter=eventTimestamp ge
            /// '2014-07-16T04:36:37.6407898Z' and eventTimestamp le
            /// '2014-07-20T04:36:37.6407898Z' and eventChannels eq 'Admin, Operation' and
            /// correlationId eq '&lt;CorrelationID&gt;'. No other syntax is allowed.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<EventData> ListNext(this IEventsOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IEventsOperations)s).ListNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Provides the list of events. The **$filter** is very restricted and allows
            /// only the following patterns. - List events for a resource group:
            /// $filter=eventTimestamp ge '&lt;Start Time&gt;' and eventTimestamp le
            /// '&lt;End Time&gt;' and eventChannels eq 'Admin, Operation' and
            /// resourceGroupName eq '&lt;ResourceGroupName&gt;'. - List events for
            /// resource: $filter=eventTimestamp ge '&lt;Start Time&gt;' and eventTimestamp
            /// le '&lt;End Time&gt;' and eventChannels eq 'Admin, Operation' and
            /// resourceUri eq '&lt;ResourceURI&gt;'. - List events for a subscription:
            /// $filter=eventTimestamp ge '&lt;Start Time&gt;' and eventTimestamp le
            /// '&lt;End Time&gt;' and eventChannels eq 'Admin, Operation'. -List events
            /// for a resource provider: $filter=eventTimestamp ge '&lt;Start Time&gt;' and
            /// eventTimestamp le '&lt;End Time&gt;' and eventChannels eq 'Admin,
            /// Operation' and resourceProvider eq '&lt;ResourceProviderName&gt;'. - List
            /// events for a correlation Id:
            /// api-version=2014-04-01&amp;$filter=eventTimestamp ge
            /// '2014-07-16T04:36:37.6407898Z' and eventTimestamp le
            /// '2014-07-20T04:36:37.6407898Z' and eventChannels eq 'Admin, Operation' and
            /// correlationId eq '&lt;CorrelationID&gt;'. No other syntax is allowed.
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
            public static async Task<Microsoft.Rest.Azure.IPage<EventData>> ListNextAsync(this IEventsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
