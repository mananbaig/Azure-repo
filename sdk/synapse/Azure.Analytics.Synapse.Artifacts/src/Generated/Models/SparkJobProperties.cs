// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The properties of the Spark job. </summary>
    public partial class SparkJobProperties : IDictionary<string, object>
    {
        /// <summary> Initializes a new instance of SparkJobProperties. </summary>
        /// <param name="file"> File containing the application to execute. </param>
        /// <param name="driverMemory"> Amount of memory to use for the driver process. </param>
        /// <param name="driverCores"> Number of cores to use for the driver. </param>
        /// <param name="executorMemory"> Amount of memory to use per executor process. </param>
        /// <param name="executorCores"> Number of cores to use for each executor. </param>
        /// <param name="numExecutors"> Number of executors to launch for this job. </param>
        public SparkJobProperties(string file, string driverMemory, int driverCores, string executorMemory, int executorCores, int numExecutors)
        {
            if (file == null)
            {
                throw new ArgumentNullException(nameof(file));
            }
            if (driverMemory == null)
            {
                throw new ArgumentNullException(nameof(driverMemory));
            }
            if (executorMemory == null)
            {
                throw new ArgumentNullException(nameof(executorMemory));
            }

            File = file;
            DriverMemory = driverMemory;
            DriverCores = driverCores;
            ExecutorMemory = executorMemory;
            ExecutorCores = executorCores;
            NumExecutors = numExecutors;
            AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary> Initializes a new instance of SparkJobProperties. </summary>
        /// <param name="name"> The name of the job. </param>
        /// <param name="file"> File containing the application to execute. </param>
        /// <param name="className"> Main class for Java/Scala application. </param>
        /// <param name="conf"> Spark configuration properties. </param>
        /// <param name="args"> Command line arguments for the application. </param>
        /// <param name="jars"> Jars to be used in this job. </param>
        /// <param name="files"> files to be used in this job. </param>
        /// <param name="archives"> Archives to be used in this job. </param>
        /// <param name="driverMemory"> Amount of memory to use for the driver process. </param>
        /// <param name="driverCores"> Number of cores to use for the driver. </param>
        /// <param name="executorMemory"> Amount of memory to use per executor process. </param>
        /// <param name="executorCores"> Number of cores to use for each executor. </param>
        /// <param name="numExecutors"> Number of executors to launch for this job. </param>
        /// <param name="additionalProperties"> . </param>
        internal SparkJobProperties(string name, string file, string className, object conf, IList<string> args, IList<string> jars, IList<string> files, IList<string> archives, string driverMemory, int driverCores, string executorMemory, int executorCores, int numExecutors, IDictionary<string, object> additionalProperties)
        {
            Name = name;
            File = file;
            ClassName = className;
            Conf = conf;
            Args = args;
            Jars = jars;
            Files = files;
            Archives = archives;
            DriverMemory = driverMemory;
            DriverCores = driverCores;
            ExecutorMemory = executorMemory;
            ExecutorCores = executorCores;
            NumExecutors = numExecutors;
            AdditionalProperties = additionalProperties ?? new Dictionary<string, object>();
        }

        /// <summary> The name of the job. </summary>
        public string Name { get; set; }
        /// <summary> File containing the application to execute. </summary>
        public string File { get; set; }
        /// <summary> Main class for Java/Scala application. </summary>
        public string ClassName { get; set; }
        /// <summary> Spark configuration properties. </summary>
        public object Conf { get; set; }
        /// <summary> Command line arguments for the application. </summary>
        public IList<string> Args { get; set; }
        /// <summary> Jars to be used in this job. </summary>
        public IList<string> Jars { get; set; }
        /// <summary> files to be used in this job. </summary>
        public IList<string> Files { get; set; }
        /// <summary> Archives to be used in this job. </summary>
        public IList<string> Archives { get; set; }
        /// <summary> Amount of memory to use for the driver process. </summary>
        public string DriverMemory { get; set; }
        /// <summary> Number of cores to use for the driver. </summary>
        public int DriverCores { get; set; }
        /// <summary> Amount of memory to use per executor process. </summary>
        public string ExecutorMemory { get; set; }
        /// <summary> Number of cores to use for each executor. </summary>
        public int ExecutorCores { get; set; }
        /// <summary> Number of executors to launch for this job. </summary>
        public int NumExecutors { get; set; }
        internal IDictionary<string, object> AdditionalProperties { get; }
        /// <inheritdoc />
        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        public bool TryGetValue(string key, out object value) => AdditionalProperties.TryGetValue(key, out value);
        /// <inheritdoc />
        public bool ContainsKey(string key) => AdditionalProperties.ContainsKey(key);
        /// <inheritdoc />
        public ICollection<string> Keys => AdditionalProperties.Keys;
        /// <inheritdoc />
        public ICollection<object> Values => AdditionalProperties.Values;
        /// <inheritdoc />
        int ICollection<KeyValuePair<string, object>>.Count => AdditionalProperties.Count;
        /// <inheritdoc />
        public void Add(string key, object value) => AdditionalProperties.Add(key, value);
        /// <inheritdoc />
        public bool Remove(string key) => AdditionalProperties.Remove(key);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, object>>.IsReadOnly => AdditionalProperties.IsReadOnly;
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, object>>.Add(KeyValuePair<string, object> value) => AdditionalProperties.Add(value);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, object>>.Remove(KeyValuePair<string, object> value) => AdditionalProperties.Remove(value);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, object>>.Contains(KeyValuePair<string, object> value) => AdditionalProperties.Contains(value);
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, object>>.CopyTo(KeyValuePair<string, object>[] destination, int offset) => AdditionalProperties.CopyTo(destination, offset);
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, object>>.Clear() => AdditionalProperties.Clear();
        /// <inheritdoc />
        public object this[string key]
        {
            get => AdditionalProperties[key];
            set => AdditionalProperties[key] = value;
        }
    }
}
