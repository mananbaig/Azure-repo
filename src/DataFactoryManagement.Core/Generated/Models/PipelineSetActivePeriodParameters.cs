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

namespace Microsoft.Azure.Management.DataFactories.Models
{
    /// <summary>
    /// Parameters specifying the active period for the set pipeline active
    /// period operation.
    /// </summary>
    public partial class PipelineSetActivePeriodParameters
    {
        private string _activePeriodEndTime;
        
        /// <summary>
        /// Required. Pipeline end time in round-trip ISO 8601 format.
        /// </summary>
        public string ActivePeriodEndTime
        {
            get { return this._activePeriodEndTime; }
            set { this._activePeriodEndTime = value; }
        }
        
        private string _activePeriodStartTime;
        
        /// <summary>
        /// Required. Pipeline start time in round-trip ISO 8601 format.
        /// </summary>
        public string ActivePeriodStartTime
        {
            get { return this._activePeriodStartTime; }
            set { this._activePeriodStartTime = value; }
        }
        
        private bool _autoResolve;
        
        /// <summary>
        /// Optional. Auto resolve active periods of conflicting pipelines.
        /// </summary>
        public bool AutoResolve
        {
            get { return this._autoResolve; }
            set { this._autoResolve = value; }
        }
        
        private bool _forceRecalc;
        
        /// <summary>
        /// Optional. Mark all slices in the period as pending execution.
        /// </summary>
        public bool ForceRecalc
        {
            get { return this._forceRecalc; }
            set { this._forceRecalc = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the PipelineSetActivePeriodParameters
        /// class.
        /// </summary>
        public PipelineSetActivePeriodParameters()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the PipelineSetActivePeriodParameters
        /// class with required arguments.
        /// </summary>
        public PipelineSetActivePeriodParameters(string activePeriodStartTime, string activePeriodEndTime)
            : this()
        {
            if (activePeriodStartTime == null)
            {
                throw new ArgumentNullException("activePeriodStartTime");
            }
            if (activePeriodEndTime == null)
            {
                throw new ArgumentNullException("activePeriodEndTime");
            }
            this.ActivePeriodStartTime = activePeriodStartTime;
            this.ActivePeriodEndTime = activePeriodEndTime;
        }
    }
}
