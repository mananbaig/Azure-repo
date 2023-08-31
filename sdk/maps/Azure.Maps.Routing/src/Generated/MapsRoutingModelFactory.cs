// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Maps.Routing.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class MapsRoutingModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="RouteMatrixResult"/>. </summary>
        /// <param name="formatVersion"> Format Version property. </param>
        /// <param name="matrix"> Results as a 2 dimensional array of route summaries. </param>
        /// <param name="summary"> Summary object. </param>
        /// <returns> A new <see cref="Models.RouteMatrixResult"/> instance for mocking. </returns>
        public static RouteMatrixResult RouteMatrixResult(string formatVersion = null, IEnumerable<IList<RouteMatrix>> matrix = null, RouteMatrixSummary summary = null)
        {
            matrix ??= new List<IList<RouteMatrix>>();

            return new RouteMatrixResult(formatVersion, matrix?.ToList(), summary, default);
        }

        /// <summary> Initializes a new instance of <see cref="RouteLegSummary"/>. </summary>
        /// <param name="lengthInMeters"> Length In Meters property. </param>
        /// <param name="travelTimeInSeconds"> Estimated travel time in seconds property that includes the delay due to real-time traffic. Note that even when traffic=false travelTimeInSeconds still includes the delay due to traffic. If DepartAt is in the future, travel time is calculated using time-dependent historic traffic data. </param>
        /// <param name="trafficDelayInSeconds"> Estimated delay in seconds caused by the real-time incident(s) according to traffic information. For routes planned with departure time in the future, delays is always 0. To return additional travel times using different types of traffic information, parameter computeTravelTimeFor=all needs to be added. </param>
        /// <param name="departureTime"> The estimated departure time for the route or leg. </param>
        /// <param name="arrivalTime"> The estimated arrival time for the route or leg. </param>
        /// <param name="noTrafficTravelTimeInSeconds"> Estimated travel time calculated as if there are no delays on the route due to traffic conditions (e.g. congestion). Included only if computeTravelTimeFor = all is used in the query. </param>
        /// <param name="historicTrafficTravelTimeInSeconds"> Estimated travel time calculated using time-dependent historic traffic data. Included only if computeTravelTimeFor = all is used in the query. </param>
        /// <param name="liveTrafficIncidentsTravelTimeInSeconds"> Estimated travel time calculated using real-time speed data. Included only if computeTravelTimeFor = all is used in the query. </param>
        /// <param name="fuelConsumptionInLiters"> Estimated fuel consumption in liters using the Combustion Consumption Model. Included if vehicleEngineType is set to _combustion_ and constantSpeedConsumptionInLitersPerHundredkm is specified. The value will be non-negative. </param>
        /// <param name="batteryConsumptionInKwH"> Estimated electric energy consumption in kilowatt hours (kWh) using the Electric Consumption Model. Included if vehicleEngineType is set to electric and constantSpeedConsumptionInkWhPerHundredkm is specified. The value of batteryConsumptionInkWh includes the recuperated electric energy and can therefore be negative (which indicates gaining energy). If both maxChargeInkWh and currentChargeInkWh are specified, recuperation will be capped to ensure that the battery charge level never exceeds maxChargeInkWh. If neither maxChargeInkWh nor currentChargeInkWh are specified, unconstrained recuperation is assumed in the consumption calculation. </param>
        /// <returns> A new <see cref="Models.RouteLegSummary"/> instance for mocking. </returns>
        public static RouteLegSummary RouteLegSummary(int? lengthInMeters = null, int? travelTimeInSeconds = null, int? trafficDelayInSeconds = null, DateTimeOffset? departureTime = null, DateTimeOffset? arrivalTime = null, int? noTrafficTravelTimeInSeconds = null, int? historicTrafficTravelTimeInSeconds = null, int? liveTrafficIncidentsTravelTimeInSeconds = null, double? fuelConsumptionInLiters = null, double? batteryConsumptionInKwH = null)
        {
            return new RouteLegSummary(lengthInMeters, travelTimeInSeconds, trafficDelayInSeconds, departureTime, arrivalTime, noTrafficTravelTimeInSeconds, historicTrafficTravelTimeInSeconds, liveTrafficIncidentsTravelTimeInSeconds, fuelConsumptionInLiters, batteryConsumptionInKwH, default);
        }

        /// <summary> Initializes a new instance of <see cref="RouteMatrixSummary"/>. </summary>
        /// <param name="successfulRoutes"> Number of successful routes in the response. </param>
        /// <param name="totalRoutes"> Total number of routes requested. Number of cells in the input matrix. </param>
        /// <returns> A new <see cref="Models.RouteMatrixSummary"/> instance for mocking. </returns>
        public static RouteMatrixSummary RouteMatrixSummary(int? successfulRoutes = null, int? totalRoutes = null)
        {
            return new RouteMatrixSummary(successfulRoutes, totalRoutes, default);
        }

        /// <summary> Initializes a new instance of <see cref="RouteDirections"/>. </summary>
        /// <param name="formatVersion"> Format Version property. </param>
        /// <param name="routes"> Routes array. </param>
        /// <param name="optimizedWaypoints">
        /// Optimized sequence of waypoints. It shows the index from the user provided waypoint sequence for the original and optimized list. For instance, a response:
        ///
        /// ```
        /// &lt;optimizedWaypoints&gt;
        /// &lt;waypoint providedIndex="0" optimizedIndex="1"/&gt;
        /// &lt;waypoint providedIndex="1" optimizedIndex="2"/&gt;
        /// &lt;waypoint providedIndex="2" optimizedIndex="0"/&gt;
        /// &lt;/optimizedWaypoints&gt;
        /// ```
        ///
        /// means that the original sequence is [0, 1, 2] and optimized sequence is [1, 2, 0]. Since the index starts by 0 the original is "first, second, third" while the optimized is "second, third, first".
        /// </param>
        /// <param name="report"> Reports the effective settings used in the current call. </param>
        /// <returns> A new <see cref="Models.RouteDirections"/> instance for mocking. </returns>
        public static RouteDirections RouteDirections(string formatVersion = null, IEnumerable<RouteData> routes = null, IEnumerable<RouteOptimizedWaypoint> optimizedWaypoints = null, RouteReport report = null)
        {
            routes ??= new List<RouteData>();
            optimizedWaypoints ??= new List<RouteOptimizedWaypoint>();

            return new RouteDirections(formatVersion, routes?.ToList(), optimizedWaypoints?.ToList(), report, default);
        }

        /// <summary> Initializes a new instance of <see cref="RouteData"/>. </summary>
        /// <param name="summary"> Summary object. </param>
        /// <param name="legs"> Legs array. </param>
        /// <param name="sections"> Sections array. </param>
        /// <param name="guidance"> Contains guidance related elements. This field is present only when guidance was requested and is available. </param>
        /// <returns> A new <see cref="Models.RouteData"/> instance for mocking. </returns>
        public static RouteData RouteData(RouteSummary summary = null, IEnumerable<RouteLeg> legs = null, IEnumerable<RouteSection> sections = null, RouteGuidance guidance = null)
        {
            legs ??= new List<RouteLeg>();
            sections ??= new List<RouteSection>();

            return new RouteData(summary, legs?.ToList(), sections?.ToList(), guidance, default);
        }

        /// <summary> Initializes a new instance of <see cref="RouteSection"/>. </summary>
        /// <param name="startPointIndex"> Index of the first point (offset 0) in the route this section applies to. </param>
        /// <param name="endPointIndex"> Index of the last point (offset 0) in the route this section applies to. </param>
        /// <param name="sectionType"> Section types of the reported route response. </param>
        /// <param name="travelMode"> Travel mode for the calculated route. The value will be set to `other` if the requested mode of transport is not possible in this section. </param>
        /// <param name="simpleCategory"> Type of the incident. Can currently be JAM, ROAD_WORK, ROAD_CLOSURE, or OTHER. See "tec" for detailed information. </param>
        /// <param name="effectiveSpeedInKmh"> Effective speed of the incident in km/h, averaged over its entire length. </param>
        /// <param name="delayInSeconds"> Delay in seconds caused by the incident. </param>
        /// <param name="delayMagnitude"> The magnitude of delay caused by the incident. These values correspond to the values of the response field ty of the [Get Traffic Incident Detail API](https://docs.microsoft.com/rest/api/maps/traffic/gettrafficincidentdetail). </param>
        /// <param name="tec"> Details of the traffic event, using definitions in the [TPEG2-TEC](https://www.iso.org/standard/63116.html) standard. Can contain effectCode and causes elements. </param>
        /// <returns> A new <see cref="Models.RouteSection"/> instance for mocking. </returns>
        public static RouteSection RouteSection(int? startPointIndex = null, int? endPointIndex = null, ResponseSectionType? sectionType = null, ResponseTravelMode? travelMode = null, TrafficIncidentCategory? simpleCategory = null, int? effectiveSpeedInKmh = null, int? delayInSeconds = null, DelayMagnitude? delayMagnitude = null, RouteSectionTec tec = null)
        {
            return new RouteSection(startPointIndex, endPointIndex, sectionType, travelMode, simpleCategory, effectiveSpeedInKmh, delayInSeconds, delayMagnitude, tec, default);
        }

        /// <summary> Initializes a new instance of <see cref="RouteSectionTec"/>. </summary>
        /// <param name="effectCode"> The effect on the traffic flow. Contains a value in the tec001:EffectCode table, as defined in the [TPEG2-TEC](https://www.iso.org/standard/63116.html) standard. Can be used to color-code traffic events according to severity. </param>
        /// <param name="causes"> Causes array. </param>
        /// <returns> A new <see cref="Models.RouteSectionTec"/> instance for mocking. </returns>
        public static RouteSectionTec RouteSectionTec(int? effectCode = null, IEnumerable<RouteSectionTecCause> causes = null)
        {
            causes ??= new List<RouteSectionTecCause>();

            return new RouteSectionTec(effectCode, causes?.ToList(), default);
        }

        /// <summary> Initializes a new instance of <see cref="RouteSectionTecCause"/>. </summary>
        /// <param name="mainCauseCode"> The main cause of the traffic event. Contains a value in the tec002:CauseCode table, as defined in the [TPEG2-TEC](https://www.iso.org/standard/63116.html) standard. </param>
        /// <param name="subCauseCode"> The subcause of the traffic event. Contains a value in the sub cause table defined by the mainCauseCode, as defined in the [TPEG2-TEC](https://www.iso.org/standard/63116.html) standard. </param>
        /// <returns> A new <see cref="Models.RouteSectionTecCause"/> instance for mocking. </returns>
        public static RouteSectionTecCause RouteSectionTecCause(int? mainCauseCode = null, int? subCauseCode = null)
        {
            return new RouteSectionTecCause(mainCauseCode, subCauseCode, default);
        }

        /// <summary> Initializes a new instance of <see cref="RouteGuidance"/>. </summary>
        /// <param name="instructions"> A list of instructions describing maneuvers. </param>
        /// <param name="instructionGroups"> Groups a sequence of instruction elements which are related to each other. </param>
        /// <returns> A new <see cref="Models.RouteGuidance"/> instance for mocking. </returns>
        public static RouteGuidance RouteGuidance(IEnumerable<RouteInstruction> instructions = null, IEnumerable<RouteInstructionGroup> instructionGroups = null)
        {
            instructions ??= new List<RouteInstruction>();
            instructionGroups ??= new List<RouteInstructionGroup>();

            return new RouteGuidance(instructions?.ToList(), instructionGroups?.ToList(), default);
        }

        /// <summary> Initializes a new instance of <see cref="RouteInstructionGroup"/>. </summary>
        /// <param name="firstInstructionIndex"> Index of the first instruction in the instructions and belonging to this group. </param>
        /// <param name="lastInstructionIndex"> Index of the last instruction in the instructions and belonging to this group. </param>
        /// <param name="groupLengthInMeters"> Length of the group. </param>
        /// <param name="groupMessage"> Summary message when human-readable text messages are requested for guidance (instructionType=text or tagged). </param>
        /// <returns> A new <see cref="Models.RouteInstructionGroup"/> instance for mocking. </returns>
        public static RouteInstructionGroup RouteInstructionGroup(int? firstInstructionIndex = null, int? lastInstructionIndex = null, int? groupLengthInMeters = null, string groupMessage = null)
        {
            return new RouteInstructionGroup(firstInstructionIndex, lastInstructionIndex, groupLengthInMeters, groupMessage, default);
        }

        /// <summary> Initializes a new instance of <see cref="RouteOptimizedWaypoint"/>. </summary>
        /// <param name="providedIndex"> Way point index provided by the user. </param>
        /// <param name="optimizedIndex"> Optimized way point index from the system. </param>
        /// <returns> A new <see cref="Models.RouteOptimizedWaypoint"/> instance for mocking. </returns>
        public static RouteOptimizedWaypoint RouteOptimizedWaypoint(int? providedIndex = null, int? optimizedIndex = null)
        {
            return new RouteOptimizedWaypoint(providedIndex, optimizedIndex, default);
        }

        /// <summary> Initializes a new instance of <see cref="RouteReport"/>. </summary>
        /// <param name="effectiveSettings"> Effective parameters or data used when calling this Route API. </param>
        /// <returns> A new <see cref="Models.RouteReport"/> instance for mocking. </returns>
        public static RouteReport RouteReport(IEnumerable<EffectiveSetting> effectiveSettings = null)
        {
            effectiveSettings ??= new List<EffectiveSetting>();

            return new RouteReport(effectiveSettings?.ToList(), default);
        }

        /// <summary> Initializes a new instance of <see cref="EffectiveSetting"/>. </summary>
        /// <param name="key"> Name of the parameter used. </param>
        /// <param name="value"> Value of the parameter used. </param>
        /// <returns> A new <see cref="Models.EffectiveSetting"/> instance for mocking. </returns>
        public static EffectiveSetting EffectiveSetting(string key = null, string value = null)
        {
            return new EffectiveSetting(key, value, default);
        }

        /// <summary> Initializes a new instance of <see cref="RouteRangeResult"/>. </summary>
        /// <param name="formatVersion"> Format Version property. </param>
        /// <param name="reachableRange"> Reachable Range. </param>
        /// <param name="report"> Reports the effective settings used in the current call. </param>
        /// <returns> A new <see cref="Models.RouteRangeResult"/> instance for mocking. </returns>
        public static RouteRangeResult RouteRangeResult(string formatVersion = null, RouteRange reachableRange = null, RouteReport report = null)
        {
            return new RouteRangeResult(formatVersion, reachableRange, report, default);
        }
    }
}
