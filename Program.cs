// See https://aka.ms/new-console-template for more information
using CSharpShape.Models.Forms;
using CSharpShape.Models;
using System.Data.SqlTypes;

class Program
{
    static void Main(string[] args)
    {
        Triangle triangle = new Triangle();
        triangle.Width = 10;
        triangle.Height = 11;

        Circle circle = new Circle();
        circle.Radius = 12;

        Square square = new Square();
        square.Width = 14;

        Rectangle rectangle = new Rectangle();
        rectangle.Width = 12;
        rectangle.Height = 14;

        Shape[] Forms = { square, circle, triangle, rectangle };
        AreaCalculator areaCalculator = new AreaCalculator();
        areaCalculator.TotalArea(Forms);

        Console.WriteLine(areaCalculator.TotalArea(Forms));
    }

}
