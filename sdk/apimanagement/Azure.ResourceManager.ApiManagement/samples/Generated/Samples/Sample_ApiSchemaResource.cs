// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ApiSchemaResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetEntityTag_ApiManagementHeadApiSchema()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementHeadApiSchema.json
            // this example is just showing the usage of "ApiSchema_GetEntityTag" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiSchemaResource created on azure
            // for more information of creating ApiSchemaResource, please refer to the document of ApiSchemaResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "57d1f7558aa04f15146d9d8a";
            string schemaId = "ec12520d-9d48-4e7b-8f39-698ca2ac63f1";
            ResourceIdentifier apiSchemaResourceId = ApiSchemaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, schemaId);
            ApiSchemaResource apiSchema = client.GetApiSchemaResource(apiSchemaResourceId);

            // invoke the operation
            bool result = await apiSchema.GetEntityTagAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ApiManagementGetApiSchema()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementGetApiSchema.json
            // this example is just showing the usage of "ApiSchema_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiSchemaResource created on azure
            // for more information of creating ApiSchemaResource, please refer to the document of ApiSchemaResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "59d6bb8f1f7fab13dc67ec9b";
            string schemaId = "ec12520d-9d48-4e7b-8f39-698ca2ac63f1";
            ResourceIdentifier apiSchemaResourceId = ApiSchemaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, schemaId);
            ApiSchemaResource apiSchema = client.GetApiSchemaResource(apiSchemaResourceId);

            // invoke the operation
            ApiSchemaResource result = await apiSchema.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiSchemaData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ApiManagementCreateApiSchema()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementCreateApiSchema.json
            // this example is just showing the usage of "ApiSchema_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiSchemaResource created on azure
            // for more information of creating ApiSchemaResource, please refer to the document of ApiSchemaResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "59d6bb8f1f7fab13dc67ec9b";
            string schemaId = "ec12520d-9d48-4e7b-8f39-698ca2ac63f1";
            ResourceIdentifier apiSchemaResourceId = ApiSchemaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, schemaId);
            ApiSchemaResource apiSchema = client.GetApiSchemaResource(apiSchemaResourceId);

            // invoke the operation
            ApiSchemaData data = new ApiSchemaData()
            {
                ContentType = "application/vnd.ms-azure-apim.xsd+xml",
                Value = "<s:schema elementFormDefault=\"qualified\" targetNamespace=\"http://ws.cdyne.com/WeatherWS/\" xmlns:tns=\"http://ws.cdyne.com/WeatherWS/\" xmlns:s=\"http://www.w3.org/2001/XMLSchema\" xmlns:soap12=\"http://schemas.xmlsoap.org/wsdl/soap12/\" xmlns:mime=\"http://schemas.xmlsoap.org/wsdl/mime/\" xmlns:soap=\"http://schemas.xmlsoap.org/wsdl/soap/\" xmlns:tm=\"http://microsoft.com/wsdl/mime/textMatching/\" xmlns:http=\"http://schemas.xmlsoap.org/wsdl/http/\" xmlns:soapenc=\"http://schemas.xmlsoap.org/soap/encoding/\" xmlns:wsdl=\"http://schemas.xmlsoap.org/wsdl/\" xmlns:apim-wsdltns=\"http://ws.cdyne.com/WeatherWS/\">\r\n  <s:element name=\"GetWeatherInformation\">\r\n    <s:complexType />\r\n  </s:element>\r\n  <s:element name=\"GetWeatherInformationResponse\">\r\n    <s:complexType>\r\n      <s:sequence>\r\n        <s:element minOccurs=\"0\" maxOccurs=\"1\" name=\"GetWeatherInformationResult\" type=\"tns:ArrayOfWeatherDescription\" />\r\n      </s:sequence>\r\n    </s:complexType>\r\n  </s:element>\r\n  <s:complexType name=\"ArrayOfWeatherDescription\">\r\n    <s:sequence>\r\n      <s:element minOccurs=\"0\" maxOccurs=\"unbounded\" name=\"WeatherDescription\" type=\"tns:WeatherDescription\" />\r\n    </s:sequence>\r\n  </s:complexType>\r\n  <s:complexType name=\"WeatherDescription\">\r\n    <s:sequence>\r\n      <s:element minOccurs=\"1\" maxOccurs=\"1\" name=\"WeatherID\" type=\"s:short\" />\r\n      <s:element minOccurs=\"0\" maxOccurs=\"1\" name=\"Description\" type=\"s:string\" />\r\n      <s:element minOccurs=\"0\" maxOccurs=\"1\" name=\"PictureURL\" type=\"s:string\" />\r\n    </s:sequence>\r\n  </s:complexType>\r\n  <s:element name=\"GetCityForecastByZIP\">\r\n    <s:complexType>\r\n      <s:sequence>\r\n        <s:element minOccurs=\"0\" maxOccurs=\"1\" name=\"ZIP\" type=\"s:string\" />\r\n      </s:sequence>\r\n    </s:complexType>\r\n  </s:element>\r\n  <s:element name=\"GetCityForecastByZIPResponse\">\r\n    <s:complexType>\r\n      <s:sequence>\r\n        <s:element minOccurs=\"0\" maxOccurs=\"1\" name=\"GetCityForecastByZIPResult\" type=\"tns:ForecastReturn\" />\r\n      </s:sequence>\r\n    </s:complexType>\r\n  </s:element>\r\n  <s:complexType name=\"ForecastReturn\">\r\n    <s:sequence>\r\n      <s:element minOccurs=\"1\" maxOccurs=\"1\" name=\"Success\" type=\"s:boolean\" />\r\n      <s:element minOccurs=\"0\" maxOccurs=\"1\" name=\"ResponseText\" type=\"s:string\" />\r\n      <s:element minOccurs=\"0\" maxOccurs=\"1\" name=\"State\" type=\"s:string\" />\r\n      <s:element minOccurs=\"0\" maxOccurs=\"1\" name=\"City\" type=\"s:string\" />\r\n      <s:element minOccurs=\"0\" maxOccurs=\"1\" name=\"WeatherStationCity\" type=\"s:string\" />\r\n      <s:element minOccurs=\"0\" maxOccurs=\"1\" name=\"ForecastResult\" type=\"tns:ArrayOfForecast\" />\r\n    </s:sequence>\r\n  </s:complexType>\r\n  <s:complexType name=\"ArrayOfForecast\">\r\n    <s:sequence>\r\n      <s:element minOccurs=\"0\" maxOccurs=\"unbounded\" name=\"Forecast\" nillable=\"true\" type=\"tns:Forecast\" />\r\n    </s:sequence>\r\n  </s:complexType>\r\n  <s:complexType name=\"Forecast\">\r\n    <s:sequence>\r\n      <s:element minOccurs=\"1\" maxOccurs=\"1\" name=\"Date\" type=\"s:dateTime\" />\r\n      <s:element minOccurs=\"1\" maxOccurs=\"1\" name=\"WeatherID\" type=\"s:short\" />\r\n      <s:element minOccurs=\"0\" maxOccurs=\"1\" name=\"Desciption\" type=\"s:string\" />\r\n      <s:element minOccurs=\"1\" maxOccurs=\"1\" name=\"Temperatures\" type=\"tns:temp\" />\r\n      <s:element minOccurs=\"1\" maxOccurs=\"1\" name=\"ProbabilityOfPrecipiation\" type=\"tns:POP\" />\r\n    </s:sequence>\r\n  </s:complexType>\r\n  <s:complexType name=\"temp\">\r\n    <s:sequence>\r\n      <s:element minOccurs=\"0\" maxOccurs=\"1\" name=\"MorningLow\" type=\"s:string\" />\r\n      <s:element minOccurs=\"0\" maxOccurs=\"1\" name=\"DaytimeHigh\" type=\"s:string\" />\r\n    </s:sequence>\r\n  </s:complexType>\r\n  <s:complexType name=\"POP\">\r\n    <s:sequence>\r\n      <s:element minOccurs=\"0\" maxOccurs=\"1\" name=\"Nighttime\" type=\"s:string\" />\r\n      <s:element minOccurs=\"0\" maxOccurs=\"1\" name=\"Daytime\" type=\"s:string\" />\r\n    </s:sequence>\r\n  </s:complexType>\r\n  <s:element name=\"GetCityWeatherByZIP\">\r\n    <s:complexType>\r\n      <s:sequence>\r\n        <s:element minOccurs=\"0\" maxOccurs=\"1\" name=\"ZIP\" type=\"s:string\" />\r\n      </s:sequence>\r\n    </s:complexType>\r\n  </s:element>\r\n  <s:element name=\"GetCityWeatherByZIPResponse\">\r\n    <s:complexType>\r\n      <s:sequence>\r\n        <s:element minOccurs=\"1\" maxOccurs=\"1\" name=\"GetCityWeatherByZIPResult\" type=\"tns:WeatherReturn\" />\r\n      </s:sequence>\r\n    </s:complexType>\r\n  </s:element>\r\n  <s:complexType name=\"WeatherReturn\">\r\n    <s:sequence>\r\n      <s:element minOccurs=\"1\" maxOccurs=\"1\" name=\"Success\" type=\"s:boolean\" />\r\n      <s:element minOccurs=\"0\" maxOccurs=\"1\" name=\"ResponseText\" type=\"s:string\" />\r\n      <s:element minOccurs=\"0\" maxOccurs=\"1\" name=\"State\" type=\"s:string\" />\r\n      <s:element minOccurs=\"0\" maxOccurs=\"1\" name=\"City\" type=\"s:string\" />\r\n      <s:element minOccurs=\"0\" maxOccurs=\"1\" name=\"WeatherStationCity\" type=\"s:string\" />\r\n      <s:element minOccurs=\"1\" maxOccurs=\"1\" name=\"WeatherID\" type=\"s:short\" />\r\n      <s:element minOccurs=\"0\" maxOccurs=\"1\" name=\"Description\" type=\"s:string\" />\r\n      <s:element minOccurs=\"0\" maxOccurs=\"1\" name=\"Temperature\" type=\"s:string\" />\r\n      <s:element minOccurs=\"0\" maxOccurs=\"1\" name=\"RelativeHumidity\" type=\"s:string\" />\r\n      <s:element minOccurs=\"0\" maxOccurs=\"1\" name=\"Wind\" type=\"s:string\" />\r\n      <s:element minOccurs=\"0\" maxOccurs=\"1\" name=\"Pressure\" type=\"s:string\" />\r\n      <s:element minOccurs=\"0\" maxOccurs=\"1\" name=\"Visibility\" type=\"s:string\" />\r\n      <s:element minOccurs=\"0\" maxOccurs=\"1\" name=\"WindChill\" type=\"s:string\" />\r\n      <s:element minOccurs=\"0\" maxOccurs=\"1\" name=\"Remarks\" type=\"s:string\" />\r\n    </s:sequence>\r\n  </s:complexType>\r\n  <s:element name=\"ArrayOfWeatherDescription\" nillable=\"true\" type=\"tns:ArrayOfWeatherDescription\" />\r\n  <s:element name=\"ForecastReturn\" nillable=\"true\" type=\"tns:ForecastReturn\" />\r\n  <s:element name=\"WeatherReturn\" type=\"tns:WeatherReturn\" />\r\n</s:schema>",
            };
            ArmOperation<ApiSchemaResource> lro = await apiSchema.UpdateAsync(WaitUntil.Completed, data);
            ApiSchemaResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiSchemaData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_ApiManagementDeleteApiSchema()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementDeleteApiSchema.json
            // this example is just showing the usage of "ApiSchema_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiSchemaResource created on azure
            // for more information of creating ApiSchemaResource, please refer to the document of ApiSchemaResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "59d5b28d1f7fab116c282650";
            string schemaId = "59d5b28e1f7fab116402044e";
            ResourceIdentifier apiSchemaResourceId = ApiSchemaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, schemaId);
            ApiSchemaResource apiSchema = client.GetApiSchemaResource(apiSchemaResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            await apiSchema.DeleteAsync(WaitUntil.Completed, ifMatch);

            Console.WriteLine("Succeeded");
        }
    }
}
