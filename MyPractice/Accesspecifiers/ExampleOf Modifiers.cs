using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractice.Accesspecifiers
{
    public class ExampleOf_Modifiers
    {
        public void Test1_Public()
        { 
        
        }

         internal void Test2_Internal()
        {

        }
        private void Test3_private()
        {

        }
        protected void Test4_protected()
        {

        }


        public static void Main()
        {

            ExampleOf_Modifiers exampleOf_Modifiers = new ExampleOf_Modifiers();

            exampleOf_Modifiers.Test1_Public();
            exampleOf_Modifiers.Test2_Internal();
            exampleOf_Modifiers.Test3_private();
            exampleOf_Modifiers.Test4_protected();

        }


    }
}
