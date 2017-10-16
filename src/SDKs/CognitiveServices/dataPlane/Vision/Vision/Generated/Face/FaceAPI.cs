// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.Face
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;

    /// <summary>
    /// An API for face detection, verification, and identification.
    /// </summary>
    public partial class FaceAPI : ServiceClient<FaceAPI>, IFaceAPI
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        internal string BaseUri {get; set;}

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// Subscription key in header
        /// </summary>
        public string SubscriptionKey { get; set; }

        /// <summary>
        /// Supported Azure regions for Cognitive Services endpoints. Possible values
        /// include: 'westus', 'westeurope', 'southeastasia', 'eastus2',
        /// 'westcentralus'
        /// </summary>
        public AzureRegions AzureRegion { get; set; }

        /// <summary>
        /// Gets the IFaceOperations.
        /// </summary>
        public virtual IFaceOperations Face { get; private set; }

        /// <summary>
        /// Gets the IPerson.
        /// </summary>
        public virtual IPerson Person { get; private set; }

        /// <summary>
        /// Gets the IPersonGroup.
        /// </summary>
        public virtual IPersonGroup PersonGroup { get; private set; }

        /// <summary>
        /// Gets the IFaceList.
        /// </summary>
        public virtual IFaceList FaceList { get; private set; }

        /// <summary>
        /// Initializes a new instance of the FaceAPI class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public FaceAPI(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the FaceAPI class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public FaceAPI(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        ///</summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            Face = new FaceOperations(this);
            Person = new Person(this);
            PersonGroup = new PersonGroup(this);
            FaceList = new FaceList(this);
            BaseUri = "https://{AzureRegion}.api.cognitive.microsoft.com/face/v1.0";
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new  List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            CustomInitialize();
        }
    }
}
