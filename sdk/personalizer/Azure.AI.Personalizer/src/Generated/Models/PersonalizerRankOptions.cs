// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.Personalizer
{
    /// <summary> Request a set of actions to be ranked by the Personalizer service. </summary>
    public partial class PersonalizerRankOptions
    {
        /// <summary> Initializes a new instance of PersonalizerRankOptions. </summary>
        /// <param name="actions">
        /// The set of actions the Personalizer service can pick from.
        /// The set should not contain more than 50 actions.
        /// The order of the actions does not affect the rank result but the order
        /// should match the sequence your application would have used to display them.
        /// The first item in the array will be used as Baseline item in Offline Evaluations.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="actions"/> is null. </exception>
        public PersonalizerRankOptions(IEnumerable<PersonalizerRankableAction> actions)
        {
            if (actions == null)
            {
                throw new ArgumentNullException(nameof(actions));
            }

            ContextFeatures = new ChangeTrackingList<object>();
            Actions = actions;
            ExcludedActions = new ChangeTrackingList<string>();
        }
        /// <summary>
        /// Optionally pass an eventId that uniquely identifies this Rank event.
        /// If null, the service generates a unique eventId. The eventId will be used for
        /// associating this request with its reward, as well as seeding the pseudo-random
        /// generator when making a Personalizer call.
        /// </summary>
        public string EventId { get; set; }
        /// <summary>
        /// Send false if it is certain the rewardActionId in rank results will be shown to the user, therefore
        /// Personalizer will expect a Reward call, otherwise it will assign the default
        /// Reward to the event. Send true if it is possible the user will not see the action specified in the rank results,
        /// (e.g. because the page is rendering later, or the Rank results may be overridden by code further downstream).
        /// You must call the Activate Event API if the event output is shown to users, otherwise Rewards will be ignored.
        /// </summary>
        public bool? DeferActivation { get; set; }
    }
}
