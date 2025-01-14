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

            //Circle circle =new Circle(10);

            //circle.DisplayShapeInfo();


            //IRectangle rectangle = new Rectangle(5, 20);
            //rectangle.DisplayShapeInfo();
            #endregion


            #region Q02

            BasicAuthenticationService service = new BasicAuthenticationService();

            Console.WriteLine("Enter username:");
            string username = Console.ReadLine();

            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();

            bool Authenticated= service.AuthenticateUser(username,password);
            if (Authenticated)
            {
                Console.WriteLine("welcome");


            }
            else
            {
                Console.WriteLine("faild AuthenticateUser");
                return;
            }





            Console.WriteLine("Enter role:");
            string role = Console.ReadLine();

            bool Authorized = service.AuthorizeUser(username,role);
            if (Authorized)
            {
                Console.WriteLine("welcome");
            }
            else
            {
                Console.WriteLine("faild AuthorizeUser");
            }

            #endregion


                #endregion
        }
    }
}
