using BYT_task3;

IShape sphere = new Sphere(5);
Console.WriteLine("Sphere:");
Console.WriteLine($"Area: {sphere.CalculateArea():F3}");
Console.WriteLine($"Volume: {sphere.CalculateVolume():F3}");
Console.WriteLine();

IShape cylinder = new Cylinder(3, 7);
Console.WriteLine("Cylinder:");
Console.WriteLine($"Area: {cylinder.CalculateArea():F3}");
Console.WriteLine($"Volume: {cylinder.CalculateVolume():F3}");
Console.WriteLine();

IShape rectangle = new Rectangle(4, 8);
Console.WriteLine("Rectangle:");
Console.WriteLine($"Area: {rectangle.CalculateArea():F3}");
Console.WriteLine($"Volume: {rectangle.CalculateVolume():F3}");
Console.WriteLine();

IShape cube = new Cube(4);
Console.WriteLine("Cube:");
Console.WriteLine($"Area: {cube.CalculateArea():F3}");
Console.WriteLine($"Volume: {cube.CalculateVolume():F3}");
Console.WriteLine();




namespace BYT_task3
{
    public interface IShape
    {
        double CalculateArea();

        double CalculateVolume();
    }
}

namespace BYT_task3
{
    public class Cube(double side) : IShape
    {
        private readonly double _side = side;

        public double CalculateArea()
        {
            return 6 * Math.Pow(_side, 2);
        }

        public double CalculateVolume()
        {
            return Math.Pow(_side, 3);
        }
    }
}

namespace BYT_task3
{
    public class Rectangle(double length, double width) : IShape
    {   
        private readonly double _length = length;
        
        private readonly double _width = width;
        
        public double CalculateArea()
        {
            return _length * _width;
        }

        public double CalculateVolume()
        {
            return 0;
        }
    }
}

namespace BYT_task3
{
    public class Cylinder(double radius, double height) : IShape
    {
        private readonly double _radius = radius;
        
        private readonly double _height = height;

        public double CalculateArea()
        {
            return 2 * Math.PI * _radius * (_radius * _height);
        }

        public double CalculateVolume()
        {
            return Math.PI * Math.Pow(_radius, 2) * _height;
        }
    }
}

namespace BYT_task3
{
    public class Sphere(double radius) : IShape
    {
        private readonly double _radius = radius;

        public double CalculateArea()
        {
            return 4 * Math.PI * Math.Pow(_radius, 2);
        }

        public double CalculateVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(_radius, 3);
        }
    }
}