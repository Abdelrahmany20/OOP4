using OOP4.Interfaces;
using OOP4.Interfaces.Classes;

namespace OOP4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 2

            #region Q01

            Circle circle =new Circle(10);

            circle.DisplayShapeInfo();


            IRectangle rectangle = new Rectangle(5, 20);
            rectangle.DisplayShapeInfo();
            #endregion


            #endregion
        }
    }
}
