// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information. 

namespace Microsoft.Azure.Management.Resource.Fluent
{

    using Microsoft.Azure.Management.Resource.Fluent.Core.CollectionActions;

    /// <summary>
    /// Entry point to deployment operation management API.
    /// </summary>
    public interface IDeploymentOperations  :
        ISupportsListing<IDeploymentOperation>,
        ISupportsGettingById<IDeploymentOperation>
    {
    }
}