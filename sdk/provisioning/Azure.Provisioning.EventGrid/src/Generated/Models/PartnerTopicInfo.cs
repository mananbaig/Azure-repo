// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// Properties of the corresponding partner topic of a Channel.
/// </summary>
public partial class PartnerTopicInfo : ProvisionableConstruct
{
    /// <summary>
    /// Azure subscription ID of the subscriber. The partner topic associated
    /// with the channel will be             created under this Azure
    /// subscription.
    /// </summary>
    public BicepValue<Guid> AzureSubscriptionId { get => _azureSubscriptionId; set => _azureSubscriptionId.Assign(value); }
    private readonly BicepValue<Guid> _azureSubscriptionId;

    /// <summary>
    /// Azure Resource Group of the subscriber. The partner topic associated
    /// with the channel will be             created under this resource group.
    /// </summary>
    public BicepValue<string> ResourceGroupName { get => _resourceGroupName; set => _resourceGroupName.Assign(value); }
    private readonly BicepValue<string> _resourceGroupName;

    /// <summary>
    /// Name of the partner topic associated with the channel.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Event Type Information for the partner topic. This information is
    /// provided by the publisher and can be used by the
    /// subscriber to view different types of events that are
    /// published.
    /// </summary>
    public BicepValue<PartnerTopicEventTypeInfo> EventTypeInfo { get => _eventTypeInfo; set => _eventTypeInfo.Assign(value); }
    private readonly BicepValue<PartnerTopicEventTypeInfo> _eventTypeInfo;

    /// <summary>
    /// The source information is provided by the publisher to determine the
    /// scope or context from which the events             are originating.
    /// This information can be used by the subscriber during the approval
    /// process of the             created partner topic.
    /// </summary>
    public BicepValue<string> Source { get => _source; set => _source.Assign(value); }
    private readonly BicepValue<string> _source;

    /// <summary>
    /// Creates a new PartnerTopicInfo.
    /// </summary>
    public PartnerTopicInfo()
    {
        _azureSubscriptionId = BicepValue<Guid>.DefineProperty(this, "AzureSubscriptionId", ["azureSubscriptionId"]);
        _resourceGroupName = BicepValue<string>.DefineProperty(this, "ResourceGroupName", ["resourceGroupName"]);
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"]);
        _eventTypeInfo = BicepValue<PartnerTopicEventTypeInfo>.DefineProperty(this, "EventTypeInfo", ["eventTypeInfo"]);
        _source = BicepValue<string>.DefineProperty(this, "Source", ["source"]);
    }
}
