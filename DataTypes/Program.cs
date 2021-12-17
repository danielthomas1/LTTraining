using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Numerical
            sbyte smallByte = 0;//8bit signed integer -128 to 127
            byte byteType   = 0;//a bit unsigned integer 0-255

            Console.WriteLine(sbyte.MinValue + "  " + sbyte.MaxValue);
            Console.WriteLine(byte.MinValue  + "  " + byte.MaxValue);

            short shortDataType     = 0;//16 bit signed integer
            ushort uShortDataType   = 0;//16 bit unsigned integer

            Console.WriteLine(short.MinValue + "  " + short.MaxValue);
            Console.WriteLine(ushort.MinValue + "  " + ushort.MaxValue);

            int  intDataType = 0;//32 bit signed integer
            uint uIntDataType = 0;//32 bit unsigned integer

            Console.WriteLine(int.MinValue + "  " + int.MaxValue);
            Console.WriteLine(uint.MinValue + "  " + uint.MaxValue);

            long  longDataType    = 0;//64 bit signed integer
            ulong ulongDataType   = 0;//64 bit unsigned integer

            Console.WriteLine(long.MinValue + "  " + long.MaxValue);
            Console.WriteLine(ulong.MinValue + "  " + ulong.MaxValue);

            //Decimal Places
            float floatDataType = 0.1234567890F; //4byte long signed value with 6-9 decimal places;
            Console.WriteLine(floatDataType);

            double doubleType = 0.123456789123456789; //8byte long signed value 15-17 decimal places
            Console.WriteLine(doubleType);

            decimal decimalType = 0.123456789123456789123456789M; //16byte long signed value 28-29 decimal places
            Console.WriteLine(decimalType);

            //String
            string str  = "This is a long string message";

            //Char
            char ch     = 'C';

            //Boolean
            bool isActive = true;
            bool isOnline = false;
        }
    }
}
