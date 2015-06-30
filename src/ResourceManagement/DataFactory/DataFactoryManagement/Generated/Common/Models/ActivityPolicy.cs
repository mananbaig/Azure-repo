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

namespace Microsoft.Azure.Management.DataFactories.Common.Models
{
    /// <summary>
    /// Activity policy.
    /// </summary>
    public partial class ActivityPolicy
    {
        private uint? _concurrency;
        
        /// <summary>
        /// Optional. The maximum number of concurrent activity executions.
        /// </summary>
        public uint? Concurrency
        {
            get { return this._concurrency; }
            set { this._concurrency = value; }
        }
        
        private System.TimeSpan? _delay;
        
        /// <summary>
        /// Optional. Delay activity execution so that upstream activities can
        /// have extra time to finish.
        /// </summary>
        public System.TimeSpan? Delay
        {
            get { return this._delay; }
            set { this._delay = value; }
        }
        
        private string _executionPriorityOrder;
        
        /// <summary>
        /// Optional. Execution priority order.  Choose from OldestFirst or
        /// NewestFirst.
        /// </summary>
        public string ExecutionPriorityOrder
        {
            get { return this._executionPriorityOrder; }
            set { this._executionPriorityOrder = value; }
        }
        
        private int? _longRetry;
        
        /// <summary>
        /// Optional. Total number of long retries after failed short retries.
        /// </summary>
        public int? LongRetry
        {
            get { return this._longRetry; }
            set { this._longRetry = value; }
        }
        
        private System.TimeSpan? _longRetryInterval;
        
        /// <summary>
        /// Optional. Interval between two long retries.
        /// </summary>
        public System.TimeSpan? LongRetryInterval
        {
            get { return this._longRetryInterval; }
            set { this._longRetryInterval = value; }
        }
        
        private int? _retry;
        
        /// <summary>
        /// Optional. Total number of short retries for a failed activity.
        /// </summary>
        public int? Retry
        {
            get { return this._retry; }
            set { this._retry = value; }
        }
        
        private string _style;
        
        /// <summary>
        /// Optional. The scheduler style for executing activity. For a slice
        /// to be generated,  StartOfInterval style requires that current time
        /// has to be later than the start time of the slice, while
        /// EndOfInterval style requires that current time has to be later
        /// than the end time of the slice.
        /// </summary>
        public string Style
        {
            get { return this._style; }
            set { this._style = value; }
        }
        
        private System.TimeSpan? _timeout;
        
        /// <summary>
        /// Optional. Specifies the timeout for the activity to run. If there
        /// is value specified, it takes the value of
        /// TimeSpan.FromMilliseconds(-1) which means indefinite timeout.
        /// </summary>
        public System.TimeSpan? Timeout
        {
            get { return this._timeout; }
            set { this._timeout = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ActivityPolicy class.
        /// </summary>
        public ActivityPolicy()
        {
        }
    }
}
