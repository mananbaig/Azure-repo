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
using Microsoft.Azure.Management.RecoveryServices.Backup.Models;

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    /// <summary>
    /// The definition of a MonthlyRetentionSchedule object.
    /// </summary>
    public partial class MonthlyRetentionSchedule : RetentionScheduleBase
    {
        private DailyRetentionFormat _retentionScheduleDaily;
        
        /// <summary>
        /// Optional. Daily Retention Format for monthly retention policy.
        /// </summary>
        public DailyRetentionFormat RetentionScheduleDaily
        {
            get { return this._retentionScheduleDaily; }
            set { this._retentionScheduleDaily = value; }
        }
        
        private RetentionScheduleFormat _retentionScheduleFormat;
        
        /// <summary>
        /// Optional. Retention ScheduleType for monthly retention policy.
        /// </summary>
        public RetentionScheduleFormat RetentionScheduleFormat
        {
            get { return this._retentionScheduleFormat; }
            set { this._retentionScheduleFormat = value; }
        }
        
        private WeeklyRetentionFormat _retentionScheduleWeekly;
        
        /// <summary>
        /// Optional. Weekly Retention format for monthly retention policy.
        /// </summary>
        public WeeklyRetentionFormat RetentionScheduleWeekly
        {
            get { return this._retentionScheduleWeekly; }
            set { this._retentionScheduleWeekly = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the MonthlyRetentionSchedule class.
        /// </summary>
        public MonthlyRetentionSchedule()
        {
        }
    }
}
