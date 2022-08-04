// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Properties used to create a user on an Azure Batch node. </summary>
    public partial class BatchUserAccount
    {
        /// <summary> Initializes a new instance of BatchUserAccount. </summary>
        /// <param name="name"> The name of the user account. </param>
        /// <param name="password"> The password for the user account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="password"/> is null. </exception>
        public BatchUserAccount(string name, string password)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }

            Name = name;
            Password = password;
        }

        /// <summary> Initializes a new instance of BatchUserAccount. </summary>
        /// <param name="name"> The name of the user account. </param>
        /// <param name="password"> The password for the user account. </param>
        /// <param name="elevationLevel"> nonAdmin - The auto user is a standard user without elevated access. admin - The auto user is a user with elevated access and operates with full Administrator permissions. The default value is nonAdmin. </param>
        /// <param name="linuxUserConfiguration"> This property is ignored if specified on a Windows pool. If not specified, the user is created with the default options. </param>
        /// <param name="windowsUserConfiguration"> This property can only be specified if the user is on a Windows pool. If not specified and on a Windows pool, the user is created with the default options. </param>
        internal BatchUserAccount(string name, string password, BatchUserAccountElevationLevel? elevationLevel, BatchLinuxUserConfiguration linuxUserConfiguration, BatchWindowsUserConfiguration windowsUserConfiguration)
        {
            Name = name;
            Password = password;
            ElevationLevel = elevationLevel;
            LinuxUserConfiguration = linuxUserConfiguration;
            WindowsUserConfiguration = windowsUserConfiguration;
        }

        /// <summary> The name of the user account. </summary>
        public string Name { get; set; }
        /// <summary> The password for the user account. </summary>
        public string Password { get; set; }
        /// <summary> nonAdmin - The auto user is a standard user without elevated access. admin - The auto user is a user with elevated access and operates with full Administrator permissions. The default value is nonAdmin. </summary>
        public BatchUserAccountElevationLevel? ElevationLevel { get; set; }
        /// <summary> This property is ignored if specified on a Windows pool. If not specified, the user is created with the default options. </summary>
        public BatchLinuxUserConfiguration LinuxUserConfiguration { get; set; }
        /// <summary> This property can only be specified if the user is on a Windows pool. If not specified and on a Windows pool, the user is created with the default options. </summary>
        internal BatchWindowsUserConfiguration WindowsUserConfiguration { get; set; }
        /// <summary> Specifies login mode for the user. The default value for VirtualMachineConfiguration pools is interactive mode and for CloudServiceConfiguration pools is batch mode. </summary>
        public BatchWindowsLoginMode? WindowsUserLoginMode
        {
            get => WindowsUserConfiguration is null ? default : WindowsUserConfiguration.LoginMode;
            set
            {
                if (WindowsUserConfiguration is null)
                    WindowsUserConfiguration = new BatchWindowsUserConfiguration();
                WindowsUserConfiguration.LoginMode = value;
            }
        }
    }
}
