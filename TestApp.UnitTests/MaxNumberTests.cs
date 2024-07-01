using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        // Arrange
        List<int> oneElementList = new List<int> { 8 };
        int expected = 8;


        // Act
        int actual = MaxNumber.FindMax(oneElementList);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> positiveElementList = new List<int> { 8, 3, 1, 12 };
        int expected = 12;


        // Act
        int actual = MaxNumber.FindMax(positiveElementList);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> negativeElementList = new List<int> { -1, -6, -14 };
        int expected = -1;


        // Act
        int actual = MaxNumber.FindMax(negativeElementList);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> mixedElementList = new List<int> { 8, -8, 0, -12, 4 };
        int expected = 8;


        // Act
        int actual = MaxNumber.FindMax(mixedElementList);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        // Arrange
        List<int> duplicateElementList = new List<int> { 8, 3, 1, 8, 0 };
        int expected = 8;


        // Act
        int actual = MaxNumber.FindMax(duplicateElementList);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
