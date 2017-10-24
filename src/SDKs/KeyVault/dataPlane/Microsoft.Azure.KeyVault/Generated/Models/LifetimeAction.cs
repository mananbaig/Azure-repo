// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.KeyVault.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.KeyVault;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Action and its trigger that will be performed by Key Vault over the
    /// lifetime of a certificate.
    /// </summary>
    public partial class LifetimeAction
    {
        /// <summary>
        /// Initializes a new instance of the LifetimeAction class.
        /// </summary>
        public LifetimeAction()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LifetimeAction class.
        /// </summary>
        /// <param name="trigger">The condition that will execute the
        /// action.</param>
        /// <param name="action">The action that will be executed.</param>
        public LifetimeAction(Trigger trigger = default(Trigger), Action action = default(Action))
        {
            Trigger = trigger;
            Action = action;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the condition that will execute the action.
        /// </summary>
        [JsonProperty(PropertyName = "trigger")]
        public Trigger Trigger { get; set; }

        /// <summary>
        /// Gets or sets the action that will be executed.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public Action Action { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Trigger != null)
            {
                Trigger.Validate();
            }
        }
    }
}
