// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The results and errors from an execution of a pool autoscale formula.
    /// </summary>
    public partial class AutoScaleRun
    {
        /// <summary>
        /// Initializes a new instance of the AutoScaleRun class.
        /// </summary>
        public AutoScaleRun() { }

        /// <summary>
        /// Initializes a new instance of the AutoScaleRun class.
        /// </summary>
        /// <param name="timestamp">The time at which the autoscale formula was last evaluated.</param>
        /// <param name="results">The final values of all variables used in the evaluation of the autoscale formula.</param>
        /// <param name="error">Details of the error encountered evaluating the autoscale formula on the pool, if the evaluation was unsuccessful.</param>
        public AutoScaleRun(DateTime timestamp, string results = default(string), AutoScaleRunError error = default(AutoScaleRunError))
        {
            Timestamp = timestamp;
            Results = results;
            Error = error;
        }

        /// <summary>
        /// Gets or sets the time at which the autoscale formula was last
        /// evaluated.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Gets or sets the final values of all variables used in the
        /// evaluation of the autoscale formula.
        /// </summary>
        /// <remarks>
        /// Each variable value is returned in the form $variable=value, and
        /// variables are separated by semicolons.
        /// </remarks>
        [JsonProperty(PropertyName = "results")]
        public string Results { get; set; }

        /// <summary>
        /// Gets or sets details of the error encountered evaluating the
        /// autoscale formula on the pool, if the evaluation was unsuccessful.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public AutoScaleRunError Error { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
