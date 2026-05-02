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

    public class Raju 
    {
        static Raju()
        {
            Console.WriteLine("I will execute first ");
        }
        public Raju(int a)
        { 
           this.b = a;
            Raju.a = a;
        }

        public Raju(string a)
        {

        }

        public Raju(string b,int a)
        {

        }

        public Raju(int b, string a)
        {

        }

        public Raju(long b, string a)
        {
            this.b = (int)b;
            Raju.a = 50;
        }

        public Raju(bool b, string a)
        {
            this.b = 30;
            Raju.a = 45;
        }
        public static int a = 10;
        public int b=20;
        public static string MyName { get; set; }
        public  long MyPhone { get; set; }
        public static void Main()
        {

            Raju raju = new Raju(true, "NAME");
            raju.add();


            Raju raju2 = new Raju(10,"Ramesh");
            raju2.add();

            Raju raju3 = new Raju(8);
            raju3.add();

            //Raju raju = new Raju("RAmu"); // you should satisfy the Constructor of paramater

            //Raju raju1 = new Raju(2099000099, "Raju");


            //int c = a + raju.b;
            //raju.add();
            //Console.WriteLine(c);
            //Ramu.Add();


            Console.ReadLine();
        }

        public void add()
        {
          int c=  a + b;
           Console.WriteLine(c);

        }

    }

}
