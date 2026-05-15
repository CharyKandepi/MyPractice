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

            #region

            ExampleofProperties exampleofProperties = new ExampleofProperties();

            //exampleofProperties.CollageName = "ANRCollage";      //Set or Write

            //var data=exampleofProperties.CollageName; //get // Read



            //exampleofProperties.CollageName("ANRCollage",1458);


            // exampleofProperties.CollageName = "ANRCollage";

            //  var data=exampleofProperties.CollageName;
            //Console.WriteLine(data);
            #endregion


            ProperiesExample properiesExample = new ProperiesExample(101,"Ramu","UK");

            Console.WriteLine(properiesExample.StdId);//101
            Console.WriteLine(properiesExample.StdName); //Ramu
            Console.WriteLine(properiesExample.StdPhone);//0
            Console.WriteLine(properiesExample.Country); //UK
            Console.WriteLine(properiesExample.StdGender);//Other


            Console.ReadLine();
              




            Console.ReadLine();

        }
    }
}
