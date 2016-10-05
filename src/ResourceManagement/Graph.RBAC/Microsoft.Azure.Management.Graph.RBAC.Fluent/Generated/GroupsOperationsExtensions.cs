// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Graph.RBAC.Fluent
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for GroupsOperations.
    /// </summary>
    public static partial class GroupsOperationsExtensions
    {
            /// <summary>
            /// Checks whether the specified user, group, contact, or service principal is
            /// a direct or a transitive member of the specified group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Check group membership parameters.
            /// </param>
            public static CheckGroupMembershipResultInner IsMemberOf(this IGroupsOperations operations, CheckGroupMembershipParametersInner parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IGroupsOperations)s).IsMemberOfAsync(parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks whether the specified user, group, contact, or service principal is
            /// a direct or a transitive member of the specified group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Check group membership parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<CheckGroupMembershipResultInner> IsMemberOfAsync(this IGroupsOperations operations, CheckGroupMembershipParametersInner parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.IsMemberOfWithHttpMessagesAsync(parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Remove a memeber from a group. Reference:
            /// https://msdn.microsoft.com/en-us/library/azure/ad/graph/api/groups-operations#DeleteGroupMember
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupObjectId'>
            /// Group object id
            /// </param>
            /// <param name='memberObjectId'>
            /// Member Object id
            /// </param>
            public static void RemoveMember(this IGroupsOperations operations, string groupObjectId, string memberObjectId)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IGroupsOperations)s).RemoveMemberAsync(groupObjectId, memberObjectId), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Remove a memeber from a group. Reference:
            /// https://msdn.microsoft.com/en-us/library/azure/ad/graph/api/groups-operations#DeleteGroupMember
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupObjectId'>
            /// Group object id
            /// </param>
            /// <param name='memberObjectId'>
            /// Member Object id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task RemoveMemberAsync(this IGroupsOperations operations, string groupObjectId, string memberObjectId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.RemoveMemberWithHttpMessagesAsync(groupObjectId, memberObjectId, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Add a memeber to a group. Reference:
            /// https://msdn.microsoft.com/en-us/library/azure/ad/graph/api/groups-operations#AddGroupMembers
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupObjectId'>
            /// Group object id
            /// </param>
            /// <param name='parameters'>
            /// Member Object Url as
            /// https://graph.windows.net/0b1f9851-1bf0-433f-aec3-cb9272f093dc/directoryObjects/f260bbc4-c254-447b-94cf-293b5ec434dd
            /// </param>
            public static void AddMember(this IGroupsOperations operations, string groupObjectId, GroupAddMemberParametersInner parameters)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IGroupsOperations)s).AddMemberAsync(groupObjectId, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add a memeber to a group. Reference:
            /// https://msdn.microsoft.com/en-us/library/azure/ad/graph/api/groups-operations#AddGroupMembers
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupObjectId'>
            /// Group object id
            /// </param>
            /// <param name='parameters'>
            /// Member Object Url as
            /// https://graph.windows.net/0b1f9851-1bf0-433f-aec3-cb9272f093dc/directoryObjects/f260bbc4-c254-447b-94cf-293b5ec434dd
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task AddMemberAsync(this IGroupsOperations operations, string groupObjectId, GroupAddMemberParametersInner parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.AddMemberWithHttpMessagesAsync(groupObjectId, parameters, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Delete a group in the directory. Reference:
            /// http://msdn.microsoft.com/en-us/library/azure/dn151676.aspx
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupObjectId'>
            /// Object id
            /// </param>
            public static void Delete(this IGroupsOperations operations, string groupObjectId)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IGroupsOperations)s).DeleteAsync(groupObjectId), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a group in the directory. Reference:
            /// http://msdn.microsoft.com/en-us/library/azure/dn151676.aspx
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupObjectId'>
            /// Object id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteAsync(this IGroupsOperations operations, string groupObjectId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(groupObjectId, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Create a group in the directory. Reference:
            /// http://msdn.microsoft.com/en-us/library/azure/dn151676.aspx
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameters to create a group
            /// </param>
            public static ADGroupInner Create(this IGroupsOperations operations, GroupCreateParametersInner parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IGroupsOperations)s).CreateAsync(parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a group in the directory. Reference:
            /// http://msdn.microsoft.com/en-us/library/azure/dn151676.aspx
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameters to create a group
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ADGroupInner> CreateAsync(this IGroupsOperations operations, GroupCreateParametersInner parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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
            public static Microsoft.Rest.Azure.IPage<ADGroupInner> List(this IGroupsOperations operations, Microsoft.Rest.Azure.OData.ODataQuery<ADGroupInner> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<ADGroupInner>))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IGroupsOperations)s).ListAsync(odataQuery), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
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
            public static async Task<Microsoft.Rest.Azure.IPage<ADGroupInner>> ListAsync(this IGroupsOperations operations, Microsoft.Rest.Azure.OData.ODataQuery<ADGroupInner> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<ADGroupInner>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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
            /// Group object Id who's members should be retrieved.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<AADObjectInner> GetGroupMembers(this IGroupsOperations operations, string objectId)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IGroupsOperations)s).GetGroupMembersAsync(objectId), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the members of a group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='objectId'>
            /// Group object Id who's members should be retrieved.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<AADObjectInner>> GetGroupMembersAsync(this IGroupsOperations operations, string objectId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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
            /// User objectId to get group information.
            /// </param>
            public static ADGroupInner Get(this IGroupsOperations operations, string objectId)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IGroupsOperations)s).GetAsync(objectId), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets group information from the directory.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='objectId'>
            /// User objectId to get group information.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ADGroupInner> GetAsync(this IGroupsOperations operations, string objectId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(objectId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a collection that contains the Object IDs of the groups of which the
            /// group is a member.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='objectId'>
            /// Group filtering parameters.
            /// </param>
            /// <param name='parameters'>
            /// Group filtering parameters.
            /// </param>
            public static System.Collections.Generic.IEnumerable<string> GetMemberGroups(this IGroupsOperations operations, string objectId, GroupGetMemberGroupsParametersInner parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IGroupsOperations)s).GetMemberGroupsAsync(objectId, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a collection that contains the Object IDs of the groups of which the
            /// group is a member.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='objectId'>
            /// Group filtering parameters.
            /// </param>
            /// <param name='parameters'>
            /// Group filtering parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<System.Collections.Generic.IEnumerable<string>> GetMemberGroupsAsync(this IGroupsOperations operations, string objectId, GroupGetMemberGroupsParametersInner parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetMemberGroupsWithHttpMessagesAsync(objectId, parameters, null, cancellationToken).ConfigureAwait(false))
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
            /// <param name='nextLink'>
            /// Next link for list operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<ADGroupInner> ListNext(this IGroupsOperations operations, string nextLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IGroupsOperations)s).ListNextAsync(nextLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets list of groups for the current tenant.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextLink'>
            /// Next link for list operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<ADGroupInner>> ListNextAsync(this IGroupsOperations operations, string nextLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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
            /// Next link for list operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<AADObjectInner> GetGroupMembersNext(this IGroupsOperations operations, string nextLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IGroupsOperations)s).GetGroupMembersNextAsync(nextLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the members of a group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextLink'>
            /// Next link for list operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<AADObjectInner>> GetGroupMembersNextAsync(this IGroupsOperations operations, string nextLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetGroupMembersNextWithHttpMessagesAsync(nextLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
