// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the WebSiteInstanceStatus data model. </summary>
    public partial class WebSiteInstanceStatusData : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of <see cref="WebSiteInstanceStatusData"/>. </summary>
        public WebSiteInstanceStatusData()
        {
            Containers = new ChangeTrackingDictionary<string, ContainerInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="WebSiteInstanceStatusData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="state"></param>
        /// <param name="statusUri"> Link to the GetStatusApi in Kudu. </param>
        /// <param name="detectorUri"> Link to the Diagnose and Solve Portal. </param>
        /// <param name="consoleUri"> Link to the console to web app instance. </param>
        /// <param name="healthCheckUri"> Link to the console to web app instance. </param>
        /// <param name="containers"> Dictionary of &lt;ContainerInfo&gt;. </param>
        internal WebSiteInstanceStatusData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kind, SiteRuntimeState? state, Uri statusUri, Uri detectorUri, Uri consoleUri, Uri healthCheckUri, IDictionary<string, ContainerInfo> containers) : base(id, name, resourceType, systemData, kind)
        {
            State = state;
            StatusUri = statusUri;
            DetectorUri = detectorUri;
            ConsoleUri = consoleUri;
            HealthCheckUri = healthCheckUri;
            Containers = containers;
        }

        /// <summary> Gets or sets the state. </summary>
        public SiteRuntimeState? State { get; set; }
        /// <summary> Link to the GetStatusApi in Kudu. </summary>
        public Uri StatusUri { get; set; }
        /// <summary> Link to the Diagnose and Solve Portal. </summary>
        public Uri DetectorUri { get; set; }
        /// <summary> Link to the console to web app instance. </summary>
        public Uri ConsoleUri { get; set; }
        /// <summary> Link to the console to web app instance. </summary>
        public Uri HealthCheckUri { get; set; }
        /// <summary> Dictionary of &lt;ContainerInfo&gt;. </summary>
        public IDictionary<string, ContainerInfo> Containers { get; }
    }
}
