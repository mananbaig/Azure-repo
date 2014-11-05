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
    /// The Blob data source as the output.
    /// </summary>
    public partial class BlobOutputDataSource : OutputDataSource
    {
        private BlobOutputDataSourceProperties _blobOutputDataSourceProperties;
        
        /// <summary>
        /// Required. The properties of the Blob data source as output.
        /// </summary>
        public BlobOutputDataSourceProperties BlobOutputDataSourceProperties
        {
            get { return this._blobOutputDataSourceProperties; }
            set { this._blobOutputDataSourceProperties = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the BlobOutputDataSource class.
        /// </summary>
        public BlobOutputDataSource()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the BlobOutputDataSource class with
        /// required arguments.
        /// </summary>
        public BlobOutputDataSource(BlobOutputDataSourceProperties blobOutputDataSourceProperties)
            : this()
        {
            if (blobOutputDataSourceProperties == null)
            {
                throw new ArgumentNullException("blobOutputDataSourceProperties");
            }
            this.BlobOutputDataSourceProperties = blobOutputDataSourceProperties;
        }
    }
}
