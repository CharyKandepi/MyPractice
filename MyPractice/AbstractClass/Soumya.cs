using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractice.AbstractClass
{
    internal class Soumya : RajKumar
    {
        public override void Raju()
        {
            Console.WriteLine("I am Fine , I am Raju method from Soumya Class");
        }

        public override void Ramesh()
        {
            Console.WriteLine("I am Remplemented Virtualmethod (Ramesh) method in Child  Class of abtract class");
        }



    }
}
