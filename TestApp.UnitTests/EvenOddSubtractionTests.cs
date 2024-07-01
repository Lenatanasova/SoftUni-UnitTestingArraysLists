using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        int result = EvenOddSubtraction.FindDifference(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    // TODO: finish the test
    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        // Arrange
        int[] evenNumArray = new int[] { 2, 4, 6, 8 };

        // Act
        int result = EvenOddSubtraction.FindDifference(evenNumArray);

        // Assert
        Assert.That(result, Is.EqualTo(20));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnNegativeOddSum()
    {
        // Arrange
        int[] oddNumArray = new int[] { 1, 5, 7, 13 };

        // Act
        int result = EvenOddSubtraction.FindDifference(oddNumArray);

        // Assert
        Assert.That(result, Is.EqualTo(-26));
    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        // Arrange
        int[] mixedNumArray = new int[] { 2, 5, 18, 17 };

        // Act
        int result = EvenOddSubtraction.FindDifference(mixedNumArray);

        // Assert
        Assert.That(result, Is.EqualTo(-2));
    }
}
