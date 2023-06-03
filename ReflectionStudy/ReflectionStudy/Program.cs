using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetTypeMathod1();
        }

        static private void GetTypeMathod1()
        {
            int num = 10;
            Type type1 = num.GetType();
            Console.WriteLine(type1.Name);
            Console.WriteLine(type1.Namespace + "\n");

            string str = "Test";
            Type type2 = str.GetType();
            Console.WriteLine(type2.Name);
            Console.WriteLine(type2.Namespace + "\n");

            bool bVal = true;
            Type type3 = bVal.GetType();
            Console.WriteLine(type3.Name);
            Console.WriteLine(type3.Namespace + "\n");

            ArrayList al = new ArrayList();
            Type type4 = al.GetType();
            Console.WriteLine(type4.Name);
            Console.WriteLine(type4.Namespace + "\n");
        }
    }
}
