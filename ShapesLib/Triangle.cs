namespace ShapesLib; 

public class Triangle : IShape
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            throw new ArgumentException("Стороны треугольника должны быть положительными числами.");
        
        if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            throw new ArgumentException("С указанными сторонами нельзя построить треугольник.");

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public double GetArea()
    {
        double semiPerimeter = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
    }
    
    public bool IsRightAngled()
    {
        var sides = new[] { SideA, SideB, SideC }.OrderBy(s => s).ToArray();
        return Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) < 1e-10;
    }
}