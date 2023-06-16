using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square shape1 = new Square("yellow", 5);
        shapes.Add(shape1);

        Rectangle shape2 = new Rectangle("blue", 3, 5);
        shapes.Add(shape2);

        Circle shape3 = new Circle("red", 7);
        shapes.Add(shape3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }

    }
}