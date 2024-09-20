// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// Information about the dead letter destination for an event subscription. To
/// configure a deadletter destination, do not directly instantiate an object
/// of this class. Instead, instantiate an object of a derived class.
/// Currently, StorageBlobDeadLetterDestination is the only class that derives
/// from this class.             Please note
/// Azure.ResourceManager.EventGrid.Models.DeadLetterDestination is the base
/// class. According to the scenario, a derived class of the base class might
/// need to be assigned here, or this property needs to be casted to one of
/// the possible derived classes.             The available derived classes
/// include
/// Azure.ResourceManager.EventGrid.Models.StorageBlobDeadLetterDestination.
/// </summary>
public partial class DeadLetterDestination : ProvisioningConstruct
{
    /// <summary>
    /// Creates a new DeadLetterDestination.
    /// </summary>
    public DeadLetterDestination()
    {
    }
}
