using Figures.Library.Figures.Figures2D;

namespace Figures.Test.Figures2D;

[TestClass]
public class TriangleTest
{
    [TestMethod]
    public void Area_A_5_B_7_C_10_Return_16Dot24807680927192()
    {
        //act
        var a = 5;
        var b = 7;
        var c = 10;

        var expected = 16.24807680927192;
        //arrange
        var triangle = new Triangle(a, b, c);
        var area = triangle.Area();
        //assert
        Assert.AreEqual(expected, area);
    }

    [TestMethod]
    public void Perimeter_A_5_B_7_C_10_Return_22()
    {
        //act
        var a = 5;
        var b = 7;
        var c = 10;

        var expected = 22;
        //arrange
        var triangle = new Triangle(a, b, c);
        var perimeter = triangle.Perimeter();
        //assert
        Assert.AreEqual(expected, perimeter);
    }

    [TestMethod]
    public void Triangle_Is_Right()
    {
        Assert.IsTrue(new Triangle(3, 4, 5).IsRight());
        Assert.IsTrue(new Triangle(3, 5, 4).IsRight());
        Assert.IsTrue(new Triangle(4, 3, 5).IsRight());
        Assert.IsTrue(new Triangle(4, 5, 3).IsRight());
        Assert.IsTrue(new Triangle(5, 3, 4).IsRight());
        Assert.IsTrue(new Triangle(5, 4, 3).IsRight());

        Assert.IsFalse(new Triangle(3, 3, 3).IsRight());
        Assert.IsFalse(new Triangle(5, 3, 3).IsRight());
        Assert.IsFalse(new Triangle(6, 4, 3).IsRight());
    }

    [TestMethod]
    public void Invalid_Sides_Which_Less_Or_Equal_0()
    {
        Assert.ThrowsException<ArgumentException>(() => new Triangle(-1, -1, -1));
        Assert.ThrowsException<ArgumentException>(() => new Triangle(0, 0, 0));

        Assert.ThrowsException<ArgumentException>(() => new Triangle(0, 1, 2));
        Assert.ThrowsException<ArgumentException>(() => new Triangle(1, 0, 2));
        Assert.ThrowsException<ArgumentException>(() => new Triangle(2, 1, 0));

        Assert.ThrowsException<ArgumentException>(() => new Triangle(-1, 1, 2));
        Assert.ThrowsException<ArgumentException>(() => new Triangle(1, -1, 2));
        Assert.ThrowsException<ArgumentException>(() => new Triangle(2, 1, -1));
    }

    [TestMethod]
    public void Invalid_Sides_Where_One_Side_Triangle_More_Than_Sum_Other_Two()
    {
        Assert.ThrowsException<ArgumentException>(() => new Triangle(7, 3, 3));
        Assert.ThrowsException<ArgumentException>(() => new Triangle(3, 7, 3));
        Assert.ThrowsException<ArgumentException>(() => new Triangle(3, 3, 7));
    }
}