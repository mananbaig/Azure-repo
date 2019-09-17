﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.Json;

//namespace Azure.AI.InkRecognizer.Models
namespace Azure.Data.InkRecognizer.Models
{
    /// <summary>
    /// The RecognitionRoot class is the root of the recognition result tree from the Ink Recognizer service.
    /// The class can be used to retrieve details of the recognition results from the service.
    /// </summary>
    public class RecognitionRoot : IEquatable<RecognitionRoot>
    {
        private List<long> recognizedWordIds;
        private List<long> recognizedDrawingIds;
        private List<long> recognizedUnitIds;

        private Dictionary<long, InkRecognitionUnit> idToRecognizedUnits;
        private Dictionary<InkRecognitionUnitKind, List<long>> kindToRecognizedUnitIds;
        private Dictionary<string, List<long>> textToRecognizedWordIds;

        /// <summary>
        /// Protected constructor to allow mocking
        /// </summary>
        protected RecognitionRoot()
        {
        }

        internal RecognitionRoot(JsonElement recoUnitJson)
        {
            JsonElement element = recoUnitJson;
        }

        internal void SetInkRecognitionUnits(List<InkRecognitionUnit> recoUnits)
        {
            recognizedWordIds = new List<long>();
            recognizedDrawingIds = new List<long>();
            recognizedUnitIds = new List<long>();
            idToRecognizedUnits = new Dictionary<long, InkRecognitionUnit>();
            kindToRecognizedUnitIds = new Dictionary<InkRecognitionUnitKind, List<long>>();
            textToRecognizedWordIds = new Dictionary<string, List<long>>();

            // Other InkRecognition units
            foreach (var recoUnit in recoUnits)
            {
                switch (recoUnit.Kind)
                {
                    case InkRecognitionUnitKind.InkWord:
                        var inkWord = recoUnit as InkWord;
                        recognizedWordIds.Add(inkWord.Id);

                        if (!textToRecognizedWordIds.ContainsKey(inkWord.RecognizedText))
                        {
                            textToRecognizedWordIds[inkWord.RecognizedText] = new List<long>();
                        }
                        textToRecognizedWordIds[inkWord.RecognizedText].Add(inkWord.Id);
                        break;

                    case InkRecognitionUnitKind.InkDrawing:
                        recognizedDrawingIds.Add(recoUnit.Id);
                        break;
                }

                recognizedUnitIds.Add(recoUnit.Id);
                idToRecognizedUnits.Add(recoUnit.Id, recoUnit);

                if (!kindToRecognizedUnitIds.ContainsKey(recoUnit.Kind))
                {
                    kindToRecognizedUnitIds[recoUnit.Kind] = new List<long>();
                }
                kindToRecognizedUnitIds[recoUnit.Kind].Add(recoUnit.Id);
            }
        }

        /// <param name="word">The word to search for</param>
        /// <returns>A list of InkWord classes with text that match the word used in the search request.</returns>
        public IEnumerable<InkWord> FindWord(string word)
        {
            var inkWords = new List<InkWord>();
            if (textToRecognizedWordIds.ContainsKey(word))
            {
                foreach (var id in textToRecognizedWordIds[word])
                {
                    var inkWord = idToRecognizedUnits[id] as InkWord;
                    inkWords.Add(inkWord);
                }
            }
            return inkWords;
        }

        /// <returns> List of InkWord model units found in the tree returned by the Ink Recognizer service</returns>
        public IEnumerable<InkWord> GetWords()
        {
            var recognizedWords = new List<InkWord>();
            foreach (var id in recognizedWordIds)
            {
                var recognizedWord = idToRecognizedUnits[id] as InkWord;
                recognizedWords.Add(recognizedWord);
            }
            return recognizedWords;
        }

        /// <returns> List of InkDrawing model units found in the tree returned by the Ink Recognizer service</returns>
        public IEnumerable<InkDrawing> GetDrawings()
        {
            var recognizedDrawings = new List<InkDrawing>();
            foreach (var id in recognizedDrawingIds)
            {
                var recognizedDrawing = idToRecognizedUnits[id] as InkDrawing;
                recognizedDrawings.Add(recognizedDrawing);
            }
            return recognizedDrawings;
        }

        /// <returns> A list of all the InkRecognitionUnit objects found in the tree returned by the Ink Recognizer service</returns>
        public IEnumerable<InkRecognitionUnit> GetInkRecognitionUnits()
        {
            var recognizedUnits = new List<InkRecognitionUnit>();
            foreach (var id in recognizedUnitIds)
            {
                var recognizedUnit = idToRecognizedUnits[id];
                recognizedUnits.Add(recognizedUnit);
            }
            return recognizedUnits;
        }

        /// <param name="kind"> parameter specifies the category of the model units to return. If the there are
        /// no units that match the requested category, an empty list is returned.</param>
        /// <returns> A list of all the relevant InkRecognitionUnit objects found in the tree returned by the Ink Recognizer service</returns>
        public IEnumerable<InkRecognitionUnit> GetInkRecognitionUnits(InkRecognitionUnitKind kind)
        {
            var recognizedUnits = new List<InkRecognitionUnit>();
            if (kindToRecognizedUnitIds.ContainsKey(kind))
            {
                foreach (var id in kindToRecognizedUnitIds[kind])
                {
                    var recognizedUnit = idToRecognizedUnits[id];
                    recognizedUnits.Add(recognizedUnit);
                }
            }
            return recognizedUnits;
        }

        internal InkRecognitionUnit FindInkRecognitionUnit(long id)
        {
            if (idToRecognizedUnits.ContainsKey(id))
            {
                return idToRecognizedUnits[id];
            }
            else
            {
                return null;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object other)
        {
            var rightType = other as RecognitionRoot;
            if (rightType == null) return false;
            return GetInkRecognitionUnits().SequenceEqual(rightType.GetInkRecognitionUnits());
        }

        /// <summary>
        /// Check if two RecognitionRoot objects are equal.
        /// </summary>
        /// <param name="other">The object to compare to.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool Equals(RecognitionRoot other)
        {
            if (other == null) return false;
            return GetInkRecognitionUnits().SequenceEqual(other.GetInkRecognitionUnits());
        }

        /// <summary>
        /// Returns a hash code for RecognitionRoot object.
        /// </summary>
        /// <returns>Hash code for the current RecognitionRoot object</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            int hashCode = 0;
            foreach (var recoUnit in GetInkRecognitionUnits())
            {
                hashCode = hashCode ^ recoUnit.GetHashCode();
            }
            return hashCode;
        }
    }

    /// <summary>
    /// Static factory class to support mocking
    /// </summary>
    public static class InkRecognitionModelFactory
    {
        public static RecognitionRoot InkRecognitionRoot(string responseContent)
        {
            return InkRecognitionResponse.Parse(responseContent);
        }
    }
}
