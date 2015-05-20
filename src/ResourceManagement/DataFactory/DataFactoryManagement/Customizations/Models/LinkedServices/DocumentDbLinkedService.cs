﻿//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

namespace Microsoft.Azure.Management.DataFactories.Models
{
#if ADF_INTERNAL
    /// <summary>
    /// Windows Azure Document Database.
    /// </summary>
    public class DocumentDbLinkedService : LinkedServiceTypeProperties
    {
        /// <summary>
        /// Required. The connection string.
        /// </summary>
        [AdfRequired]
        public string ConnectionString { get; set; }

        /// <summary>
        /// Initializes a new instance of the DocumentDbLinkedService class.
        /// </summary>
        public DocumentDbLinkedService()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DocumentDbLinkedService class
        /// with required arguments.
        /// </summary>
        public DocumentDbLinkedService(string connectionString)
            : this()
        {
            Ensure.IsNotNullOrEmpty(connectionString, "connectionString");
            this.ConnectionString = connectionString;
        }
    }
#endif
}
