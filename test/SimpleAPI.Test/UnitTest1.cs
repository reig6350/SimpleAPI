using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();

        [Fact]
        public void GetReturnsMyName()
        {
            var returnValues = controller.Get(2);
            Assert.Equal("Shaun Reiger", returnValues);
        }


        [Fact]
        public void Test1()
        {

        }
    }
}
