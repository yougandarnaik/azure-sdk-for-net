// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Insights
{
    using Azure;
    using Rest;
    using Rest.Azure;
    using Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ActivityLogsOperations.
    /// </summary>
    public static partial class ActivityLogsOperationsExtensions
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
            public static IPage<EventData> List(this IActivityLogsOperations operations, ODataQuery<EventData> odataQuery = default(ODataQuery<EventData>), string select = default(string))
            {
                return operations.ListAsync(odataQuery, select).GetAwaiter().GetResult();
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
            public static async Task<IPage<EventData>> ListAsync(this IActivityLogsOperations operations, ODataQuery<EventData> odataQuery = default(ODataQuery<EventData>), string select = default(string), CancellationToken cancellationToken = default(CancellationToken))
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
            public static IPage<EventData> ListNext(this IActivityLogsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
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
            public static async Task<IPage<EventData>> ListNextAsync(this IActivityLogsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

