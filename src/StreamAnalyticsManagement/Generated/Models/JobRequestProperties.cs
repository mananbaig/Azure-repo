// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Azure.Management.StreamAnalytics.Models;
using Microsoft.WindowsAzure.Common.Internals;

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    /// <summary>
    /// The properties of the stream analytics job.
    /// </summary>
    public partial class JobRequestProperties
    {
        private int _eventsOutOfOrderMaxDelayInMilliseconds;
        
        /// <summary>
        /// Required. The max delay time of the out of order policy of the
        /// stream analytics job. It is in Milliseconds
        /// </summary>
        public int EventsOutOfOrderMaxDelayInMilliseconds
        {
            get { return this._eventsOutOfOrderMaxDelayInMilliseconds; }
            set { this._eventsOutOfOrderMaxDelayInMilliseconds = value; }
        }
        
        private string _eventsOutOfOrderPolicy;
        
        /// <summary>
        /// Required. The out of order policy of the stream analytics job.
        /// </summary>
        public string EventsOutOfOrderPolicy
        {
            get { return this._eventsOutOfOrderPolicy; }
            set { this._eventsOutOfOrderPolicy = value; }
        }
        
        private IList<Input> _inputs;
        
        /// <summary>
        /// Optional. A list of one or more inputs.
        /// </summary>
        public IList<Input> Inputs
        {
            get { return this._inputs; }
            set { this._inputs = value; }
        }
        
        private IList<Output> _outputs;
        
        /// <summary>
        /// Optional. A list of outputs.
        /// </summary>
        public IList<Output> Outputs
        {
            get { return this._outputs; }
            set { this._outputs = value; }
        }
        
        private string _outputStartMode;
        
        /// <summary>
        /// Required. The output start mode of the stream analytics job.
        /// </summary>
        public string OutputStartMode
        {
            get { return this._outputStartMode; }
            set { this._outputStartMode = value; }
        }
        
        private System.DateTime? _outputStartTime;
        
        /// <summary>
        /// Optional. The output start time of the stream analytics job.
        /// </summary>
        public System.DateTime? OutputStartTime
        {
            get { return this._outputStartTime; }
            set { this._outputStartTime = value; }
        }
        
        private Sku _sku;
        
        /// <summary>
        /// Required. The Sku of the stream analytics job.
        /// </summary>
        public Sku Sku
        {
            get { return this._sku; }
            set { this._sku = value; }
        }
        
        private Transformation _transformation;
        
        /// <summary>
        /// Optional. The transformation definition, including the query and
        /// the streaming unit count.
        /// </summary>
        public Transformation Transformation
        {
            get { return this._transformation; }
            set { this._transformation = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the JobRequestProperties class.
        /// </summary>
        public JobRequestProperties()
        {
            this.Inputs = new LazyList<Input>();
            this.Outputs = new LazyList<Output>();
        }
    }
}
