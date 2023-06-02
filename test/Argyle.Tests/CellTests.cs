using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Argyle.Tests;

public class CellTests
{
    [Fact]
    public void Equals_ReturnsTrue_WhenIndexIsEqual()
    {
        // Arrange
        var cell1 = new Cell(0, null);
        var cell2 = new Cell(0, null);

        // Act
        var result = cell1.Equals(cell2);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Equals_ReturnsFalse_WhenIndexIsNotEqual()
    {
        // Arrange
        var cell1 = new Cell(0, null);
        var cell2 = new Cell(1, null);

        // Act
        var result = cell1.Equals(cell2);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Equals_ReturnsFalse_WhenObjectIsNotCell()
    {
        // Arrange
        var cell = new Cell(0, null);
        var obj = new object();

        // Act
        var result = cell.Equals(obj);

        // Assert
        Assert.False(result);
    }
}
