using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace pe14_Reester
{
    public interface iInterface
    {
        void interMethod();
    }

    public class Class1 : iInterface
    {
        public void interMethod()
        {
            Console.WriteLine("this is class1");
        }
    }

    public class Class2 : iInterface
    {
        public void interMethod()
        {
            Console.WriteLine("this is class2");
        }
    }


    internal class Program
    {
        
        public static void Main(string[] args)
        {
            
            Class1 i = new Class1();
            Class2 i2 = new Class2();
            MyMethod(i);
            MyMethod(i2);
        }
        public static void MyMethod(object myObject)
        {
            iInterface iFace;
            iFace = (iInterface)myObject;
            iFace.interMethod();
        }
    }
}
