// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The desired maximum forecast horizon in units of time-series frequency. </summary>
    public partial class CustomForecastHorizon : ForecastHorizon
    {
        /// <summary> Initializes a new instance of <see cref="CustomForecastHorizon"/>. </summary>
        /// <param name="value"> [Required] Forecast horizon value. </param>
        public CustomForecastHorizon(int value)
        {
            Value = value;
            Mode = ForecastHorizonMode.Custom;
        }

        /// <summary> Initializes a new instance of <see cref="CustomForecastHorizon"/>. </summary>
        /// <param name="mode"> [Required] Set forecast horizon value selection mode. </param>
        /// <param name="value"> [Required] Forecast horizon value. </param>
        internal CustomForecastHorizon(ForecastHorizonMode mode, int value) : base(mode)
        {
            Value = value;
            Mode = mode;
        }

        /// <summary> [Required] Forecast horizon value. </summary>
        public int Value { get; set; }
    }
}
