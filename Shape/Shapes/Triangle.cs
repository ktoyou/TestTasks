namespace Shape.Shapes;

public sealed class Triangle : IShape
{
    public bool IsRectangular
    {
        get
        {
            if (_a > _b && _a > _c)
                return Math.Pow(_c, 2) + Math.Pow(_b, 2) == Math.Pow(_a, 2);
                
            if (_b > _a && _b > _c) 
                return Math.Pow(_c, 2) + Math.Pow(_a, 2) == Math.Pow(_b, 2);
            
            if (_c > _a && _c > _b) 
                return Math.Pow(_b, 2) + Math.Pow(_a, 2) == Math.Pow(_c, 2);

            return false;
        }
    }

    private readonly float _a;

    private readonly float _b;

    private readonly float _c;

    public Triangle(float a, float b, float c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            throw new InvalidOperationException("The sides of the triangle cannot be less than 0 or equal to 0");

        if (a > b + c || b > a + c || c > b + a)
            throw new InvalidOperationException("The triangle does not exist");

        _a = a;
        _b = b;
        _c = c;
    }
    
    public double Square()
    {
        var p = (_a + _b + _c) / 2;
        var s = Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        return s;
    }
}