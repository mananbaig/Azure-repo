// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.MachineLearning.WebServices.Models
{
    using System.Linq;

    /// <summary>
    /// The set of properties specific to the Azure ML web service resource.
    /// </summary>
    public partial class WebServiceProperties
    {
        /// <summary>
        /// Initializes a new instance of the WebServiceProperties class.
        /// </summary>
        public WebServiceProperties() { }

        /// <summary>
        /// Initializes a new instance of the WebServiceProperties class.
        /// </summary>
        /// <param name="title">The title of the web service.</param>
        /// <param name="description">The description of the web
        /// service.</param>
        /// <param name="createdOn">Read Only: The date and time when the web
        /// service was created.</param>
        /// <param name="modifiedOn">Read Only: The date and time when the web
        /// service was last modified.</param>
        /// <param name="provisioningState">Read Only: The provision state of
        /// the web service. Valid values are Unknown, Provisioning,
        /// Succeeded, and Failed. Possible values include: 'Unknown',
        /// 'Provisioning', 'Succeeded', 'Failed'</param>
        /// <param name="keys">Contains the web service provisioning keys. If
        /// you do not specify provisioning keys, the Azure Machine Learning
        /// system generates them for you. Note: The keys are not returned
        /// from calls to GET operations.</param>
        /// <param name="readOnlyProperty">When set to true, indicates that
        /// the web service is read-only and can no longer be updated or
        /// patched, only removed. Default, is false. Note: Once set to true,
        /// you cannot change its value.</param>
        /// <param name="swaggerLocation">Read Only: Contains the URI of the
        /// swagger spec associated with this web service.</param>
        /// <param name="exposeSampleData">When set to true, sample data is
        /// included in the web service's swagger definition. The default
        /// value is true.</param>
        /// <param name="realtimeConfiguration">Contains the configuration
        /// settings for the web service endpoint.</param>
        /// <param name="diagnostics">Settings controlling the diagnostics
        /// traces collection for the web service.</param>
        /// <param name="storageAccount">Specifies the storage account that
        /// Azure Machine Learning uses to store information about the web
        /// service. Only the name of the storage account is returned from
        /// calls to GET operations. When updating the storage account
        /// information, you must ensure that all necessary assets are
        /// available in the new storage account or calls to your web service
        /// will fail.</param>
        /// <param name="machineLearningWorkspace">Specifies the Machine
        /// Learning workspace containing the experiment that is source for
        /// the web service.</param>
        /// <param name="commitmentPlan">Contains the commitment plan
        /// associated with this web service. Set at creation time. Once set,
        /// this value cannot be changed. Note: The commitment plan is not
        /// returned from calls to GET operations.</param>
        /// <param name="input">Contains the Swagger 2.0 schema describing one
        /// or more of the web service's inputs. For more information, see
        /// the Swagger specification.</param>
        /// <param name="output">Contains the Swagger 2.0 schema describing
        /// one or more of the web service's outputs. For more information,
        /// see the Swagger specification.</param>
        /// <param name="exampleRequest">Defines sample input data for one or
        /// more of the service's inputs.</param>
        /// <param name="assets">Contains user defined properties describing
        /// web service assets. Properties are expressed as Key/Value
        /// pairs.</param>
        /// <param name="parameters">The set of global parameters values
        /// defined for the web service, given as a global parameter name to
        /// default value map. If no default value is specified, the
        /// parameter is considered to be required.</param>
        /// <param name="payloadsInBlobStorage">If
        /// Assets+Input+Output+Package+Parameters+ExampleRequest is too
        /// large (> 3MB), this field will be set to true and the content
        /// will be put into a blob. Otherwise, this will be set to false and
        /// Assets, Input, Output, Package, Parameters, ExampleRequest will
        /// be inline.</param>
        /// <param name="payloadsLocation">Blob location of the large
        /// payload.</param>
        public WebServiceProperties(string title = default(string), string description = default(string), System.DateTime? createdOn = default(System.DateTime?), System.DateTime? modifiedOn = default(System.DateTime?), string provisioningState = default(string), WebServiceKeys keys = default(WebServiceKeys), bool? readOnlyProperty = default(bool?), string swaggerLocation = default(string), bool? exposeSampleData = default(bool?), RealtimeConfiguration realtimeConfiguration = default(RealtimeConfiguration), DiagnosticsConfiguration diagnostics = default(DiagnosticsConfiguration), StorageAccount storageAccount = default(StorageAccount), MachineLearningWorkspace machineLearningWorkspace = default(MachineLearningWorkspace), CommitmentPlan commitmentPlan = default(CommitmentPlan), ServiceInputOutputSpecification input = default(ServiceInputOutputSpecification), ServiceInputOutputSpecification output = default(ServiceInputOutputSpecification), ExampleRequest exampleRequest = default(ExampleRequest), System.Collections.Generic.IDictionary<string, AssetItem> assets = default(System.Collections.Generic.IDictionary<string, AssetItem>), System.Collections.Generic.IDictionary<string, WebServiceParameter> parameters = default(System.Collections.Generic.IDictionary<string, WebServiceParameter>), bool? payloadsInBlobStorage = default(bool?), BlobLocation payloadsLocation = default(BlobLocation))
        {
            Title = title;
            Description = description;
            CreatedOn = createdOn;
            ModifiedOn = modifiedOn;
            ProvisioningState = provisioningState;
            Keys = keys;
            ReadOnlyProperty = readOnlyProperty;
            SwaggerLocation = swaggerLocation;
            ExposeSampleData = exposeSampleData;
            RealtimeConfiguration = realtimeConfiguration;
            Diagnostics = diagnostics;
            StorageAccount = storageAccount;
            MachineLearningWorkspace = machineLearningWorkspace;
            CommitmentPlan = commitmentPlan;
            Input = input;
            Output = output;
            ExampleRequest = exampleRequest;
            Assets = assets;
            Parameters = parameters;
            PayloadsInBlobStorage = payloadsInBlobStorage;
            PayloadsLocation = payloadsLocation;
        }

        /// <summary>
        /// Gets or sets the title of the web service.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description of the web service.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets read Only: The date and time when the web service was created.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "createdOn")]
        public System.DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// Gets read Only: The date and time when the web service was last
        /// modified.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "modifiedOn")]
        public System.DateTime? ModifiedOn { get; private set; }

        /// <summary>
        /// Gets read Only: The provision state of the web service. Valid
        /// values are Unknown, Provisioning, Succeeded, and Failed. Possible
        /// values include: 'Unknown', 'Provisioning', 'Succeeded', 'Failed'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets contains the web service provisioning keys. If you do
        /// not specify provisioning keys, the Azure Machine Learning system
        /// generates them for you. Note: The keys are not returned from
        /// calls to GET operations.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "keys")]
        public WebServiceKeys Keys { get; set; }

        /// <summary>
        /// Gets or sets when set to true, indicates that the web service is
        /// read-only and can no longer be updated or patched, only removed.
        /// Default, is false. Note: Once set to true, you cannot change its
        /// value.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "readOnly")]
        public bool? ReadOnlyProperty { get; set; }

        /// <summary>
        /// Gets read Only: Contains the URI of the swagger spec associated
        /// with this web service.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "swaggerLocation")]
        public string SwaggerLocation { get; private set; }

        /// <summary>
        /// Gets or sets when set to true, sample data is included in the web
        /// service's swagger definition. The default value is true.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "exposeSampleData")]
        public bool? ExposeSampleData { get; set; }

        /// <summary>
        /// Gets or sets contains the configuration settings for the web
        /// service endpoint.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "realtimeConfiguration")]
        public RealtimeConfiguration RealtimeConfiguration { get; set; }

        /// <summary>
        /// Gets or sets settings controlling the diagnostics traces
        /// collection for the web service.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "diagnostics")]
        public DiagnosticsConfiguration Diagnostics { get; set; }

        /// <summary>
        /// Gets or sets specifies the storage account that Azure Machine
        /// Learning uses to store information about the web service. Only
        /// the name of the storage account is returned from calls to GET
        /// operations. When updating the storage account information, you
        /// must ensure that all necessary assets are available in the new
        /// storage account or calls to your web service will fail.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "storageAccount")]
        public StorageAccount StorageAccount { get; set; }

        /// <summary>
        /// Gets or sets specifies the Machine Learning workspace containing
        /// the experiment that is source for the web service.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "machineLearningWorkspace")]
        public MachineLearningWorkspace MachineLearningWorkspace { get; set; }

        /// <summary>
        /// Gets or sets contains the commitment plan associated with this web
        /// service. Set at creation time. Once set, this value cannot be
        /// changed. Note: The commitment plan is not returned from calls to
        /// GET operations.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "commitmentPlan")]
        public CommitmentPlan CommitmentPlan { get; set; }

        /// <summary>
        /// Gets or sets contains the Swagger 2.0 schema describing one or
        /// more of the web service's inputs. For more information, see the
        /// Swagger specification.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "input")]
        public ServiceInputOutputSpecification Input { get; set; }

        /// <summary>
        /// Gets or sets contains the Swagger 2.0 schema describing one or
        /// more of the web service's outputs. For more information, see the
        /// Swagger specification.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "output")]
        public ServiceInputOutputSpecification Output { get; set; }

        /// <summary>
        /// Gets or sets defines sample input data for one or more of the
        /// service's inputs.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "exampleRequest")]
        public ExampleRequest ExampleRequest { get; set; }

        /// <summary>
        /// Gets or sets contains user defined properties describing web
        /// service assets. Properties are expressed as Key/Value pairs.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "assets")]
        public System.Collections.Generic.IDictionary<string, AssetItem> Assets { get; set; }

        /// <summary>
        /// Gets or sets the set of global parameters values defined for the
        /// web service, given as a global parameter name to default value
        /// map. If no default value is specified, the parameter is
        /// considered to be required.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "parameters")]
        public System.Collections.Generic.IDictionary<string, WebServiceParameter> Parameters { get; set; }

        /// <summary>
        /// Gets or sets if
        /// Assets+Input+Output+Package+Parameters+ExampleRequest is too
        /// large (&gt; 3MB), this field will be set to true and the content
        /// will be put into a blob. Otherwise, this will be set to false and
        /// Assets, Input, Output, Package, Parameters, ExampleRequest will
        /// be inline.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "payloadsInBlobStorage")]
        public bool? PayloadsInBlobStorage { get; set; }

        /// <summary>
        /// Gets or sets blob location of the large payload.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "PayloadsLocation")]
        public BlobLocation PayloadsLocation { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.RealtimeConfiguration != null)
            {
                this.RealtimeConfiguration.Validate();
            }
            if (this.Diagnostics != null)
            {
                this.Diagnostics.Validate();
            }
            if (this.MachineLearningWorkspace != null)
            {
                this.MachineLearningWorkspace.Validate();
            }
            if (this.CommitmentPlan != null)
            {
                this.CommitmentPlan.Validate();
            }
            if (this.Input != null)
            {
                this.Input.Validate();
            }
            if (this.Output != null)
            {
                this.Output.Validate();
            }
            if (this.Assets != null)
            {
                foreach (var valueElement in this.Assets.Values)
                {
                    if (valueElement != null)
                    {
                        valueElement.Validate();
                    }
                }
            }
            if (this.PayloadsLocation != null)
            {
                this.PayloadsLocation.Validate();
            }
        }
    }
}
