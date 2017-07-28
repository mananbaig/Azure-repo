// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Graph.RBAC.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Graph;
    using Microsoft.Azure.Management.Graph.RBAC;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for GroupsOperations.
    /// </summary>
    public static partial class GroupsOperationsExtensions
    {
            /// <summary>
            /// Checks whether the specified user, group, contact, or service principal is
            /// a direct or transitive member of the specified group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// The check group membership parameters.
            /// </param>
            public static CheckGroupMembershipResultInner IsMemberOf(this IGroupsOperations operations, CheckGroupMembershipParametersInner parameters)
            {
                return operations.IsMemberOfAsync(parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks whether the specified user, group, contact, or service principal is
            /// a direct or transitive member of the specified group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// The check group membership parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CheckGroupMembershipResultInner> IsMemberOfAsync(this IGroupsOperations operations, CheckGroupMembershipParametersInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.IsMemberOfWithHttpMessagesAsync(parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Remove a member from a group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupObjectId'>
            /// The object ID of the group from which to remove the member.
            /// </param>
            /// <param name='memberObjectId'>
            /// Member object id
            /// </param>
            public static void RemoveMember(this IGroupsOperations operations, string groupObjectId, string memberObjectId)
            {
                operations.RemoveMemberAsync(groupObjectId, memberObjectId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Remove a member from a group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupObjectId'>
            /// The object ID of the group from which to remove the member.
            /// </param>
            /// <param name='memberObjectId'>
            /// Member object id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RemoveMemberAsync(this IGroupsOperations operations, string groupObjectId, string memberObjectId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.RemoveMemberWithHttpMessagesAsync(groupObjectId, memberObjectId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Add a member to a group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupObjectId'>
            /// The object ID of the group to which to add the member.
            /// </param>
            /// <param name='parameters'>
            /// The URL of the member object, such as
            /// https://graph.windows.net/0b1f9851-1bf0-433f-aec3-cb9272f093dc/directoryObjects/f260bbc4-c254-447b-94cf-293b5ec434dd.
            /// </param>
            public static void AddMember(this IGroupsOperations operations, string groupObjectId, GroupAddMemberParametersInner parameters)
            {
                operations.AddMemberAsync(groupObjectId, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add a member to a group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupObjectId'>
            /// The object ID of the group to which to add the member.
            /// </param>
            /// <param name='parameters'>
            /// The URL of the member object, such as
            /// https://graph.windows.net/0b1f9851-1bf0-433f-aec3-cb9272f093dc/directoryObjects/f260bbc4-c254-447b-94cf-293b5ec434dd.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task AddMemberAsync(this IGroupsOperations operations, string groupObjectId, GroupAddMemberParametersInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.AddMemberWithHttpMessagesAsync(groupObjectId, parameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Delete a group from the directory.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupObjectId'>
            /// The object ID of the group to delete.
            /// </param>
            public static void Delete(this IGroupsOperations operations, string groupObjectId)
            {
                operations.DeleteAsync(groupObjectId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a group from the directory.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupObjectId'>
            /// The object ID of the group to delete.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IGroupsOperations operations, string groupObjectId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(groupObjectId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Create a group in the directory.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// The parameters for the group to create.
            /// </param>
            public static ADGroupInner Create(this IGroupsOperations operations, GroupCreateParametersInner parameters)
            {
                return operations.CreateAsync(parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a group in the directory.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// The parameters for the group to create.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ADGroupInner> CreateAsync(this IGroupsOperations operations, GroupCreateParametersInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets list of groups for the current tenant.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<ADGroupInner> List(this IGroupsOperations operations, ODataQuery<ADGroupInner> odataQuery = default(ODataQuery<ADGroupInner>))
            {
                return ((IGroupsOperations)operations).ListAsync(odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets list of groups for the current tenant.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ADGroupInner>> ListAsync(this IGroupsOperations operations, ODataQuery<ADGroupInner> odataQuery = default(ODataQuery<ADGroupInner>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the members of a group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='objectId'>
            /// The object ID of the group whose members should be retrieved.
            /// </param>
            public static IPage<AADObjectInner> GetGroupMembers(this IGroupsOperations operations, string objectId)
            {
                return operations.GetGroupMembersAsync(objectId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the members of a group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='objectId'>
            /// The object ID of the group whose members should be retrieved.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<AADObjectInner>> GetGroupMembersAsync(this IGroupsOperations operations, string objectId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetGroupMembersWithHttpMessagesAsync(objectId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets group information from the directory.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='objectId'>
            /// The object ID of the user for which to get group information.
            /// </param>
            public static ADGroupInner Get(this IGroupsOperations operations, string objectId)
            {
                return operations.GetAsync(objectId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets group information from the directory.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='objectId'>
            /// The object ID of the user for which to get group information.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ADGroupInner> GetAsync(this IGroupsOperations operations, string objectId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(objectId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a collection of object IDs of groups of which the specified group is a
            /// member.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='objectId'>
            /// The object ID of the group for which to get group membership.
            /// </param>
            /// <param name='parameters'>
            /// Group filtering parameters.
            /// </param>
            public static IEnumerable<string> GetMemberGroups(this IGroupsOperations operations, string objectId, GroupGetMemberGroupsParametersInner parameters)
            {
                return operations.GetMemberGroupsAsync(objectId, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a collection of object IDs of groups of which the specified group is a
            /// member.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='objectId'>
            /// The object ID of the group for which to get group membership.
            /// </param>
            /// <param name='parameters'>
            /// Group filtering parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<string>> GetMemberGroupsAsync(this IGroupsOperations operations, string objectId, GroupGetMemberGroupsParametersInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetMemberGroupsWithHttpMessagesAsync(objectId, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of groups for the current tenant.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextLink'>
            /// Next link for the list operation.
            /// </param>
            public static IPage<ADGroupInner> ListNext(this IGroupsOperations operations, string nextLink)
            {
                return operations.ListNextAsync(nextLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of groups for the current tenant.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextLink'>
            /// Next link for the list operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ADGroupInner>> ListNextAsync(this IGroupsOperations operations, string nextLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the members of a group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextLink'>
            /// Next link for the list operation.
            /// </param>
            public static IPage<AADObjectInner> GetGroupMembersNext(this IGroupsOperations operations, string nextLink)
            {
                return operations.GetGroupMembersNextAsync(nextLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the members of a group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextLink'>
            /// Next link for the list operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<AADObjectInner>> GetGroupMembersNextAsync(this IGroupsOperations operations, string nextLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetGroupMembersNextWithHttpMessagesAsync(nextLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
