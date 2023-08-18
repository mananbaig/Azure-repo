// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Describes the progress of a database. </summary>
    public partial class MongoDBDatabaseProgress : MongoDBProgress
    {
        /// <summary> Initializes a new instance of MongoDBDatabaseProgress. </summary>
        /// <param name="bytesCopied"> The number of document bytes copied during the Copying stage. </param>
        /// <param name="documentsCopied"> The number of documents copied during the Copying stage. </param>
        /// <param name="elapsedTime"> The elapsed time in the format [ddd.]hh:mm:ss[.fffffff] (i.e. TimeSpan format). </param>
        /// <param name="errors"> The errors and warnings that have occurred for the current object. The keys are the error codes. </param>
        /// <param name="eventsPending"> The number of oplog events awaiting replay. </param>
        /// <param name="eventsReplayed"> The number of oplog events replayed so far. </param>
        /// <param name="state"></param>
        /// <param name="totalBytes"> The total number of document bytes on the source at the beginning of the Copying stage, or -1 if the total size was unknown. </param>
        /// <param name="totalDocuments"> The total number of documents on the source at the beginning of the Copying stage, or -1 if the total count was unknown. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="elapsedTime"/> or <paramref name="errors"/> is null. </exception>
        internal MongoDBDatabaseProgress(long bytesCopied, long documentsCopied, string elapsedTime, IReadOnlyDictionary<string, MongoDBError> errors, long eventsPending, long eventsReplayed, MongoDBMigrationState state, long totalBytes, long totalDocuments) : base(bytesCopied, documentsCopied, elapsedTime, errors, eventsPending, eventsReplayed, state, totalBytes, totalDocuments)
        {
            Argument.AssertNotNull(elapsedTime, nameof(elapsedTime));
            Argument.AssertNotNull(errors, nameof(errors));

            Collections = new Core.ChangeTrackingDictionary<string, MongoDBCollectionProgress>();
            ResultType = MongoDBProgressResultType.Database;
        }

        /// <summary> Initializes a new instance of MongoDBDatabaseProgress. </summary>
        /// <param name="bytesCopied"> The number of document bytes copied during the Copying stage. </param>
        /// <param name="documentsCopied"> The number of documents copied during the Copying stage. </param>
        /// <param name="elapsedTime"> The elapsed time in the format [ddd.]hh:mm:ss[.fffffff] (i.e. TimeSpan format). </param>
        /// <param name="errors"> The errors and warnings that have occurred for the current object. The keys are the error codes. </param>
        /// <param name="eventsPending"> The number of oplog events awaiting replay. </param>
        /// <param name="eventsReplayed"> The number of oplog events replayed so far. </param>
        /// <param name="lastEventOn"> The timestamp of the last oplog event received, or null if no oplog event has been received yet. </param>
        /// <param name="lastReplayOn"> The timestamp of the last oplog event replayed, or null if no oplog event has been replayed yet. </param>
        /// <param name="name"> The name of the progress object. For a collection, this is the unqualified collection name. For a database, this is the database name. For the overall migration, this is null. </param>
        /// <param name="qualifiedName"> The qualified name of the progress object. For a collection, this is the database-qualified name. For a database, this is the database name. For the overall migration, this is null. </param>
        /// <param name="resultType"> The type of progress object. </param>
        /// <param name="state"></param>
        /// <param name="totalBytes"> The total number of document bytes on the source at the beginning of the Copying stage, or -1 if the total size was unknown. </param>
        /// <param name="totalDocuments"> The total number of documents on the source at the beginning of the Copying stage, or -1 if the total count was unknown. </param>
        /// <param name="collections"> The progress of the collections in the database. The keys are the unqualified names of the collections. </param>
        internal MongoDBDatabaseProgress(long bytesCopied, long documentsCopied, string elapsedTime, IReadOnlyDictionary<string, MongoDBError> errors, long eventsPending, long eventsReplayed, DateTimeOffset? lastEventOn, DateTimeOffset? lastReplayOn, string name, string qualifiedName, MongoDBProgressResultType resultType, MongoDBMigrationState state, long totalBytes, long totalDocuments, IReadOnlyDictionary<string, MongoDBCollectionProgress> collections) : base(bytesCopied, documentsCopied, elapsedTime, errors, eventsPending, eventsReplayed, lastEventOn, lastReplayOn, name, qualifiedName, resultType, state, totalBytes, totalDocuments)
        {
            Collections = collections;
            ResultType = resultType;
        }

        /// <summary> The progress of the collections in the database. The keys are the unqualified names of the collections. </summary>
        public IReadOnlyDictionary<string, MongoDBCollectionProgress> Collections { get; }
    }
}
