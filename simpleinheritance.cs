using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_prog
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a sound");
        }

        public void Drink()
        {
            Console.WriteLine("The animal drinks water");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The dog barks");
        }

        // Hiding the base method (implicitly using 'new' keyword)
        public void Drink()
        {
            Console.WriteLine("The dog drinks from a bowl");
        }
    }
}
