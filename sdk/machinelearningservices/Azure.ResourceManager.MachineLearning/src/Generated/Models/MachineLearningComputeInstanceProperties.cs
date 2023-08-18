// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Compute Instance properties. </summary>
    public partial class MachineLearningComputeInstanceProperties
    {
        /// <summary> Initializes a new instance of MachineLearningComputeInstanceProperties. </summary>
        public MachineLearningComputeInstanceProperties()
        {
            Applications = new Core.ChangeTrackingList<MachineLearningComputeInstanceApplication>();
            Errors = new Core.ChangeTrackingList<MachineLearningError>();
            Containers = new Core.ChangeTrackingList<MachineLearningComputeInstanceContainer>();
            DataDisks = new Core.ChangeTrackingList<MachineLearningComputeInstanceDataDisk>();
            DataMounts = new Core.ChangeTrackingList<MachineLearningComputeInstanceDataMount>();
        }

        /// <summary> Initializes a new instance of MachineLearningComputeInstanceProperties. </summary>
        /// <param name="vmSize"> Virtual Machine Size. </param>
        /// <param name="subnet"> Virtual network subnet resource ID the compute nodes belong to. </param>
        /// <param name="applicationSharingPolicy"> Policy for sharing applications on this compute instance among users of parent workspace. If Personal, only the creator can access applications on this compute instance. When Shared, any workspace user can access applications on this instance depending on his/her assigned role. </param>
        /// <param name="sshSettings"> Specifies policy and settings for SSH access. </param>
        /// <param name="connectivityEndpoints"> Describes all connectivity endpoints available for this ComputeInstance. </param>
        /// <param name="applications"> Describes available applications and their endpoints on this ComputeInstance. </param>
        /// <param name="createdBy"> Describes information on user who created this ComputeInstance. </param>
        /// <param name="errors"> Collection of errors encountered on this ComputeInstance. </param>
        /// <param name="state"> The current state of this ComputeInstance. </param>
        /// <param name="computeInstanceAuthorizationType"> The Compute Instance Authorization type. Available values are personal (default). </param>
        /// <param name="personalComputeInstanceSettings"> Settings for a personal compute instance. </param>
        /// <param name="setupScriptsSettings"> Details of customized scripts to execute for setting up the cluster. </param>
        /// <param name="lastOperation"> The last operation on ComputeInstance. </param>
        /// <param name="schedules"> The list of schedules to be applied on the computes. </param>
        /// <param name="enableNodePublicIP"> Enable or disable node public IP address provisioning. Possible values are: Possible values are: true - Indicates that the compute nodes will have public IPs provisioned. false - Indicates that the compute nodes will have a private endpoint and no public IPs. </param>
        /// <param name="containers"> Describes informations of containers on this ComputeInstance. </param>
        /// <param name="dataDisks"> Describes informations of dataDisks on this ComputeInstance. </param>
        /// <param name="dataMounts"> Describes informations of dataMounts on this ComputeInstance. </param>
        /// <param name="versions"> ComputeInstance version. </param>
        internal MachineLearningComputeInstanceProperties(string vmSize, ResourceId subnet, MachineLearningApplicationSharingPolicy? applicationSharingPolicy, MachineLearningComputeInstanceSshSettings sshSettings, MachineLearningComputeInstanceConnectivityEndpoints connectivityEndpoints, IReadOnlyList<MachineLearningComputeInstanceApplication> applications, MachineLearningComputeInstanceCreatedBy createdBy, IReadOnlyList<MachineLearningError> errors, MachineLearningComputeInstanceState? state, MachineLearningComputeInstanceAuthorizationType? computeInstanceAuthorizationType, PersonalComputeInstanceSettings personalComputeInstanceSettings, SetupScripts setupScriptsSettings, MachineLearningComputeInstanceLastOperation lastOperation, ComputeSchedules schedules, bool? enableNodePublicIP, IReadOnlyList<MachineLearningComputeInstanceContainer> containers, IReadOnlyList<MachineLearningComputeInstanceDataDisk> dataDisks, IReadOnlyList<MachineLearningComputeInstanceDataMount> dataMounts, ComputeInstanceVersion versions)
        {
            VmSize = vmSize;
            Subnet = subnet;
            ApplicationSharingPolicy = applicationSharingPolicy;
            SshSettings = sshSettings;
            ConnectivityEndpoints = connectivityEndpoints;
            Applications = applications;
            CreatedBy = createdBy;
            Errors = errors;
            State = state;
            ComputeInstanceAuthorizationType = computeInstanceAuthorizationType;
            PersonalComputeInstanceSettings = personalComputeInstanceSettings;
            SetupScriptsSettings = setupScriptsSettings;
            LastOperation = lastOperation;
            Schedules = schedules;
            EnableNodePublicIP = enableNodePublicIP;
            Containers = containers;
            DataDisks = dataDisks;
            DataMounts = dataMounts;
            Versions = versions;
        }

        /// <summary> Virtual Machine Size. </summary>
        public string VmSize { get; set; }
        /// <summary> Virtual network subnet resource ID the compute nodes belong to. </summary>
        internal ResourceId Subnet { get; set; }
        /// <summary> The ID of the resource. </summary>
        public ResourceIdentifier SubnetId
        {
            get => Subnet is null ? default : Subnet.Id;
            set => Subnet = new ResourceId(value);
        }

        /// <summary> Policy for sharing applications on this compute instance among users of parent workspace. If Personal, only the creator can access applications on this compute instance. When Shared, any workspace user can access applications on this instance depending on his/her assigned role. </summary>
        public MachineLearningApplicationSharingPolicy? ApplicationSharingPolicy { get; set; }
        /// <summary> Specifies policy and settings for SSH access. </summary>
        public MachineLearningComputeInstanceSshSettings SshSettings { get; set; }
        /// <summary> Describes all connectivity endpoints available for this ComputeInstance. </summary>
        public MachineLearningComputeInstanceConnectivityEndpoints ConnectivityEndpoints { get; }
        /// <summary> Describes available applications and their endpoints on this ComputeInstance. </summary>
        public IReadOnlyList<MachineLearningComputeInstanceApplication> Applications { get; }
        /// <summary> Describes information on user who created this ComputeInstance. </summary>
        public MachineLearningComputeInstanceCreatedBy CreatedBy { get; }
        /// <summary> Collection of errors encountered on this ComputeInstance. </summary>
        public IReadOnlyList<MachineLearningError> Errors { get; }
        /// <summary> The current state of this ComputeInstance. </summary>
        public MachineLearningComputeInstanceState? State { get; }
        /// <summary> The Compute Instance Authorization type. Available values are personal (default). </summary>
        public MachineLearningComputeInstanceAuthorizationType? ComputeInstanceAuthorizationType { get; set; }
        /// <summary> Settings for a personal compute instance. </summary>
        internal PersonalComputeInstanceSettings PersonalComputeInstanceSettings { get; set; }
        /// <summary> A user explicitly assigned to a personal compute instance. </summary>
        public MachineLearningComputeInstanceAssignedUser PersonalComputeInstanceAssignedUser
        {
            get => PersonalComputeInstanceSettings is null ? default : PersonalComputeInstanceSettings.AssignedUser;
            set
            {
                if (PersonalComputeInstanceSettings is null)
                    PersonalComputeInstanceSettings = new PersonalComputeInstanceSettings();
                PersonalComputeInstanceSettings.AssignedUser = value;
            }
        }

        /// <summary> Details of customized scripts to execute for setting up the cluster. </summary>
        internal SetupScripts SetupScriptsSettings { get; set; }
        /// <summary> Customized setup scripts. </summary>
        public MachineLearningScriptsToExecute Scripts
        {
            get => SetupScriptsSettings is null ? default : SetupScriptsSettings.Scripts;
            set
            {
                if (SetupScriptsSettings is null)
                    SetupScriptsSettings = new SetupScripts();
                SetupScriptsSettings.Scripts = value;
            }
        }

        /// <summary> The last operation on ComputeInstance. </summary>
        public MachineLearningComputeInstanceLastOperation LastOperation { get; }
        /// <summary> The list of schedules to be applied on the computes. </summary>
        internal ComputeSchedules Schedules { get; }
        /// <summary> The list of compute start stop schedules to be applied. </summary>
        public IReadOnlyList<MachineLearningComputeStartStopSchedule> SchedulesComputeStartStop
        {
            get => Schedules?.ComputeStartStop;
        }

        /// <summary> Enable or disable node public IP address provisioning. Possible values are: Possible values are: true - Indicates that the compute nodes will have public IPs provisioned. false - Indicates that the compute nodes will have a private endpoint and no public IPs. </summary>
        public bool? EnableNodePublicIP { get; set; }
        /// <summary> Describes informations of containers on this ComputeInstance. </summary>
        public IReadOnlyList<MachineLearningComputeInstanceContainer> Containers { get; }
        /// <summary> Describes informations of dataDisks on this ComputeInstance. </summary>
        public IReadOnlyList<MachineLearningComputeInstanceDataDisk> DataDisks { get; }
        /// <summary> Describes informations of dataMounts on this ComputeInstance. </summary>
        public IReadOnlyList<MachineLearningComputeInstanceDataMount> DataMounts { get; }
        /// <summary> ComputeInstance version. </summary>
        internal ComputeInstanceVersion Versions { get; }
        /// <summary> Runtime of compute instance. </summary>
        public string VersionsRuntime
        {
            get => Versions?.Runtime;
        }
    }
}
