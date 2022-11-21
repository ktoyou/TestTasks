using Shape;
using Shape.Shapes;

namespace ShapesTests;

public class CircleTests
{
    [Test]
    public void SquareTest1()
    {
        var shape = new Circle(5);
        Assert.AreEqual(shape.Square(), 78.5398, 0.1);
    }
    
    [Test]
    public void SquareTest2()
    {
        var shape = new Circle(12);
        Assert.AreEqual(shape.Square(), 452.3893, 0.1);
    }
    
    [Test]
    public void SquareTest3()
    {
        var shape = new Circle(1);
        Assert.AreEqual(shape.Square(), 3.1415, 0.1);
    }
    
    [Test]
    public void CreateCircleTest1()
    {
        Assert.Throws<InvalidOperationException>(() =>
        {
            var circle = new Circle(0);
        });
    }
    
    [Test]
    public void CreateCircleTest2()
    {
        Assert.Throws<InvalidOperationException>(() =>
        {
            var circle = new Circle(-1);
        });
    }
}