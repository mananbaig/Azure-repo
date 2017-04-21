// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ProtectionPolicyOperationStatusesOperations operations.
    /// </summary>
    public partial interface IProtectionPolicyOperationStatusesOperations
    {
        /// <summary>
        /// Provides the status of the asynchronous operations like backup,
        /// restore. The status can be in progress, completed or failed. You
        /// can refer to the Operation Status enum for all the possible states
        /// of an operation. Some operations create jobs. This method returns
        /// the list of jobs associated with operation.
        /// </summary>
        /// <param name='vaultName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='policyName'>
        /// Backup policy name whose operation's status needs to be fetched.
        /// </param>
        /// <param name='operationId'>
        /// Operation ID which represents an operation whose status needs to be
        /// fetched.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<OperationStatus>> GetWithHttpMessagesAsync(string vaultName, string resourceGroupName, string policyName, string operationId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
