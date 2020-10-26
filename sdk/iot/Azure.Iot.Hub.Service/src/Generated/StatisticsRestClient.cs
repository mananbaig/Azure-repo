// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Iot.Hub.Service.Models;

namespace Azure.Iot.Hub.Service
{
    internal partial class StatisticsRestClient
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of StatisticsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public StatisticsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null, string apiVersion = "2020-03-13")
        {
            endpoint ??= new Uri("https://fully-qualified-iothubname.azure-devices.net");
            if (apiVersion == null)
            {
                throw new ArgumentNullException(nameof(apiVersion));
            }

            this.endpoint = endpoint;
            this.apiVersion = apiVersion;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetDeviceStatisticsRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/statistics/devices", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets device statistics of the IoT Hub identity registry, such as total device count. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<DevicesStatistics>> GetDeviceStatisticsAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetDeviceStatisticsRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DevicesStatistics value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DevicesStatistics.DeserializeDevicesStatistics(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets device statistics of the IoT Hub identity registry, such as total device count. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<DevicesStatistics> GetDeviceStatistics(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetDeviceStatisticsRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DevicesStatistics value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DevicesStatistics.DeserializeDevicesStatistics(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetServiceStatisticsRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/statistics/service", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets service statistics of the IoT Hub identity registry, such as connected device count. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<ServiceStatistics>> GetServiceStatisticsAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetServiceStatisticsRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceStatistics value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ServiceStatistics.DeserializeServiceStatistics(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets service statistics of the IoT Hub identity registry, such as connected device count. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ServiceStatistics> GetServiceStatistics(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetServiceStatisticsRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceStatistics value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ServiceStatistics.DeserializeServiceStatistics(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
