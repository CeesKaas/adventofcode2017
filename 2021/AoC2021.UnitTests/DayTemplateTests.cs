﻿using Moq;
using NUnit.Framework;
using System;
using Utilities;

namespace AoC2021.UnitTests;

internal class DayTemplateTests
{
    [Test]
    public void TestDayTemplatePart1()
    {
        var inputMock = new Mock<IInputFetcher>();
        var objUnderTest = new DayTemplate(inputMock.Object);
        PrepareInput(inputMock);
        Assert.That(objUnderTest.Part1(), Is.EqualTo(7));
    }
    [Test]
    public void TestDayTemplatePart2()
    {
        var inputMock = new Mock<IInputFetcher>();
        var objUnderTest = new DayTemplate(inputMock.Object);
        PrepareInput(inputMock);
        Assert.That(objUnderTest.Part2(), Is.EqualTo(5));
    }

    private static void PrepareInput(Mock<IInputFetcher> inputMock)
    {
        inputMock.Setup(m => m.GetTransformedSplitInputForDay<int>(1, It.IsAny<Func<string, int>>())).Returns(new int[]{
                199,
                200,
                208,
                210,
                200,
                207,
                240,
                269,
                260,
                263
            });
    }
}
