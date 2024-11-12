// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ManagedServices.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ManagedServices.Samples
{
    public partial class Sample_ManagedServicesRegistrationAssignmentResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetRegistrationAssignment()
        {
            // Generated from example definition: specification/managedservices/resource-manager/Microsoft.ManagedServices/stable/2022-10-01/examples/GetRegistrationAssignment.json
            // this example is just showing the usage of "RegistrationAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedServicesRegistrationAssignmentResource created on azure
            // for more information of creating ManagedServicesRegistrationAssignmentResource, please refer to the document of ManagedServicesRegistrationAssignmentResource
            string scope = "subscription/0afefe50-734e-4610-8a82-a144ahf49dea";
            string registrationAssignmentId = "26c128c2-fefa-4340-9bb1-6e081c90ada2";
            ResourceIdentifier managedServicesRegistrationAssignmentResourceId = ManagedServicesRegistrationAssignmentResource.CreateResourceIdentifier(scope, registrationAssignmentId);
            ManagedServicesRegistrationAssignmentResource managedServicesRegistrationAssignment = client.GetManagedServicesRegistrationAssignmentResource(managedServicesRegistrationAssignmentResourceId);

            // invoke the operation
            ManagedServicesRegistrationAssignmentResource result = await managedServicesRegistrationAssignment.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedServicesRegistrationAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteRegistrationAssignment()
        {
            // Generated from example definition: specification/managedservices/resource-manager/Microsoft.ManagedServices/stable/2022-10-01/examples/DeleteRegistrationAssignment.json
            // this example is just showing the usage of "RegistrationAssignments_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedServicesRegistrationAssignmentResource created on azure
            // for more information of creating ManagedServicesRegistrationAssignmentResource, please refer to the document of ManagedServicesRegistrationAssignmentResource
            string scope = "subscription/0afefe50-734e-4610-8a82-a144ahf49dea";
            string registrationAssignmentId = "26c128c2-fefa-4340-9bb1-6e081c90ada2";
            ResourceIdentifier managedServicesRegistrationAssignmentResourceId = ManagedServicesRegistrationAssignmentResource.CreateResourceIdentifier(scope, registrationAssignmentId);
            ManagedServicesRegistrationAssignmentResource managedServicesRegistrationAssignment = client.GetManagedServicesRegistrationAssignmentResource(managedServicesRegistrationAssignmentResourceId);

            // invoke the operation
            await managedServicesRegistrationAssignment.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_PutRegistrationAssignment()
        {
            // Generated from example definition: specification/managedservices/resource-manager/Microsoft.ManagedServices/stable/2022-10-01/examples/PutRegistrationAssignment.json
            // this example is just showing the usage of "RegistrationAssignments_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedServicesRegistrationAssignmentResource created on azure
            // for more information of creating ManagedServicesRegistrationAssignmentResource, please refer to the document of ManagedServicesRegistrationAssignmentResource
            string scope = "subscription/0afefe50-734e-4610-8a82-a144ahf49dea";
            string registrationAssignmentId = "26c128c2-fefa-4340-9bb1-6e081c90ada2";
            ResourceIdentifier managedServicesRegistrationAssignmentResourceId = ManagedServicesRegistrationAssignmentResource.CreateResourceIdentifier(scope, registrationAssignmentId);
            ManagedServicesRegistrationAssignmentResource managedServicesRegistrationAssignment = client.GetManagedServicesRegistrationAssignmentResource(managedServicesRegistrationAssignmentResourceId);

            // invoke the operation
            ManagedServicesRegistrationAssignmentData data = new ManagedServicesRegistrationAssignmentData()
            {
                Properties = new ManagedServicesRegistrationAssignmentProperties(new ResourceIdentifier("/subscriptions/0afefe50-734e-4610-8a82-a144ahf49dea/providers/Microsoft.ManagedServices/registrationDefinitions/26c128c2-fefa-4340-9bb1-6e081c90ada2")),
            };
            ArmOperation<ManagedServicesRegistrationAssignmentResource> lro = await managedServicesRegistrationAssignment.UpdateAsync(WaitUntil.Completed, data);
            ManagedServicesRegistrationAssignmentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedServicesRegistrationAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
