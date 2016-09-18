using System;
using System.IO;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
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
        public async void Test_6dbfe0c5ab03443d8a6b2236de3195f5()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/media/1338612569593807801_287676068?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
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
        public async void Test_45ef13ef085247c49b3a18d8e9182fa7()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/media/1338612569593807801_287676068?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/json");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
                    // You can do whatever you want with the resulting stream, or you can ReadAsStringAsync, or just remove "Async" to use the blocking methods.
                }
                else
                {
                    // You can do some stuff with the status code to decide what to do.
                }
            }

            // Assert

            string schema = @"{
  ""type"": ""object"",
  ""properties"": {
    ""data"": {
      ""type"": ""object"",
      ""properties"": {
        ""users_in_photo"": {
          ""type"": ""array""
        },
        ""filter"": {
          ""type"": ""string""
        },
        ""tags"": {
          ""type"": ""array""
        },
        ""comments"": {
          ""type"": ""object"",
          ""properties"": {
            ""data"": {
              ""type"": ""array""
            },
            ""count"": {
              ""type"": ""number""
            }
          }
        },
        ""caption"": {
          ""type"": [
            ""object"",
            ""null""
          ]
        },
        ""likes"": {
          ""type"": ""object"",
          ""properties"": {
            ""count"": {
              ""type"": ""number""
            },
            ""data"": {
              ""type"": ""array""
            }
          }
        },
        ""link"": {
          ""type"": ""string""
        },
        ""user"": {
          ""type"": ""object"",
          ""properties"": {
            ""id"": {
              ""type"": ""string""
            },
            ""username"": {
              ""type"": ""string""
            },
            ""full_name"": {
              ""type"": ""string""
            },
            ""profile_picture"": {
              ""type"": ""string""
            },
            ""bio"": {
              ""type"": ""string""
            },
            ""website"": {
              ""type"": ""string""
            },
            ""count"": {
              ""type"": ""object"",
              ""properties"": {
                ""media"": {
                  ""type"": ""integer""
                },
                ""follows"": {
                  ""type"": ""integer""
                },
                ""followed_by"": {
                  ""type"": ""integer""
                }
              }
            }
          }
        },
        ""created_time"": {
          ""type"": ""string""
        },
        ""id"": {
          ""type"": ""string""
        },
        ""location"": {
          ""type"": [
            ""object"",
            ""null""
          ]
        }
      }
    }
  }
}";

            JSchema s = JSchema.Parse(schema);
            JObject obj = JObject.Parse(body);
            // Assert
            Assert.True(obj.IsValid(s));
        }

        [Fact]
        public async void Test_68acef3a40e941f5b15aba2b95ea2571()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/media/1338612569593807801_287676068/comments?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
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
        public async void Test_534858f3072140efb96e8a0df8214ede()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/media/1338612569593807801_287676068/comments?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/x-www-form-urlencoded");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
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
        public async void Test_33bfa42e2dfc491a971c0dd2839c5b4c()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/media/1338612569593807801_287676068/comments?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/json");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
                    // You can do whatever you want with the resulting stream, or you can ReadAsStringAsync, or just remove "Async" to use the blocking methods.
                }
                else
                {
                    // You can do some stuff with the status code to decide what to do.
                }
            }

            // Assert

            string schema = @"{
  ""type"": ""object""
}";

            JSchema s = JSchema.Parse(schema);
            JObject obj = JObject.Parse(body);
            // Assert
            Assert.True(obj.IsValid(s));
        }

        [Fact]
        public async void Test_b72c8e2cfc39479f805147ac26b0c4f1()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/media/1338612569593807801_287676068/comments?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/x-www-form-urlencoded");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
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
        public async void Test_e73663698351450a9cc1d3c543c807d8()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/media/1338612569593807801_287676068/comments/17851823476094686?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
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
        public async void Test_5c9a4916e5ee44d496619c39411d080e()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/media/1338612569593807801_287676068/likes?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
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
        public async void Test_5d9187141e7c449d8efe1cf6ecbc7a5a()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/media/1338612569593807801_287676068/likes?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
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
        public async void Test_cef6960db0ff42b3a3ebd301ec9f948e()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("NoContent", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/media/1338612569593807801_287676068/likes?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
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
        public async void Test_a5018f9872834d8da0f38d5edf253821()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/media/1338612569593807801_287676068/likes?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/json");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
                    // You can do whatever you want with the resulting stream, or you can ReadAsStringAsync, or just remove "Async" to use the blocking methods.
                }
                else
                {
                    // You can do some stuff with the status code to decide what to do.
                }
            }

            // Assert

            string schema = @"{
  ""type"": ""object"",
  ""properties"": {
    ""data"": {
      ""type"": ""array""
    }
  }
}";

            JSchema s = JSchema.Parse(schema);
            JObject obj = JObject.Parse(body);
            // Assert
            Assert.True(obj.IsValid(s));
        }

        [Fact]
        public async void Test_9dc019fc92af40469d3627b487c8ad49()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/tags/computerscience?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
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
        public async void Test_029ca8ebd8744a5cbce0506feb324325()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/tags/computerscience?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/json");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
                    // You can do whatever you want with the resulting stream, or you can ReadAsStringAsync, or just remove "Async" to use the blocking methods.
                }
                else
                {
                    // You can do some stuff with the status code to decide what to do.
                }
            }

            // Assert

            string schema = @"{
  ""type"": ""object"",
  ""properties"": {
    ""data"": {
      ""type"": ""object"",
      ""properties"": {
        ""media_count"": {
          ""type"": ""integer""
        },
        ""name"": {
          ""type"": ""string""
        }
      }
    }
  }
}";

            JSchema s = JSchema.Parse(schema);
            JObject obj = JObject.Parse(body);
            // Assert
            Assert.True(obj.IsValid(s));
        }

        [Fact]
        public async void Test_49d6396ace3147c18dc46febea72aa43()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/tags/computerscience/media/recent?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
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
        public async void Test_cf31507b17f240719bc70672c434e245()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/tags/computerscience/media/recent?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/json");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
                    // You can do whatever you want with the resulting stream, or you can ReadAsStringAsync, or just remove "Async" to use the blocking methods.
                }
                else
                {
                    // You can do some stuff with the status code to decide what to do.
                }
            }

            // Assert

            string schema = @"{
  ""type"": ""object"",
  ""properties"": {
    ""data"": {
      ""type"": ""array""
    }
  }
}";

            JSchema s = JSchema.Parse(schema);
            JObject obj = JObject.Parse(body);
            // Assert
            Assert.True(obj.IsValid(s));
        }

        [Fact]
        public async void Test_03f4741871cc4362a137b5df3d766dff()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/tags/search?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
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
        public async void Test_dc1ab5789f234dc89190d136f188b63f()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/tags/search?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/json");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
                    // You can do whatever you want with the resulting stream, or you can ReadAsStringAsync, or just remove "Async" to use the blocking methods.
                }
                else
                {
                    // You can do some stuff with the status code to decide what to do.
                }
            }

            // Assert

            string schema = @"{
  ""type"": ""object""
}";

            JSchema s = JSchema.Parse(schema);
            JObject obj = JObject.Parse(body);
            // Assert
            Assert.True(obj.IsValid(s));
        }

        [Fact]
        public async void Test_1bfaeb8bf4134860b0816468ff7b24d7()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/users/287676068?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
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
        public async void Test_a1a4bf71906340588d76e2893f68fd70()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/users/287676068?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/json");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
                    // You can do whatever you want with the resulting stream, or you can ReadAsStringAsync, or just remove "Async" to use the blocking methods.
                }
                else
                {
                    // You can do some stuff with the status code to decide what to do.
                }
            }

            // Assert

            string schema = @"{
  ""type"": ""object"",
  ""properties"": {
    ""data"": {
      ""type"": ""object"",
      ""properties"": {
        ""id"": {
          ""type"": ""string""
        },
        ""username"": {
          ""type"": ""string""
        },
        ""full_name"": {
          ""type"": ""string""
        },
        ""profile_picture"": {
          ""type"": ""string""
        },
        ""bio"": {
          ""type"": ""string""
        },
        ""website"": {
          ""type"": ""string""
        },
        ""count"": {
          ""type"": ""object"",
          ""properties"": {
            ""media"": {
              ""type"": ""integer""
            },
            ""follows"": {
              ""type"": ""integer""
            },
            ""followed_by"": {
              ""type"": ""integer""
            }
          }
        }
      }
    }
  }
}";

            JSchema s = JSchema.Parse(schema);
            JObject obj = JObject.Parse(body);
            // Assert
            Assert.True(obj.IsValid(s));
        }

        [Fact]
        public async void Test_2bdbd908e5734701bd460f12be98b77a()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/users/287676068/relationship?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
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
        public async void Test_a4dd5046b294403c965a318267b8c3be()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/users/287676068/relationship?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
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
        public async void Test_a457908595e34d509164661de958fdb6()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/users/287676068/relationship?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/x-www-form-urlencoded");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
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
        public async void Test_fd809e3fe16c4926bb0c7e825cddf9b0()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/users/287676068/relationship?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/json");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
                    // You can do whatever you want with the resulting stream, or you can ReadAsStringAsync, or just remove "Async" to use the blocking methods.
                }
                else
                {
                    // You can do some stuff with the status code to decide what to do.
                }
            }

            // Assert

            string schema = @"{
  ""type"": ""object""
}";

            JSchema s = JSchema.Parse(schema);
            JObject obj = JObject.Parse(body);
            // Assert
            Assert.True(obj.IsValid(s));
        }

        [Fact]
        public async void Test_7721408903594ffdb20720529d393ade()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/users/287676068/relationship?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/json");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
                    // You can do whatever you want with the resulting stream, or you can ReadAsStringAsync, or just remove "Async" to use the blocking methods.
                }
                else
                {
                    // You can do some stuff with the status code to decide what to do.
                }
            }

            // Assert

            string schema = @"{
  ""type"": ""object""
}";

            JSchema s = JSchema.Parse(schema);
            JObject obj = JObject.Parse(body);
            // Assert
            Assert.True(obj.IsValid(s));
        }

        [Fact]
        public async void Test_bef4332f71b2473ba6873894b54ac12e()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/users/287676068/relationship?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/x-www-form-urlencoded");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
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
        public async void Test_af6120a2fe6548f2bb90e237d37e7bb8()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/users/self?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
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
        public async void Test_23d21d2b2eb14124888c1ee0136c8a08()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/users/self?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/json");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
                    // You can do whatever you want with the resulting stream, or you can ReadAsStringAsync, or just remove "Async" to use the blocking methods.
                }
                else
                {
                    // You can do some stuff with the status code to decide what to do.
                }
            }

            // Assert

            string schema = @"{
  ""type"": ""object"",
  ""properties"": {
    ""data"": {
      ""type"": ""object"",
      ""properties"": {
        ""id"": {
          ""type"": ""string""
        },
        ""username"": {
          ""type"": ""string""
        },
        ""full_name"": {
          ""type"": ""string""
        },
        ""profile_picture"": {
          ""type"": ""string""
        },
        ""bio"": {
          ""type"": ""string""
        },
        ""website"": {
          ""type"": ""string""
        },
        ""count"": {
          ""type"": ""object"",
          ""properties"": {
            ""media"": {
              ""type"": ""integer""
            },
            ""follows"": {
              ""type"": ""integer""
            },
            ""followed_by"": {
              ""type"": ""integer""
            }
          }
        }
      }
    }
  }
}";

            JSchema s = JSchema.Parse(schema);
            JObject obj = JObject.Parse(body);
            // Assert
            Assert.True(obj.IsValid(s));
        }

        [Fact]
        public async void Test_4c624a9f26e74eb8846b5645592ca2a2()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/locations/217492538?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
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
        public async void Test_5d751cd8562f4a54a46168310e765bba()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/locations/217492538?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/json");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
                    // You can do whatever you want with the resulting stream, or you can ReadAsStringAsync, or just remove "Async" to use the blocking methods.
                }
                else
                {
                    // You can do some stuff with the status code to decide what to do.
                }
            }

            // Assert

            string schema = @"{
  ""type"": ""object"",
  ""properties"": {
    ""id"": {
      ""type"": ""string""
    },
    ""name"": {
      ""type"": ""string""
    },
    ""latitude"": {
      ""type"": ""number""
    },
    ""longitude"": {
      ""type"": ""number""
    },
    ""street_address"": {
      ""type"": ""string""
    }
  }
}";

            JSchema s = JSchema.Parse(schema);
            JObject obj = JObject.Parse(body);
            // Assert
            Assert.True(obj.IsValid(s));
        }

        [Fact]
        public async void Test_f5a7dedbb97748c4a486520076c8a575()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/locations/search?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
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
        public async void Test_7463229e148a431d9c9e05ad3899467f()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/locations/search?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/json");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
                    // You can do whatever you want with the resulting stream, or you can ReadAsStringAsync, or just remove "Async" to use the blocking methods.
                }
                else
                {
                    // You can do some stuff with the status code to decide what to do.
                }
            }

            // Assert

            string schema = @"{
  ""type"": ""object""
}";

            JSchema s = JSchema.Parse(schema);
            JObject obj = JObject.Parse(body);
            // Assert
            Assert.True(obj.IsValid(s));
        }

        [Fact]
        public async void Test_e4c1867fece841e8ac3324948624bb05()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/geographies/xxxxxxx/media/recent?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
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
        public async void Test_d2de993a9de84b9f9bac2b8a0cc1749a()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/subscriptions?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
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
        public async void Test_400e071cf5b5474e88e596932b76a980()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/subscriptions?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
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
        public async void Test_1d394cb28802432d80e0511b4d6765d4()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/subscriptions?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
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
        public async void Test_85b7bf84416742f58a2032006888588d()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/subscriptions?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/x-www-form-urlencoded");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
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
        public async void Test_1f25c6e0710f41d5a66bc825c7e2a283()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/subscriptions?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/json");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
                    // You can do whatever you want with the resulting stream, or you can ReadAsStringAsync, or just remove "Async" to use the blocking methods.
                }
                else
                {
                    // You can do some stuff with the status code to decide what to do.
                }
            }

            // Assert

            string schema = @"{
  ""type"": ""object""
}";

            JSchema s = JSchema.Parse(schema);
            JObject obj = JObject.Parse(body);
            // Assert
            Assert.True(obj.IsValid(s));
        }

        [Fact]
        public async void Test_9e057a462ce8402b93ee244bc1ecd452()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/subscriptions?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/json");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
                    // You can do whatever you want with the resulting stream, or you can ReadAsStringAsync, or just remove "Async" to use the blocking methods.
                }
                else
                {
                    // You can do some stuff with the status code to decide what to do.
                }
            }

            // Assert

            string schema = @"{
  ""type"": ""object""
}";

            JSchema s = JSchema.Parse(schema);
            JObject obj = JObject.Parse(body);
            // Assert
            Assert.True(obj.IsValid(s));
        }

        [Fact]
        public async void Test_8ba31b00d5a2474fa41fb264a179fef2()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/subscriptions?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/json");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
                    // You can do whatever you want with the resulting stream, or you can ReadAsStringAsync, or just remove "Async" to use the blocking methods.
                }
                else
                {
                    // You can do some stuff with the status code to decide what to do.
                }
            }

            // Assert

            string schema = @"{
  ""type"": ""object""
}";

            JSchema s = JSchema.Parse(schema);
            JObject obj = JObject.Parse(body);
            // Assert
            Assert.True(obj.IsValid(s));
        }

        [Fact]
        public async void Test_2558d4d3b40a4e78a188ddb1d7edcb5e()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/subscriptions?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/x-www-form-urlencoded");
            HttpStatusCode acctualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                acctualStatusCode = response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    body = new StreamReader(result).ReadToEnd();
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
