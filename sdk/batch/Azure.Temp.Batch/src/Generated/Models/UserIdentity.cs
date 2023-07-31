// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Temp.Batch.Models
{
    /// <summary> Specify either the userName or autoUser property, but not both. </summary>
    public partial class UserIdentity
    {
        /// <summary> Initializes a new instance of UserIdentity. </summary>
        public UserIdentity()
        {
        }

        /// <summary> Initializes a new instance of UserIdentity. </summary>
        /// <param name="userName"> The userName and autoUser properties are mutually exclusive; you must specify one but not both. </param>
        /// <param name="autoUser"> The userName and autoUser properties are mutually exclusive; you must specify one but not both. </param>
        internal UserIdentity(string userName, AutoUserSpecification autoUser)
        {
            UserName = userName;
            AutoUser = autoUser;
        }

        /// <summary> The userName and autoUser properties are mutually exclusive; you must specify one but not both. </summary>
        public string UserName { get; set; }
        /// <summary> The userName and autoUser properties are mutually exclusive; you must specify one but not both. </summary>
        public AutoUserSpecification AutoUser { get; set; }
    }
}
