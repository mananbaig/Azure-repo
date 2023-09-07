// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> The binding to an Azure Machine Learning Studio. </summary>
    public partial class EMachineLearningStudioFunctionBinding : StreamingJobFunctionBinding
    {
        /// <summary> Initializes a new instance of <see cref="EMachineLearningStudioFunctionBinding"/>. </summary>
        public EMachineLearningStudioFunctionBinding()
        {
            Outputs = new ChangeTrackingList<MachineLearningStudioOutputColumn>();
            FunctionBindingType = "Microsoft.MachineLearning/WebService";
        }

        /// <summary> Initializes a new instance of <see cref="EMachineLearningStudioFunctionBinding"/>. </summary>
        /// <param name="functionBindingType"> Indicates the function binding type. </param>
        /// <param name="endpoint"> The Request-Response execute endpoint of the Azure Machine Learning Studio. Find out more here: https://docs.microsoft.com/en-us/azure/machine-learning/machine-learning-consume-web-services#request-response-service-rrs. </param>
        /// <param name="apiKey"> The API key used to authenticate with Request-Response endpoint. </param>
        /// <param name="inputs"> The inputs for the Azure Machine Learning Studio endpoint. </param>
        /// <param name="outputs"> A list of outputs from the Azure Machine Learning Studio endpoint execution. </param>
        /// <param name="batchSize"> Number between 1 and 10000 describing maximum number of rows for every Azure ML RRS execute request. Default is 1000. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EMachineLearningStudioFunctionBinding(string functionBindingType, string endpoint, string apiKey, MachineLearningStudioInputs inputs, IList<MachineLearningStudioOutputColumn> outputs, int? batchSize, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(functionBindingType, serializedAdditionalRawData)
        {
            Endpoint = endpoint;
            ApiKey = apiKey;
            Inputs = inputs;
            Outputs = outputs;
            BatchSize = batchSize;
            FunctionBindingType = functionBindingType ?? "Microsoft.MachineLearning/WebService";
        }

        /// <summary> The Request-Response execute endpoint of the Azure Machine Learning Studio. Find out more here: https://docs.microsoft.com/en-us/azure/machine-learning/machine-learning-consume-web-services#request-response-service-rrs. </summary>
        public string Endpoint { get; set; }
        /// <summary> The API key used to authenticate with Request-Response endpoint. </summary>
        public string ApiKey { get; set; }
        /// <summary> The inputs for the Azure Machine Learning Studio endpoint. </summary>
        public MachineLearningStudioInputs Inputs { get; set; }
        /// <summary> A list of outputs from the Azure Machine Learning Studio endpoint execution. </summary>
        public IList<MachineLearningStudioOutputColumn> Outputs { get; }
        /// <summary> Number between 1 and 10000 describing maximum number of rows for every Azure ML RRS execute request. Default is 1000. </summary>
        public int? BatchSize { get; set; }
    }
}
