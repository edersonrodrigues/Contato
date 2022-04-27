using Api.Application.Controllers;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using Test.Service;
using Xunit;

namespace Test
{
    public class ContatoControllerTest
    {
        public IContato _service { get; set; }
        ContatoController _controller;

        public ContatoControllerTest()
        {
            _service = new ContatoServiceFake();
            _controller = new ContatoController(_service);
        }

        [Fact]
        public void GetAllAsync()
        {
            var okResult = _controller.GetAllAsync();
            Assert.IsType<OkObjectResult>(okResult.Result);
        }
    }
}
