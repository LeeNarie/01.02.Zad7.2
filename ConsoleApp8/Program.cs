using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    public class Clss
    {

        double a = 0;
        double b = 0;
        public void SetA(double a)
        {
            this.a = a;
        }

        public void SetB(double b)
        {
            this.b = b;
        }

        public void WriteA()
        {
            Console.WriteLine(a);
        }

        public void WriteB()
        {
            Console.WriteLine(b);
        }

        public double SumAB()
        {
            return a + b;
        }


        public double max()
        {
            double max = 0;
            if (a >= b) max = a;
            else if (b > a) max = b;
            return max;
        }

    }


    class Program
        {
            static void Main(string[] args)
            {

            Clss C = new Clss();
            C.SetA(5);
            C.SetB(7);
            C.WriteA();

                C.WriteB();
            Console.WriteLine(C.SumAB());
            Console.WriteLine(C.max());

            Console.ReadKey();

        }
        }
    }

