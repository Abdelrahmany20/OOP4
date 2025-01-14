using OOP4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4.Classes
{
    internal class Rectangle : IRectangle
    {
        //public int Area { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        double Length { get; set; }
        double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }


        double IShape.Area { get; set; }
        public double Area => Length * Width;
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Length = {Length}, Width = {Width}, Area = {Area:F2}");
        }
    }
}
