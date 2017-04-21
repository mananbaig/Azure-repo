// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.Backup;

    /// <summary>
    /// Defines values for JobOperationType.
    /// </summary>
    public static class JobOperationType
    {
        public const string Invalid = "Invalid";
        public const string Register = "Register";
        public const string UnRegister = "UnRegister";
        public const string ConfigureBackup = "ConfigureBackup";
        public const string Backup = "Backup";
        public const string Restore = "Restore";
        public const string DisableBackup = "DisableBackup";
        public const string DeleteBackupData = "DeleteBackupData";
    }
}
