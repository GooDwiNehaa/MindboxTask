using Figures.Library.Figures.Figures2D;

namespace Figures.Test.Figures2D;

[TestClass]
public class CircleTest
{
    [TestMethod]
    public void Area_R_5_Return_78Dot53981633974483()
    {
        //act
        var r = 5;
        var expected = 78.53981633974483;
        //arrange
        var circle = new Circle(r);
        var area = circle.Area();
        //assert
        Assert.AreEqual(expected, area);
    }

    [TestMethod]
    public void Perimeter_R_5_Return_31Dot41592653589793()
    {
        //act
        var r = 5;
        var expected = 31.41592653589793;
        //arrange
        var circle = new Circle(r);
        var perimeter = circle.Perimeter();
        //assert
        Assert.AreEqual(expected, perimeter);
    }

    [TestMethod]
    public void Invalid_Radius()
    {
        Assert.ThrowsException<ArgumentException>(() => new Circle(0));
        Assert.ThrowsException<ArgumentException>(() => new Circle(-1));
    }
}