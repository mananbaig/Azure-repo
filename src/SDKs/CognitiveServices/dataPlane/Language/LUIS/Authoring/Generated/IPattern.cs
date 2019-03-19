// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Authoring
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Pattern operations.
    /// </summary>
    public partial interface IPattern
    {
        /// <summary>
        /// Adds a pattern to a version of the application.
        /// </summary>
        /// <param name='azureRegion'>
        /// Supported Azure regions for Cognitive Services endpoints. Possible
        /// values include: 'westus', 'westeurope', 'southeastasia', 'eastus2',
        /// 'westcentralus', 'westus2', 'eastus', 'southcentralus',
        /// 'northeurope', 'eastasia', 'australiaeast', 'brazilsouth',
        /// 'virginia'
        /// </param>
        /// <param name='azureCloud'>
        /// Supported Azure Clouds for Cognitive Services endpoints. Possible
        /// values include: 'com', 'us'
        /// </param>
        /// <param name='appId'>
        /// The application ID.
        /// </param>
        /// <param name='versionId'>
        /// The version ID.
        /// </param>
        /// <param name='pattern'>
        /// The input pattern.
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
        Task<HttpOperationResponse<PatternRuleInfo>> AddPatternWithHttpMessagesAsync(AzureRegions azureRegion, AzureClouds azureCloud, System.Guid appId, string versionId, PatternRuleCreateObject pattern, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets patterns in a version of the application.
        /// </summary>
        /// <param name='azureRegion'>
        /// Supported Azure regions for Cognitive Services endpoints. Possible
        /// values include: 'westus', 'westeurope', 'southeastasia', 'eastus2',
        /// 'westcentralus', 'westus2', 'eastus', 'southcentralus',
        /// 'northeurope', 'eastasia', 'australiaeast', 'brazilsouth',
        /// 'virginia'
        /// </param>
        /// <param name='azureCloud'>
        /// Supported Azure Clouds for Cognitive Services endpoints. Possible
        /// values include: 'com', 'us'
        /// </param>
        /// <param name='appId'>
        /// The application ID.
        /// </param>
        /// <param name='versionId'>
        /// The version ID.
        /// </param>
        /// <param name='skip'>
        /// The number of entries to skip. Default value is 0.
        /// </param>
        /// <param name='take'>
        /// The number of entries to return. Maximum page size is 500. Default
        /// is 100.
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
        Task<HttpOperationResponse<IList<PatternRuleInfo>>> ListPatternsWithHttpMessagesAsync(AzureRegions azureRegion, AzureClouds azureCloud, System.Guid appId, string versionId, int? skip = 0, int? take = 100, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates patterns in a version of the application.
        /// </summary>
        /// <param name='azureRegion'>
        /// Supported Azure regions for Cognitive Services endpoints. Possible
        /// values include: 'westus', 'westeurope', 'southeastasia', 'eastus2',
        /// 'westcentralus', 'westus2', 'eastus', 'southcentralus',
        /// 'northeurope', 'eastasia', 'australiaeast', 'brazilsouth',
        /// 'virginia'
        /// </param>
        /// <param name='azureCloud'>
        /// Supported Azure Clouds for Cognitive Services endpoints. Possible
        /// values include: 'com', 'us'
        /// </param>
        /// <param name='appId'>
        /// The application ID.
        /// </param>
        /// <param name='versionId'>
        /// The version ID.
        /// </param>
        /// <param name='patterns'>
        /// An array represents the patterns.
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
        Task<HttpOperationResponse<IList<PatternRuleInfo>>> UpdatePatternsWithHttpMessagesAsync(AzureRegions azureRegion, AzureClouds azureCloud, System.Guid appId, string versionId, IList<PatternRuleUpdateObject> patterns, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Adds a batch of patterns in a version of the application.
        /// </summary>
        /// <param name='azureRegion'>
        /// Supported Azure regions for Cognitive Services endpoints. Possible
        /// values include: 'westus', 'westeurope', 'southeastasia', 'eastus2',
        /// 'westcentralus', 'westus2', 'eastus', 'southcentralus',
        /// 'northeurope', 'eastasia', 'australiaeast', 'brazilsouth',
        /// 'virginia'
        /// </param>
        /// <param name='azureCloud'>
        /// Supported Azure Clouds for Cognitive Services endpoints. Possible
        /// values include: 'com', 'us'
        /// </param>
        /// <param name='appId'>
        /// The application ID.
        /// </param>
        /// <param name='versionId'>
        /// The version ID.
        /// </param>
        /// <param name='patterns'>
        /// A JSON array containing patterns.
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
        Task<HttpOperationResponse<IList<PatternRuleInfo>>> BatchAddPatternsWithHttpMessagesAsync(AzureRegions azureRegion, AzureClouds azureCloud, System.Guid appId, string versionId, IList<PatternRuleCreateObject> patterns, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a list of patterns in a version of the application.
        /// </summary>
        /// <param name='azureRegion'>
        /// Supported Azure regions for Cognitive Services endpoints. Possible
        /// values include: 'westus', 'westeurope', 'southeastasia', 'eastus2',
        /// 'westcentralus', 'westus2', 'eastus', 'southcentralus',
        /// 'northeurope', 'eastasia', 'australiaeast', 'brazilsouth',
        /// 'virginia'
        /// </param>
        /// <param name='azureCloud'>
        /// Supported Azure Clouds for Cognitive Services endpoints. Possible
        /// values include: 'com', 'us'
        /// </param>
        /// <param name='appId'>
        /// The application ID.
        /// </param>
        /// <param name='versionId'>
        /// The version ID.
        /// </param>
        /// <param name='patternIds'>
        /// The patterns IDs.
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
        Task<HttpOperationResponse<OperationStatus>> DeletePatternsWithHttpMessagesAsync(AzureRegions azureRegion, AzureClouds azureCloud, System.Guid appId, string versionId, IList<System.Guid?> patternIds, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates a pattern in a version of the application.
        /// </summary>
        /// <param name='azureRegion'>
        /// Supported Azure regions for Cognitive Services endpoints. Possible
        /// values include: 'westus', 'westeurope', 'southeastasia', 'eastus2',
        /// 'westcentralus', 'westus2', 'eastus', 'southcentralus',
        /// 'northeurope', 'eastasia', 'australiaeast', 'brazilsouth',
        /// 'virginia'
        /// </param>
        /// <param name='azureCloud'>
        /// Supported Azure Clouds for Cognitive Services endpoints. Possible
        /// values include: 'com', 'us'
        /// </param>
        /// <param name='appId'>
        /// The application ID.
        /// </param>
        /// <param name='versionId'>
        /// The version ID.
        /// </param>
        /// <param name='patternId'>
        /// The pattern ID.
        /// </param>
        /// <param name='pattern'>
        /// An object representing a pattern.
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
        Task<HttpOperationResponse<PatternRuleInfo>> UpdatePatternWithHttpMessagesAsync(AzureRegions azureRegion, AzureClouds azureCloud, System.Guid appId, string versionId, System.Guid patternId, PatternRuleUpdateObject pattern, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the pattern with the specified ID from a version of the
        /// application..
        /// </summary>
        /// <param name='azureRegion'>
        /// Supported Azure regions for Cognitive Services endpoints. Possible
        /// values include: 'westus', 'westeurope', 'southeastasia', 'eastus2',
        /// 'westcentralus', 'westus2', 'eastus', 'southcentralus',
        /// 'northeurope', 'eastasia', 'australiaeast', 'brazilsouth',
        /// 'virginia'
        /// </param>
        /// <param name='azureCloud'>
        /// Supported Azure Clouds for Cognitive Services endpoints. Possible
        /// values include: 'com', 'us'
        /// </param>
        /// <param name='appId'>
        /// The application ID.
        /// </param>
        /// <param name='versionId'>
        /// The version ID.
        /// </param>
        /// <param name='patternId'>
        /// The pattern ID.
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
        Task<HttpOperationResponse<OperationStatus>> DeletePatternWithHttpMessagesAsync(AzureRegions azureRegion, AzureClouds azureCloud, System.Guid appId, string versionId, System.Guid patternId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns patterns for the specific intent in a version of the
        /// application.
        /// </summary>
        /// <param name='azureRegion'>
        /// Supported Azure regions for Cognitive Services endpoints. Possible
        /// values include: 'westus', 'westeurope', 'southeastasia', 'eastus2',
        /// 'westcentralus', 'westus2', 'eastus', 'southcentralus',
        /// 'northeurope', 'eastasia', 'australiaeast', 'brazilsouth',
        /// 'virginia'
        /// </param>
        /// <param name='azureCloud'>
        /// Supported Azure Clouds for Cognitive Services endpoints. Possible
        /// values include: 'com', 'us'
        /// </param>
        /// <param name='appId'>
        /// The application ID.
        /// </param>
        /// <param name='versionId'>
        /// The version ID.
        /// </param>
        /// <param name='intentId'>
        /// The intent classifier ID.
        /// </param>
        /// <param name='skip'>
        /// The number of entries to skip. Default value is 0.
        /// </param>
        /// <param name='take'>
        /// The number of entries to return. Maximum page size is 500. Default
        /// is 100.
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
        Task<HttpOperationResponse<IList<PatternRuleInfo>>> ListIntentPatternsWithHttpMessagesAsync(AzureRegions azureRegion, AzureClouds azureCloud, System.Guid appId, string versionId, System.Guid intentId, int? skip = 0, int? take = 100, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
