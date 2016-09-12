using System;
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
        public async void Test_0dba3570cc4543e684fffd8c3a4d02e7()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/media/392839750589921094_287676068/comments?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/x-www-form-urlencoded");
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

        [Fact]
        public async void Test_6444d51b11fd45a5a73efd81dbf5e1bc()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/media/392839750589921094_287676068/comments?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/x-www-form-urlencoded");
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

        [Fact]
        public async void Test_24a695b6e6c048e694e905082707c221()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/users/391387866/relationship?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/x-www-form-urlencoded");
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

        [Fact]
        public async void Test_3dbd6e9fa4184948886d85b9b17c9dd6()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/users/391387866/relationship?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/x-www-form-urlencoded");
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

        [Fact]
        public async void Test_db3ee630add14adabfdffe85f780444e()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/users/391387866/relationship?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/x-www-form-urlencoded");
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

        [Fact]
        public async void Test_8ff7b5fb25e749999339af39824593aa()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/subscriptions?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/x-www-form-urlencoded");
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

        [Fact]
        public async void Test_394298ff7bf846c19ebe351f22680bd3()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/subscriptions?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049&client_secret=a5dfad3128df4f5d9975484d88cd7493");
            message.Headers.Add("Accept", "application/x-www-form-urlencoded");
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

        [Fact]
        public async void Test_9fffc45b49124436b849c8d4ea2d2d92()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/subscriptions?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/x-www-form-urlencoded");
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
            if (m == "GET") return System.Net.Http.HttpMethod.Get;
            if (m == "POST") return System.Net.Http.HttpMethod.Post;
            if (m == "PUT") return System.Net.Http.HttpMethod.Put;
            if (m == "DELETE") return System.Net.Http.HttpMethod.Delete;
            if (m == "OPTIONS") return System.Net.Http.HttpMethod.Options;
            if (m == "HEAD") return System.Net.Http.HttpMethod.Head;
            if (m == "TRACE") return System.Net.Http.HttpMethod.Trace;

            throw new ArgumentException("Can't resolve the requested method keyword");
        }
    }
}
