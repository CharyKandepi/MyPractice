using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractice.property
{
    internal class CallingProperties
    {

        public static void Main()
        { 
           
           ExampleofProperties exampleofProperties = new ExampleofProperties();

            //exampleofProperties.CollageName = "ANRCollage";      //Set or Write

            //var data=exampleofProperties.CollageName; //get // Read



            //exampleofProperties.CollageName("ANRCollage",1458);


           // exampleofProperties.CollageName = "ANRCollage";

            var data=exampleofProperties.CollageName;
          Console.WriteLine(data);

            Console.ReadLine();

        }
    }
}
