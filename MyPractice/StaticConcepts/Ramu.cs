using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractice.StaticConcepts
{
    public static class Ramu
    {

          static Ramu()
        {
            Console.WriteLine("I am Static Constructor");
        }

        public static void Add()
        {
            c = a + b;
            Console.WriteLine(c);
            Console.ReadLine();
        }

        public static int MyName {get;set;}

        static string Name="Raju";

        static int a = 10;
        static int b = 20;
        static int c;
        // c=a+b; // opration (Opration not possiable out side method)


        public static void Main()  // execution entry point
        {
            Console.WriteLine("I am static Void Method");

           // Ramu ramu = new Ramu();

            Add();

        }

    }

    public static class Raju
    {

        public static void Main()
        {
            Ramu.Add();
        }

    }

}
