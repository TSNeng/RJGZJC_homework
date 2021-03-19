using System;
using System.Collections.Generic;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Generator generator = new Generator();
            List<string> geomes = new List<string>() { "Rectangle", "Triangle", "Square" };
            List<Geome>shapes = new List<Geome>();
            double sum = 0;
            for (int a = 0; a < 10; a++) 
            {
                //Geome shape;
                Random rm = new Random();
                int i = rm.Next(geomes.Count);
                switch (i)
                {
                    case 0:
                        shapes.Add(generator.Generate("Rectangle", 3, 4));
                        sum += shapes[shapes.Count - 1].Getarea();
                        break;
                    case 1:
                        shapes.Add(generator.Generate("Triangle", 4, 3, 3));
                        sum += shapes[shapes.Count - 1].Getarea();
                        break;
                    case 2:
                        shapes.Add(generator.Generate("Square", 4));
                        sum += shapes[shapes.Count - 1].Getarea();
                        break;
                }  
            }
            Console.WriteLine(sum);
        }
    }
 
    class Rectangle:Geome
    {
        public double width;
        public double length;
        public Rectangle(double width, double length)
        {
            if (width <= 0 || length <= 0) 
            { throw new ArgumentException("长或宽必须大于0"); }
            else
            {
                this.width = width;
                this.length = length;
            }
        }
       
        public override double Getarea()
        {
            return width * length;
        }
        public override double Getperimeter()
        {
            return 2 * (width + length);
        }
    }

    class Triangle:Geome
    {
        public double side1;
        public double side2;
        public double side3;

        public Triangle(double side1, double side2, double side3)
        {
            if(side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
            {
                throw new ArgumentException("任意两条边需大于第三条边");
            }
            else
            {
                this.side1 = side1;
                this.side2 = side2;
                this.side3 = side3;
            }
        }
        public override double Getarea()
        {
            return 0.25 * Math.Sqrt((side1 + side2 + side3) * (side1 + side2 - side3) * (side1 + side3 - side2) * (side2 + side3 - side1));
        }
        public override double Getperimeter()
        {
            return side1 + side2 + side3;
        }
    }

    class Square:Geome
    {
        public double side;

        public Square(double side)
        {
            if (side <= 0)
            {
                throw new ArgumentException("边长需大于0");
            }
            this.side = side;
        }

        public override double Getarea()
        {
            return side * side;
        }

        public override double Getperimeter()
        {
            return side * 4;
        }
    }

     public abstract class Geome
    {
        public abstract double Getarea();
        public abstract double Getperimeter();
    }

    public class Generator
    {
        public Geome Generate(string gemoeType, double side1 = 0, double side2 = 0, double side3 = 0)
        {
            if (gemoeType == "Rectangle")
            {
                return new Rectangle(width: side1, length: side2);
            }
            else if (gemoeType == "Triangle")
            {
                return new Triangle(side1, side2, side3);
            }
            else if (gemoeType == "Square") {
                return new Square(side1);
            }
            else return null;
        }
    }
}
