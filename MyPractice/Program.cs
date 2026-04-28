using System;


namespace MyPractice
{
    internal class Program
    {
        static void Main()
        {
            object Obj_abc = 10;

            object Obj_abc1;
                   Obj_abc1 = 10;

          int Obj_abc2 =(int) Obj_abc; //error
        //  string Obj_abc3 = (string)Obj_abc;  //error in run time

            string Obj_abc3 = Convert.ToString(Obj_abc);


            var Var_abc = 10;

                Var_abc = 25;

              // Var_abc = "ABC"; //error

        //var Var_Obj1; // error


        dynamic dynamic_Abc = 10;

            string vaue = Convert.ToString(dynamic_Abc);
            dynamic_Abc = 99;
            bool vaue2= Convert.ToBoolean(dynamic_Abc);

            dynamic x =890;
            int y = x;

            dynamic dynamic2_ABC;
                    dynamic2_ABC=10;

        }
    }
}
