// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Orbital.Models
{
    /// <summary> List of authorized spacecraft links per ground station and the expiration date of the authorization. </summary>
    public partial class OrbitalSpacecraftLink
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="OrbitalSpacecraftLink"/>. </summary>
        /// <param name="name"> Link name. </param>
        /// <param name="centerFrequencyMHz"> Center Frequency in MHz. </param>
        /// <param name="bandwidthMHz"> Bandwidth in MHz. </param>
        /// <param name="direction"> Direction (uplink or downlink). </param>
        /// <param name="polarization"> Polarization. e.g. (RHCP, LHCP). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public OrbitalSpacecraftLink(string name, float centerFrequencyMHz, float bandwidthMHz, OrbitalLinkDirection direction, OrbitalLinkPolarization polarization)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            CenterFrequencyMHz = centerFrequencyMHz;
            BandwidthMHz = bandwidthMHz;
            Direction = direction;
            Polarization = polarization;
            Authorizations = new ChangeTrackingList<AuthorizedGroundStation>();
        }

        /// <summary> Initializes a new instance of <see cref="OrbitalSpacecraftLink"/>. </summary>
        /// <param name="name"> Link name. </param>
        /// <param name="centerFrequencyMHz"> Center Frequency in MHz. </param>
        /// <param name="bandwidthMHz"> Bandwidth in MHz. </param>
        /// <param name="direction"> Direction (uplink or downlink). </param>
        /// <param name="polarization"> Polarization. e.g. (RHCP, LHCP). </param>
        /// <param name="authorizations"> Authorized Ground Stations. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal OrbitalSpacecraftLink(string name, float centerFrequencyMHz, float bandwidthMHz, OrbitalLinkDirection direction, OrbitalLinkPolarization polarization, IReadOnlyList<AuthorizedGroundStation> authorizations, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            CenterFrequencyMHz = centerFrequencyMHz;
            BandwidthMHz = bandwidthMHz;
            Direction = direction;
            Polarization = polarization;
            Authorizations = authorizations;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="OrbitalSpacecraftLink"/> for deserialization. </summary>
        internal OrbitalSpacecraftLink()
        {
        }

        /// <summary> Link name. </summary>
        public string Name { get; set; }
        /// <summary> Center Frequency in MHz. </summary>
        public float CenterFrequencyMHz { get; set; }
        /// <summary> Bandwidth in MHz. </summary>
        public float BandwidthMHz { get; set; }
        /// <summary> Direction (uplink or downlink). </summary>
        public OrbitalLinkDirection Direction { get; set; }
        /// <summary> Polarization. e.g. (RHCP, LHCP). </summary>
        public OrbitalLinkPolarization Polarization { get; set; }
        /// <summary> Authorized Ground Stations. </summary>
        public IReadOnlyList<AuthorizedGroundStation> Authorizations { get; }
    }
}
