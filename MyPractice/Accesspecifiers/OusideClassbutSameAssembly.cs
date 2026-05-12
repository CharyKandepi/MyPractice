using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractice.Accesspecifiers
{
    internal class OusideClassbutSameAssembly
    {
        public void Sample()
        {

            ExampleOf_Modifiers exampleOf_Modifiers = new ExampleOf_Modifiers();
            exampleOf_Modifiers.Test1_Public();
            exampleOf_Modifiers.Test2_Internal();
            exampleOf_Modifiers.Test5_protected_internal();
           
        }

    }
}
