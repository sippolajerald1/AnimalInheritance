

    using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace AnimalInheritance
{

    // base Class 
    using System;

    class Animal
    {
        private string name; // only accessible within this class
        protected string type; //accessible from derived classes
        public string color;  // accessible from any class

        public void setName(string name)
        {
            this.name = name;
        }
        public virtual string getName()
        {
            return this.name;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public virtual string getType()
        {
            return this.type;
        }
    }

    // derived class
    class Pets : Animal
    {
        public string tail;
        protected string kind;
        public string size;

        /* public pets()
         {

             tail = string.Empty;
             kind = string.Empty;
             size = string.Empty;
         }

         public pets(string tail, string kind, string size)
         {

             this.tail = tail;
             this.kind = kind;
             this.size = size;
         }
        */

        public void setKind(string kind)
        {
            this.kind = kind;
        }

        public virtual string getKind()
        {
            return kind;
        }


        // access name through base because it is private
        public override string getName()
        {
            return base.getName();
        }

        // access type directly because it is protected  and this is a derived class

        public override string getType()
        {
            return type;

        }

        public virtual string noise()
        {
            return "squeak";
        }



    }

    class Program
    {

        static void Main(string[] args)
        {
            // object of the base class Animal
            Animal small = new Animal();
            small.setName("Reggie");
            small.setType("squirrel");
            // color is a public field and can be accessed anywhere
            small.color = "grey";

            Console.WriteLine("Animal Information... ");
            Console.WriteLine($"My name is {small.getName()}");
            Console.WriteLine($"I am a {small.getType()}");
            Console.WriteLine($"I am a lovely {small.color} color");
            Console.WriteLine();

            // object of derived class pets

            Pets rabbit = new Pets();
            rabbit.setName("Fluffy");
            rabbit.setType("bunny");
            rabbit.setKind("tame");
            rabbit.size = ("large");


            // color is a public field and can be accessed anywhere
            rabbit.color = "white";
            // breed is a public field
            rabbit.tail = "short";
            // age is protected field


            Console.WriteLine("Pets Information... ");
            Console.WriteLine($"My name is {rabbit.getName()}");
            Console.WriteLine($"I am a {rabbit.tail} {rabbit.getType()}");
            Console.WriteLine($"I am a lovely {rabbit.color} color");
            Console.WriteLine($"I am {rabbit.getKind()}");
            Console.WriteLine($"I am {rabbit.size}");
            Console.WriteLine($"I like to {rabbit.noise()}");

            Console.ReadLine(); // pauses end of program display






        }

    }
}
