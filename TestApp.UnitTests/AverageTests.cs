using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class AverageTests
{
    // TODO: finish the test
    [Test]
    public void Test_CalculateAverage_InputHasOneElement_ShouldReturnSameElement()
    {
        // Arrange
        int[] oneElementArray = { 42 };

        // Act
        double result = Average.CalculateAverage(oneElementArray);

        // Assert
        Assert.That(result, Is.EqualTo(42));
    }

    [Test]
    public void Test_CalculateAverage_InputHasPositiveIntegers_ShouldReturnCorrectAverage()
    {
        // TODO: finish the test

        // Arrange
        int[] positiveElementsArray = { 2, 5, 18, 27 };

        // Act
        double result = Average.CalculateAverage(positiveElementsArray);

        // Assert
        Assert.That(result, Is.EqualTo(13));
    }

    [Test]
    public void Test_CalculateAverage_InputHasNegativeIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] negativeElementsArray = { -1, -8, -19, -76 };

        // Act
        double result = Average.CalculateAverage(negativeElementsArray);

        // Assert
        Assert.That(result, Is.EqualTo(-26));
    }

    [Test]
    public void Test_CalculateAverage_InputHasMixedIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] mixedElementsArray = { 1, -8, 36, -6, 19 };

        // Act
        double result = Average.CalculateAverage(mixedElementsArray);

        // Assert
        Assert.That(result, Is.EqualTo(8.4));
    }
}
