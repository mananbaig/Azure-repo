// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Chainer job settings.
    /// </summary>
    public partial class ChainerSettings
    {
        /// <summary>
        /// Initializes a new instance of the ChainerSettings class.
        /// </summary>
        public ChainerSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ChainerSettings class.
        /// </summary>
        /// <param name="pythonScriptFilePath">Python script file path.</param>
        /// <param name="pythonInterpreterPath">Python interpreter
        /// path.</param>
        /// <param name="commandLineArgs">Command line arguments.</param>
        /// <param name="processCount">Process count.</param>
        public ChainerSettings(string pythonScriptFilePath, string pythonInterpreterPath = default(string), string commandLineArgs = default(string), int? processCount = default(int?))
        {
            PythonScriptFilePath = pythonScriptFilePath;
            PythonInterpreterPath = pythonInterpreterPath;
            CommandLineArgs = commandLineArgs;
            ProcessCount = processCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets python script file path.
        /// </summary>
        /// <remarks>
        /// The python script to execute.
        /// </remarks>
        [JsonProperty(PropertyName = "pythonScriptFilePath")]
        public string PythonScriptFilePath { get; set; }

        /// <summary>
        /// Gets or sets python interpreter path.
        /// </summary>
        /// <remarks>
        /// The path to the Python interpreter.
        /// </remarks>
        [JsonProperty(PropertyName = "pythonInterpreterPath")]
        public string PythonInterpreterPath { get; set; }

        /// <summary>
        /// Gets or sets command line arguments.
        /// </summary>
        /// <remarks>
        /// Command line arguments that need to be passed to the python script.
        /// </remarks>
        [JsonProperty(PropertyName = "commandLineArgs")]
        public string CommandLineArgs { get; set; }

        /// <summary>
        /// Gets or sets process count.
        /// </summary>
        /// <remarks>
        /// Number of processes to launch for the job execution. The default
        /// value for this property is equal to nodeCount property
        /// </remarks>
        [JsonProperty(PropertyName = "processCount")]
        public int? ProcessCount { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PythonScriptFilePath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PythonScriptFilePath");
            }
        }
    }
}
