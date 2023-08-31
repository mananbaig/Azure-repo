// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Maps.Routing.Models
{
    /// <summary> A set of attributes describing a maneuver, e.g. 'Turn right', 'Keep left', 'Take the ferry', 'Take the motorway', 'Arrive'. </summary>
    public partial class RouteInstruction
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RouteInstruction"/>. </summary>
        internal RouteInstruction()
        {
            RoadNumbers = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="RouteInstruction"/>. </summary>
        /// <param name="routeOffsetInMeters"> Distance from the start of the route to the point of the instruction. </param>
        /// <param name="travelTimeInSeconds"> Estimated travel time up to the point corresponding to routeOffsetInMeters. </param>
        /// <param name="point"> A location represented as a latitude and longitude. </param>
        /// <param name="pointIndex"> The index of the point in the list of polyline "points" corresponding to the point of the instruction. </param>
        /// <param name="instructionType"> Type of the instruction, e.g., turn or change of road form. </param>
        /// <param name="roadNumbers"> The road number(s) of the next significant road segment(s) after the maneuver, or of the road(s) to be followed. Example: ["E34", "N205"]. </param>
        /// <param name="exitNumber"> The number(s) of a highway exit taken by the current maneuver. If an exit has multiple exit numbers, they will be separated by "," and possibly aggregated by "-", e.g., "10, 13-15". </param>
        /// <param name="street"> Street name of the next significant road segment after the maneuver, or of the street that should be followed. </param>
        /// <param name="signpostText"> The text on a signpost which is most relevant to the maneuver, or to the direction that should be followed. </param>
        /// <param name="countryCode"> 3-character [ISO 3166-1](https://www.iso.org/iso-3166-country-codes.html) alpha-3 country code. E.g. USA. </param>
        /// <param name="stateCode"> A subdivision (e.g., state) of the country, represented by the second part of an [ISO 3166-2](https://www.iso.org/standard/63546.html) code. This is only available for some countries like the US, Canada, and Mexico. </param>
        /// <param name="junctionType"> The type of the junction where the maneuver takes place. For larger roundabouts, two separate instructions are generated for entering and leaving the roundabout. </param>
        /// <param name="turnAngleInDegrees">
        /// Indicates the direction of an instruction. If junctionType indicates a turn instruction:
        ///
        ///   * 180 = U-turn
        ///   * [-179, -1] = Left turn
        ///   * 0 = Straight on (a '0 degree' turn)
        ///   * [1, 179] = Right turn
        ///
        /// If junctionType indicates a bifurcation instruction:
        ///
        ///   * &lt;0 - keep left
        ///   * \&gt;0 - keep right
        /// </param>
        /// <param name="roundaboutExitNumber"> This indicates which exit to take at a roundabout. </param>
        /// <param name="possibleCombineWithNext"> It is possible to optionally combine the instruction with the next one. This can be used to build messages like "Turn left and then turn right". </param>
        /// <param name="drivingSide"> Indicates left-hand vs. right-hand side driving at the point of the maneuver. </param>
        /// <param name="maneuver"> A code identifying the maneuver. </param>
        /// <param name="message"> A human-readable message for the maneuver. </param>
        /// <param name="combinedMessage">
        /// A human-readable message for the maneuver combined with the message from the next instruction. Sometimes it is possible to combine two successive instructions into a single instruction making it easier to follow. When this is the case the possibleCombineWithNext flag will be true. For example:
        ///
        /// ```
        /// 10. Turn left onto Einsteinweg/A10/E22 towards Ring Amsterdam
        /// 11. Follow Einsteinweg/A10/E22 towards Ring Amsterdam
        /// ```
        ///
        /// The possibleCombineWithNext flag on instruction 10 is true. This indicates to the clients of coded guidance that it can be combined with instruction 11. The instructions will be combined automatically for clients requesting human-readable guidance. The combinedMessage field contains the combined message:
        ///
        /// ```
        /// Turn left onto Einsteinweg/A10/E22 towards Ring Amsterdam
        /// then follow Einsteinweg/A10/E22 towards Ring Amsterdam.
        /// ```
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RouteInstruction(int? routeOffsetInMeters, int? travelTimeInSeconds, LatLongPair point, int? pointIndex, GuidanceInstructionType? instructionType, IReadOnlyList<string> roadNumbers, string exitNumber, string street, string signpostText, string countryCode, string stateCode, JunctionType? junctionType, int? turnAngleInDegrees, string roundaboutExitNumber, bool? possibleCombineWithNext, DrivingSide? drivingSide, GuidanceManeuver? maneuver, string message, string combinedMessage, Dictionary<string, BinaryData> rawData)
        {
            RouteOffsetInMeters = routeOffsetInMeters;
            TravelTimeInSeconds = travelTimeInSeconds;
            _Point = point;
            PointIndex = pointIndex;
            InstructionType = instructionType;
            RoadNumbers = roadNumbers;
            ExitNumber = exitNumber;
            Street = street;
            SignpostText = signpostText;
            CountryCode = countryCode;
            StateCode = stateCode;
            JunctionType = junctionType;
            TurnAngleInDegrees = turnAngleInDegrees;
            RoundaboutExitNumber = roundaboutExitNumber;
            PossibleCombineWithNext = possibleCombineWithNext;
            DrivingSide = drivingSide;
            Maneuver = maneuver;
            Message = message;
            CombinedMessage = combinedMessage;
            _rawData = rawData;
        }

        /// <summary> Distance from the start of the route to the point of the instruction. </summary>
        public int? RouteOffsetInMeters { get; }
        /// <summary> Estimated travel time up to the point corresponding to routeOffsetInMeters. </summary>
        public int? TravelTimeInSeconds { get; }
        /// <summary> The index of the point in the list of polyline "points" corresponding to the point of the instruction. </summary>
        public int? PointIndex { get; }
        /// <summary> Type of the instruction, e.g., turn or change of road form. </summary>
        public GuidanceInstructionType? InstructionType { get; }
        /// <summary> The road number(s) of the next significant road segment(s) after the maneuver, or of the road(s) to be followed. Example: ["E34", "N205"]. </summary>
        public IReadOnlyList<string> RoadNumbers { get; }
        /// <summary> The number(s) of a highway exit taken by the current maneuver. If an exit has multiple exit numbers, they will be separated by "," and possibly aggregated by "-", e.g., "10, 13-15". </summary>
        public string ExitNumber { get; }
        /// <summary> Street name of the next significant road segment after the maneuver, or of the street that should be followed. </summary>
        public string Street { get; }
        /// <summary> The text on a signpost which is most relevant to the maneuver, or to the direction that should be followed. </summary>
        public string SignpostText { get; }
        /// <summary> 3-character [ISO 3166-1](https://www.iso.org/iso-3166-country-codes.html) alpha-3 country code. E.g. USA. </summary>
        public string CountryCode { get; }
        /// <summary> A subdivision (e.g., state) of the country, represented by the second part of an [ISO 3166-2](https://www.iso.org/standard/63546.html) code. This is only available for some countries like the US, Canada, and Mexico. </summary>
        public string StateCode { get; }
        /// <summary> The type of the junction where the maneuver takes place. For larger roundabouts, two separate instructions are generated for entering and leaving the roundabout. </summary>
        public JunctionType? JunctionType { get; }
        /// <summary>
        /// Indicates the direction of an instruction. If junctionType indicates a turn instruction:
        ///
        ///   * 180 = U-turn
        ///   * [-179, -1] = Left turn
        ///   * 0 = Straight on (a '0 degree' turn)
        ///   * [1, 179] = Right turn
        ///
        /// If junctionType indicates a bifurcation instruction:
        ///
        ///   * &lt;0 - keep left
        ///   * \&gt;0 - keep right
        /// </summary>
        public int? TurnAngleInDegrees { get; }
        /// <summary> This indicates which exit to take at a roundabout. </summary>
        public string RoundaboutExitNumber { get; }
        /// <summary> It is possible to optionally combine the instruction with the next one. This can be used to build messages like "Turn left and then turn right". </summary>
        public bool? PossibleCombineWithNext { get; }
        /// <summary> Indicates left-hand vs. right-hand side driving at the point of the maneuver. </summary>
        public DrivingSide? DrivingSide { get; }
        /// <summary> A code identifying the maneuver. </summary>
        public GuidanceManeuver? Maneuver { get; }
        /// <summary> A human-readable message for the maneuver. </summary>
        public string Message { get; }
        /// <summary>
        /// A human-readable message for the maneuver combined with the message from the next instruction. Sometimes it is possible to combine two successive instructions into a single instruction making it easier to follow. When this is the case the possibleCombineWithNext flag will be true. For example:
        ///
        /// ```
        /// 10. Turn left onto Einsteinweg/A10/E22 towards Ring Amsterdam
        /// 11. Follow Einsteinweg/A10/E22 towards Ring Amsterdam
        /// ```
        ///
        /// The possibleCombineWithNext flag on instruction 10 is true. This indicates to the clients of coded guidance that it can be combined with instruction 11. The instructions will be combined automatically for clients requesting human-readable guidance. The combinedMessage field contains the combined message:
        ///
        /// ```
        /// Turn left onto Einsteinweg/A10/E22 towards Ring Amsterdam
        /// then follow Einsteinweg/A10/E22 towards Ring Amsterdam.
        /// ```
        /// </summary>
        public string CombinedMessage { get; }
    }
}
