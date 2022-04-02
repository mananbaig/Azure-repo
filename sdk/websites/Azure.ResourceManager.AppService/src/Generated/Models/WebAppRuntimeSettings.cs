// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Web App runtime settings. </summary>
    public partial class WebAppRuntimeSettings
    {
        /// <summary> Initializes a new instance of WebAppRuntimeSettings. </summary>
        internal WebAppRuntimeSettings()
        {
        }

        /// <summary> Initializes a new instance of WebAppRuntimeSettings. </summary>
        /// <param name="runtimeVersion"> Web App stack minor version (runtime only). </param>
        /// <param name="remoteDebuggingSupported"> &lt;code&gt;true&lt;/code&gt; if remote debugging is supported for the stack; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="appInsightsSettings"> Application Insights settings associated with the minor version. </param>
        /// <param name="gitHubActionSettings"> GitHub Actions settings associated with the minor version. </param>
        /// <param name="isPreview"> &lt;code&gt;true&lt;/code&gt; if the stack is in preview; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="isDeprecated"> &lt;code&gt;true&lt;/code&gt; if the stack is deprecated; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="isHidden"> &lt;code&gt;true&lt;/code&gt; if the stack should be hidden; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="endOfLifeOn"> End-of-life date for the minor version. </param>
        /// <param name="isAutoUpdate"> &lt;code&gt;true&lt;/code&gt; if the stack version is auto-updated; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="isEarlyAccess"> &lt;code&gt;true&lt;/code&gt; if the minor version is early-access; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        internal WebAppRuntimeSettings(string runtimeVersion, bool? remoteDebuggingSupported, AppInsightsWebAppStackSettings appInsightsSettings, GitHubActionWebAppStackSettings gitHubActionSettings, bool? isPreview, bool? isDeprecated, bool? isHidden, DateTimeOffset? endOfLifeOn, bool? isAutoUpdate, bool? isEarlyAccess)
        {
            RuntimeVersion = runtimeVersion;
            RemoteDebuggingSupported = remoteDebuggingSupported;
            AppInsightsSettings = appInsightsSettings;
            GitHubActionSettings = gitHubActionSettings;
            IsPreview = isPreview;
            IsDeprecated = isDeprecated;
            IsHidden = isHidden;
            EndOfLifeOn = endOfLifeOn;
            IsAutoUpdate = isAutoUpdate;
            IsEarlyAccess = isEarlyAccess;
        }

        /// <summary> Web App stack minor version (runtime only). </summary>
        public string RuntimeVersion { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if remote debugging is supported for the stack; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? RemoteDebuggingSupported { get; }
        /// <summary> Application Insights settings associated with the minor version. </summary>
        public AppInsightsWebAppStackSettings AppInsightsSettings { get; }
        /// <summary> GitHub Actions settings associated with the minor version. </summary>
        public GitHubActionWebAppStackSettings GitHubActionSettings { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the stack is in preview; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsPreview { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the stack is deprecated; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsDeprecated { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the stack should be hidden; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsHidden { get; }
        /// <summary> End-of-life date for the minor version. </summary>
        public DateTimeOffset? EndOfLifeOn { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the stack version is auto-updated; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsAutoUpdate { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the minor version is early-access; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsEarlyAccess { get; }
    }
}
