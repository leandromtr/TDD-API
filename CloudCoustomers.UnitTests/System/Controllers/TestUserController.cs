using Xunit;
using CloudCoustomers.API.Controllers;
using Microsoft.AspNetCore.Mvc;
using FluentAssertions;
using Moq;
using CloudCoustomers.API.Services;
using CloudCoustomers.API.Models;
using System.Collections.Generic;

namespace CloudCoustomers.UnitTests.System.Controllers;

public class TestUserController
{
    [Fact]
    public async void Get_OnSuccess_ReturnsStatusCode200()
    {
        //Arrange   
        var mockUserService = new Mock<IUsersService>();
        mockUserService.Setup(service => service.GetAllUsers())
            .ReturnsAsync(new List<User>());

        var sut = new UsersController(mockUserService.Object);
        //Act
        var result = (OkObjectResult)await sut.Get();
        //Assert
        result.StatusCode.Should().Be(200);
    }

    [Fact]
    public async void Get_OnSuccess_InvokesUserServiceExactlyOnce()
    {
        //Arrange   
        var mockUserService = new Mock<IUsersService>();
        mockUserService.Setup(service => service.GetAllUsers())
            .ReturnsAsync(new List<User>());

        var sut = new UsersController(mockUserService.Object);
        //Act
        var result = (OkObjectResult)await sut.Get();
        //Assert
        mockUserService.Verify(service => service.GetAllUsers(), Times.Once());
    }

    [Fact]
    public async void Get_OnSuccess_ReturnListUsers()
    {
        //Arrange   
        var mockUserService = new Mock<IUsersService>();
        mockUserService.Setup(service => service.GetAllUsers())
            .ReturnsAsync(new List<User>());

        var sut = new UsersController(mockUserService.Object);
        //Act
        var result = (OkObjectResult)await sut.Get();
        //Assert
        result.Should().BeOfType<OkObjectResult>();
        var objectResult = (OkObjectResult)result;
        objectResult.Value.Should().BeOfType<List<User>>();
    }
}