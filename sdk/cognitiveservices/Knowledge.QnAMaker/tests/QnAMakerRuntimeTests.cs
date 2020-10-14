﻿using Microsoft.Azure.CognitiveServices.Knowledge.QnAMaker;
using Microsoft.Azure.CognitiveServices.Knowledge.QnAMaker.Models;
using Microsoft.Azure.Test.HttpRecorder;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace QnAMaker.Tests
{
    public class QnAMakerRuntimeTests: BaseTests
    {
        [Fact]
        public void QnAMakerRuntimeGenerateAnswerTest()
        {
            using (MockContext context = MockContext.Start(this.GetType()))
            {
                HttpMockServer.Initialize(this.GetType(), "QnAMakerRuntimeGenerateAnswerTest");

                var client = GetQnAMakerRuntimeClient(HttpMockServer.CreateInstance());
                var queryDTO = new QueryDTO();
                queryDTO.Question = "hi";
                queryDTO.IsTest = true;
                //queryDTO.StrictFiltersCompoundOperationType = StrictFiltersCompoundOperationType.OR;
                //queryDTO.StrictFilters = new List<MetadataDTO>();
                //queryDTO.StrictFilters.Add(new MetadataDTO("question", "good afternoon"));
                //queryDTO.StrictFilters.Add(new MetadataDTO("question", "good morning"));
                var answer = client.Runtime.GenerateAnswerAsync("07b5a7c3-0119-44b1-a32a-4912205d6217", queryDTO).Result;
                Assert.Equal(1, answer.Answers.Count);
                Assert.Equal(100, answer.Answers[0].Score);
            }
        }
    }
}
