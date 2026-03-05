using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance_prog
{
    public abstract class message
    {
        virtual public void sendmessage()
        {
            Console.WriteLine("test notification ");
            Console.WriteLine("This is base class method and does not send any notification ");
        }
        public abstract void checkifreceived();
    }
    public class Email2 : message
    {
        public override void sendmessage()
        {
            Console.WriteLine("sending email");
            Console.WriteLine("Email sent ");
        }
        public override void checkifreceived()   //this is compulsary to ovverride abstract method 
        {
           Console.WriteLine("email is received :");
        }
    }
    public class sms2 : message
    {
        override public void sendmessage()
        {
            Console.WriteLine("sending SMS");
            Console.WriteLine("SMS sent");
        }
        public override void checkifreceived()
        {
            Console.WriteLine("Sms is received :");
        }
    }
}
