// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.Backup;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Restore files/folders from a backup copy of IaaS VM.
    /// </summary>
    public partial class IaasVMILRRegistrationRequest : ILRRequest
    {
        /// <summary>
        /// Initializes a new instance of the IaasVMILRRegistrationRequest
        /// class.
        /// </summary>
        public IaasVMILRRegistrationRequest()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IaasVMILRRegistrationRequest
        /// class.
        /// </summary>
        /// <param name="recoveryPointId">ID of the IaaS VM backup copy from
        /// where the files/folders have to be restored.</param>
        /// <param name="virtualMachineId">Fully qualified ARM ID of the
        /// virtual machine whose the files / folders have to be
        /// restored.</param>
        /// <param name="initiatorName">iSCSI initiator name.</param>
        /// <param name="renewExistingRegistration">Whether to renew existing
        /// registration with the iSCSI server.</param>
        public IaasVMILRRegistrationRequest(string recoveryPointId = default(string), string virtualMachineId = default(string), string initiatorName = default(string), bool? renewExistingRegistration = default(bool?))
        {
            RecoveryPointId = recoveryPointId;
            VirtualMachineId = virtualMachineId;
            InitiatorName = initiatorName;
            RenewExistingRegistration = renewExistingRegistration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ID of the IaaS VM backup copy from where the
        /// files/folders have to be restored.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointId")]
        public string RecoveryPointId { get; set; }

        /// <summary>
        /// Gets or sets fully qualified ARM ID of the virtual machine whose
        /// the files / folders have to be restored.
        /// </summary>
        [JsonProperty(PropertyName = "virtualMachineId")]
        public string VirtualMachineId { get; set; }

        /// <summary>
        /// Gets or sets iSCSI initiator name.
        /// </summary>
        [JsonProperty(PropertyName = "initiatorName")]
        public string InitiatorName { get; set; }

        /// <summary>
        /// Gets or sets whether to renew existing registration with the iSCSI
        /// server.
        /// </summary>
        [JsonProperty(PropertyName = "renewExistingRegistration")]
        public bool? RenewExistingRegistration { get; set; }

    }
}
