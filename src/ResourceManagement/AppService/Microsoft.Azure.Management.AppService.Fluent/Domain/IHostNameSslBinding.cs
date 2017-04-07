// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.AppService.Fluent
{
    using Microsoft.Azure.Management.AppService.Fluent.Models;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;

    /// <summary>
    /// An immutable representation of an host name SSL binding.
    /// </summary>
    /// <remarks>
    /// (Beta: This functionality is in preview and as such is subject to change in non-backwards compatible ways in
    /// future releases, including removal, regardless of any compatibility expectations set by the containing library
    /// version number.).
    /// </remarks>
    public interface IHostNameSslBinding  :
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.IHasInner<Models.HostNameSslState>,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.IChildResource<Microsoft.Azure.Management.AppService.Fluent.IWebAppBase>
    {
        /// <summary>
        /// Gets the SSL cert thumbprint.
        /// </summary>
        string Thumbprint { get; }

        /// <summary>
        /// Gets the virtual IP address assigned to the host name if IP based SSL is enabled.
        /// </summary>
        string VirtualIP { get; }

        /// <summary>
        /// Gets the SSL type.
        /// </summary>
        Models.SslState SslState { get; }
    }
}