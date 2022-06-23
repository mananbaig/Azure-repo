// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Azure.Messaging.EventHubs.Producer;

namespace Azure.Messaging.EventHubs.Stress;

/// <summary>
///   The set of configurations to use for a test scenario run.
/// </summary>
///
public class TestConfiguration
{
    // Resource Configurations

    /// <summary>
    ///   The Event Hubs Namespace connection string to use for a test run.
    /// </summary>
    ///
    public string EventHubsConnectionString = string.Empty;

    /// <summary>
    ///   The name of the Event Hub to use for a test run.
    /// </summary>
    ///
    public string EventHub = string.Empty;

    /// <summary>
    ///   The Storage account connection string to use for a test run.
    /// </summary>
    ///
    public string StorageConnectionString = string.Empty;

    /// <summary>
    ///   The blob storage container to use for a test run.
    /// </summary>
    ///
    public string BlobContainer = string.Empty;

    // Test Run Configurations

    /// <summary>
    ///   The number of hours to run a test scenario for.
    /// </summary>
    ///
    public int DurationInHours = 150;

    /// <summary>
    ///   Gets the partition count of the Event Hub being used for this test run.
    /// </summary>
    ///
    /// <returns>The number of partitions in the Event Hub associated with this test.</returns>
    ///
    public async Task<int> GetEventHubPartitionCountAsync()
    {
        int partitionCount;

        if (string.IsNullOrEmpty(EventHubsConnectionString) || string.IsNullOrEmpty(EventHub))
        {
            return 0;
        }

        await using (var producerClient = new EventHubProducerClient(EventHubsConnectionString, EventHub))
        {
            partitionCount = (await producerClient.GetEventHubPropertiesAsync().ConfigureAwait(false)).PartitionIds.Length;
        }

        return partitionCount;
    }

    /// <summary>
    ///   Gets the list of partitions from the Event Hub being used for this test run.
    /// </summary>
    ///
    /// <returns>An array holding the partition IDs associated with the Event Hub used for this test.>/returns>
    ///
    public async Task<string[]> GetEventHubPartitionsAsync()
    {
        if (string.IsNullOrEmpty(EventHubsConnectionString) || string.IsNullOrEmpty(EventHub))
        {
            return new string[0];
        }

        await using (var producerClient = new EventHubProducerClient(EventHubsConnectionString, EventHub))
        {
            return (await producerClient.GetPartitionIdsAsync().ConfigureAwait(false));
        }
    }
}