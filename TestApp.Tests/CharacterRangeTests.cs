using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading;

namespace TestApp.Tests;

public class CharacterRangeTests
{
    [Test]
    public void Test_GetRange_WithAAndBInOrder_ReturnsEmptyString()
    {
        //Arrange
        char chOne = 'A';
        char chTwo = 'B';

        //Act
        string output = CharacterRange.GetRange('A', 'B');

        //Assert
        Assert.That(output, Is.Empty);
    }

    [Test]
    public void Test_GetRange_WithBAndAInOrder_ReturnsEmptyString()
    {
        //Arrange
        char chOne = 'B';
        char chTwo = 'A';

        //Act
        string output = CharacterRange.GetRange('B', 'A');

        //Assert
        Assert.That(output, Is.Empty);
    }

    [Test]
    public void Test_GetRange_WithAAndCInOrder_ReturnsB()
    {
        //Arrange
        
        List<char> charThree = new List<char> { 'A', 'C' };

        //Act
        string output = CharacterRange.GetRange('A', 'C');

        //Assert
        Assert.That(output, Is.EqualTo("B"));
    }

    [Test]
    public void Test_GetRange_WithDAndGInOrder_Returns_E_F()
    {
        //Arrange

        List<char> charThree = new List<char> { 'D', 'G' };

        //Act
        string output = CharacterRange.GetRange('D', 'G');

        //Assert
        Assert.That(output, Is.EqualTo("E F"));
    }

    [Test]
    public void Test_GetRange_WithXAndZInOrder_Returns_Y()
    {
        //Arrange

        List<char> charThree = new List<char> { 'X', 'Z' };

        //Act
        string output = CharacterRange.GetRange('X', 'Z');

        //Assert
        Assert.That(output, Is.EqualTo("Y"));
    }
}
