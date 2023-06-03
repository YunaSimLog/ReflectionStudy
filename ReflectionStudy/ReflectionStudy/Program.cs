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
            //GetTypeMathod1();
            //GetTypeMathod2();
            GetInterfaceList();
        }

        /// <summary>
        /// 타입 가져오기 함수-1
        /// </summary>
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

        /// <summary>
        /// 타입 가져오기 함수-2
        /// </summary>
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

        /// <summary>
        /// 인터페이스 목록 가져오기
        /// </summary>
        static private void GetInterfaceList()
        {
            Type type = typeof(int);
            Type[] typeInterfaces = type.GetInterfaces();

            foreach (Type t in typeInterfaces)
            {
                Console.WriteLine("Name: {0}", t.Name);
            }
        }
    }
}
