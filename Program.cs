using System.Reflection;

namespace Inheritance_prog
{
    internal class Program
    {
        static notification lobjnotificationservice = new Email();
        static void Main(string[] args)
        {
            // person lobjp = new student();
            // lobjp.show();

            //person lobjb = new outofstudent();
            //lobjb.show();
             
            //code to register user
            lobjnotificationservice.sendnotification();    //notification of reg

            //code for updating user details
            lobjnotificationservice.sendnotification();    //notification of update

          
            Console.ReadLine();
           
        }
    }
}
