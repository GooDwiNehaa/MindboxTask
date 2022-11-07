using Figures.Library.Figures.Figures3D;

namespace Figures.Test.Figures3D;

[TestClass]
public class SphereTest
{
    [TestMethod]
    public void Area_R_5_Return_314Dot1592653589793()
    {
        //act
        var r = 5;
        var expected = 314.1592653589793;
        //arrange
        var sphere = new Sphere(r);
        var area = sphere.Area();
        //assert
        Assert.AreEqual(expected, area);
    }

    [TestMethod]
    public void Volume_R_5_Return_523Dot5987755982989()
    {
        //act
        var r = 5;
        var expected = 523.5987755982989;
        //arrange
        var sphere = new Sphere(r);
        var volume = sphere.Volume();
        //assert
        Assert.AreEqual(expected, volume);
    }

    [TestMethod]
    public void Invalid_Radius()
    {
        Assert.ThrowsException<ArgumentException>(() => new Sphere(0));
        Assert.ThrowsException<ArgumentException>(() => new Sphere(-1));
    }
}