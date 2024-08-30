using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var_dynamic_object
{
    internal class Program
    {
        //var is a local variable so we can't initaiaize it as a global
       
        static void Main(string[] args)
        {
            //if we intialize a var variable with integer than we can't replace with string

            var testVar = 5;
            ////testVar = "mehran"; like this 

            //if once we initialize object with integer also we can reassign it with string datatype

            object testObject = 10;
            testObject = "mehran";
            //here is possible


            //dynamic is also same as object but one different

            dynamic testDynamic = 10;
            testDynamic = "MEHRAN";

            string assign = testDynamic;
            string assign2 = testObject;

            Console.WriteLine(testVar);
            Console.WriteLine(testObject);
            Console.WriteLine(testDynamic);
        }
    }
}
