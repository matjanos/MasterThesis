﻿using System;
using System.Net;
using System.Net.Http;
using Xunit;

namespace MasterThesis.RestTestsGenerator.Tests
{
    /// <summary>
    /// Summary description for TemplateTest
    /// </summary
    public class TemplateTest
    {
        public TemplateTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        [Fact]
        public async void TestMethod1()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("200", out expectedStatusCode);

            var method = GetMethodFromString("GET");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.twitter.com/%7Bversion%7D/statuses");

           // message.Headers.Add("Content-Type", "application/x-www-form-urlencoded");

            HttpStatusCode acctualStatusCode;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    // You can do whatever you want with the resulting stream, or you can ReadAsStringAsync, or just remove "Async" to use the blocking methods.
                }
                else
                {
                    // You can do some stuff with the status code to decide what to do.
                }
            }


            // Assert
            Assert.Equal(expectedStatusCode, acctualStatusCode);
        }

        private System.Net.Http.HttpMethod GetMethodFromString(string methodString)
        {
            var m = methodString.ToUpper();
            if(m=="GET") return System.Net.Http.HttpMethod.Get;
            if(m=="POST") return System.Net.Http.HttpMethod.Post;
            if(m=="PUT") return System.Net.Http.HttpMethod.Put;
            if(m=="DELETE") return System.Net.Http.HttpMethod.Delete;
            if(m=="OPTIONS") return System.Net.Http.HttpMethod.Options;
            if(m=="HEAD") return System.Net.Http.HttpMethod.Head;
            if(m=="TRACE") return System.Net.Http.HttpMethod.Trace;

            throw new ArgumentException("Can't resolve the requested method keyword");
        }
    }
}
