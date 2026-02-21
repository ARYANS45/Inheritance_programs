using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Inheritance_prog
{
    public class person
    {
        private DateTime idob;

        protected string istrgender;

        internal int iintmobile;

        public string istrfirstname;
        public string istrlastname;
        public string istremail;
        
        virtual public void show()
        {
            Console.WriteLine("i am inside of show method of class person");
        }
        
    }

    public class student : person
    {
       public override void show()
        {
            Console.WriteLine("i am inside of show method of class student");
                       
        }
    }

    public class outofstudent : student
    {
        public override void show()
        {
            Console.WriteLine("i am inside of show method of class outofstudent ");
        }
    }



}
