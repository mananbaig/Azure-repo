// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core.Extensions;
using Azure.Health.Deidentification;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="DeidentificationClient"/> to client builder. </summary>
    public static partial class HealthDeidentificationClientBuilderExtensions
    {
        /// <summary> Registers a <see cref="DeidentificationClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> Url of your De-identification Service. </param>
        public static IAzureClientBuilder<DeidentificationClient, DeidentificationClientOptions> AddDeidentificationClient<TBuilder>(this TBuilder builder, Uri endpoint)
        where TBuilder : IAzureClientFactoryBuilderWithCredential
        {
            return builder.RegisterClientFactory<DeidentificationClient, DeidentificationClientOptions>((options, cred) => new DeidentificationClient(endpoint, cred, options));
        }

        /// <summary> Registers a <see cref="DeidentificationClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<DeidentificationClient, DeidentificationClientOptions> AddDeidentificationClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<DeidentificationClient, DeidentificationClientOptions>(configuration);
        }
    }
}
