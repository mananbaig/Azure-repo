// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specifies the operating system settings for the virtual machine.
    /// </summary>
    public partial class OSProfile
    {
        /// <summary>
        /// Initializes a new instance of the OSProfile class.
        /// </summary>
        public OSProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OSProfile class.
        /// </summary>
        /// <param name="computerName">Specifies the host OS name of the
        /// virtual machine. &lt;br&gt;&lt;br&gt; **Max-length (Windows):** 15
        /// characters &lt;br&gt;&lt;br&gt; **Max-length (Linux):** 64
        /// characters. &lt;br&gt;&lt;br&gt; For naming conventions and
        /// restrictions see [Azure infrastructure services implementation
        /// guidelines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-infrastructure-subscription-accounts-guidelines?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json#1-naming-conventions).</param>
        /// <param name="adminUsername">Specifies the name of the administrator
        /// account. &lt;br&gt;&lt;br&gt; **Windows-only restriction:** Cannot
        /// end in "." &lt;br&gt;&lt;br&gt; **Disallowed values:**
        /// "administrator", "admin", "user", "user1", "test", "user2",
        /// "test1", "user3", "admin1", "1", "123", "a", "actuser", "adm",
        /// "admin2", "aspnet", "backup", "console", "david", "guest", "john",
        /// "owner", "root", "server", "sql", "support", "support_388945a0",
        /// "sys", "test2", "test3", "user4", "user5". &lt;br&gt;&lt;br&gt;
        /// **Minimum-length (Linux):** 1  character &lt;br&gt;&lt;br&gt;
        /// **Max-length (Linux):** 64 characters &lt;br&gt;&lt;br&gt;
        /// **Max-length (Windows):** 20 characters
        /// &lt;br&gt;&lt;br&gt;&lt;li&gt; For root access to the Linux VM, see
        /// [Using root privileges on Linux virtual machines in
        /// Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-use-root-privileges?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)&lt;br&gt;&lt;li&gt;
        /// For a list of built-in system users on Linux that should not be
        /// used in this field, see [Selecting User Names for Linux on
        /// Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-usernames?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)</param>
        /// <param name="adminPassword">Specifies the password of the
        /// administrator account. &lt;br&gt;&lt;br&gt; **Minimum-length
        /// (Windows):** 8 characters &lt;br&gt;&lt;br&gt; **Minimum-length
        /// (Linux):** 6 characters &lt;br&gt;&lt;br&gt; **Max-length
        /// (Windows):** 123 characters &lt;br&gt;&lt;br&gt; **Max-length
        /// (Linux):** 72 characters &lt;br&gt;&lt;br&gt; **Complexity
        /// requirements:** 3 out of 4 conditions below need to be fulfilled
        /// &lt;br&gt; Has lower characters &lt;br&gt;Has upper characters
        /// &lt;br&gt; Has a digit &lt;br&gt; Has a special character (Regex
        /// match [\W_]) &lt;br&gt;&lt;br&gt; **Disallowed values:** "abc@123",
        /// "P@$$w0rd", "P@ssw0rd", "P@ssword123", "Pa$$word", "pass@word1",
        /// "Password!", "Password1", "Password22", "iloveyou!"
        /// &lt;br&gt;&lt;br&gt; For resetting the password, see [How to reset
        /// the Remote Desktop service or its login password in a Windows
        /// VM](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-reset-rdp?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json)
        /// &lt;br&gt;&lt;br&gt; For resetting root password, see [Manage
        /// users, SSH, and check or repair disks on Azure Linux VMs using the
        /// VMAccess
        /// Extension](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-using-vmaccess-extension?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json#reset-root-password)</param>
        /// <param name="customData">Specifies a base-64 encoded string of
        /// custom data. The base-64 encoded string is decoded to a binary
        /// array that is saved as a file on the Virtual Machine. The maximum
        /// length of the binary array is 65535 bytes. &lt;br&gt;&lt;br&gt; For
        /// using cloud-init for your VM, see [Using cloud-init to customize a
        /// Linux VM during
        /// creation](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-using-cloud-init?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)</param>
        /// <param name="windowsConfiguration">Specifies Windows operating
        /// system settings on the virtual machine.</param>
        /// <param name="linuxConfiguration">Specifies the Linux operating
        /// system settings on the virtual machine. &lt;br&gt;&lt;br&gt;For a
        /// list of supported Linux distributions, see [Linux on Azure-Endorsed
        /// Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-endorsed-distros?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)
        /// &lt;br&gt;&lt;br&gt; For running non-endorsed distributions, see
        /// [Information for Non-Endorsed
        /// Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-create-upload-generic?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json).</param>
        /// <param name="secrets">Specifies set of certificates that should be
        /// installed onto the virtual machine.</param>
        public OSProfile(string computerName = default(string), string adminUsername = default(string), string adminPassword = default(string), string customData = default(string), WindowsConfiguration windowsConfiguration = default(WindowsConfiguration), LinuxConfiguration linuxConfiguration = default(LinuxConfiguration), IList<VaultSecretGroup> secrets = default(IList<VaultSecretGroup>))
        {
            ComputerName = computerName;
            AdminUsername = adminUsername;
            AdminPassword = adminPassword;
            CustomData = customData;
            WindowsConfiguration = windowsConfiguration;
            LinuxConfiguration = linuxConfiguration;
            Secrets = secrets;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the host OS name of the virtual machine.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **Max-length (Windows):** 15
        /// characters &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **Max-length
        /// (Linux):** 64 characters. &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; For
        /// naming conventions and restrictions see [Azure infrastructure
        /// services implementation
        /// guidelines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-infrastructure-subscription-accounts-guidelines?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json#1-naming-conventions).
        /// </summary>
        [JsonProperty(PropertyName = "computerName")]
        public string ComputerName { get; set; }

        /// <summary>
        /// Gets or sets specifies the name of the administrator account.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **Windows-only restriction:**
        /// Cannot end in "." &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **Disallowed
        /// values:** "administrator", "admin", "user", "user1", "test",
        /// "user2", "test1", "user3", "admin1", "1", "123", "a", "actuser",
        /// "adm", "admin2", "aspnet", "backup", "console", "david", "guest",
        /// "john", "owner", "root", "server", "sql", "support",
        /// "support_388945a0", "sys", "test2", "test3", "user4", "user5".
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **Minimum-length (Linux):** 1
        /// character &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **Max-length
        /// (Linux):** 64 characters &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;
        /// **Max-length (Windows):** 20 characters
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;&amp;lt;li&amp;gt; For root
        /// access to the Linux VM, see [Using root privileges on Linux virtual
        /// machines in
        /// Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-use-root-privileges?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)&amp;lt;br&amp;gt;&amp;lt;li&amp;gt;
        /// For a list of built-in system users on Linux that should not be
        /// used in this field, see [Selecting User Names for Linux on
        /// Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-usernames?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)
        /// </summary>
        [JsonProperty(PropertyName = "adminUsername")]
        public string AdminUsername { get; set; }

        /// <summary>
        /// Gets or sets specifies the password of the administrator account.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **Minimum-length (Windows):**
        /// 8 characters &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **Minimum-length
        /// (Linux):** 6 characters &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;
        /// **Max-length (Windows):** 123 characters
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **Max-length (Linux):** 72
        /// characters &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **Complexity
        /// requirements:** 3 out of 4 conditions below need to be fulfilled
        /// &amp;lt;br&amp;gt; Has lower characters &amp;lt;br&amp;gt;Has upper
        /// characters &amp;lt;br&amp;gt; Has a digit &amp;lt;br&amp;gt; Has a
        /// special character (Regex match [\W_])
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **Disallowed values:**
        /// "abc@123", "P@$$w0rd", "P@ssw0rd", "P@ssword123", "Pa$$word",
        /// "pass@word1", "Password!", "Password1", "Password22", "iloveyou!"
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; For resetting the password,
        /// see [How to reset the Remote Desktop service or its login password
        /// in a Windows
        /// VM](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-reset-rdp?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json)
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; For resetting root password,
        /// see [Manage users, SSH, and check or repair disks on Azure Linux
        /// VMs using the VMAccess
        /// Extension](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-using-vmaccess-extension?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json#reset-root-password)
        /// </summary>
        [JsonProperty(PropertyName = "adminPassword")]
        public string AdminPassword { get; set; }

        /// <summary>
        /// Gets or sets specifies a base-64 encoded string of custom data. The
        /// base-64 encoded string is decoded to a binary array that is saved
        /// as a file on the Virtual Machine. The maximum length of the binary
        /// array is 65535 bytes. &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; For
        /// using cloud-init for your VM, see [Using cloud-init to customize a
        /// Linux VM during
        /// creation](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-using-cloud-init?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)
        /// </summary>
        [JsonProperty(PropertyName = "customData")]
        public string CustomData { get; set; }

        /// <summary>
        /// Gets or sets specifies Windows operating system settings on the
        /// virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "windowsConfiguration")]
        public WindowsConfiguration WindowsConfiguration { get; set; }

        /// <summary>
        /// Gets or sets specifies the Linux operating system settings on the
        /// virtual machine. &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;For a list of
        /// supported Linux distributions, see [Linux on Azure-Endorsed
        /// Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-endorsed-distros?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; For running non-endorsed
        /// distributions, see [Information for Non-Endorsed
        /// Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-create-upload-generic?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json).
        /// </summary>
        [JsonProperty(PropertyName = "linuxConfiguration")]
        public LinuxConfiguration LinuxConfiguration { get; set; }

        /// <summary>
        /// Gets or sets specifies set of certificates that should be installed
        /// onto the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "secrets")]
        public IList<VaultSecretGroup> Secrets { get; set; }

    }
}
