using System;

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle("blue", 2, 4);
        Square square = new Square("red", 3);
        Circle circle = new Circle("yellow", 2);

        List<Shape> shapes = new List<Shape>();

        shapes.Add(rectangle);
        shapes.Add(circle);
        shapes.Add(square);

        foreach(Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
            Console.WriteLine();
        }
        
    }
}