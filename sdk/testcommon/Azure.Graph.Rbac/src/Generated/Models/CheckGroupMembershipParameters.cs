// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;

namespace Azure.Graph.Rbac.Models
{
    /// <summary> Request parameters for IsMemberOf API call. </summary>
    public partial class CheckGroupMembershipParameters : IDictionary<string, object>
    {
        /// <summary> Initializes a new instance of CheckGroupMembershipParameters. </summary>
        /// <param name="groupId"> The object ID of the group to check. </param>
        /// <param name="memberId"> The object ID of the contact, group, user, or service principal to check for membership in the specified group. </param>
        public CheckGroupMembershipParameters(string groupId, string memberId)
        {
            if (groupId == null)
            {
                throw new ArgumentNullException(nameof(groupId));
            }
            if (memberId == null)
            {
                throw new ArgumentNullException(nameof(memberId));
            }

            GroupId = groupId;
            MemberId = memberId;
            AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary> Initializes a new instance of CheckGroupMembershipParameters. </summary>
        /// <param name="groupId"> The object ID of the group to check. </param>
        /// <param name="memberId"> The object ID of the contact, group, user, or service principal to check for membership in the specified group. </param>
        /// <param name="additionalProperties"> . </param>
        internal CheckGroupMembershipParameters(string groupId, string memberId, IDictionary<string, object> additionalProperties)
        {
            GroupId = groupId;
            MemberId = memberId;
            AdditionalProperties = additionalProperties ?? new Dictionary<string, object>();
        }

        /// <summary> The object ID of the group to check. </summary>
        public string GroupId { get; }
        /// <summary> The object ID of the contact, group, user, or service principal to check for membership in the specified group. </summary>
        public string MemberId { get; }
        internal IDictionary<string, object> AdditionalProperties { get; }
        /// <inheritdoc />
        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        public bool TryGetValue(string key, out object value) => AdditionalProperties.TryGetValue(key, out value);
        /// <inheritdoc />
        public bool ContainsKey(string key) => AdditionalProperties.ContainsKey(key);
        /// <inheritdoc />
        public ICollection<string> Keys => AdditionalProperties.Keys;
        /// <inheritdoc />
        public ICollection<object> Values => AdditionalProperties.Values;
        /// <inheritdoc />
        int ICollection<KeyValuePair<string, object>>.Count => AdditionalProperties.Count;
        /// <inheritdoc />
        public void Add(string key, object value) => AdditionalProperties.Add(key, value);
        /// <inheritdoc />
        public bool Remove(string key) => AdditionalProperties.Remove(key);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, object>>.IsReadOnly => AdditionalProperties.IsReadOnly;
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, object>>.Add(KeyValuePair<string, object> value) => AdditionalProperties.Add(value);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, object>>.Remove(KeyValuePair<string, object> value) => AdditionalProperties.Remove(value);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, object>>.Contains(KeyValuePair<string, object> value) => AdditionalProperties.Contains(value);
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, object>>.CopyTo(KeyValuePair<string, object>[] destination, int offset) => AdditionalProperties.CopyTo(destination, offset);
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, object>>.Clear() => AdditionalProperties.Clear();
        /// <inheritdoc />
        public object this[string key]
        {
            get => AdditionalProperties[key];
            set => AdditionalProperties[key] = value;
        }
    }
}
