using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_prog
{
    public  class notification
    {
         virtual public void sendnotification()
        {
            Console.WriteLine("test notification ");
            Console.WriteLine("This is base class method and does not send any notification ");
        }
    }

    public class Email : notification
    {
        public override void sendnotification()
        {
            Console.WriteLine("sending email");
            Console.WriteLine("Email sent ");
        }
    }
    public class sms : notification
    {
        override public  void sendnotification()
        {
            Console.WriteLine("sending SMS");
            Console.WriteLine("SMS sent");
        }
    }
    public class telegram : notification
    {
        override public void sendnotification()
        {
            Console.WriteLine("sending telegram");
            Console.WriteLine("telegram sent");
        }
    }
}
