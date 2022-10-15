using NUnit.Framework;

public class DifferenceOfSquaresTests
{
    [Test]
    public void Square_of_sum_1()
    {
        Assert.AreEqual(1, DifferenceOfSquares.CalculateSquareOfSum(1));
    }

    [Test]
    public void Square_of_sum_5()
    {
        Assert.AreEqual(225, DifferenceOfSquares.CalculateSquareOfSum(5));
    }

    [Test]
    public void Square_of_sum_100()
    {
        Assert.AreEqual(25502500, DifferenceOfSquares.CalculateSquareOfSum(100));
    }

    [Test]
    public void Sum_of_squares_1()
    {
        Assert.AreEqual(1, DifferenceOfSquares.CalculateSumOfSquares(1));
    }

    [Test]
    public void Sum_of_squares_5()
    {
        Assert.AreEqual(55, DifferenceOfSquares.CalculateSumOfSquares(5));
    }

    [Test]
    public void Sum_of_squares_100()
    {
        Assert.AreEqual(338350, DifferenceOfSquares.CalculateSumOfSquares(100));
    }

    [Test]
    public void Difference_of_squares_1()
    {
        Assert.AreEqual(0, DifferenceOfSquares.CalculateDifferenceOfSquares(1));
    }

    [Test]
    public void Difference_of_squares_5()
    {
        Assert.AreEqual(170, DifferenceOfSquares.CalculateDifferenceOfSquares(5));
    }

    [Test]
    public void Difference_of_squares_100()
    {
        Assert.AreEqual(25164150, DifferenceOfSquares.CalculateDifferenceOfSquares(100));
    }
}