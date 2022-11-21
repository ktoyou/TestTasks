namespace Shape.Shapes;

public sealed class Circle : IShape
{
    private readonly double _radius;
    
    public Circle(double radius)
    {
        if(radius <= 0) 
            throw new InvalidOperationException("The radius cannot be less than 0 or equal to 0");
        
        _radius = radius;
    }

    public double Square() => Math.PI * Math.Pow(_radius, 2);
}