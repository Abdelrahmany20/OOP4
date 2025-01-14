using OOP4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4.Classes
{
    internal class Circle : ICircle
    {
        public int Radius { get; set; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public double Area => Math.PI * Radius * Radius;

        double IShape.Area { get; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Radius = {Radius}, Area = {Area}");
        }

        void IShape.DisplayShapeInfo()
        {
            throw new NotImplementedException();
        }
    }
}

