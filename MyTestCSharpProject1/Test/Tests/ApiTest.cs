using System;
using System.Diagnostics;
using Allure.Xunit.Attributes;
using MyTestCSharpProject1.Src.API;
using MyTestCSharpProject1.Src.Dto;
using MyTestCSharpProject1.Test.Tests.Base;
using Xunit;

namespace MyTestCSharpProject1.Test.Tests
{
    [AllureSuite("Suite D")]
    //[Collection("Collection D")]
    [Trait("Category", "CategoryA")]
    public class ApiTest : BaseApiTest
    {
        UserService userService;

        public ApiTest()
        {
             userService = new UserService();
        }

        //[Fact]
        [AllureXunit(DisplayName = "Get User Test")]
        public void GetUsersTest()
        {
            var response = userService.GetUser(2);

            Assert.Equal(2, response.Page);
            Assert.Equal("Michael", response.Data[0].FirstName);
        }

        //[Fact]
        [AllureXunit(DisplayName = "Create User Test")]
        public void CreateUserTest()
        {
            var response = userService.CreateUser("Mike", "QA");

            Assert.Equal("Mike",response.Name);
            Assert.Equal("QA", response.Job);
        }

        //[Fact]
        [AllureXunit(DisplayName = "Async Create User Test")]
        public async void TestAsync()
        {
            var response = await userService.CreateUserAsync("Mike", "QA");
            var response2 = await userService.CreateUserAsync2("Mike2", "QA2");


            Assert.Equal("Mike", response.Name);
            Assert.Equal("QA", response.Job);
        }
    }
}
