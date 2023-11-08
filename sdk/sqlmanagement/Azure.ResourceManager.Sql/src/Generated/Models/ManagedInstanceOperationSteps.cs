// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The steps of a managed instance operation. </summary>
    public partial class ManagedInstanceOperationSteps
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManagedInstanceOperationSteps"/>. </summary>
        internal ManagedInstanceOperationSteps()
        {
            StepsList = new ChangeTrackingList<UpsertManagedServerOperationStep>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedInstanceOperationSteps"/>. </summary>
        /// <param name="totalSteps"> The total number of operation steps. </param>
        /// <param name="currentStep"> The number of current operation steps. </param>
        /// <param name="stepsList"> The operation steps list. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedInstanceOperationSteps(string totalSteps, int? currentStep, IReadOnlyList<UpsertManagedServerOperationStep> stepsList, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TotalSteps = totalSteps;
            CurrentStep = currentStep;
            StepsList = stepsList;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The total number of operation steps. </summary>
        public string TotalSteps { get; }
        /// <summary> The number of current operation steps. </summary>
        public int? CurrentStep { get; }
        /// <summary> The operation steps list. </summary>
        public IReadOnlyList<UpsertManagedServerOperationStep> StepsList { get; }
    }
}
