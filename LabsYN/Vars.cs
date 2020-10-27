using System;
using System.Collections.Generic;
using System.Text;

namespace LabsYN
{
    class Vars
    {
        private static char h;

        static void Main(string[] args)
        {
            // Use "Debugging" and "Watch" to study variables and constants

            //1) declare variables of all simple types:
            //bool, char, byte, sbyte, short, ushort, int, uint, long, ulong, decimal, float, double
            // their names should be: 
            //boo, ch, b, sb, sh, ush, i, ui, l, ul, de, fl, d0
            // initialize them with 1, 100, 250.7, 150, 10000, -25, -223, 300, 100000.6, 8, -33.1
            // Check results (types and values). Is possible to do initialization?
            // Fix compilation errors (change values for impossible initialization)

            bool boo = true;

            char ch = h;
            byte b = 100;
            sbyte sb = -25;
            short sh = 10000;
            ushort ush = 65000;
            int i = 1;
            uint ui = 1231341241;
            long lo = -223;
            ulong ul = 234567890234567890;
            decimal d = 0.1m;
            float f = 100000.6F;
            double db = 250.7;

            //2) declare constants of int and double. Try to change their values.

            int v;
            v = 5;

            //

            v = 10;

            double y;
            y = 15.6;

            y = 12.2;

            //3) declare 2 variables with var. Initialize them 20 and 20.5. Check types. 
            // Try to reinitialize by 20.5 and 20 (change values). What results are there?

            var t = 20;
            var th = 20.5;

            th = 20;
            //t = 20.5;

            // 4) declare variables of System.Int32 and System.Double.
            // Initialize them by values of i and d0. Is it possible?
            System.Int32 i1 = 345;
            System.Double d0 = 2.4;



            if (true)
            {
                // 5) declare variables of int, char, double 
                // with names i, ch, do
                // is it possible?
                // int i;     Bad. A local or parameter named 'i' cannot be declared in this scope because that name is used in an enclosing local scope to define a local or parameter
                // char ch;   Bad. A local or parameter named 'ch' cannot be declared in this scope because that name is used in an enclosing local scope to define a local or parameter
                // double d0; Bad. A local or parameter named 'd0' cannot be declared in this scope because that name is used in an enclosing local scope to define a local or parameter

                // 6) change values of variables from 1)
                i = 34;
                ch = 'B';
                d0 = 1e-6;

            }

            // 7)check values of variables from 1). Are they changed? Think, why
            //Vars are changed
            i = 5;
            ui = 98765432;
            lo = -226;

            // 8) use implicit/ explicit conversion to convert variables from 1). 
            // Is it possible? 
            //string s = ch;
            long l1 = ui;

            // Fix compilation errors (in case of impossible conversion commemt that line).
            // int -> char
            i = (char)i;

            // bool -> short

            //sh = (short)boo;

            // double -> long

            lo = (long)db;
            lo = System.Convert.ToInt64(db);

            // char -> float

            f = (float)ch;

            // char to int 

            i = (int)ch;

            // double -> decimal

            d = (decimal)db;

            // uint -> byte

            b = (byte)b;

            // ulong -> sbyte

            sb = (sbyte)ul;

            // 9) and reverse conversion with fixing compilation errors.

            // char -> int  

            i = (int)ch;

            // short -> bool

            //boo = (bool)sh;

            //  long -> double 

            db = (double)lo;

            // float -> char 
            ch = (char)f;
            // int to char
            ch = (char)i;
            // double  -> decimal
            d = (decimal)db;
            // uint -> byte  
            b = (byte)ui;
            // sbyte -> ulong 
            ul = (ulong)sb;

            // 10) declare int nullable value. Initialize it with 'null'. 
            // Try to initialize variable i with 'null'. Is it possible?
            int? nu = null;
            //int i1 = null;

        }



    }

}
