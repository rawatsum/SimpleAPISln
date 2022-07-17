using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Tests;

public class UnitTest1
{
    
    WeatherForecastController controller = new WeatherForecastController();
        
         [Fact]
    public void getTest()
    {
        var arr = controller.Get(1);
        Assert.Matches("sumit",arr.ToString());
        
    }

[Fact]
    public void getTest1()
    {
        var arr1 = controller.Get(1,2);
        Assert.Matches("ravikant",arr1.ToString());
    }
[Fact]
 public void getTest2()
    {
        var arr1 = controller.Get(1,2,3);
        Assert.Matches("kathmandu",arr1.ToString());
    }

}