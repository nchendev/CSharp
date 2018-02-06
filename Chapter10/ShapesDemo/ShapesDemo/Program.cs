using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
///-----------------------------------------------------------------
///   Author:  Nick Chen                    Date: March 9, 2017
///   Purpose: Program that finds the area of input based on its 
///            shape
///-----------------------------------------------------------------
namespace ShapesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("--Rectangle--");
            Rectangle shape1 = new Rectangle();
            WriteLine("--Square--");
            Square shape2 = new Square();
            WriteLine("--Triangle--");
            Triangle shape3 = new Triangle();
            ReadLine();
        }
    }
    abstract class GeometricFigure
    {
        public double height;
        public double width;
        public  double area;
        abstract public double ComputeArea(double height, double width);
        public GeometricFigure()
        {
            WriteLine("What is the height?");
            height = double.Parse(ReadLine());
            WriteLine("What is the width?");
            width = double.Parse(ReadLine()); 
        }
    }
    class Rectangle:GeometricFigure
    {
        public Rectangle()
        {
            area = ComputeArea(height, width);
            WriteLine("Area: " + area);
        }
        public override double ComputeArea(double height, double width)
        {
            return height * width;
        }
    }
    class Square : GeometricFigure
    {
        public Square()
        {
            while (width != height)
            {
                WriteLine("Width and height is not the same; please try again");
                WriteLine("Width: ");
                width = double.Parse(ReadLine());
                WriteLine("Height: ");
                height = double.Parse(ReadLine());
            }
            area = ComputeArea(height, width);
            WriteLine("Area: " + area);
        }
        public override double ComputeArea(double height, double width)
        {
            return height * width;
        }
    }
    class Triangle : GeometricFigure
    {
        public Triangle()
        {
            area = ComputeArea(height, width);
            WriteLine("Area: " + area);
        }
        public override double ComputeArea(double height, double width)
        {
            return .5 * height * width;
        }
    }
}
