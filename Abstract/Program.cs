using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            int a = 20;
            int b = 10;
            
            M2 obj = new M2();
            
            int resultAdd = obj.add(a, b);
            int resultSub = obj.sub(a, b);
            int resultMul = obj.mul(a, b);
            float resultDiv = obj.div(a, b);

            Console.WriteLine("the result add is {0}\n", resultAdd);
            Console.WriteLine("the result sub is {0}\n", resultSub);
            Console.WriteLine("the result mul is {0}\n", resultMul);
            Console.WriteLine("the result div is {0}\n", resultDiv);
            
            Console.ReadLine();
        }
    }

    abstract class M1
    {

        /// <summary>
        /// Adds the specified a.
        /// </summary>
        /// <param name="a">A.</param>
        /// <param name="b">The b.</param>
        /// <returns></returns>
        public int add(int a, int b)
        {
            return a + b;
        }


        /// <summary>
        /// Subs the specified a.
        /// </summary>
        /// <param name="a">A.</param>
        /// <param name="b">The b.</param>
        /// <returns></returns>
        public abstract int sub(int a, int b);



        /// <summary>
        /// Muls the specified a.
        /// </summary>
        /// <param name="a">A.</param>
        /// <param name="b">The b.</param>
        /// <returns></returns>
        public virtual int mul(int a, int b)
        {
            return a * b;
        }
    }

    class M2 : M1
    {

        /// <summary>
        /// Subs the specified a.
        /// </summary>
        /// <param name="a">A.</param>
        /// <param name="b">The b.</param>
        /// <returns></returns>
        public override int sub(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// Virtual method override
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public override int mul(int a, int b)
        {
            //return base.mul(a, b);
            return a * b * 2;
        }

        public float div(int a, int b)
        {
            return a / b;
        }


    }
}
