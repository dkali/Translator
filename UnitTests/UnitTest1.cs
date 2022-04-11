using System;
using System.Threading;
using Xunit;
using System.Collections.Generic;

namespace UnitTests;

[Collection("Our Test Collection #1")]
public class UnitTest1 : IDisposable
{
    Stack<int> stack;

    public UnitTest1()
    {
        // setup
        stack = new Stack<int>();
    }

    public void Dispose()
    {
        // teardown
    }

    [Fact]
    public void PassingTest()
    {
        Assert.Equal(4, Add(2, 2));
    }

    [Fact]
    public void FailingTest()
    {
        Assert.Equal(5, Add(2, 2));
    }

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

    // [Fact]
    // public void Test1()
    // {
    //     Thread.Sleep(3000);
    // }

}