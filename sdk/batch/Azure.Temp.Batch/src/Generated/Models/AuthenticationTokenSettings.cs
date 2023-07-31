// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Temp.Batch.Models
{
    /// <summary> The settings for an authentication token that the Task can use to perform Batch service operations. </summary>
    public partial class AuthenticationTokenSettings
    {
        /// <summary> Initializes a new instance of AuthenticationTokenSettings. </summary>
        public AuthenticationTokenSettings()
        {
            Access = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of AuthenticationTokenSettings. </summary>
        /// <param name="access"> The authentication token grants access to a limited set of Batch service operations. Currently the only supported value for the access property is 'job', which grants access to all operations related to the Job which contains the Task. </param>
        internal AuthenticationTokenSettings(IList<string> access)
        {
            Access = access;
        }

        /// <summary> The authentication token grants access to a limited set of Batch service operations. Currently the only supported value for the access property is 'job', which grants access to all operations related to the Job which contains the Task. </summary>
        public IList<string> Access { get; }
    }
}
