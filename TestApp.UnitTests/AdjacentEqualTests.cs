using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{
    // TODO: finish test
    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> emptyList = new();
        string expected = "";

        // Act
        string actual = AdjacentEqual.Sum(emptyList);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    // TODO: finish test
    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
        // Arrange
        List<int> numbers = new() { 1, 2, 3, 4, 5 };
        string expected = "1 2 3 4 5";

        // Act
        string actual = AdjacentEqual.Sum(numbers);

        // Assert
        Assert.That(actual, Is.EqualTo (expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        // Arrange
        List<int> numbers = new() { 1, 1, 2, 3, 3, 3, 4, 5, 5 };
        string expected = "2 2 9 4 10";

        // Act
        string actual = AdjacentEqual.Sum(numbers);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        // Arrange
        List<int> numbers = new() { 8, 8, 8, 8, 8};
        string expected = "40";

        // Act
        string actual = AdjacentEqual.Sum(numbers);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {
        // Arrange
        List<int> numbers = new() {4, 4, 1, 2, 3 };
        string expected = "8 1 2 3";

        // Act
        string actual = AdjacentEqual.Sum(numbers);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        // Arrange
        List<int> numbers = new() { 1, 2, 3, 7, 7 };
        string expected = "1 2 3 14";

        // Act
        string actual = AdjacentEqual.Sum(numbers);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        // Arrange
        List<int> numbers = new() { 1, 2, 3, 3, 7 };
        string expected = "1 2 6 7";

        // Act
        string actual = AdjacentEqual.Sum(numbers);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
