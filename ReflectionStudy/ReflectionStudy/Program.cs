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
            GetTypeMathod2();
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

        static private void GetTypeMathod2()
        {
            Type type1 = typeof(int);
            Console.WriteLine(type1.Name);
            Console.WriteLine(type1.Namespace + "\n");

            Type type2 = typeof(string);
            Console.WriteLine(type2.Name);
            Console.WriteLine(type2.Namespace + "\n");

            Type type3 = typeof(bool);
            Console.WriteLine(type3.Name);
            Console.WriteLine(type3.Namespace + "\n");

            Type type4 = typeof(ArrayList);
            Console.WriteLine(type4.Name);
            Console.WriteLine(type4.Namespace + "\n");
        }
    }
}
