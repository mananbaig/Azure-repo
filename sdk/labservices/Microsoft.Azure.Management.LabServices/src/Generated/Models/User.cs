// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.LabServices.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// User of a lab that can register for and use virtual machines within the
    /// lab.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class User : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the User class.
        /// </summary>
        public User()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the User class.
        /// </summary>
        /// <param name="email">Email address of the user.</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="systemData">Metadata pertaining to creation and last
        /// modification of the user resource.</param>
        /// <param name="additionalUsageQuota">The amount of usage quota time
        /// the user gets in addition to the lab usage quota.</param>
        /// <param name="provisioningState">Current provisioning state of the
        /// user resource. Possible values include: 'Creating', 'Updating',
        /// 'Deleting', 'Succeeded', 'Failed', 'Locked'</param>
        /// <param name="displayName">Display name of the user, for example
        /// user's full name.</param>
        /// <param name="registrationState">State of the user's registration
        /// within the lab. Possible values include: 'Registered',
        /// 'NotRegistered'</param>
        /// <param name="invitationState">State of the invitation message for
        /// the user. Possible values include: 'NotSent', 'Sending', 'Sent',
        /// 'Failed'</param>
        /// <param name="invitationSent">Date and time when the invitation
        /// message was sent to the user.</param>
        /// <param name="totalUsage">How long the user has used their virtual
        /// machines in this lab.</param>
        public User(string email, string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), System.TimeSpan? additionalUsageQuota = default(System.TimeSpan?), ProvisioningState? provisioningState = default(ProvisioningState?), string displayName = default(string), RegistrationState? registrationState = default(RegistrationState?), InvitationState? invitationState = default(InvitationState?), System.DateTime? invitationSent = default(System.DateTime?), System.TimeSpan? totalUsage = default(System.TimeSpan?))
            : base(id, name, type)
        {
            SystemData = systemData;
            AdditionalUsageQuota = additionalUsageQuota;
            ProvisioningState = provisioningState;
            DisplayName = displayName;
            Email = email;
            RegistrationState = registrationState;
            InvitationState = invitationState;
            InvitationSent = invitationSent;
            TotalUsage = totalUsage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets metadata pertaining to creation and last modification of the
        /// user resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

        /// <summary>
        /// Gets or sets the amount of usage quota time the user gets in
        /// addition to the lab usage quota.
        /// </summary>
        [JsonProperty(PropertyName = "properties.additionalUsageQuota")]
        public System.TimeSpan? AdditionalUsageQuota { get; set; }

        /// <summary>
        /// Gets current provisioning state of the user resource. Possible
        /// values include: 'Creating', 'Updating', 'Deleting', 'Succeeded',
        /// 'Failed', 'Locked'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState? ProvisioningState { get; private set; }

        /// <summary>
        /// Gets display name of the user, for example user's full name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets or sets email address of the user.
        /// </summary>
        [JsonProperty(PropertyName = "properties.email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets state of the user's registration within the lab. Possible
        /// values include: 'Registered', 'NotRegistered'
        /// </summary>
        [JsonProperty(PropertyName = "properties.registrationState")]
        public RegistrationState? RegistrationState { get; private set; }

        /// <summary>
        /// Gets state of the invitation message for the user. Possible values
        /// include: 'NotSent', 'Sending', 'Sent', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.invitationState")]
        public InvitationState? InvitationState { get; private set; }

        /// <summary>
        /// Gets date and time when the invitation message was sent to the
        /// user.
        /// </summary>
        [JsonProperty(PropertyName = "properties.invitationSent")]
        public System.DateTime? InvitationSent { get; private set; }

        /// <summary>
        /// Gets how long the user has used their virtual machines in this lab.
        /// </summary>
        [JsonProperty(PropertyName = "properties.totalUsage")]
        public System.TimeSpan? TotalUsage { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Email == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Email");
            }
        }
    }
}
