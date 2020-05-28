// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Management.Network.Models
{
    /// <summary> Parameters that define a resource to query flow log and traffic analytics (optional) status. </summary>
    public partial class FlowLogStatusParameters
    {
        /// <summary> Initializes a new instance of FlowLogStatusParameters. </summary>
        /// <param name="targetResourceId"> The target resource where getting the flow log and traffic analytics (optional) status. </param>
        public FlowLogStatusParameters(string targetResourceId)
        {
            if (targetResourceId == null)
            {
                throw new ArgumentNullException(nameof(targetResourceId));
            }

            TargetResourceId = targetResourceId;
        }

        /// <summary> The target resource where getting the flow log and traffic analytics (optional) status. </summary>
        public string TargetResourceId { get; }
    }
}
