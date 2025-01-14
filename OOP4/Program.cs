using OOP4.Interfaces;
using OOP4.Classes;

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

            //BasicAuthenticationService service = new BasicAuthenticationService();

            //Console.WriteLine("Enter username:");
            //string username = Console.ReadLine();

            //Console.WriteLine("Enter password:");
            //string password = Console.ReadLine();

            //bool Authenticated= service.AuthenticateUser(username,password);
            //if (Authenticated)
            //{
            //Console.WriteLine("welcome");


            //}
            //else
            //{
            //Console.WriteLine("faild AuthenticateUser");
            //return;
            //}





            //Console.WriteLine("Enter role:");
            //string role = Console.ReadLine();

            //bool Authorized = service.AuthorizeUser(username,role);
            //if (Authorized)
            //{
            //Console.WriteLine("welcome");
            //}
            //else
            //{
            //Console.WriteLine("faild AuthorizeUser");
            //}

            #endregion


            #region Q03




            EmailNotificationService emailServices = new EmailNotificationService();
            emailServices.SendNotification ("Abdelrahman", "How R U ?");



            //INotificationService emailService = new EmailNotificationService();

            //emailService.SendNotification("Abdelrahman", "How R U ?");



            SmsNotificationService smsServices = new SmsNotificationService();

            smsServices.SendNotification("Abdelrahman", "hello,how R U ?");



            PushNotificationService pushServices = new PushNotificationService();
            pushServices.SendNotification("Abdelrahman", "hello,how R U ?");
















            #endregion




            #region Part 1

           /*
         
            1-b
            2-a
            3-b (contract)
            4-b
            5-d
            6-a (C# 8)
            7-b
            8-c
            9b
            10-c
         


            */  
            #endregion
            #endregion






        }
    }
}
