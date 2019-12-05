// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBoxEdge
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AlertsOperations.
    /// </summary>
    public static partial class AlertsOperationsExtensions
    {
            /// <summary>
            /// Gets all the alerts for a Data Box Edge/Data Box Gateway device.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceName'>
            /// The device name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            public static IPage<Alert> ListByDataBoxEdgeDevice(this IAlertsOperations operations, string deviceName, string resourceGroupName)
            {
                return operations.ListByDataBoxEdgeDeviceAsync(deviceName, resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the alerts for a Data Box Edge/Data Box Gateway device.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceName'>
            /// The device name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Alert>> ListByDataBoxEdgeDeviceAsync(this IAlertsOperations operations, string deviceName, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByDataBoxEdgeDeviceWithHttpMessagesAsync(deviceName, resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets an alert by name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceName'>
            /// The device name.
            /// </param>
            /// <param name='name'>
            /// The alert name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            public static Alert Get(this IAlertsOperations operations, string deviceName, string name, string resourceGroupName)
            {
                return operations.GetAsync(deviceName, name, resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an alert by name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceName'>
            /// The device name.
            /// </param>
            /// <param name='name'>
            /// The alert name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Alert> GetAsync(this IAlertsOperations operations, string deviceName, string name, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(deviceName, name, resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the alerts for a Data Box Edge/Data Box Gateway device.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Alert> ListByDataBoxEdgeDeviceNext(this IAlertsOperations operations, string nextPageLink)
            {
                return operations.ListByDataBoxEdgeDeviceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the alerts for a Data Box Edge/Data Box Gateway device.
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
            public static async Task<IPage<Alert>> ListByDataBoxEdgeDeviceNextAsync(this IAlertsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByDataBoxEdgeDeviceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
