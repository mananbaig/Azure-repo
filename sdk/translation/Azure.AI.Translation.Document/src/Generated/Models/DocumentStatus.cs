// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.Translation.Document
{
    /// <summary> Document Status Response. </summary>
    public partial class DocumentStatus
    {
        /// <summary> Initializes a new instance of DocumentStatus. </summary>
        /// <param name="sourceDocumentUri"> Location of the source document. </param>
        /// <param name="createdOn"> Operation created date time. </param>
        /// <param name="lastModified"> Date time in which the operation&apos;s status has been updated. </param>
        /// <param name="status"> List of possible statuses for job or document. </param>
        /// <param name="translatedTo"> To language. </param>
        /// <param name="progress"> Progress of the translation if available. </param>
        /// <param name="id"> Document Id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceDocumentUri"/>, <paramref name="translatedTo"/>, or <paramref name="id"/> is null. </exception>
        internal DocumentStatus(Uri sourceDocumentUri, DateTimeOffset createdOn, DateTimeOffset lastModified, DocumentTranslationStatus status, string translatedTo, float progress, string id)
        {
            if (sourceDocumentUri == null)
            {
                throw new ArgumentNullException(nameof(sourceDocumentUri));
            }
            if (translatedTo == null)
            {
                throw new ArgumentNullException(nameof(translatedTo));
            }
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            SourceDocumentUri = sourceDocumentUri;
            CreatedOn = createdOn;
            LastModified = lastModified;
            Status = status;
            TranslatedTo = translatedTo;
            Progress = progress;
            Id = id;
        }

        /// <summary> Initializes a new instance of DocumentStatus. </summary>
        /// <param name="translatedDocumentUri"> Location of the document or folder. </param>
        /// <param name="sourceDocumentUri"> Location of the source document. </param>
        /// <param name="createdOn"> Operation created date time. </param>
        /// <param name="lastModified"> Date time in which the operation&apos;s status has been updated. </param>
        /// <param name="status"> List of possible statuses for job or document. </param>
        /// <param name="translatedTo"> To language. </param>
        /// <param name="error"> This contains an outer error with error code, message, details, target and an inner error with more descriptive details. </param>
        /// <param name="progress"> Progress of the translation if available. </param>
        /// <param name="id"> Document Id. </param>
        /// <param name="charactersCharged"> Character charged by the API. </param>
        internal DocumentStatus(Uri translatedDocumentUri, Uri sourceDocumentUri, DateTimeOffset createdOn, DateTimeOffset lastModified, DocumentTranslationStatus status, string translatedTo, DocumentTranslationError error, float progress, string id, long charactersCharged)
        {
            TranslatedDocumentUri = translatedDocumentUri;
            SourceDocumentUri = sourceDocumentUri;
            CreatedOn = createdOn;
            LastModified = lastModified;
            Status = status;
            TranslatedTo = translatedTo;
            Error = error;
            Progress = progress;
            Id = id;
            CharactersCharged = charactersCharged;
        }
    }
}
