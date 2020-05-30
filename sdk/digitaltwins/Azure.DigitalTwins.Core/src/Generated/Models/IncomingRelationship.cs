// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.DigitalTwins.Core.Models
{
    /// <summary> An incoming relationship. </summary>
    public partial class IncomingRelationship
    {
        /// <summary> Initializes a new instance of IncomingRelationship. </summary>
        internal IncomingRelationship()
        {
        }

        /// <summary> Initializes a new instance of IncomingRelationship. </summary>
        /// <param name="relationshipId"> A user-provided string representing the id of this relationship, unique in the context of the source digital twin, i.e. sourceId + relationshipId is unique in the context of the service. </param>
        /// <param name="sourceId"> The id of the source digital twin. </param>
        /// <param name="relationshipName"> The name of the relationship. </param>
        /// <param name="relationshipLink"> Link to the relationship, to be used for deletion. </param>
        internal IncomingRelationship(string relationshipId, string sourceId, string relationshipName, string relationshipLink)
        {
            RelationshipId = relationshipId;
            SourceId = sourceId;
            RelationshipName = relationshipName;
            RelationshipLink = relationshipLink;
        }

        /// <summary> A user-provided string representing the id of this relationship, unique in the context of the source digital twin, i.e. sourceId + relationshipId is unique in the context of the service. </summary>
        public string RelationshipId { get; }
        /// <summary> The id of the source digital twin. </summary>
        public string SourceId { get; }
        /// <summary> The name of the relationship. </summary>
        public string RelationshipName { get; }
        /// <summary> Link to the relationship, to be used for deletion. </summary>
        public string RelationshipLink { get; }
    }
}
