// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Spark.Models
{
    /// <summary> The SparkBatchJobOptions. </summary>
    public partial class SparkBatchJobOptions
    {
        /// <summary> Initializes a new instance of SparkBatchJobOptions. </summary>
        /// <param name="name"> . </param>
        /// <param name="file"> . </param>
        public SparkBatchJobOptions(string name, string file)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (file == null)
            {
                throw new ArgumentNullException(nameof(file));
            }

            Tags = new ChangeTrackingDictionary<string, string>();
            Name = name;
            File = file;
            Arguments = new ChangeTrackingList<string>();
            Jars = new ChangeTrackingList<string>();
            PythonFiles = new ChangeTrackingList<string>();
            Files = new ChangeTrackingList<string>();
            Archives = new ChangeTrackingList<string>();
            Configuration = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IDictionary<string, string> Tags { get; }
        public string ArtifactId { get; set; }
        public string Name { get; }
        public string File { get; }
        public string ClassName { get; set; }
        public IList<string> Arguments { get; }
        public IList<string> Jars { get; }
        public IList<string> PythonFiles { get; }
        public IList<string> Files { get; }
        public IList<string> Archives { get; }
        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IDictionary<string, string> Configuration { get; }
        public string DriverMemory { get; set; }
        public int? DriverCores { get; set; }
        public string ExecutorMemory { get; set; }
        public int? ExecutorCores { get; set; }
        public int? ExecutorCount { get; set; }
    }
}
