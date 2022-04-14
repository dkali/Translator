using System;
using System.Threading;
using Xunit;
using System.Collections.Generic;
using UnitTests.Models;
using RestSharp;
using System.Threading.Tasks;
using FluentAssertions;

namespace UnitTests;

[Collection("Our Test Collection #1")]
public class UnitTest1 : IDisposable
{
    Stack<int> stack;
    WebClient webClient;

    public UnitTest1(WebClient fixture)
    {
        // setup
        stack = new Stack<int>();
        webClient = fixture;
    }

    public void Dispose()
    {
        // teardown
    }

    [Fact]
    public async Task PassingTest()
    {
        Pizza pz = await webClient.GetPizza(1);

        pz.Id.Should().Be(1);
        pz.Name.Should().Be("Classic Italian", "I want so");
        pz.IsGlutenFree.Should().Be(false);

        //Assert.Equal(4, Add(2, 2));
    }

    //[Fact]
    //public void FailingTest()
    //{
    //    Assert.Equal(5, Add(2, 2));
    //}

    int Add(int x, int y)
    {
        return x + y;
    }

    [Theory]
    [InlineData(3)]
    [InlineData(5)]
    [InlineData(6)]
    public void MyFirstTheory(int value)
    {
        Assert.True(IsOdd(value));
    }

    bool IsOdd(int value)
    {
        return value % 2 == 1;
    }

    [Fact]
    public void Test1()
    {
        Thread.Sleep(3000);
    }

}