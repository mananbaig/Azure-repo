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
using System.Linq;
using Microsoft.Azure.Management.StreamAnalytics.Models;

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    /// <summary>
    /// The definition of the stream input properties.
    /// </summary>
    public partial class StreamInputProperties : InputProperties
    {
        private StreamInputDataSource _dataSource;
        
        /// <summary>
        /// Required. The data source configuration of the input.
        /// </summary>
        public StreamInputDataSource DataSource
        {
            get { return this._dataSource; }
            set { this._dataSource = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the StreamInputProperties class.
        /// </summary>
        public StreamInputProperties()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the StreamInputProperties class with
        /// required arguments.
        /// </summary>
        public StreamInputProperties(StreamInputDataSource dataSource, Serialization serialization)
            : this()
        {
            if (dataSource == null)
            {
                throw new ArgumentNullException("dataSource");
            }
            if (serialization == null)
            {
                throw new ArgumentNullException("serialization");
            }
            this.DataSource = dataSource;
            this.Serialization = serialization;
        }
    }
}
