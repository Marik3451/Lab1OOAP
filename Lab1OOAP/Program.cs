using System;
using System.Collections.Generic;

public class Rectangle
{
    public int X { get; }
    public int Y { get; }
    public int Width { get; }
    public int Height { get; }

    public Rectangle(int x, int y, int width, int height)
    {
        X = x;
        Y = y;
        Width = width;
        Height = height;
    }
}
public class RectangleSystem
{
    private List<Rectangle> rectangles = new List<Rectangle>();

    public RectangleSystem AddRectangle(int x, int y, int width, int height)
    {
        var newRectangle = new Rectangle(x, y, width, height);
        var newRectangles = new List<Rectangle>(rectangles) { newRectangle };
        return new RectangleSystem { rectangles = newRectangles };
    }
    public void DrawRectangles()
    {
        foreach (var rectangle in rectangles)
        {
            Console.WriteLine($"Rectangle: X={rectangle.X}, Y={rectangle.Y}, Width={rectangle.Width}, Height={rectangle.Height}");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        var rectangleSystem = new RectangleSystem();

        rectangleSystem = rectangleSystem.AddRectangle(10, 10, 50, 30);
        rectangleSystem = rectangleSystem.AddRectangle(30, 50, 70, 40);
        rectangleSystem = rectangleSystem.AddRectangle(20, 80, 60, 20);

        rectangleSystem.DrawRectangles();
    }
}
