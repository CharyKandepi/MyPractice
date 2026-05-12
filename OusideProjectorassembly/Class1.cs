
using MyPractice.Accesspecifiers;

namespace OusideProjectorassembly
{
    public class OutsideassemblyClass: ExampleOf_Modifiers
    {

        public void sample3()
        { 
           ExampleOf_Modifiers exampleOf_Modifiers = new ExampleOf_Modifiers();

            exampleOf_Modifiers.Test1_Public();
            
            OutsideassemblyClass outsideassemblyClass = new OutsideassemblyClass();

            outsideassemblyClass.Test1_Public();

            outsideassemblyClass.Test4_protected();

            outsideassemblyClass.Test5_protected_internal();
           

        }

    }
}
