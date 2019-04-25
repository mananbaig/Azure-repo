// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.EventGrid.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Schema of the Data property of an EventGridEvent for a Geofence event
    /// (GeofenceEntered, GeofenceExited, GeofenceResult).
    /// </summary>
    public partial class MapsGeofenceEventProperties
    {
        /// <summary>
        /// Initializes a new instance of the MapsGeofenceEventProperties
        /// class.
        /// </summary>
        public MapsGeofenceEventProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MapsGeofenceEventProperties
        /// class.
        /// </summary>
        /// <param name="expiredGeofenceGeometryId">Lists of the geometry ID of
        /// the geofence which is expired relative to the user time in the
        /// request.</param>
        /// <param name="geometries">Lists the fence geometries that either
        /// fully contain the coordinate position or have an overlap with the
        /// searchBuffer around the fence.</param>
        /// <param name="invalidPeriodGeofenceGeometryId">Lists of the geometry
        /// ID of the geofence which is in invalid period relative to the user
        /// time in the request.</param>
        /// <param name="isEventPublished">True if at least one event is
        /// published to the Azure Maps event subscriber, false if no event is
        /// published to the Azure Maps event subscriber.</param>
        public MapsGeofenceEventProperties(IList<string> expiredGeofenceGeometryId = default(IList<string>), IList<MapsGeofenceGeometry> geometries = default(IList<MapsGeofenceGeometry>), IList<string> invalidPeriodGeofenceGeometryId = default(IList<string>), bool? isEventPublished = default(bool?))
        {
            ExpiredGeofenceGeometryId = expiredGeofenceGeometryId;
            Geometries = geometries;
            InvalidPeriodGeofenceGeometryId = invalidPeriodGeofenceGeometryId;
            IsEventPublished = isEventPublished;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets lists of the geometry ID of the geofence which is
        /// expired relative to the user time in the request.
        /// </summary>
        [JsonProperty(PropertyName = "expiredGeofenceGeometryId")]
        public IList<string> ExpiredGeofenceGeometryId { get; set; }

        /// <summary>
        /// Gets or sets lists the fence geometries that either fully contain
        /// the coordinate position or have an overlap with the searchBuffer
        /// around the fence.
        /// </summary>
        [JsonProperty(PropertyName = "geometries")]
        public IList<MapsGeofenceGeometry> Geometries { get; set; }

        /// <summary>
        /// Gets or sets lists of the geometry ID of the geofence which is in
        /// invalid period relative to the user time in the request.
        /// </summary>
        [JsonProperty(PropertyName = "invalidPeriodGeofenceGeometryId")]
        public IList<string> InvalidPeriodGeofenceGeometryId { get; set; }

        /// <summary>
        /// Gets or sets true if at least one event is published to the Azure
        /// Maps event subscriber, false if no event is published to the Azure
        /// Maps event subscriber.
        /// </summary>
        [JsonProperty(PropertyName = "isEventPublished")]
        public bool? IsEventPublished { get; set; }

    }
}
