using System;
using System.Diagnostics;
using MyTestCSharpProject1.Src.API;
using MyTestCSharpProject1.Src.Dto;
using MyTestCSharpProject1.Test.Tests.Base;
using Xunit;

namespace MyTestCSharpProject1.Test.Tests
{
    [Collection("Collection D")]
    public class ApiTest : BaseApiTest
    {
        UserService userService;

        public ApiTest()
        {
             userService = new UserService();
        }

        [Fact]
        public void GetUsersTest()
        {
            var response = userService.GetUser(2);

            Assert.Equal(2, response.Page);
            Assert.Equal("Michael", response.Data[0].FirstName);
        }

        [Fact]
        public void CreateUserTest()
        {
            var response = userService.CreateUser("Mike", "QA");

            Assert.Equal("Mike",response.Name);
            Assert.Equal("QA", response.Job);
        }

        [Fact]
        public async void TestAsync()
        {
            var response = await userService.CreateUserAsync("Mike", "QA");
            var response2 = await userService.CreateUserAsync2("Mike2", "QA2");


            Assert.Equal("Mike", response.Name);
            Assert.Equal("QA", response.Job);
        }
    }
}
