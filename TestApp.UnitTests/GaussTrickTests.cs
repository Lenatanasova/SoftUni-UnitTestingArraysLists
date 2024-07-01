using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new();
        List<int> expected = new();

        // Act
        List<int> result = GaussTrick.SumPairs(emptyList);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        // Arrange
        List<int> singleElementList = new List<int> { 7 };

        // Act
        List<int> result = GaussTrick.SumPairs(singleElementList);

        // Assert
        CollectionAssert.AreEqual(singleElementList, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> evenCountList = new List<int> {2, 1, 7, 9};
        List<int> expected = new List<int> { 11, 8 };

        // Act
        List<int> result = GaussTrick.SumPairs(evenCountList);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> oddCountList = new List<int> { 2, 1, 7, 9, 17 };
        List<int> expected = new List<int> { 19, 10, 7 };

        // Act
        List<int> result = GaussTrick.SumPairs(oddCountList);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> evenLargeCountList = new List<int> { 2, 1, 56, 9, 71, 34, 86, 4 };
        List<int> expected = new List<int> { 6, 87, 90, 80 };

        // Act
        List<int> result = GaussTrick.SumPairs(evenLargeCountList);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> oddLargeCountList = new List<int> { 2, 8, 7, 9, 17, 36, 19, 42, 3 };
        List<int> expected = new List<int> { 5, 50, 26, 45, 17};

        // Act
        List<int> result = GaussTrick.SumPairs(oddLargeCountList);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
