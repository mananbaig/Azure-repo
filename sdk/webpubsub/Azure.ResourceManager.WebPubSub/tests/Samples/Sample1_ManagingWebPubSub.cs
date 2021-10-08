﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
#region Snippet:Manage_WebPubSub_Namespaces
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.WebPubSub.Models;
using NUnit.Framework;
#endregion Snippet:Manage_WebPubSub_Namespaces

namespace Azure.ResourceManager.WebPubSub.Tests.Samples
{
    public class Sample1_ManagingWebPubSub
    {
        private ResourceGroup resourceGroup;

        [SetUp]
        protected async Task initialize()
        {
            #region Snippet:Readme_DefaultSubscription
            ArmClient armClient = new ArmClient(new DefaultAzureCredential());
            Subscription subscription = armClient.DefaultSubscription;
            #endregion

            #region Snippet:Readme_GetResourceGroupContainer
            ResourceGroupContainer rgContainer = subscription.GetResourceGroups();
            // With the container, we can create a new resource group with an specific name
            string rgName = "myRgName";
            Location location = Location.WestUS2;
            ResourceGroup resourceGroup = await rgContainer.CreateOrUpdate(rgName, new ResourceGroupData(location)).WaitForCompletionAsync();
            #endregion

            this.resourceGroup = resourceGroup;
        }

        [Test]
        [Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate()
        {
            #region Snippet:Managing_WebPubSub_CreateWebPubSub
            WebPubSubResourceContainer webPubSubResourceContainer = resourceGroup.GetWebPubSubResources();

            string webPubSubName = "myWebPubSubName";

            // Use the same location as the resource group
            IList<LiveTraceCategory> categories = new List<LiveTraceCategory>();
            categories.Add(new LiveTraceCategory("category-01", "true"));

            ACLAction aCLAction = new ACLAction("Deny");
            IList<WebPubSubRequestType> allow = new List<WebPubSubRequestType>();
            IList<WebPubSubRequestType> deny = new List<WebPubSubRequestType>();
            deny.Add(new WebPubSubRequestType("RESTAPI"));
            NetworkACL publicNetwork = new NetworkACL(allow, deny);
            IList<PrivateEndpointACL> privateEndpoints = new List<PrivateEndpointACL>();

            List<ResourceLogCategory> resourceLogCategory = new List<ResourceLogCategory>()
            {
                new ResourceLogCategory(){ Name = "category1", Enabled = "false" }
            };
            WebPubSubResourceData data = new WebPubSubResourceData(Location.WestUS2)
            {
                Sku = new ResourceSku("Standard_S1"),
                LiveTraceConfiguration = new LiveTraceConfiguration("true", categories),
                NetworkACLs = new WebPubSubNetworkACLs(aCLAction, publicNetwork, privateEndpoints),
                ResourceLogConfiguration = new ResourceLogConfiguration(resourceLogCategory),
            };

            WebPubSubResource webPubSub = await (await webPubSubResourceContainer.CreateOrUpdateAsync(webPubSubName, data)).WaitForCompletionAsync();

            #endregion
        }

        [Test]
        [Ignore("Only verifying that the sample builds")]
        public async Task List()
        {
            #region Snippet:Managing_WebPubSub_ListAllWebPubSub
            WebPubSubResourceContainer webPubSubResourceContainer = resourceGroup.GetWebPubSubResources();

            AsyncPageable<WebPubSubResource> response = webPubSubResourceContainer.GetAllAsync();
            await foreach (WebPubSubResource WebPubSubResource in response)
            {
                Console.WriteLine(WebPubSubResource.Data.Name);
            }
            #endregion
        }

        [Test]
        [Ignore("Only verifying that the sample builds")]
        public async Task Get()
        {
            #region Snippet:Managing_WebPubSub_GetWebPubSub
            WebPubSubResourceContainer webPubSubResourceContainer = resourceGroup.GetWebPubSubResources();

            WebPubSubResource webPubSub = await webPubSubResourceContainer.GetAsync("myWebPubSubName");
            Console.WriteLine(webPubSub.Data.Name);
            #endregion
        }

        [Test]
        [Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists()
        {
            #region Snippet:Managing_WebPubSub_GetWebPubSubIfExists
            WebPubSubResourceContainer webPubSubResourceContainer = resourceGroup.GetWebPubSubResources();

            WebPubSubResource webPubSub = await webPubSubResourceContainer.GetIfExistsAsync("foo");
            if (webPubSub != null)
            {
                Console.WriteLine(webPubSub.Data.Name);
            }

            if (await webPubSubResourceContainer.CheckIfExistsAsync("bar"))
            {
                Console.WriteLine("WebPubSub 'bar' exists.");
            }
            #endregion
        }

        [Test]
        [Ignore("Only verifying that the sample builds")]
        public async Task DeleteVirtualWebPubSub()
        {
            #region Snippet:Managing_WebPubSub_DeleteWebPubSub
            WebPubSubResourceContainer webPubSubResourceContainer = resourceGroup.GetWebPubSubResources();

            WebPubSubResource webPubSub = await webPubSubResourceContainer.GetAsync("myWebPubSubName");
            await webPubSub.DeleteAsync();
            #endregion
        }
    }
}
