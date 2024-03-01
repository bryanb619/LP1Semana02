using System;


namespace ValoresEspeciais
{
    class Program
    {
        private static void Main(string[] args)
        {

            // sbyte
            sbyte ssb = sbyte.MinValue;
            sbyte sbb = sbyte.MaxValue; 

            // byte
            byte sb = byte.MinValue; 
            byte bb = byte.MaxValue; 

            // int
            int si = int.MinValue; 
            int bi = int.MaxValue; 

            // uint
            uint suint = uint.MinValue;
            uint buint = uint.MaxValue;

            // ulong
            ulong sulong = ulong.MinValue; 
            ulong bulong = ulong.MaxValue; 

            // long
            long slong = long.MinValue; 
            long blong = long.MaxValue; 

            // short
            short sshort = short.MinValue; 
            short bshort = short.MaxValue; 

            // ushort
            ushort sushort = ushort.MinValue;
            ushort bushort = ushort.MaxValue; 

            // char
            char schar = char.MinValue; 
            char bchar = char.MaxValue;


            // float
            float sfloat = float.MinValue; 
            float bfloat = float.MaxValue; 

            // double 
            double sdouble = double.MinValue; 
            double bdouble = double.MaxValue; 

            // decimal 
            decimal sdecimal = decimal.MinValue; 
            decimal bdecimal = decimal.MaxValue; 

            // FLOAT & Double positive & negative values
            float fi = float.NegativeInfinity; 
            float fp = float.PositiveInfinity; 

            double di = double.NegativeInfinity; 
            double dp = double.PositiveInfinity; 

            // NaN value
            float x = float.NaN; 


            // INTEGRAL TYPES PRINT VALUES

            // sbyte print
            Console.WriteLine(ssb);
            Console.WriteLine(sbb); 

            // byte print
            Console.WriteLine(sb);
            Console.WriteLine(bb);

            // int print
            Console.WriteLine(si);
            Console.WriteLine(bi);

            // uint print
            Console.WriteLine(suint);
            Console.WriteLine($"uint max value {buint}");

            // ulong print
            Console.WriteLine(sulong);
            Console.WriteLine(bulong);

            // long print
            Console.WriteLine(slong);
            Console.WriteLine(blong);

            // short print
            Console.WriteLine(sshort);
            Console.WriteLine(bshort);

            // ushort print
            Console.WriteLine(sushort);
            Console.WriteLine(bushort);

            // char print
            Console.WriteLine(schar);
            Console.WriteLine(bchar);


            // real types print
            Console.WriteLine(sfloat);
            Console.WriteLine(bfloat);

            Console.WriteLine(sdouble);
            Console.WriteLine(bdouble);

            Console.WriteLine(sdecimal);
            Console.WriteLine(bdecimal);



            // FLOAT & Double positive & negative values Print 
            Console.WriteLine(fi); 
            Console.WriteLine(fp); 
            Console.WriteLine(di); 
            Console.WriteLine(dp); 
            
            // print of NaN
            Console.WriteLine(x); 

            // 7

            Console.WriteLine($"uint overflow: {buint +1}"); 

            // 2 OVERFLOWS in floats
            float fo = 2 * float.MaxValue; 
            float fo2 = float.MaxValue +1;  

            
            Console.WriteLine(fo); 
            Console.WriteLine(fo2); 

            
            // underflow test
            float uf = 60000.0f; 

            Console.WriteLine(uf == 60000.0f + 0.0001f); 
        
        }
    }
}
