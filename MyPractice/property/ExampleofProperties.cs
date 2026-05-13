using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractice.property
{
    internal class ExampleofProperties
    {
        string _CollageName ="MGRCollage";


        public string CollageName
        {
            get 
            { 
               return _CollageName;
            }

            set
            {
                if (value != null && value != string.Empty)
                {
                    _CollageName = value;
                }
            }

        }

        //public string CollageName(int pwd)                      //Get  // reading
        //{     if (pwd==123)
        //    { 
        //        return _CollageName;

        //    }
        //    return null;
        //}

        //public void CollageName(string CollageName, int? Password = null) //set // Writing
        //{
        //    if (Password == 1234)
        //    {
        //        _CollageName = CollageName;

        //    }
        //}


        public static void Main()
        {
            ExampleofProperties exampleofProperties = new ExampleofProperties();

           // exampleofProperties.CollageName("NTRCollage");



            Console.WriteLine(exampleofProperties._CollageName);

            Console.ReadLine();
        }



    }
}
