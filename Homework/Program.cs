using System;

class Program
{
    static(double perimeter, double area) CalculateRectangle(double length, double width)
    {
        double perimeter = (length + width) * 2;
        double area = length * width;
        return (perimeter, area);
    }
    static(double perimeter, double area) CalculateSquare(double edge)
    {
        double perimeter = 4 * edge;
        double area = edge * edge;
        return (perimeter, area);
    }
    static(double perimeter, double area) CalculateTriangle(double edgeA, double edgeB, double edgeC)
    {
        double perimeter = edgeA + edgeB + edgeC;
        double semiPerimeter = perimeter / 2; 
        double area = Math.Sqrt(semiPerimeter * (semiPerimeter - edgeA) * (semiPerimeter - edgeB) * (semiPerimeter - edgeC)); 
        return (perimeter, area);
    }
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            try
            {
                Console.WriteLine("Choose the shape to calculate:");
                Console.WriteLine("1. Rectangle");
                Console.WriteLine("2. Square");
                Console.WriteLine("3. Triangle");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice (1-4): ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the length of the rectangle: ");
                        double length = double.Parse(Console.ReadLine());
                        Console.Write("Enter the width of the rectangle: ");
                        double width = double.Parse(Console.ReadLine());

                        var rectangle = CalculateRectangle(length, width);
                        Console.WriteLine($"Rectangle - Perimeter: {rectangle.perimeter}, Area: {rectangle.area}");
                        break;

                    case 2:
                        Console.Write("Enter the edge length of the square: ");
                        double edge = double.Parse(Console.ReadLine());

                        var square = CalculateSquare(edge);
                        Console.WriteLine($"Square - Perimeter: {square.perimeter}, Area: {square.area}");
                        break;

                    case 3:
                        Console.Write("Enter edge A of the triangle: ");
                        double edgeA = double.Parse(Console.ReadLine());
                        Console.Write("Enter edge B of the triangle: ");
                        double edgeB = double.Parse(Console.ReadLine());
                        Console.Write("Enter edge C of the triangle: ");
                        double edgeC = double.Parse(Console.ReadLine());

                        var triangle = CalculateTriangle(edgeA, edgeB, edgeC);
                        Console.WriteLine($"Triangle - Perimeter: {triangle.perimeter}, Area: {triangle.area}");
                        break;

                    case 4:
                        running = false;
                        Console.WriteLine("Exiting the program.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select again.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Please enter a number.");
            }
            Console.ReadLine(); 
        }
    }
}
