// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Translation.Document
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class BatchDocumentTranslationModelFactory
    {
        /// <summary> Initializes new instance of DocumentStatusResult class. </summary>
        /// <param name="translatedDocumentUri"> Location of the document or folder. </param>
        /// <param name="sourceDocumentUri"> Location of the source document. </param>
        /// <param name="createdOn"> Operation created date time. </param>
        /// <param name="lastModified"> Date time in which the operation&apos;s status has been updated. </param>
        /// <param name="status"> List of possible statuses for job or document. </param>
        /// <param name="translatedTo"> To language. </param>
        /// <param name="error"> This contains an outer error with error code, message, details, target and an inner error with more descriptive details. </param>
        /// <param name="progress"> Progress of the translation if available. </param>
        /// <param name="documentId"> Document Id. </param>
        /// <param name="charactersCharged"> Character charged by the API. </param>
        /// <returns> A new <see cref="Document.DocumentStatusResult"/> instance for mocking. </returns>
        public static DocumentStatusResult DocumentStatusResult(Uri translatedDocumentUri = default, Uri sourceDocumentUri = default, DateTimeOffset createdOn = default, DateTimeOffset lastModified = default, TranslationStatus status = default, string translatedTo = default, DocumentTranslationError error = default, float progress = default, string documentId = default, long charactersCharged = default)
        {
            return new DocumentStatusResult(translatedDocumentUri, sourceDocumentUri, createdOn, lastModified, status, translatedTo, error, progress, documentId, charactersCharged);
        }

        /// <summary> Initializes new instance of FileFormat class. </summary>
        /// <param name="format"> Name of the format. </param>
        /// <param name="fileExtensions"> Supported file extension for this format. </param>
        /// <param name="contentTypes"> Supported Content-Types for this format. </param>
        /// <param name="defaultFormatVersion"> Default version if none is specified. </param>
        /// <param name="formatVersions"> Supported Version. </param>
        /// <returns> A new <see cref="Document.FileFormat"/> instance for mocking. </returns>
        public static FileFormat FileFormat(string format = default, IReadOnlyList<string> fileExtensions = default, IReadOnlyList<string> contentTypes = default, string defaultFormatVersion = default, IReadOnlyList<string> formatVersions = default)
        {
            fileExtensions ??= new List<string>();
            contentTypes ??= new List<string>();
            formatVersions ??= new List<string>();
            return new FileFormat(format, fileExtensions, contentTypes, defaultFormatVersion, formatVersions);
        }
    }
}
