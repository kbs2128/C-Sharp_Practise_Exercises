﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A = System.Console;

namespace Polymorphism
{
    class Shape
    {
        public virtual void Draw()
        {
            A.WriteLine("Base class draw method");
        }
    }
    class Triangle : Shape
    {
        public override void Draw()
        {
            A.WriteLine("drawing a circle");
        }
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            A.WriteLine("drawing a rectangle");
        }
    }
    class Square : Shape
    {
        public override void Draw()
        {
            A.WriteLine("drawing a square");
        }
    }
    class Circle : Shape
    {
        public override void Draw()
        {
            A.WriteLine("drawing a circle");
        }
    }
    class program
    {
        public static void Main(String[] args)
        {
            int ui;
            Shape s = null;
            do
            {
                A.WriteLine("Menu\n");
                A.WriteLine("1.Rectangle\n" + "2.Circle\n" + "3.Square\n" + "4.Triangle\n");
                A.WriteLine("Enter the inpute\n");
                ui = Convert.ToInt32(A.ReadLine());
                switch (ui)
                {
                    case 1:
                        s = new Rectangle();
                        break;
                    case 2:
                        s = new Circle();
                        break;
                    case 3:
                        s = new Square();
                        break;
                    case 4:
                        s = new Triangle();
                        break;
                    default:
                        A.WriteLine("Invalid input");
                        Environment.Exit(0);
                        break;

                }
                s.Draw();
            } while (ui >= 1 && ui <= 5);

            /* var drawobjects = new List<Shape>
             {
                 new Triangle(),
                 new Rectangle(),
                 new Circle(),
                 new Square()
             };
             foreach(Shape s in drawobjects)
             {
                 s.Draw();
             }*/
        }
    }
}
