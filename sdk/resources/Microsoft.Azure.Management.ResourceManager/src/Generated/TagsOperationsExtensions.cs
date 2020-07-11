// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for TagsOperations.
    /// </summary>
    public static partial class TagsOperationsExtensions
    {
            /// <summary>
            /// Deletes a predefined tag value for a predefined tag name.
            /// </summary>
            /// <remarks>
            /// This operation allows deleting a value from the list of predefined values
            /// for an existing predefined tag name. The value being deleted must not be in
            /// use as a tag value for the given tag name for any resource.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tagName'>
            /// The name of the tag.
            /// </param>
            /// <param name='tagValue'>
            /// The value of the tag to delete.
            /// </param>
            public static void DeleteValue(this ITagsOperations operations, string tagName, string tagValue)
            {
                operations.DeleteValueAsync(tagName, tagValue).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a predefined tag value for a predefined tag name.
            /// </summary>
            /// <remarks>
            /// This operation allows deleting a value from the list of predefined values
            /// for an existing predefined tag name. The value being deleted must not be in
            /// use as a tag value for the given tag name for any resource.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tagName'>
            /// The name of the tag.
            /// </param>
            /// <param name='tagValue'>
            /// The value of the tag to delete.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteValueAsync(this ITagsOperations operations, string tagName, string tagValue, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteValueWithHttpMessagesAsync(tagName, tagValue, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates a predefined value for a predefined tag name.
            /// </summary>
            /// <remarks>
            /// This operation allows adding a value to the list of predefined values for
            /// an existing predefined tag name. A tag value can have a maximum of 256
            /// characters.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tagName'>
            /// The name of the tag.
            /// </param>
            /// <param name='tagValue'>
            /// The value of the tag to create.
            /// </param>
            public static TagValue CreateOrUpdateValue(this ITagsOperations operations, string tagName, string tagValue)
            {
                return operations.CreateOrUpdateValueAsync(tagName, tagValue).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a predefined value for a predefined tag name.
            /// </summary>
            /// <remarks>
            /// This operation allows adding a value to the list of predefined values for
            /// an existing predefined tag name. A tag value can have a maximum of 256
            /// characters.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tagName'>
            /// The name of the tag.
            /// </param>
            /// <param name='tagValue'>
            /// The value of the tag to create.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TagValue> CreateOrUpdateValueAsync(this ITagsOperations operations, string tagName, string tagValue, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateValueWithHttpMessagesAsync(tagName, tagValue, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a predefined tag name.
            /// </summary>
            /// <remarks>
            /// This operation allows adding a name to the list of predefined tag names for
            /// the given subscription. A tag name can have a maximum of 512 characters and
            /// is case-insensitive. Tag names cannot have the following prefixes which are
            /// reserved for Azure use: 'microsoft', 'azure', 'windows'.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tagName'>
            /// The name of the tag to create.
            /// </param>
            public static TagDetails CreateOrUpdate(this ITagsOperations operations, string tagName)
            {
                return operations.CreateOrUpdateAsync(tagName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a predefined tag name.
            /// </summary>
            /// <remarks>
            /// This operation allows adding a name to the list of predefined tag names for
            /// the given subscription. A tag name can have a maximum of 512 characters and
            /// is case-insensitive. Tag names cannot have the following prefixes which are
            /// reserved for Azure use: 'microsoft', 'azure', 'windows'.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tagName'>
            /// The name of the tag to create.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TagDetails> CreateOrUpdateAsync(this ITagsOperations operations, string tagName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(tagName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a predefined tag name.
            /// </summary>
            /// <remarks>
            /// This operation allows deleting a name from the list of predefined tag names
            /// for the given subscription. The name being deleted must not be in use as a
            /// tag name for any resource. All predefined values for the given name must
            /// have already been deleted.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tagName'>
            /// The name of the tag.
            /// </param>
            public static void Delete(this ITagsOperations operations, string tagName)
            {
                operations.DeleteAsync(tagName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a predefined tag name.
            /// </summary>
            /// <remarks>
            /// This operation allows deleting a name from the list of predefined tag names
            /// for the given subscription. The name being deleted must not be in use as a
            /// tag name for any resource. All predefined values for the given name must
            /// have already been deleted.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tagName'>
            /// The name of the tag.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ITagsOperations operations, string tagName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(tagName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a summary of tag usage under the subscription.
            /// </summary>
            /// <remarks>
            /// This operation performs a union of predefined tags, resource tags, resource
            /// group tags and subscription tags, and returns a summary of usage for each
            /// tag name and value under the given subscription. In case of a large number
            /// of tags, this operation may return a previously cached result.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<TagDetails> List(this ITagsOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a summary of tag usage under the subscription.
            /// </summary>
            /// <remarks>
            /// This operation performs a union of predefined tags, resource tags, resource
            /// group tags and subscription tags, and returns a summary of usage for each
            /// tag name and value under the given subscription. In case of a large number
            /// of tags, this operation may return a previously cached result.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<TagDetails>> ListAsync(this ITagsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates the entire set of tags on a resource or subscription.
            /// </summary>
            /// <remarks>
            /// This operation allows adding or replacing the entire set of tags on the
            /// specified resource or subscription. The specified entity can have a maximum
            /// of 50 tags.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The resource scope.
            /// </param>
            /// <param name='parameters'>
            /// </param>
            public static TagsResource CreateOrUpdateAtScope(this ITagsOperations operations, string scope, TagsResource parameters)
            {
                return operations.CreateOrUpdateAtScopeAsync(scope, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the entire set of tags on a resource or subscription.
            /// </summary>
            /// <remarks>
            /// This operation allows adding or replacing the entire set of tags on the
            /// specified resource or subscription. The specified entity can have a maximum
            /// of 50 tags.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The resource scope.
            /// </param>
            /// <param name='parameters'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TagsResource> CreateOrUpdateAtScopeAsync(this ITagsOperations operations, string scope, TagsResource parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateAtScopeWithHttpMessagesAsync(scope, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Selectively updates the set of tags on a resource or subscription.
            /// </summary>
            /// <remarks>
            /// This operation allows replacing, merging or selectively deleting tags on
            /// the specified resource or subscription. The specified entity can have a
            /// maximum of 50 tags at the end of the operation. The 'replace' option
            /// replaces the entire set of existing tags with a new set. The 'merge' option
            /// allows adding tags with new names and updating the values of tags with
            /// existing names. The 'delete' option allows selectively deleting tags based
            /// on given names or name/value pairs.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The resource scope.
            /// </param>
            /// <param name='parameters'>
            /// </param>
            public static TagsResource UpdateAtScope(this ITagsOperations operations, string scope, TagsPatchResource parameters)
            {
                return operations.UpdateAtScopeAsync(scope, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Selectively updates the set of tags on a resource or subscription.
            /// </summary>
            /// <remarks>
            /// This operation allows replacing, merging or selectively deleting tags on
            /// the specified resource or subscription. The specified entity can have a
            /// maximum of 50 tags at the end of the operation. The 'replace' option
            /// replaces the entire set of existing tags with a new set. The 'merge' option
            /// allows adding tags with new names and updating the values of tags with
            /// existing names. The 'delete' option allows selectively deleting tags based
            /// on given names or name/value pairs.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The resource scope.
            /// </param>
            /// <param name='parameters'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TagsResource> UpdateAtScopeAsync(this ITagsOperations operations, string scope, TagsPatchResource parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateAtScopeWithHttpMessagesAsync(scope, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the entire set of tags on a resource or subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The resource scope.
            /// </param>
            public static TagsResource GetAtScope(this ITagsOperations operations, string scope)
            {
                return operations.GetAtScopeAsync(scope).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the entire set of tags on a resource or subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The resource scope.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TagsResource> GetAtScopeAsync(this ITagsOperations operations, string scope, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAtScopeWithHttpMessagesAsync(scope, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the entire set of tags on a resource or subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The resource scope.
            /// </param>
            public static void DeleteAtScope(this ITagsOperations operations, string scope)
            {
                operations.DeleteAtScopeAsync(scope).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the entire set of tags on a resource or subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The resource scope.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAtScopeAsync(this ITagsOperations operations, string scope, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteAtScopeWithHttpMessagesAsync(scope, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a summary of tag usage under the subscription.
            /// </summary>
            /// <remarks>
            /// This operation performs a union of predefined tags, resource tags, resource
            /// group tags and subscription tags, and returns a summary of usage for each
            /// tag name and value under the given subscription. In case of a large number
            /// of tags, this operation may return a previously cached result.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<TagDetails> ListNext(this ITagsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a summary of tag usage under the subscription.
            /// </summary>
            /// <remarks>
            /// This operation performs a union of predefined tags, resource tags, resource
            /// group tags and subscription tags, and returns a summary of usage for each
            /// tag name and value under the given subscription. In case of a large number
            /// of tags, this operation may return a previously cached result.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<TagDetails>> ListNextAsync(this ITagsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
