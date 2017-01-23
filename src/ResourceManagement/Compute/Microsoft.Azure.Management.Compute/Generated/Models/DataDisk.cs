// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System.Linq;

    /// <summary>
    /// Describes a data disk.
    /// </summary>
    public partial class DataDisk
    {
        /// <summary>
        /// Initializes a new instance of the DataDisk class.
        /// </summary>
        public DataDisk() { }

        /// <summary>
        /// Initializes a new instance of the DataDisk class.
        /// </summary>
        /// <param name="lun">The logical unit number.</param>
        /// <param name="createOption">The create option. Possible values
        /// include: 'fromImage', 'empty', 'attach'</param>
        /// <param name="name">The disk name.</param>
        /// <param name="vhd">The virtual hard disk.</param>
        /// <param name="image">The source user image virtual hard disk. This
        /// virtual hard disk will be copied before using it to attach to the
        /// virtual machine. If SourceImage is provided, the destination
        /// virtual hard disk must not exist.</param>
        /// <param name="caching">The caching type. Possible values include:
        /// 'None', 'ReadOnly', 'ReadWrite'</param>
        /// <param name="diskSizeGB">The initial disk size in GB for blank
        /// data disks, and the new desired size for resizing existing OS and
        /// data disks.</param>
        /// <param name="managedDisk">The managed disk parameters.</param>
        public DataDisk(int lun, DiskCreateOptionTypes createOption, string name = default(string), VirtualHardDisk vhd = default(VirtualHardDisk), VirtualHardDisk image = default(VirtualHardDisk), CachingTypes? caching = default(CachingTypes?), int? diskSizeGB = default(int?), ManagedDiskParameters managedDisk = default(ManagedDiskParameters))
        {
            Lun = lun;
            Name = name;
            Vhd = vhd;
            Image = image;
            Caching = caching;
            CreateOption = createOption;
            DiskSizeGB = diskSizeGB;
            ManagedDisk = managedDisk;
        }

        /// <summary>
        /// Gets or sets the logical unit number.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lun")]
        public int Lun { get; set; }

        /// <summary>
        /// Gets or sets the disk name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the virtual hard disk.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "vhd")]
        public VirtualHardDisk Vhd { get; set; }

        /// <summary>
        /// Gets or sets the source user image virtual hard disk. This virtual
        /// hard disk will be copied before using it to attach to the virtual
        /// machine. If SourceImage is provided, the destination virtual hard
        /// disk must not exist.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "image")]
        public VirtualHardDisk Image { get; set; }

        /// <summary>
        /// Gets or sets the caching type. Possible values include: 'None',
        /// 'ReadOnly', 'ReadWrite'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "caching")]
        public CachingTypes? Caching { get; set; }

        /// <summary>
        /// Gets or sets the create option. Possible values include:
        /// 'fromImage', 'empty', 'attach'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "createOption")]
        public DiskCreateOptionTypes CreateOption { get; set; }

        /// <summary>
        /// Gets or sets the initial disk size in GB for blank data disks, and
        /// the new desired size for resizing existing OS and data disks.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "diskSizeGB")]
        public int? DiskSizeGB { get; set; }

        /// <summary>
        /// Gets or sets the managed disk parameters.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "managedDisk")]
        public ManagedDiskParameters ManagedDisk { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
