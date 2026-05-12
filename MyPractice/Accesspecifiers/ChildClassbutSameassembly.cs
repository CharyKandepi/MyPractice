using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractice.Accesspecifiers
{
    internal class ChildClassbutSameassembly:ExampleOf_Modifiers
    {

        public void Sample2()
        {
            ChildClassbutSameassembly childClassbutSameassembly = new ChildClassbutSameassembly();

            childClassbutSameassembly.Test1_Public();
            childClassbutSameassembly.Test2_Internal();
            childClassbutSameassembly.Test4_protected();


            //ExampleOf_Modifiers exampleOf_Modifiers = new ExampleOf_Modifiers();

        }

    }
}
