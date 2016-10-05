// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Network.Fluent
{

    using Microsoft.Azure.Management.Network.Fluent.Network.Definition;
    using Microsoft.Azure.Management.Resource.Fluent.Core;
    using Microsoft.Azure.Management.Network.Fluent.Subnet.UpdateDefinition;
    using Microsoft.Azure.Management.Network.Fluent.Subnet.Update;
    using Microsoft.Azure.Management.Resource.Fluent.Core.ChildResource.Definition;
    using Microsoft.Azure.Management.Network.Fluent.Network.Update;
    using Microsoft.Azure.Management.Resource.Fluent.Core.ChildResource.Update;
    using Microsoft.Azure.Management.Network.Fluent.Subnet.Definition;
    using Microsoft.Azure.Management.Network.Fluent.Models;
    public partial class SubnetImpl 
    {
        /// <summary>
        /// Attaches the child definition to the parent resource update.
        /// </summary>
        /// <returns>the next stage of the parent definition</returns>
        Microsoft.Azure.Management.Network.Fluent.Network.Update.IUpdate Microsoft.Azure.Management.Resource.Fluent.Core.ChildResource.Update.IInUpdate<Microsoft.Azure.Management.Network.Fluent.Network.Update.IUpdate>.Attach() { 
            return this.Attach() as Microsoft.Azure.Management.Network.Fluent.Network.Update.IUpdate;
        }

        /// <summary>
        /// Assigns an existing network security group to this subnet.
        /// </summary>
        /// <param name="resourceId">resourceId the resource ID of the network security group</param>
        /// <returns>the next stage of the definition</returns>
        Microsoft.Azure.Management.Network.Fluent.Subnet.Definition.IWithAttach<Microsoft.Azure.Management.Network.Fluent.Network.Definition.IWithCreateAndSubnet> Microsoft.Azure.Management.Network.Fluent.Subnet.Definition.IWithNetworkSecurityGroup<Microsoft.Azure.Management.Network.Fluent.Network.Definition.IWithCreateAndSubnet>.WithExistingNetworkSecurityGroup(string resourceId) { 
            return this.WithExistingNetworkSecurityGroup( resourceId) as Microsoft.Azure.Management.Network.Fluent.Subnet.Definition.IWithAttach<Microsoft.Azure.Management.Network.Fluent.Network.Definition.IWithCreateAndSubnet>;
        }

        /// <summary>
        /// Assigns an existing network security group to this subnet.
        /// </summary>
        /// <param name="nsg">nsg the network security group to assign</param>
        /// <returns>the next stage of the definition</returns>
        Microsoft.Azure.Management.Network.Fluent.Subnet.Definition.IWithAttach<Microsoft.Azure.Management.Network.Fluent.Network.Definition.IWithCreateAndSubnet> Microsoft.Azure.Management.Network.Fluent.Subnet.Definition.IWithNetworkSecurityGroup<Microsoft.Azure.Management.Network.Fluent.Network.Definition.IWithCreateAndSubnet>.WithExistingNetworkSecurityGroup(INetworkSecurityGroup nsg) { 
            return this.WithExistingNetworkSecurityGroup( nsg) as Microsoft.Azure.Management.Network.Fluent.Subnet.Definition.IWithAttach<Microsoft.Azure.Management.Network.Fluent.Network.Definition.IWithCreateAndSubnet>;
        }

        /// <summary>
        /// Assigns an existing network security group to this subnet.
        /// </summary>
        /// <param name="resourceId">resourceId the resource ID of the network security group</param>
        /// <returns>the next stage of the definition</returns>
        Microsoft.Azure.Management.Network.Fluent.Subnet.UpdateDefinition.IWithAttach<Microsoft.Azure.Management.Network.Fluent.Network.Update.IUpdate> Microsoft.Azure.Management.Network.Fluent.Subnet.UpdateDefinition.IWithNetworkSecurityGroup<Microsoft.Azure.Management.Network.Fluent.Network.Update.IUpdate>.WithExistingNetworkSecurityGroup(string resourceId) { 
            return this.WithExistingNetworkSecurityGroup( resourceId) as Microsoft.Azure.Management.Network.Fluent.Subnet.UpdateDefinition.IWithAttach<Microsoft.Azure.Management.Network.Fluent.Network.Update.IUpdate>;
        }

        /// <summary>
        /// Assigns an existing network security group to this subnet.
        /// </summary>
        /// <param name="nsg">nsg the network security group to assign</param>
        /// <returns>the next stage of the definition</returns>
        Microsoft.Azure.Management.Network.Fluent.Subnet.UpdateDefinition.IWithAttach<Microsoft.Azure.Management.Network.Fluent.Network.Update.IUpdate> Microsoft.Azure.Management.Network.Fluent.Subnet.UpdateDefinition.IWithNetworkSecurityGroup<Microsoft.Azure.Management.Network.Fluent.Network.Update.IUpdate>.WithExistingNetworkSecurityGroup(INetworkSecurityGroup nsg) { 
            return this.WithExistingNetworkSecurityGroup( nsg) as Microsoft.Azure.Management.Network.Fluent.Subnet.UpdateDefinition.IWithAttach<Microsoft.Azure.Management.Network.Fluent.Network.Update.IUpdate>;
        }

        /// <returns>the network security group associated with this subnet</returns>
        /// <returns><p></returns>
        /// <returns>Note that this method will result in a call to Azure each time it is invoked.</returns>
        Microsoft.Azure.Management.Network.Fluent.INetworkSecurityGroup Microsoft.Azure.Management.Network.Fluent.ISubnet.GetNetworkSecurityGroup() { 
            return this.GetNetworkSecurityGroup() as Microsoft.Azure.Management.Network.Fluent.INetworkSecurityGroup;
        }

        /// <returns>the address space prefix, in CIDR notation, assigned to this subnet</returns>
        string Microsoft.Azure.Management.Network.Fluent.ISubnet.AddressPrefix
        {
            get
            { 
            return this.AddressPrefix() as string;
            }
        }
        /// <summary>
        /// Specifies the IP address space of the subnet, within the address space of the network.
        /// </summary>
        /// <param name="cidr">cidr the IP address space prefix using the CIDR notation</param>
        /// <returns>the next stage</returns>
        Microsoft.Azure.Management.Network.Fluent.Subnet.Update.IUpdate Microsoft.Azure.Management.Network.Fluent.Subnet.Update.IWithAddressPrefix.WithAddressPrefix(string cidr) { 
            return this.WithAddressPrefix( cidr) as Microsoft.Azure.Management.Network.Fluent.Subnet.Update.IUpdate;
        }

        /// <returns>the name of this child object</returns>
        string Microsoft.Azure.Management.Resource.Fluent.Core.IChildResource<Microsoft.Azure.Management.Network.Fluent.INetwork>.Name
        {
            get
            { 
            return this.Name() as string;
            }
        }
        /// <summary>
        /// Specifies the IP address space of the subnet, within the address space of the network.
        /// </summary>
        /// <param name="cidr">cidr the IP address space prefix using the CIDR notation</param>
        /// <returns>the next stage of the subnet definition</returns>
        Microsoft.Azure.Management.Network.Fluent.Subnet.Definition.IWithAttach<Microsoft.Azure.Management.Network.Fluent.Network.Definition.IWithCreateAndSubnet> Microsoft.Azure.Management.Network.Fluent.Subnet.Definition.IWithAddressPrefix<Microsoft.Azure.Management.Network.Fluent.Network.Definition.IWithCreateAndSubnet>.WithAddressPrefix(string cidr) { 
            return this.WithAddressPrefix( cidr) as Microsoft.Azure.Management.Network.Fluent.Subnet.Definition.IWithAttach<Microsoft.Azure.Management.Network.Fluent.Network.Definition.IWithCreateAndSubnet>;
        }

        /// <summary>
        /// Specifies the IP address space of the subnet, within the address space of the network.
        /// </summary>
        /// <param name="cidr">cidr the IP address space prefix using the CIDR notation</param>
        /// <returns>the next stage of the subnet definition</returns>
        Microsoft.Azure.Management.Network.Fluent.Subnet.UpdateDefinition.IWithAttach<Microsoft.Azure.Management.Network.Fluent.Network.Update.IUpdate> Microsoft.Azure.Management.Network.Fluent.Subnet.UpdateDefinition.IWithAddressPrefix<Microsoft.Azure.Management.Network.Fluent.Network.Update.IUpdate>.WithAddressPrefix(string cidr) { 
            return this.WithAddressPrefix( cidr) as Microsoft.Azure.Management.Network.Fluent.Subnet.UpdateDefinition.IWithAttach<Microsoft.Azure.Management.Network.Fluent.Network.Update.IUpdate>;
        }

        /// <summary>
        /// Attaches the child definition to the parent resource definiton.
        /// </summary>
        /// <returns>the next stage of the parent definition</returns>
        Microsoft.Azure.Management.Network.Fluent.Network.Definition.IWithCreateAndSubnet Microsoft.Azure.Management.Resource.Fluent.Core.ChildResource.Definition.IInDefinition<Microsoft.Azure.Management.Network.Fluent.Network.Definition.IWithCreateAndSubnet>.Attach() { 
            return this.Attach() as Microsoft.Azure.Management.Network.Fluent.Network.Definition.IWithCreateAndSubnet;
        }

        /// <summary>
        /// Assigns an existing network security group to this subnet.
        /// </summary>
        /// <param name="resourceId">resourceId the resource ID of the network security group</param>
        /// <returns>the next stage of the update</returns>
        Microsoft.Azure.Management.Network.Fluent.Subnet.Update.IUpdate Microsoft.Azure.Management.Network.Fluent.Subnet.Update.IWithNetworkSecurityGroup.WithExistingNetworkSecurityGroup(string resourceId) { 
            return this.WithExistingNetworkSecurityGroup( resourceId) as Microsoft.Azure.Management.Network.Fluent.Subnet.Update.IUpdate;
        }

        /// <summary>
        /// Assigns an existing network security group to this subnet.
        /// </summary>
        /// <param name="nsg">nsg the network security group to assign</param>
        /// <returns>the next stage of the update</returns>
        Microsoft.Azure.Management.Network.Fluent.Subnet.Update.IUpdate Microsoft.Azure.Management.Network.Fluent.Subnet.Update.IWithNetworkSecurityGroup.WithExistingNetworkSecurityGroup(INetworkSecurityGroup nsg) { 
            return this.WithExistingNetworkSecurityGroup( nsg) as Microsoft.Azure.Management.Network.Fluent.Subnet.Update.IUpdate;
        }

    }
}