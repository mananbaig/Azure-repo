// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> SAP ODP Resource properties. </summary>
    public partial class SapOdpResourceDataset : Dataset
    {
        /// <summary> Initializes a new instance of SapOdpResourceDataset. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="context"> The context of the SAP ODP Object. Type: string (or Expression with resultType string). </param>
        /// <param name="objectName"> The name of the SAP ODP Object. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/>, <paramref name="context"/> or <paramref name="objectName"/> is null. </exception>
        public SapOdpResourceDataset(LinkedServiceReference linkedServiceName, object context, object objectName) : base(linkedServiceName)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }
            if (objectName == null)
            {
                throw new ArgumentNullException(nameof(objectName));
            }

            Context = context;
            ObjectName = objectName;
            Type = "SapOdpResource";
        }

        /// <summary> Initializes a new instance of SapOdpResourceDataset. </summary>
        /// <param name="type"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="context"> The context of the SAP ODP Object. Type: string (or Expression with resultType string). </param>
        /// <param name="objectName"> The name of the SAP ODP Object. Type: string (or Expression with resultType string). </param>
        internal SapOdpResourceDataset(string type, string description, object structure, object schema, LinkedServiceReference linkedServiceName, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, DatasetFolder folder, IDictionary<string, object> additionalProperties, object context, object objectName) : base(type, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
        {
            Context = context;
            ObjectName = objectName;
            Type = type ?? "SapOdpResource";
        }

        /// <summary> The context of the SAP ODP Object. Type: string (or Expression with resultType string). </summary>
        public object Context { get; set; }
        /// <summary> The name of the SAP ODP Object. Type: string (or Expression with resultType string). </summary>
        public object ObjectName { get; set; }
    }
}
