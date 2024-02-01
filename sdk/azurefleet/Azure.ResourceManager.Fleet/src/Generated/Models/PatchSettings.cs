// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Fleet.Models
{
    /// <summary> Specifies settings related to VM Guest Patching on Windows. </summary>
    public partial class PatchSettings
    {
        /// <summary> Initializes a new instance of <see cref="PatchSettings"/>. </summary>
        public PatchSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PatchSettings"/>. </summary>
        /// <param name="patchMode"> Specifies the mode of VM Guest Patching to IaaS virtual machine or virtual machines associated to virtual machine scale set with OrchestrationMode as Flexible.&lt;br /&gt;&lt;br /&gt; Possible values are:&lt;br /&gt;&lt;br /&gt; **Manual** - You  control the application of patches to a virtual machine. You do this by applying patches manually inside the VM. In this mode, automatic updates are disabled; the property WindowsConfiguration.enableAutomaticUpdates must be false&lt;br /&gt;&lt;br /&gt; **AutomaticByOS** - The virtual machine will automatically be updated by the OS. The property WindowsConfiguration.enableAutomaticUpdates must be true. &lt;br /&gt;&lt;br /&gt; **AutomaticByPlatform** - the virtual machine will automatically updated by the platform. The properties provisionVMAgent and WindowsConfiguration.enableAutomaticUpdates must be true. </param>
        /// <param name="enableHotpatching"> Enables customers to patch their Azure VMs without requiring a reboot. For enableHotpatching, the 'provisionVMAgent' must be set to true and 'patchMode' must be set to 'AutomaticByPlatform'. </param>
        /// <param name="assessmentMode"> Specifies the mode of VM Guest patch assessment for the IaaS virtual machine.&lt;br /&gt;&lt;br /&gt; Possible values are:&lt;br /&gt;&lt;br /&gt; **ImageDefault** - You control the timing of patch assessments on a virtual machine.&lt;br /&gt;&lt;br /&gt; **AutomaticByPlatform** - The platform will trigger periodic patch assessments. The property provisionVMAgent must be true. </param>
        /// <param name="automaticByPlatformSettings"> Specifies additional settings for patch mode AutomaticByPlatform in VM Guest Patching on Windows. </param>
        internal PatchSettings(WindowsVmGuestPatchMode? patchMode, bool? enableHotpatching, WindowsPatchAssessmentMode? assessmentMode, WindowsVmGuestPatchAutomaticByPlatformSettings automaticByPlatformSettings)
        {
            PatchMode = patchMode;
            EnableHotpatching = enableHotpatching;
            AssessmentMode = assessmentMode;
            AutomaticByPlatformSettings = automaticByPlatformSettings;
        }

        /// <summary> Specifies the mode of VM Guest Patching to IaaS virtual machine or virtual machines associated to virtual machine scale set with OrchestrationMode as Flexible.&lt;br /&gt;&lt;br /&gt; Possible values are:&lt;br /&gt;&lt;br /&gt; **Manual** - You  control the application of patches to a virtual machine. You do this by applying patches manually inside the VM. In this mode, automatic updates are disabled; the property WindowsConfiguration.enableAutomaticUpdates must be false&lt;br /&gt;&lt;br /&gt; **AutomaticByOS** - The virtual machine will automatically be updated by the OS. The property WindowsConfiguration.enableAutomaticUpdates must be true. &lt;br /&gt;&lt;br /&gt; **AutomaticByPlatform** - the virtual machine will automatically updated by the platform. The properties provisionVMAgent and WindowsConfiguration.enableAutomaticUpdates must be true. </summary>
        public WindowsVmGuestPatchMode? PatchMode { get; set; }
        /// <summary> Enables customers to patch their Azure VMs without requiring a reboot. For enableHotpatching, the 'provisionVMAgent' must be set to true and 'patchMode' must be set to 'AutomaticByPlatform'. </summary>
        public bool? EnableHotpatching { get; set; }
        /// <summary> Specifies the mode of VM Guest patch assessment for the IaaS virtual machine.&lt;br /&gt;&lt;br /&gt; Possible values are:&lt;br /&gt;&lt;br /&gt; **ImageDefault** - You control the timing of patch assessments on a virtual machine.&lt;br /&gt;&lt;br /&gt; **AutomaticByPlatform** - The platform will trigger periodic patch assessments. The property provisionVMAgent must be true. </summary>
        public WindowsPatchAssessmentMode? AssessmentMode { get; set; }
        /// <summary> Specifies additional settings for patch mode AutomaticByPlatform in VM Guest Patching on Windows. </summary>
        public WindowsVmGuestPatchAutomaticByPlatformSettings AutomaticByPlatformSettings { get; set; }
    }
}
