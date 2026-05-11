using MyPractice.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractice
{
    internal class Akhila
    {
        public void Ramu()
        {

        }
        public string Ramu(int a)
        {
            return  "ABC";
        }

        public string Ramu(string Firstname)
        {
            return Firstname;
        }
        public long Ramu(long Phone)
        {
            return Phone;
        }
        public  object  Ramu(long Phone, string Firstname)
        {
            return Phone + Firstname;
        }
        public object Ramu( string Firstname, long Phone)
        {
            return Phone + Firstname;
        }
        public string Ramu(int Phone, String Firstname)
        {
            return Phone + Firstname;
        }

        public static void Main()
        {
            //Akhila obj = new Akhila();
            //obj.Ramu();
            //obj.Ramu(3567788, "XYZ");

            //Akhila.Ramu(2434634567, "ABC");

            Soumya soumyaObj = new Soumya();
            soumyaObj.Raju();
            soumyaObj.Ramesh();

        }


    }
}
