// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary>
    /// Deploy SAP Infrastructure Details.
    /// Please note <see cref="InfrastructureConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="SingleServerConfiguration"/> and <see cref="ThreeTierConfiguration"/>.
    /// </summary>
    public abstract partial class InfrastructureConfiguration
    {
        /// <summary> Initializes a new instance of InfrastructureConfiguration. </summary>
        /// <param name="appResourceGroup"> The application resource group where SAP system resources will be deployed. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="appResourceGroup"/> is null. </exception>
        protected InfrastructureConfiguration(string appResourceGroup)
        {
            if (appResourceGroup == null)
            {
                throw new ArgumentNullException(nameof(appResourceGroup));
            }

            AppResourceGroup = appResourceGroup;
        }

        /// <summary> Initializes a new instance of InfrastructureConfiguration. </summary>
        /// <param name="deploymentType"> The deployment Type. </param>
        /// <param name="appResourceGroup"> The application resource group where SAP system resources will be deployed. </param>
        internal InfrastructureConfiguration(SapDeploymentType deploymentType, string appResourceGroup)
        {
            DeploymentType = deploymentType;
            AppResourceGroup = appResourceGroup;
        }

        /// <summary> The deployment Type. </summary>
        internal SapDeploymentType DeploymentType { get; set; }
        /// <summary> The application resource group where SAP system resources will be deployed. </summary>
        public string AppResourceGroup { get; set; }
    }
}
