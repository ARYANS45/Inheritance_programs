using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance_prog
{
     public interface I1
     {
        public void show();
     }
    public interface I2
    {
        public void show();
    }
    public class Testinterface : I1, I2
    {
        public void show()
        {
            Console.WriteLine("Inside show method of Testinterface class "); //Common method for I1,I2  
        }

        void I1.show()
        {
            Console.WriteLine("Inside show method of I1 interface implementation ");
        }
        void I2.show()
        {
            Console.WriteLine("Inside show method of I2 interface implementation ");
        }
    }

    public interface Icar
    {
         public void DriveonRoad();
    }
    public interface Ifly
    {
       public void fly(); 
    }
    public class flyingcar : Icar, Ifly
    {
       public void DriveonRoad()
       {
          Console.WriteLine("Driving on Road ");
       }
       public void fly()
       {
          Console.WriteLine("Fly in the sky ");

       }
    }    
}
