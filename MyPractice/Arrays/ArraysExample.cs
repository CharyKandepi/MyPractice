using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractice.Arrays
{
    internal class ArraysExample
    {


        public static void Main(string[] args)
        {
            int a;
                 a = 1;
            int AB = 10;

            //int[] Arryas = new int[3];

            //Arryas[0] = 55;
            //Arryas[1] = 50;

            //Arryas[2] = 70;

            //Console.WriteLine(Arryas);


            //Console.WriteLine(Arryas[0]);
            //Console.WriteLine(Arryas[1]);
            //Console.WriteLine(Arryas[2]);


            //int[] Arryas = { 55, 60, 67 };
            //Console.WriteLine(Arryas[0]);
            //Console.WriteLine(Arryas[1]);
            //Console.WriteLine(Arryas[2]);

            int[] Arryas = new int[4] { 67, 60, 77,50 };
            //int[] Arryas = new int[] { 67, 60, 77};

            //Console.WriteLine(Arryas[0]);
            //Console.WriteLine(Arryas[1]);
            //Console.WriteLine(Arryas[2]);


            foreach (var DATA in Arryas)
            {
                Console.WriteLine(DATA);
            
            }



            Console.ReadLine();

        }

    }
}
