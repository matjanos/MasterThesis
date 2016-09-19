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
        public async void Test_f0be1cd4d98b44b9af2b97a1dea059a2()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/media/1338612569593807801_287676068?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            HttpStatusCode actualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                actualStatusCode = response.StatusCode;

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
            Assert.Equal(expectedStatusCode, actualStatusCode);
        }

        [Fact]
        public async void Test_816cb2e0f4fd46b8aa054bdaac7a403f()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/media/1338612569593807801_287676068?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/json");
            HttpStatusCode actualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                actualStatusCode = response.StatusCode;

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
        public async void Test_e5524278cf78405f9b047b3af64b88b6()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/media/1338612569593807801_287676068/comments?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            HttpStatusCode actualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                actualStatusCode = response.StatusCode;

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
            Assert.Equal(expectedStatusCode, actualStatusCode);
        }

        [Fact]
        public async void Test_39bdb794e3d9454bb1b5ec8410048040()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/media/1338612569593807801_287676068/comments?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/x-www-form-urlencoded");
            HttpStatusCode actualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                actualStatusCode = response.StatusCode;

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
            Assert.Equal(expectedStatusCode, actualStatusCode);
        }

        [Fact]
        public async void Test_61b99f0fd0954e1da69a85f6673272bb()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/media/1338612569593807801_287676068/comments?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/json");
            HttpStatusCode actualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                actualStatusCode = response.StatusCode;

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
        public async void Test_b5761b3b597b4bc79dfba3f99002912b()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/media/1338612569593807801_287676068/comments?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/x-www-form-urlencoded");
            HttpStatusCode actualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                actualStatusCode = response.StatusCode;

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
            Assert.Equal(expectedStatusCode, actualStatusCode);
        }

        [Fact]
        public async void Test_e58ce878299345e6a50257e60536ce15()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/media/1338612569593807801_287676068/likes?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            HttpStatusCode actualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                actualStatusCode = response.StatusCode;

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
            Assert.Equal(expectedStatusCode, actualStatusCode);
        }

        [Fact]
        public async void Test_3a709ec8b9f14cb0b6b9737e878653f5()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Post");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/media/1338612569593807801_287676068/likes?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            HttpStatusCode actualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                actualStatusCode = response.StatusCode;

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
            Assert.Equal(expectedStatusCode, actualStatusCode);
        }

        [Fact]
        public async void Test_0f5e79cb432e47bbb667d446bb39ce6a()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("NoContent", out expectedStatusCode);

            var method = GetMethodFromString("Delete");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/media/1338612569593807801_287676068/likes?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            HttpStatusCode actualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                actualStatusCode = response.StatusCode;

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
            Assert.Equal(expectedStatusCode, actualStatusCode);
        }

        [Fact]
        public async void Test_501fd7ae1f8a4adea59b85ad1fc35601()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/media/1338612569593807801_287676068/likes?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/json");
            HttpStatusCode actualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                actualStatusCode = response.StatusCode;

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
        public async void Test_92e3ffb7494941bcb372dbee63d9c1d7()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/tags/computerscience?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            HttpStatusCode actualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                actualStatusCode = response.StatusCode;

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
            Assert.Equal(expectedStatusCode, actualStatusCode);
        }

        [Fact]
        public async void Test_61da97d026a64cb4b7c4b54f08ca7ac0()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/tags/computerscience?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/json");
            HttpStatusCode actualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                actualStatusCode = response.StatusCode;

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
        public async void Test_4b1af2e4650d4bbbad67a1592f426946()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/tags/computerscience/media/recent?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            HttpStatusCode actualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                actualStatusCode = response.StatusCode;

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
            Assert.Equal(expectedStatusCode, actualStatusCode);
        }

        [Fact]
        public async void Test_d417ddfcfda74715b9f9ccbd0556c632()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/tags/computerscience/media/recent?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/json");
            HttpStatusCode actualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                actualStatusCode = response.StatusCode;

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
        public async void Test_df8ffa60ab424bd8b1b46ec34f8e7d58()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/tags/search?q=nofilter&access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            HttpStatusCode actualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                actualStatusCode = response.StatusCode;

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
            Assert.Equal(expectedStatusCode, actualStatusCode);
        }

        [Fact]
        public async void Test_a4eb92a9c7954d8faf72ae7bb1a73116()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/tags/search?q=nofilter&access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/json");
            HttpStatusCode actualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                actualStatusCode = response.StatusCode;

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
        public async void Test_620acf710dd74776ab512dc573fad43c()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/users/287676068?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            HttpStatusCode actualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                actualStatusCode = response.StatusCode;

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
            Assert.Equal(expectedStatusCode, actualStatusCode);
        }

        [Fact]
        public async void Test_965e4adf6b1b4e32b857f754ddc0d33b()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/users/287676068?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/json");
            HttpStatusCode actualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                actualStatusCode = response.StatusCode;

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
        public async void Test_ff06a24137bf4f988fd8f9346ff66636()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/users/287676068/relationship?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            HttpStatusCode actualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                actualStatusCode = response.StatusCode;

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
            Assert.Equal(expectedStatusCode, actualStatusCode);
        }

        [Fact]
        public async void Test_6d92fc408d70408988c8eaa305b44d6c()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/users/287676068/relationship?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            HttpStatusCode actualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                actualStatusCode = response.StatusCode;

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
            Assert.Equal(expectedStatusCode, actualStatusCode);
        }

        [Fact]
        public async void Test_969063139fed4b6292a2968250170c5f()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/users/287676068/relationship?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/x-www-form-urlencoded");
            HttpStatusCode actualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                actualStatusCode = response.StatusCode;

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
            Assert.Equal(expectedStatusCode, actualStatusCode);
        }

        [Fact]
        public async void Test_f9ce2c30a7534885b395e7ebbc20a5d4()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/users/287676068/relationship?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/json");
            HttpStatusCode actualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                actualStatusCode = response.StatusCode;

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
        public async void Test_2389e1daa9a14f58a53397c7767ab7e2()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/users/287676068/relationship?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/json");
            HttpStatusCode actualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                actualStatusCode = response.StatusCode;

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
        public async void Test_6eff21eec2d84aa5be1e5eaf2a3854c2()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/users/287676068/relationship?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/x-www-form-urlencoded");
            HttpStatusCode actualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                actualStatusCode = response.StatusCode;

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
            Assert.Equal(expectedStatusCode, actualStatusCode);
        }

        [Fact]
        public async void Test_cff7db11dca24e2085a75eac8059e827()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/users/self?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            HttpStatusCode actualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                actualStatusCode = response.StatusCode;

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
            Assert.Equal(expectedStatusCode, actualStatusCode);
        }

        [Fact]
        public async void Test_69648241873c4b419c92a0317a4201d7()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/users/self?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/json");
            HttpStatusCode actualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                actualStatusCode = response.StatusCode;

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
        public async void Test_2813355dbd854a1ea42231de832eb986()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/locations/217492538?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            HttpStatusCode actualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                actualStatusCode = response.StatusCode;

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
            Assert.Equal(expectedStatusCode, actualStatusCode);
        }

        [Fact]
        public async void Test_8b310f9d96f247a98a6a950db3a68bba()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/locations/217492538?access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/json");
            HttpStatusCode actualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                actualStatusCode = response.StatusCode;

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
        public async void Test_8845add2368a41999989f49408ae2b4a()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/locations/search?lat=48.858844&lng=2.294351&access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            HttpStatusCode actualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                actualStatusCode = response.StatusCode;

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
            Assert.Equal(expectedStatusCode, actualStatusCode);
        }

        [Fact]
        public async void Test_50a5ac857bcf4b459e127cb338d4c72d()
        {
            // Arrange
            HttpStatusCode expectedStatusCode;
            Enum.TryParse("OK", out expectedStatusCode);

            var method = GetMethodFromString("Get");
            HttpRequestMessage message = new HttpRequestMessage(method, @"https://api.instagram.com/v1/locations/search?lat=48.858844&lng=2.294351&access_token=287676068.f22a470.ff57149353f24c859f234a6b0c945049");
            message.Headers.Add("Accept", "application/json");
            HttpStatusCode actualStatusCode;
            string body = null;

            // Act
            using (HttpClient client = new HttpClient())
            using (var response = await client.SendAsync(message))
            {
                actualStatusCode = response.StatusCode;

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
