using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE12Part1_Reester
{
    public class MyClass
    {
        string myString;
        string MyString
        {
            set { myString = value; }
        }
        public virtual string GetString()
        {
            return myString;
        }
    }

    public class MyDerivedClass : MyClass
    {
        public override string GetString()
        {
            // Call the base implementation of GetString() and append some text to the returned string
            return base.GetString() + " output from the derived class.";
        }
    }









    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
