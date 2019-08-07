﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

namespace ContainerRegistry.Tests
{
    using Microsoft.Azure.ContainerRegistry;
    using Microsoft.Azure.ContainerRegistry.Models;
    using Microsoft.Rest;
    using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
    using System.Threading.Tasks;
    using Xunit;

    public class RepositoryTests
    {

        [Fact]
        public async Task ListRepository()
        {
            using (var context = MockContext.Start(GetType().FullName, nameof(ListRepository)))
            {
                var client = await ACRTestUtil.GetACRClientAsync(context, ACRTestUtil.ManagedTestRegistry);
                var repositories = await client.GetRepositoriesAsync(null, 1);

                Assert.Equal(1, repositories.Names.Count);
                Assert.Collection(repositories.Names, name => Assert.Equal(ACRTestUtil.ProdRepository, name));
            }
        }

        [Fact]
        public async Task GetAcrRepositoryDetails()
        {
            using (var context = MockContext.Start(GetType().FullName, nameof(GetAcrRepositoryDetails)))
            {
                var client = await ACRTestUtil.GetACRClientAsync(context, ACRTestUtil.ManagedTestRegistry);
                var repositoryDetails = await client.GetAcrRepositoryAttributesAsync(ACRTestUtil.ProdRepository);
                
                Assert.Equal(ACRTestUtil.ManagedTestRegistryFullName, repositoryDetails.Registry);
                Assert.Equal(2, repositoryDetails.TagCount);
                Assert.Equal(2, repositoryDetails.ManifestCount);
                Assert.Equal("2019-08-01T22:49:11.1632015Z", repositoryDetails.CreatedTime);
                Assert.Equal(ACRTestUtil.ProdRepository, repositoryDetails.ImageName);
                Assert.False(repositoryDetails.ChangeableAttributes.DeleteEnabled);
                Assert.True(repositoryDetails.ChangeableAttributes.ListEnabled);
                Assert.True(repositoryDetails.ChangeableAttributes.ReadEnabled);
                Assert.False(repositoryDetails.ChangeableAttributes.WriteEnabled);
            }
        }


        [Fact]
        public async Task GetAcrRepositories()
        {
            using (var context = MockContext.Start(GetType().FullName, nameof(GetAcrRepositories)))
            {
                var client = await ACRTestUtil.GetACRClientAsync(context, ACRTestUtil.ManagedTestRegistry);
                var repositories = await client.GetAcrRepositoriesAsync();
                Assert.Equal(2, repositories.Names.Count);
                Assert.Collection(repositories.Names, name => Assert.Equal(ACRTestUtil.ProdRepository, name),
                                                      name => Assert.Equal(ACRTestUtil.TestRepository, name));
            }
        }

        [Fact]
        public async Task DeleteAcrRepository()
        {
            using (var context = MockContext.Start(GetType().FullName, nameof(DeleteAcrRepository)))
            {
                var client = await ACRTestUtil.GetACRClientAsync(context, ACRTestUtil.ManagedTestRegistryForChanges);
                var repositories = await client.GetAcrRepositoriesAsync();

                //Selects one of the previously stored hello-world repositories for deletion
                string deletableRepo = "";
                foreach (var repo in repositories.Names) {
                    if (repo.StartsWith("hello-world")) {
                        deletableRepo = repo;
                        continue;
                    }
                }
                var deletedRepo = await client.DeleteAcrRepositoryAsync(deletableRepo);

                Assert.Equal(1, deletedRepo.ManifestsDeleted.Count);
                Assert.Equal("sha256:92c7f9c92844bbbb5d0a101b22f7c2a7949e40f8ea90c8b3bc396879d95e899a", deletedRepo.ManifestsDeleted[0]);
                Assert.Equal(1, deletedRepo.TagsDeleted.Count);
                Assert.Collection(deletedRepo.TagsDeleted, tag => Assert.Equal("latest", tag));
            }
        }

        [Fact]
        public async Task UpdateAcrRepositoryAttributes()
        {
            using (var context = MockContext.Start(GetType().FullName, nameof(UpdateAcrRepositoryAttributes)))
            {
                var client = await ACRTestUtil.GetACRClientAsync(context, ACRTestUtil.ManagedTestRegistryForChanges);

                //Changeable attributes
                var updateAttributes = new ChangeableAttributes() { DeleteEnabled = false, ListEnabled = true, ReadEnabled = true, WriteEnabled = false };
                await client.UpdateAcrRepositoryAttributesAsync(ACRTestUtil.changeableRepository, updateAttributes); 

                //Check success
                var repositoryDetails = await client.GetAcrRepositoryAttributesAsync(ACRTestUtil.changeableRepository);
                Assert.Equal(1, repositoryDetails.TagCount);
                Assert.Equal(1, repositoryDetails.ManifestCount);
                Assert.Equal(ACRTestUtil.changeableRepository, repositoryDetails.ImageName);
                Assert.False(repositoryDetails.ChangeableAttributes.DeleteEnabled);
                Assert.True(repositoryDetails.ChangeableAttributes.ListEnabled);
                Assert.True(repositoryDetails.ChangeableAttributes.ReadEnabled);
                Assert.False(repositoryDetails.ChangeableAttributes.WriteEnabled);

                //Undo change
                updateAttributes.WriteEnabled = true;
                updateAttributes.DeleteEnabled = true;
                await client.UpdateAcrRepositoryAttributesAsync(ACRTestUtil.changeableRepository, updateAttributes);
            }
        }

    }
}
