using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractice.Inheritence
{

    internal class Parent
    {

        public void Method1()
        { 
        
        }
        public static void Method2()
        {

        }
        public int MyPhone { get; set; }
    }
    internal class Child1:Parent
    {

        public static void Main()
        {
            Child1.Method2 ();

            Child1 child1 = new Child1();
            child1.Method1 ();
            child1.MyPhone = 1;

        }

    }
    internal class Child2: Parent //: Parent, Child1
    {

        public static void Main()
        {
            Child2 child2 = new Child2();
            child2.Method1 ();
        }
    }


}
