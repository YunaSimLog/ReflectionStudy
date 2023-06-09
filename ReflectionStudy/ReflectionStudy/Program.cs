﻿using System;
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
            //GetInterfaceList();
            //GetFieldList();
            //GetMethods();
            GetBindingFlags();
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

        static private void GetFieldList()
        {
            int nNum = 0;
            Type type = nNum.GetType();
            var vFieldinfo = type.GetFields();
            foreach (var CurField in vFieldinfo)
            {
                Console.WriteLine("Name: {0} Type: {1} ", CurField.Name, CurField.FieldType);
            }
        }

        static private void GetMethods()
        {
            int nNum = 0;
            Type type = nNum.GetType();

            var vMethods = type.GetMethods();
            foreach (var CurMethod in vMethods)
            {
                Console.WriteLine("Name: {0}, ReturnType: {1}", CurMethod.Name, CurMethod.ReturnType);

                foreach (var CurParameters in CurMethod.GetParameters())
                {
                    Console.WriteLine("ParameterTypeName: {0}, ParameterType: {1}", CurParameters.Name, CurParameters.ParameterType);
                }
            }
        }

        static private void GetBindingFlags()
        {
            int nNum = 0;
            Type type = nNum.GetType();

            var vMethods = type.GetMethods(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);

            foreach (var CurMethod in vMethods)
            {
                Console.WriteLine("Name: {0}, ReturnType: {1}", CurMethod.Name, CurMethod.ReturnType);

                foreach (var CurParameters in CurMethod.GetParameters())
                {
                    Console.WriteLine("ParameterTypeName: {0}, ParameterType: {1}", CurParameters.Name, CurParameters.ParameterType);
                }
            }
        }
    }
}
