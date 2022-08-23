// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    /// <summary> Set a patching window during which Windows and SQL patches will be applied. </summary>
    public partial class SqlVmAutoPatchingSettings
    {
        /// <summary> Initializes a new instance of SqlVmAutoPatchingSettings. </summary>
        public SqlVmAutoPatchingSettings()
        {
        }

        /// <summary> Initializes a new instance of SqlVmAutoPatchingSettings. </summary>
        /// <param name="isEnabled"> Enable or disable autopatching on SQL virtual machine. </param>
        /// <param name="dayOfWeek"> Day of week to apply the patch on. </param>
        /// <param name="maintenanceWindowStartingHour"> Hour of the day when patching is initiated. Local VM time. </param>
        /// <param name="maintenanceWindowDurationInMinutes"> Duration of patching. </param>
        internal SqlVmAutoPatchingSettings(bool? isEnabled, SqlVmAutoPatchingDayOfWeek? dayOfWeek, int? maintenanceWindowStartingHour, int? maintenanceWindowDurationInMinutes)
        {
            IsEnabled = isEnabled;
            DayOfWeek = dayOfWeek;
            MaintenanceWindowStartingHour = maintenanceWindowStartingHour;
            MaintenanceWindowDurationInMinutes = maintenanceWindowDurationInMinutes;
        }

        /// <summary> Enable or disable autopatching on SQL virtual machine. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> Day of week to apply the patch on. </summary>
        public SqlVmAutoPatchingDayOfWeek? DayOfWeek { get; set; }
        /// <summary> Hour of the day when patching is initiated. Local VM time. </summary>
        public int? MaintenanceWindowStartingHour { get; set; }
        /// <summary> Duration of patching. </summary>
        public int? MaintenanceWindowDurationInMinutes { get; set; }
    }
}
