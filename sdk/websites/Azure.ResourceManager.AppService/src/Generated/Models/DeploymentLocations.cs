// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// List of available locations (regions or App Service Environments) for
    /// deployment of App Service resources.
    /// </summary>
    public partial class DeploymentLocations
    {
        /// <summary> Initializes a new instance of DeploymentLocations. </summary>
        internal DeploymentLocations()
        {
            Locations = new ChangeTrackingList<GeoRegion>();
            HostingEnvironments = new ChangeTrackingList<AppServiceEnvironmentAutoGenerated>();
            HostingEnvironmentDeploymentInfos = new ChangeTrackingList<HostingEnvironmentDeploymentInfo>();
        }

        /// <summary> Initializes a new instance of DeploymentLocations. </summary>
        /// <param name="locations"> Available regions. </param>
        /// <param name="hostingEnvironments"> Available App Service Environments with full descriptions of the environments. </param>
        /// <param name="hostingEnvironmentDeploymentInfos"> Available App Service Environments with basic information. </param>
        internal DeploymentLocations(IReadOnlyList<GeoRegion> locations, IReadOnlyList<AppServiceEnvironmentAutoGenerated> hostingEnvironments, IReadOnlyList<HostingEnvironmentDeploymentInfo> hostingEnvironmentDeploymentInfos)
        {
            Locations = locations;
            HostingEnvironments = hostingEnvironments;
            HostingEnvironmentDeploymentInfos = hostingEnvironmentDeploymentInfos;
        }

        /// <summary> Available regions. </summary>
        public IReadOnlyList<GeoRegion> Locations { get; }
        /// <summary> Available App Service Environments with full descriptions of the environments. </summary>
        public IReadOnlyList<AppServiceEnvironmentAutoGenerated> HostingEnvironments { get; }
        /// <summary> Available App Service Environments with basic information. </summary>
        public IReadOnlyList<HostingEnvironmentDeploymentInfo> HostingEnvironmentDeploymentInfos { get; }
    }
}
