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
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Features.
    /// </summary>
    public static partial class FeaturesExtensions
    {
            /// <summary>
            /// Creates a new phraselist feature in a version of the application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID.
            /// </param>
            /// <param name='phraselistCreateObject'>
            /// A Phraselist object containing Name, comma-separated Phrases and the
            /// isExchangeable boolean. Default value for isExchangeable is true.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<int?> AddPhraseListAsync(this IFeatures operations, System.Guid appId, string versionId, PhraselistCreateObject phraselistCreateObject, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddPhraseListWithHttpMessagesAsync(appId, versionId, phraselistCreateObject, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the phraselist features in a version of the application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
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
            /// The number of entries to return. Maximum page size is 500. Default is 100.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<PhraseListFeatureInfo>> ListPhraseListsAsync(this IFeatures operations, System.Guid appId, string versionId, int? skip = 0, int? take = 100, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListPhraseListsWithHttpMessagesAsync(appId, versionId, skip, take, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the extraction phraselist and pattern features in a version of the
            /// application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
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
            /// The number of entries to return. Maximum page size is 500. Default is 100.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FeaturesResponseObject> ListAsync(this IFeatures operations, System.Guid appId, string versionId, int? skip = 0, int? take = 100, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(appId, versionId, skip, take, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets phraselist feature info in a version of the application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID.
            /// </param>
            /// <param name='phraselistId'>
            /// The ID of the feature to be retrieved.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PhraseListFeatureInfo> GetPhraseListAsync(this IFeatures operations, System.Guid appId, string versionId, int phraselistId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPhraseListWithHttpMessagesAsync(appId, versionId, phraselistId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the phrases, the state and the name of the phraselist feature in a
            /// version of the application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID.
            /// </param>
            /// <param name='phraselistId'>
            /// The ID of the feature to be updated.
            /// </param>
            /// <param name='phraselistUpdateObject'>
            /// The new values for: - Just a boolean called IsActive, in which case the
            /// status of the feature will be changed. - Name, Pattern, Mode, and a boolean
            /// called IsActive to update the feature.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationStatus> UpdatePhraseListAsync(this IFeatures operations, System.Guid appId, string versionId, int phraselistId, PhraselistUpdateObject phraselistUpdateObject = default(PhraselistUpdateObject), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdatePhraseListWithHttpMessagesAsync(appId, versionId, phraselistId, phraselistUpdateObject, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a phraselist feature from a version of the application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID.
            /// </param>
            /// <param name='phraselistId'>
            /// The ID of the feature to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationStatus> DeletePhraseListAsync(this IFeatures operations, System.Guid appId, string versionId, int phraselistId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeletePhraseListWithHttpMessagesAsync(appId, versionId, phraselistId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Adds a new feature relation to be used by the intent in a version of the
            /// application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
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
            /// <param name='featureRelationCreateObject'>
            /// A Feature relation information object.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationStatus> AddIntentFeatureAsync(this IFeatures operations, System.Guid appId, string versionId, System.Guid intentId, ModelFeatureInformation featureRelationCreateObject, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddIntentFeatureWithHttpMessagesAsync(appId, versionId, intentId, featureRelationCreateObject, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Adds a new feature relation to be used by the entity in a version of the
            /// application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID.
            /// </param>
            /// <param name='entityId'>
            /// The entity extractor ID.
            /// </param>
            /// <param name='featureRelationCreateObject'>
            /// A Feature relation information object.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationStatus> AddEntityFeatureAsync(this IFeatures operations, System.Guid appId, string versionId, System.Guid entityId, ModelFeatureInformation featureRelationCreateObject, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddEntityFeatureWithHttpMessagesAsync(appId, versionId, entityId, featureRelationCreateObject, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
