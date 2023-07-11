using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encap001
{
    public interface A
    {
        void m1();
    }

    class B:A

    {
        public void m1()
        {
            Console.WriteLine("mi is a interface ");
        
        }

        public static void Main(string[] args)

        {


            B a = new B();

            a.m1();
            Console.ReadLine();
        }

    }
}
