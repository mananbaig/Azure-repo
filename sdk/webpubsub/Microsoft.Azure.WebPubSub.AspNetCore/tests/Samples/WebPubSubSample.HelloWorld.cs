﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#if NETCOREAPP3_1_OR_GREATER
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Azure.WebPubSub.Common;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Azure.WebPubSub.AspNetCore.Tests.Samples
{
    public class WebPubSubSample
    {
        #region Snippet:WebPubSubDependencyInjection
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddWebPubSub(o =>
            {
                o.ServiceEndpoint = new("<connection-string>");
            }).AddWebPubSubServiceClient<SampleHub>();
        }
        #endregion

        #region Snippet:WebPubSubMapHub
        public void Configure(IApplicationBuilder app)
        {
            app.UseEndpoints(endpoint =>
            {
                endpoint.MapWebPubSubHub<SampleHub>("/eventhandler");
            });
        }
        #endregion

        private sealed class SampleHub : WebPubSubHub
        {
            internal WebPubSubServiceClient<SampleHub> _serviceClient;

            // Need to ensure is injected by call `AddServiceHub<SampleHub>` in ConfigureServices.
            public SampleHub(WebPubSubServiceClient<SampleHub> serviceClient)
            {
                _serviceClient = serviceClient;
            }

            #region Snippet:WebPubSubConnectMethods
            public override ValueTask<ConnectEventResponse> OnConnectAsync(ConnectEventRequest request, CancellationToken cancellationToken)
            {
                var response = new ConnectEventResponse
                {
                    UserId = request.ConnectionContext.UserId
                };
                return new ValueTask<ConnectEventResponse>(response);
            }
            #endregion

            public override ValueTask<UserEventResponse> OnMessageReceivedAsync(UserEventRequest request, CancellationToken cancellationToken)
            {
                return base.OnMessageReceivedAsync(request, cancellationToken);
            }
        }
    }
}
#endif