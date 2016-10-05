﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.Management.Resource.Fluent.Authentication;
using Microsoft.Azure.Management.Resource.Fluent.Core;
using System.Linq;
using Xunit;
using static Microsoft.Azure.Management.Resource.Fluent.ResourceManager;

namespace Fluent.Tests.ResourceManager
{
    public class SubscriptionsTests
    {
        [Fact(Skip = "TODO: Convert to recorded tests")]
        public void CanListSubscriptions()
        {
            var resourceManager = CreateResourceManager();
            var subscriptions = resourceManager.Subscriptions.List();
            Assert.True(subscriptions.Count > 0);
        }

        [Fact(Skip = "TODO: Convert to recorded tests")]
        public void CanListLocations()
        {
            var resourceManager = CreateResourceManager();
            var subscription = resourceManager.Subscriptions.List().First();
            var locations = subscription.ListLocations();
            Assert.True(locations.Count > 0);
        }

        private IAuthenticated CreateResourceManager()
        {
            AzureCredentials credentials = AzureCredentials.FromFile(@"C:\my.azureauth");
            IAuthenticated resourceManager = Microsoft.Azure.Management.Resource.Fluent.ResourceManager.Configure()
                .WithLogLevel(HttpLoggingDelegatingHandler.Level.BODY)
                .Authenticate(credentials);
            return resourceManager;
        }
    }
}
