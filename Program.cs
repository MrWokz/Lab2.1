using System;

public class Rectangle
{
    private double _side1;
    private double _side2;

    // Конструктор класу
    public Rectangle(double side1, double side2)
    {
        _side1 = side1;
        _side2 = side2;
    }

    // Метод для обчислення площі
    public double CalculateArea()
    {
        return _side1 * _side2;
    }

    // Метод для обчислення периметра
    public double CalculatePerimeter()
    {
        return 2 * (_side1 + _side2);
    }

    // Властивість для отримання площі
    public double Area
    {
        get { return CalculateArea(); }
    }

    // Властивість для отримання периметра
    public double Perimeter
    {
        get { return CalculatePerimeter(); }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the length of side 1: ");
        double side1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the length of side 2: ");
        double side2 = double.Parse(Console.ReadLine());

        // Створення екземпляру класу Rectangle
        Rectangle rectangle = new Rectangle(side1, side2);

        // Виведення результатів
        Console.WriteLine($"Area of the rectangle: {rectangle.Area}");
        Console.WriteLine($"Perimeter of the rectangle: {rectangle.Perimeter}");
    }
}
