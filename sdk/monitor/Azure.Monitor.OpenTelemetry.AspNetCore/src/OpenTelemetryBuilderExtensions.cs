﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable enable

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Azure.Monitor.OpenTelemetry.Exporter;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OpenTelemetry;
using OpenTelemetry.Logs;
using OpenTelemetry.Metrics;
using OpenTelemetry.ResourceDetectors.Azure;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;
using Azure.Monitor.OpenTelemetry.Exporter.Internals.Platform;
using Microsoft.Extensions.Configuration;

namespace Azure.Monitor.OpenTelemetry.AspNetCore
{
    /// <summary>
    /// Extension methods for setting up Azure Monitor in an <see cref="OpenTelemetryBuilder" />.
    /// </summary>
    public static class OpenTelemetryBuilderExtensions
    {
        private const string SqlClientInstrumentationPackageName = "OpenTelemetry.Instrumentation.SqlClient";

        /// <summary>
        /// Configures Azure Monitor for logging, distributed tracing, and metrics.
        /// </summary>
        /// <param name="builder"><see cref="OpenTelemetryBuilder"/>.</param>
        /// <returns>The supplied <see cref="OpenTelemetryBuilder"/> for chaining calls.</returns>
        /// <remarks>
        /// <para>
        /// This method configures Azure Monitor for use with OpenTelemetry by adding the Azure Monitor exporter for logging,
        /// distributed tracing, and metrics. It also configures the OpenTelemetry logger to include formatted messages and
        /// parsed state values.
        /// </para>
        ///
        /// <para>The following vendored instrumentations are added for distributed tracing:</para>
        /// <list type="bullet">
        /// <item>ASP.NET Core.</item>
        /// <item>HTTP Client.</item>
        /// <item>SQL Client.</item>
        /// </list>
        /// </remarks>
#pragma warning disable CS0618 // Type or member is obsolete
        // Note: OpenTelemetryBuilder is obsolete because users should target
        // IOpenTelemetryBuilder for extensions but this method is valid and
        // expected to be called to obtain a root builder.
        public static OpenTelemetryBuilder UseAzureMonitor(this OpenTelemetryBuilder builder)
#pragma warning restore CS0618 // Type or member is obsolete
        {
            builder.Services.TryAddSingleton<IConfigureOptions<AzureMonitorOptions>,
                        DefaultAzureMonitorOptions>();
            return builder.UseAzureMonitor(o => { });
        }

        /// <summary>
        /// Configures Azure Monitor for logging, distributed tracing, and metrics.
        /// </summary>
        /// <param name="builder"><see cref="OpenTelemetryBuilder"/>.</param>
        /// <param name="configureAzureMonitor">Callback action for configuring <see cref="AzureMonitorOptions"/>.</param>
        /// <returns>The supplied <see cref="OpenTelemetryBuilder"/> for chaining calls.</returns>
        /// <remarks>
        /// <para>
        /// This method configures Azure Monitor for use with OpenTelemetry by adding the Azure Monitor exporter for logging,
        /// distributed tracing, and metrics. It also configures the OpenTelemetry logger to include formatted messages and
        /// parsed state values.
        /// </para>
        ///
        /// <para>The following vendored instrumentations are added for distributed tracing:</para>
        /// <list type="bullet">
        /// <item>ASP.NET Core.</item>
        /// <item>HTTP Client.</item>
        /// <item>SQL Client.</item>
        /// </list>
        /// </remarks>
#pragma warning disable CS0618 // Type or member is obsolete
        // Note: OpenTelemetryBuilder is obsolete because users should target
        // IOpenTelemetryBuilder for extensions but this method is valid and
        // expected to be called to obtain a root builder.
        public static OpenTelemetryBuilder UseAzureMonitor(this OpenTelemetryBuilder builder, Action<AzureMonitorOptions> configureAzureMonitor)
#pragma warning restore CS0618 // Type or member is obsolete
        {
            if (builder.Services == null)
            {
                throw new ArgumentNullException(nameof(builder.Services));
            }

            if (configureAzureMonitor != null)
            {
                builder.Services.Configure(configureAzureMonitor);
            }

            Action<ResourceBuilder> configureResource = (r) => r
                .AddAttributes(new[] { new KeyValuePair<string, object>("telemetry.distro.name", "Azure.Monitor.OpenTelemetry.AspNetCore") })
                .AddDetector(new AppServiceResourceDetector())
                .AddDetector(new AzureVMResourceDetector());

            builder.ConfigureResource(configureResource);

            builder.WithTracing(b => b
                            .AddSource("Azure.*")
                            .AddVendorInstrumentationIfPackageNotReferenced()
                            .AddAspNetCoreInstrumentation()
                            .AddHttpClientInstrumentation(o => o.FilterHttpRequestMessage = (_) =>
                            {
                                // Azure SDKs create their own client span before calling the service using HttpClient
                                // In this case, we would see two spans corresponding to the same operation
                                // 1) created by Azure SDK 2) created by HttpClient
                                // To prevent this duplication we are filtering the span from HttpClient
                                // as span from Azure SDK contains all relevant information needed.
                                var parentActivity = Activity.Current?.Parent;
                                if (parentActivity != null && parentActivity.Source.Name.Equals("Azure.Core.Http"))
                                {
                                    return false;
                                }
                                return true;
                            })
                            .AddAzureMonitorTraceExporter());

            builder.WithMetrics(b => b
                            .AddAzureMonitorMetricExporter());

            builder.Services.AddLogging(logging =>
            {
                logging.AddOpenTelemetry(builderOptions =>
                {
                    var resourceBuilder = ResourceBuilder.CreateDefault();
                    configureResource(resourceBuilder);
                    builderOptions.SetResourceBuilder(resourceBuilder);

                    builderOptions.IncludeFormattedMessage = true;
                    builderOptions.IncludeScopes = false;
                });
            });

            // Add AzureMonitorLogExporter to AzureMonitorOptions
            // once the service provider is available containing the final
            // AzureMonitorOptions.
            builder.Services.AddOptions<OpenTelemetryLoggerOptions>()
                    .Configure<IOptionsMonitor<AzureMonitorOptions>>((loggingOptions, azureOptions) =>
                    {
                        loggingOptions.AddAzureMonitorLogExporter(o => azureOptions.Get(Options.DefaultName).SetValueToExporterOptions(o));
                    });

            // Register a configuration action so that when
            // AzureMonitorExporterOptions is requested it is populated from
            // AzureMonitorOptions.
            builder.Services
                    .AddOptions<AzureMonitorExporterOptions>()
                    .Configure<IOptionsMonitor<AzureMonitorOptions>>((exporterOptions, azureMonitorOptions) =>
                    {
                        azureMonitorOptions.Get(Options.DefaultName).SetValueToExporterOptions(exporterOptions);
                    });

            builder.Services.AddOptions<AzureMonitorOptions>()
                .Configure<IConfiguration>((options, config) =>
                {
                    // This is a temporary workaround for hotfix GHSA-vh2m-22xx-q94f.
                    // https://github.com/open-telemetry/opentelemetry-dotnet/security/advisories/GHSA-vh2m-22xx-q94f
                    // We are disabling the workaround set by OpenTelemetry.Instrumentation.AspNetCore v1.8.1 and OpenTelemetry.Instrumentation.Http v1.8.1.
                    // The OpenTelemetry Community is deciding on an official stance on this issue and we will align with that final decision.
                    // TODO: FOLLOW UP ON: https://github.com/open-telemetry/semantic-conventions/pull/961 (2024-04-26)
                    if (config[EnvironmentVariableConstants.ASPNETCORE_DISABLE_URL_QUERY_REDACTION] == null)
                    {
                        config[EnvironmentVariableConstants.ASPNETCORE_DISABLE_URL_QUERY_REDACTION] = Boolean.TrueString;
                    }

                    if (config[EnvironmentVariableConstants.HTTPCLIENT_DISABLE_URL_QUERY_REDACTION] == null)
                    {
                        config[EnvironmentVariableConstants.HTTPCLIENT_DISABLE_URL_QUERY_REDACTION] = Boolean.TrueString;
                    }
                });

            return builder;
        }

        private static TracerProviderBuilder AddVendorInstrumentationIfPackageNotReferenced(this TracerProviderBuilder tracerProviderBuilder)
        {
            var vendorInstrumentationActions = new Dictionary<string, Action>
            {
                { SqlClientInstrumentationPackageName, () => tracerProviderBuilder.AddSqlClientInstrumentation() },
            };

            foreach (var packageActionPair in vendorInstrumentationActions)
            {
                Assembly? instrumentationAssembly = null;

                try
                {
                    instrumentationAssembly = Assembly.Load(packageActionPair.Key);
                    AzureMonitorAspNetCoreEventSource.Log.FoundInstrumentationPackageReference(packageActionPair.Key);
                }
                catch
                {
                    AzureMonitorAspNetCoreEventSource.Log.NoInstrumentationPackageReference(packageActionPair.Key);
                }

                if (instrumentationAssembly == null)
                {
                    packageActionPair.Value.Invoke();
                    AzureMonitorAspNetCoreEventSource.Log.VendorInstrumentationAdded(packageActionPair.Key);
                }
            }

            return tracerProviderBuilder;
        }
    }
}
