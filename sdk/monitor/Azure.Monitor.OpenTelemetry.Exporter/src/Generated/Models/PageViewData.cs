// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Monitor.OpenTelemetry.Exporter;

namespace Azure.Monitor.OpenTelemetry.Exporter.Models
{
    /// <summary> An instance of PageView represents a generic action on a page like a button click. It is also the base type for PageView. </summary>
    internal partial class PageViewData : MonitorDomain
    {
        /// <summary> Initializes a new instance of <see cref="PageViewData"/>. </summary>
        /// <param name="version"> Schema version. </param>
        /// <param name="id"> Identifier of a page view instance. Used for correlation between page view and other telemetry items. </param>
        /// <param name="name"> Event name. Keep it low cardinality to allow proper grouping and useful metrics. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="name"/> is null. </exception>
        public PageViewData(int version, string id, string name) : base(version)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(name, nameof(name));

            Id = id;
            Name = name;
            Properties = new ChangeTrackingDictionary<string, string>();
            Measurements = new ChangeTrackingDictionary<string, double>();
        }

        /// <summary> Initializes a new instance of <see cref="PageViewData"/>. </summary>
        /// <param name="version"> Schema version. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="id"> Identifier of a page view instance. Used for correlation between page view and other telemetry items. </param>
        /// <param name="name"> Event name. Keep it low cardinality to allow proper grouping and useful metrics. </param>
        /// <param name="url"> Request URL with all query string parameters. </param>
        /// <param name="duration"> Request duration in format: DD.HH:MM:SS.MMMMMM. For a page view (PageViewData), this is the duration. For a page view with performance information (PageViewPerfData), this is the page load time. Must be less than 1000 days. </param>
        /// <param name="referredUri"> Fully qualified page URI or URL of the referring page; if unknown, leave blank. </param>
        /// <param name="properties"> Collection of custom properties. </param>
        /// <param name="measurements"> Collection of custom measurements. </param>
        internal PageViewData(int version, IDictionary<string, object> additionalProperties, string id, string name, string url, string duration, string referredUri, IDictionary<string, string> properties, IDictionary<string, double> measurements) : base(version, additionalProperties)
        {
            Id = id;
            Name = name;
            Url = url;
            Duration = duration;
            ReferredUri = referredUri;
            Properties = properties;
            Measurements = measurements;
        }

        /// <summary> Identifier of a page view instance. Used for correlation between page view and other telemetry items. </summary>
        public string Id { get; }
        /// <summary> Event name. Keep it low cardinality to allow proper grouping and useful metrics. </summary>
        public string Name { get; }
        /// <summary> Request URL with all query string parameters. </summary>
        public string Url { get; set; }
        /// <summary> Request duration in format: DD.HH:MM:SS.MMMMMM. For a page view (PageViewData), this is the duration. For a page view with performance information (PageViewPerfData), this is the page load time. Must be less than 1000 days. </summary>
        public string Duration { get; set; }
        /// <summary> Fully qualified page URI or URL of the referring page; if unknown, leave blank. </summary>
        public string ReferredUri { get; set; }
        /// <summary> Collection of custom properties. </summary>
        public IDictionary<string, string> Properties { get; }
        /// <summary> Collection of custom measurements. </summary>
        public IDictionary<string, double> Measurements { get; }
    }
}
