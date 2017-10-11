// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The configuration for compute nodes in a pool based on the Azure Cloud Services platform.
    /// </summary>
    public partial class CloudServiceConfiguration : ITransportObjectProvider<Models.CloudServiceConfiguration>, IPropertyMetadata
    {
        private class PropertyContainer : PropertyCollection
        {
            public readonly PropertyAccessor<string> CurrentOSVersionProperty;
            public readonly PropertyAccessor<string> OSFamilyProperty;
            public readonly PropertyAccessor<string> TargetOSVersionProperty;

            public PropertyContainer() : base(BindingState.Unbound)
            {
                this.CurrentOSVersionProperty = this.CreatePropertyAccessor<string>(nameof(CurrentOSVersion), BindingAccess.None);
                this.OSFamilyProperty = this.CreatePropertyAccessor<string>(nameof(OSFamily), BindingAccess.Read | BindingAccess.Write);
                this.TargetOSVersionProperty = this.CreatePropertyAccessor<string>(nameof(TargetOSVersion), BindingAccess.Read | BindingAccess.Write);
            }

            public PropertyContainer(Models.CloudServiceConfiguration protocolObject) : base(BindingState.Bound)
            {
                this.CurrentOSVersionProperty = this.CreatePropertyAccessor(
                    protocolObject.CurrentOSVersion,
                    nameof(CurrentOSVersion),
                    BindingAccess.Read);
                this.OSFamilyProperty = this.CreatePropertyAccessor(
                    protocolObject.OsFamily,
                    nameof(OSFamily),
                    BindingAccess.Read | BindingAccess.Write);
                this.TargetOSVersionProperty = this.CreatePropertyAccessor(
                    protocolObject.TargetOSVersion,
                    nameof(TargetOSVersion),
                    BindingAccess.Read | BindingAccess.Write);
            }
        }

        private readonly PropertyContainer propertyContainer;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudServiceConfiguration"/> class.
        /// </summary>
        /// <param name='osFamily'>The Azure Guest OS family to be installed on the virtual machines in the pool.</param>
        /// <param name='targetOSVersion'>The Azure Guest OS version to be installed on the virtual machines in the pool. If no value is provided, the 
        /// Batch service will default to "'*", which specifies the latest operating system version for the <see cref="OSFamily"/>.</param>
        public CloudServiceConfiguration(
            string osFamily,
            string targetOSVersion = default(string))
        {
            this.propertyContainer = new PropertyContainer();
            this.OSFamily = osFamily;
            this.TargetOSVersion = targetOSVersion;
        }

        internal CloudServiceConfiguration(Models.CloudServiceConfiguration protocolObject)
        {
            this.propertyContainer = new PropertyContainer(protocolObject);
        }

        #endregion Constructors

        #region CloudServiceConfiguration

        /// <summary>
        /// Gets the Azure Guest OS version currently installed on the virtual machines in the pool. This may differ from 
        /// <see cref="TargetOSVersion"/> if the pool state is <see cref="Common.PoolState.Upgrading"/>.
        /// </summary>
        public string CurrentOSVersion
        {
            get { return this.propertyContainer.CurrentOSVersionProperty.Value; }
        }

        /// <summary>
        /// Gets or sets the Azure Guest OS family to be installed on the virtual machines in the pool.
        /// </summary>
        /// <remarks>
        /// For more information about Guest OS families, see https://azure.microsoft.com/documentation/articles/cloud-services-guestos-update-matrix/.
        /// </remarks>
        public string OSFamily
        {
            get { return this.propertyContainer.OSFamilyProperty.Value; }
            set { this.propertyContainer.OSFamilyProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the Azure Guest OS version to be installed on the virtual machines in the pool. If no value is provided, 
        /// the Batch service will default to "'*", which specifies the latest operating system version for the <see cref="OSFamily"/>.
        /// </summary>
        public string TargetOSVersion
        {
            get { return this.propertyContainer.TargetOSVersionProperty.Value; }
            set { this.propertyContainer.TargetOSVersionProperty.Value = value; }
        }

        #endregion // CloudServiceConfiguration

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            get { return this.propertyContainer.HasBeenModified; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return this.propertyContainer.IsReadOnly; }
            set { this.propertyContainer.IsReadOnly = value; }
        }

        #endregion //IPropertyMetadata

        #region Internal/private methods
        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.CloudServiceConfiguration ITransportObjectProvider<Models.CloudServiceConfiguration>.GetTransportObject()
        {
            Models.CloudServiceConfiguration result = new Models.CloudServiceConfiguration()
            {
                OsFamily = this.OSFamily,
                TargetOSVersion = this.TargetOSVersion,
            };

            return result;
        }


        #endregion // Internal/private methods
    }
}