// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Specification of data sources that will be collected. </summary>
    public partial class DataSourcesSpec
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DataSourcesSpec"/>. </summary>
        public DataSourcesSpec()
        {
            PerformanceCounters = new ChangeTrackingList<PerfCounterDataSource>();
            WindowsEventLogs = new ChangeTrackingList<WindowsEventLogDataSource>();
            Syslog = new ChangeTrackingList<SyslogDataSource>();
            Extensions = new ChangeTrackingList<ExtensionDataSource>();
            LogFiles = new ChangeTrackingList<LogFilesDataSource>();
            IisLogs = new ChangeTrackingList<IisLogsDataSource>();
            WindowsFirewallLogs = new ChangeTrackingList<WindowsFirewallLogsDataSource>();
            PrometheusForwarder = new ChangeTrackingList<PrometheusForwarderDataSource>();
            PlatformTelemetry = new ChangeTrackingList<PlatformTelemetryDataSource>();
        }

        /// <summary> Initializes a new instance of <see cref="DataSourcesSpec"/>. </summary>
        /// <param name="performanceCounters"> The list of performance counter data source configurations. </param>
        /// <param name="windowsEventLogs"> The list of Windows Event Log data source configurations. </param>
        /// <param name="syslog"> The list of Syslog data source configurations. </param>
        /// <param name="extensions"> The list of Azure VM extension data source configurations. </param>
        /// <param name="logFiles"> The list of Log files source configurations. </param>
        /// <param name="iisLogs"> The list of IIS logs source configurations. </param>
        /// <param name="windowsFirewallLogs"> The list of Windows Firewall logs source configurations. </param>
        /// <param name="prometheusForwarder"> The list of Prometheus forwarder data source configurations. </param>
        /// <param name="platformTelemetry"> The list of platform telemetry configurations. </param>
        /// <param name="dataImports"> Specifications of pull based data sources. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataSourcesSpec(IList<PerfCounterDataSource> performanceCounters, IList<WindowsEventLogDataSource> windowsEventLogs, IList<SyslogDataSource> syslog, IList<ExtensionDataSource> extensions, IList<LogFilesDataSource> logFiles, IList<IisLogsDataSource> iisLogs, IList<WindowsFirewallLogsDataSource> windowsFirewallLogs, IList<PrometheusForwarderDataSource> prometheusForwarder, IList<PlatformTelemetryDataSource> platformTelemetry, DataSourcesSpecDataImports dataImports, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PerformanceCounters = performanceCounters;
            WindowsEventLogs = windowsEventLogs;
            Syslog = syslog;
            Extensions = extensions;
            LogFiles = logFiles;
            IisLogs = iisLogs;
            WindowsFirewallLogs = windowsFirewallLogs;
            PrometheusForwarder = prometheusForwarder;
            PlatformTelemetry = platformTelemetry;
            DataImports = dataImports;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of performance counter data source configurations. </summary>
        public IList<PerfCounterDataSource> PerformanceCounters { get; }
        /// <summary> The list of Windows Event Log data source configurations. </summary>
        public IList<WindowsEventLogDataSource> WindowsEventLogs { get; }
        /// <summary> The list of Syslog data source configurations. </summary>
        public IList<SyslogDataSource> Syslog { get; }
        /// <summary> The list of Azure VM extension data source configurations. </summary>
        public IList<ExtensionDataSource> Extensions { get; }
        /// <summary> The list of Log files source configurations. </summary>
        public IList<LogFilesDataSource> LogFiles { get; }
        /// <summary> The list of IIS logs source configurations. </summary>
        public IList<IisLogsDataSource> IisLogs { get; }
        /// <summary> The list of Windows Firewall logs source configurations. </summary>
        public IList<WindowsFirewallLogsDataSource> WindowsFirewallLogs { get; }
        /// <summary> The list of Prometheus forwarder data source configurations. </summary>
        public IList<PrometheusForwarderDataSource> PrometheusForwarder { get; }
        /// <summary> The list of platform telemetry configurations. </summary>
        public IList<PlatformTelemetryDataSource> PlatformTelemetry { get; }
        /// <summary> Specifications of pull based data sources. </summary>
        internal DataSourcesSpecDataImports DataImports { get; set; }
        /// <summary> Definition of Event Hub configuration. </summary>
        public DataImportSourcesEventHub DataImportsEventHub
        {
            get => DataImports is null ? default : DataImports.EventHub;
            set
            {
                if (DataImports is null)
                    DataImports = new DataSourcesSpecDataImports();
                DataImports.EventHub = value;
            }
        }
    }
}
