// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DevTestLabs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevTestLabs
{
    /// <summary>
    /// A class representing the DevTestLabCustomImage data model.
    /// A custom image.
    /// </summary>
    public partial class DevTestLabCustomImageData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DevTestLabCustomImageData"/>. </summary>
        /// <param name="location"> The location. </param>
        public DevTestLabCustomImageData(AzureLocation location) : base(location)
        {
            DataDiskStorageInfo = new ChangeTrackingList<DevTestLabDataDiskStorageTypeInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="DevTestLabCustomImageData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="vm"> The virtual machine from which the image is to be created. </param>
        /// <param name="vhd"> The VHD from which the image is to be created. </param>
        /// <param name="description"> The description of the custom image. </param>
        /// <param name="author"> The author of the custom image. </param>
        /// <param name="createdOn"> The creation date of the custom image. </param>
        /// <param name="managedImageId"> The Managed Image Id backing the custom image. </param>
        /// <param name="managedSnapshotId"> The Managed Snapshot Id backing the custom image. </param>
        /// <param name="dataDiskStorageInfo"> Storage information about the data disks present in the custom image. </param>
        /// <param name="customImagePlan"> Storage information about the plan related to this custom image. </param>
        /// <param name="isPlanAuthorized"> Whether or not the custom images underlying offer/plan has been enabled for programmatic deployment. </param>
        /// <param name="provisioningState"> The provisioning status of the resource. </param>
        /// <param name="uniqueIdentifier"> The unique immutable identifier of a resource (Guid). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DevTestLabCustomImageData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, DevTestLabCustomImageVm vm, DevTestLabCustomImageVhd vhd, string description, string author, DateTimeOffset? createdOn, string managedImageId, string managedSnapshotId, IList<DevTestLabDataDiskStorageTypeInfo> dataDiskStorageInfo, DevTestLabCustomImagePlan customImagePlan, bool? isPlanAuthorized, string provisioningState, Guid? uniqueIdentifier, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Vm = vm;
            Vhd = vhd;
            Description = description;
            Author = author;
            CreatedOn = createdOn;
            ManagedImageId = managedImageId;
            ManagedSnapshotId = managedSnapshotId;
            DataDiskStorageInfo = dataDiskStorageInfo;
            CustomImagePlan = customImagePlan;
            IsPlanAuthorized = isPlanAuthorized;
            ProvisioningState = provisioningState;
            UniqueIdentifier = uniqueIdentifier;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DevTestLabCustomImageData"/> for deserialization. </summary>
        internal DevTestLabCustomImageData()
        {
        }

        /// <summary> The virtual machine from which the image is to be created. </summary>
        public DevTestLabCustomImageVm Vm { get; set; }
        /// <summary> The VHD from which the image is to be created. </summary>
        public DevTestLabCustomImageVhd Vhd { get; set; }
        /// <summary> The description of the custom image. </summary>
        public string Description { get; set; }
        /// <summary> The author of the custom image. </summary>
        public string Author { get; set; }
        /// <summary> The creation date of the custom image. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The Managed Image Id backing the custom image. </summary>
        public string ManagedImageId { get; set; }
        /// <summary> The Managed Snapshot Id backing the custom image. </summary>
        public string ManagedSnapshotId { get; set; }
        /// <summary> Storage information about the data disks present in the custom image. </summary>
        public IList<DevTestLabDataDiskStorageTypeInfo> DataDiskStorageInfo { get; }
        /// <summary> Storage information about the plan related to this custom image. </summary>
        public DevTestLabCustomImagePlan CustomImagePlan { get; set; }
        /// <summary> Whether or not the custom images underlying offer/plan has been enabled for programmatic deployment. </summary>
        public bool? IsPlanAuthorized { get; set; }
        /// <summary> The provisioning status of the resource. </summary>
        public string ProvisioningState { get; }
        /// <summary> The unique immutable identifier of a resource (Guid). </summary>
        public Guid? UniqueIdentifier { get; }
    }
}
