using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_1_2_lab
{
    class Program
    {
		//RV: I see your program but cannot neither open it in visual studio nor run because it doesn't belong to any project and no project file.
		//RV: For the following labs please create project if there is no one in the template. 
		//RV: If there are any questions regarding this we can discuss it on a lesson. 
        static void Main(string[] args)
        {
            // Use "Debugging" and "Watch" to study variables and constants

            //1) declare variables of all simple types:
            //bool, char, byte, sbyte, short, ushort, int, uint, long, ulong, decimal, float, double
            // their names should be: 
            //boo, ch, sb, sh, ush, i, ui, l, ul, de, fl, do
            // initialize them with 1, 100, 250.7, 150, 10000, -25, -223, 300, 100000.6, 8, -33.1
            // Check results (types and values). Is possible to do initialization?
            // Fix compilation errors (change values for impossible initialization)


            int @i = 654;
            char ch = '6';
            bool boo = false ;
            byte @byte = 255;
            sbyte @sbyte = -85;
            short sh = -32768;
            ushort ush = 596;
            uint ui = 6461321 ;
            long ul = 235498723;
            decimal de = 654613.366M;
            float fl = 1230.665F;
            double @do = 5607.32;



            //2) declare constants of int and double. Try to change their values.


            const int myConstInt = 45;
            const double myConstDouble = 123.89;

            /// myConstInt = 43;



            //3) declare 2 variables with var. Initialize them 20 and 20.5. Check types. 
            // Try to reinitialize by 20.5 and 20 (change values). What results are there?

            var myVar1 = 20;
            var myVar2 = 20.5;

            Console.WriteLine("MyVar1 type is: {0}", myVar1.GetType());
            Console.WriteLine("MyVar2 type is {0}:", myVar2.GetType());
            Console.WriteLine("MyVar2 type is {0}:", de.GetType());


            // 4) declare variables of System.Int32 and System.Double.
            // Initialize them by values of i and do. Is it possible?

            // System.Int32 myInt = i;
            // System.Double myDouble = do;

            if (true)
            {


                // 5) declare variables of int, char, double 
                // with names i, ch, do
                // is it possible?

                // int i = 45;
                //  char ch = '3';
                // double do = 456.234;
                // 6) change values of variables from 1)


                @i = 12;
                ch = 'g';
                boo = true;
                @byte = 0;
                @sbyte = 127;
                sh = -768;
                ush = 59;
                ui = 61321;
                ul = 238723;
                de = 6513.36M;
                fl = 10.665F;
                @do = 560.562;

                // 7)check values of variables from 1). Are they changed? Think, why

                Console.WriteLine(@i.GetType());
                Console.WriteLine(boo.GetType());
                Console.WriteLine(@byte.GetType());
                Console.WriteLine(sh.GetType());
                Console.WriteLine(ush.GetType());
                Console.WriteLine(ui.GetType());
                Console.WriteLine(ul.GetType());
                Console.WriteLine(de.GetType());
                Console.WriteLine(fl.GetType());
                Console.WriteLine(@do.GetType());

            }



            // 8) use implicit/ explicit conversion to convert variables from 1). 
            // Is it possible? 
            // Fix compilation errors (in case of impossible conversion commemt that line).


            // int -> char
            Console.WriteLine(@i + ch);
            // bool -> short
            //Console.WriteLine(boo + sh);
            //double -> long
            Console.WriteLine(double.MaxValue - long.MaxValue);
            //float -> char 
            Console.WriteLine(fl - ch);
            //decimal -> double
            double bud = double.MaxValue;
            double mud = double.MaxValue;
            decimal sum;
           // mud = (double)bud;
            sum = (decimal)(mud + bud);
            Console.WriteLine(sum);
            //byte -> uint
            //Console.WriteLine((uint)(byte.MaxValue) + uint.MaxValue);
            // ulong -> sbyte
            //Console.WriteLine





            // 9) and reverse conversion with fixing compilation errors.

            // 10) declare int nullable value. Initialize it with 'null'. 
            // Try to initialize variable i with 'null'. Is it possible?


            int? @null = null;
            //var? i = null;

            Console.ReadLine();

        }
    }
}
