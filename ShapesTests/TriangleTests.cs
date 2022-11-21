using Shape.Shapes;

namespace ShapesTests;

public class TriangleTests
{
    [Test]
    public void SquareTest1()
    {
        var triangle = new Triangle(3, 2, 4);
        Assert.AreEqual(triangle.Square(),  2.9047, 0.1);
    }
    
    [Test]
    public void SquareTest2()
    {
        var triangle = new Triangle(4, 6, 8);
        Assert.AreEqual(triangle.Square(),  11.6189, 0.1);
    }
    
    [Test]
    public void SquareTest3()
    {
        var triangle = new Triangle(12, 23, 12);
        Assert.AreEqual(triangle.Square(),  39.4200, 0.1);
    }

    [Test]
    public void CreateTriangleTest1()
    {
        Assert.Throws<InvalidOperationException>(() =>
        {
            var triangle = new Triangle(212, 23, 12);
        });
    }
    
    [Test]
    public void CreateTriangleTest2()
    {
        Assert.Throws<InvalidOperationException>(() =>
        {
            var triangle = new Triangle(0, 23, 12);
        });
    }
    
    [Test]
    public void CreateTriangleTest3()
    {
        Assert.Throws<InvalidOperationException>(() =>
        {
            var triangle = new Triangle(0, 0, 0);
        });
    }
    
    [Test]
    public void CreateTriangleTest4()
    {
        Assert.Throws<InvalidOperationException>(() =>
        {
            var triangle = new Triangle(-21, 23, 12);
        });
    }

    [Test]
    public void IsRectangularTriangleTest1()
    {
        var triangle = new Triangle(6, 8, 10);
        Assert.AreEqual(triangle.IsRectangular, true);
    }
    
    [Test]
    public void IsRectangularTriangleTest2()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.AreEqual(triangle.IsRectangular, true);
    }
    
    [Test]
    public void IsRectangularTriangleTest3()
    {
        var triangle = new Triangle(9, 12, 15);
        Assert.AreEqual(triangle.IsRectangular, true);
    }
    
    [Test]
    public void IsNotRectangularTriangleTest1()
    {
        var triangle = new Triangle(19, 12, 15);
        Assert.AreEqual(triangle.IsRectangular, false);
    }
    
    [Test]
    public void IsNotRectangularTriangleTest2()
    {
        var triangle = new Triangle(11, 14, 23);
        Assert.AreEqual(triangle.IsRectangular, false);
    }
    
    [Test]
    public void IsNotRectangularTriangleTest3()
    {
        var triangle = new Triangle(14, 16, 21);
        Assert.AreEqual(triangle.IsRectangular, false);
    }
}