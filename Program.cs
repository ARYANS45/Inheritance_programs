using System.Reflection;

namespace Inheritance_prog
{
    internal class Program
    {
       static notification lobjnotificationservice = new Email();
        static message lobjmessageservice = new sms2();
  
        static void Main(string[] args)
        {
             useofinheritance1();

             notification1();

             useofabstract1();

             is_as();

             useofinterface1();

             simpinheritance();
            
             Console.ReadLine();
         }

        public static void useofinheritance1()
        {
            person lobjp = new student();
            lobjp.show();

            person lobjb = new outofstudent();
            lobjb.show();
        }
        public static void notification1()
        {
            //code to register user
            lobjnotificationservice.sendnotification();    //notification of reg

            //code for updating user details
            lobjnotificationservice.sendnotification();    //notification of update
            
            if (lobjnotificationservice is Email)
            {
                Email lobjemail = lobjnotificationservice as Email;
                lobjemail.Recall();
            }
        }
        public static void useofabstract1()
        {
            lobjmessageservice.sendmessage();
            lobjmessageservice.checkifreceived();
            lobjmessageservice.sendmessage();
        }

        public static void is_as()
        {
            person lobjs = new student();
            if (lobjs is person)
            {
                Console.WriteLine("student is person.");
            }
            else
            {
                Console.WriteLine("student is not person.");
            }
            if (lobjs is outofstudent)
            {
                Console.WriteLine("student is outofstudent.");
            }
            else
            {
                Console.WriteLine("student is not outofstudent.");
            }

            person lobjos = new outofstudent();
            (lobjos as outofstudent).istrcollegename = "";

            // (lobjos as outofstudent).print();
            //((outofstudent)lobjs).istrcollegename = "";
        }
        public static void useofinterface1()
        {
            Testinterface lobjT = new Testinterface();
           
            (lobjT as I1).show();

            ((I2)lobjT).show();

            I2 lobjT2 = new Testinterface();
            lobjT2.show();

            flyingcar lobjfc = new flyingcar();    
          //  Ifly lobjfly = lobjfc;
          //  lobjfly.fly();
            lobjfc.DriveonRoad();
            lobjfc.fly();
        }

        public static void simpinheritance()
        {
            Animal myAnimal = new Animal();
            Animal myDog = new Dog();
            Dog specificDog = new Dog();

            myAnimal.MakeSound();
            myDog.MakeSound();
            specificDog.MakeSound();

            myAnimal.Drink();
            myDog.Drink();
            specificDog.Drink();
        }
    }
}

