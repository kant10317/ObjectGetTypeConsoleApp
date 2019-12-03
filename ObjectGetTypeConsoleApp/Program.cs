using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectGetTypeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyBaseClass myBase = new MyBaseClass();
            MyDerivedClass myDerived = new MyDerivedClass();
            object o = myDerived;
            MyBaseClass b = myDerived;

            Console.WriteLine("mybase: Type is {0}", myBase.GetType());
            Console.WriteLine("myDerived: Type is {0}", myDerived.GetType());
            Console.WriteLine("object o = myDerived: Type is {0}", o.GetType());
            // Class Type不會因此被覆蓋
            Console.WriteLine("MyBaseClass b = myDerived: Type is {0}", b.GetType());

            int n1 = 12;
            int n2 = 82;
            long n3 = 12;

            Console.WriteLine("n1 and n2 are the same type: {0}",
                              Object.ReferenceEquals(n1.GetType(), n2.GetType()));
            Console.WriteLine("n1 and n3 are the same type: {0}",
                              Object.ReferenceEquals(n1.GetType(), n3.GetType()));

            Console.ReadLine();
        }
    }

    public class MyBaseClass
    {
    }

    public class MyDerivedClass : MyBaseClass
    {
    }
}
