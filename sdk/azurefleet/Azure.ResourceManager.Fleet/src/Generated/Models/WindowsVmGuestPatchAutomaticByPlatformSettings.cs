// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Fleet.Models
{
    /// <summary> Specifies additional settings to be applied when patch mode AutomaticByPlatform is selected in Windows patch settings. </summary>
    public partial class WindowsVmGuestPatchAutomaticByPlatformSettings
    {
        /// <summary> Initializes a new instance of <see cref="WindowsVmGuestPatchAutomaticByPlatformSettings"/>. </summary>
        public WindowsVmGuestPatchAutomaticByPlatformSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WindowsVmGuestPatchAutomaticByPlatformSettings"/>. </summary>
        /// <param name="rebootSetting"> Specifies the reboot setting for all AutomaticByPlatform patch installation operations. </param>
        /// <param name="bypassPlatformSafetyChecksOnUserSchedule"> Enables customer to schedule patching without accidental upgrades. </param>
        internal WindowsVmGuestPatchAutomaticByPlatformSettings(WindowsVmGuestPatchAutomaticByPlatformRebootSetting? rebootSetting, bool? bypassPlatformSafetyChecksOnUserSchedule)
        {
            RebootSetting = rebootSetting;
            BypassPlatformSafetyChecksOnUserSchedule = bypassPlatformSafetyChecksOnUserSchedule;
        }

        /// <summary> Specifies the reboot setting for all AutomaticByPlatform patch installation operations. </summary>
        public WindowsVmGuestPatchAutomaticByPlatformRebootSetting? RebootSetting { get; set; }
        /// <summary> Enables customer to schedule patching without accidental upgrades. </summary>
        public bool? BypassPlatformSafetyChecksOnUserSchedule { get; set; }
    }
}
