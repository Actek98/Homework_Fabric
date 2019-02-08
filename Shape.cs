using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Shape
{
    interface IDrawable
    {
        void Draw();
    }

    abstract class Shape : IDrawable
    {
        protected int _x;
        protected int _y;
        protected int _width;
        protected int _height;

        public abstract void Draw();
    }

    class Rectangle : Shape
    {
        public Rectangle(int x, int y, int height, int width)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
        }

        public override void Draw()
        {
            Console.WriteLine($"Я прямоугольник. С координатами ({_x},{_y}) - ({_x + _width},{_y + _height})");
        }
    }

    class Triangle : Shape
    {
        public Triangle(int x, int y, int width, int height)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
        }

        public override void Draw()
        {
            Console.WriteLine($"Я треугольник. С координатами ({_x},{_y}) - ({_x + _width},{_y + _height})");
        }
    }

    class Circle : Shape
    {
        public Circle(int x, int y, int width)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = width;
        }

        public override void Draw()
        {
            Console.WriteLine($"Я круг. С координатами ({_x},{_y}) - ({_x + _width},{_y + _width})");
        }
    }
}
