using System;

namespace pi_number__n_position
{
    class Program
    {
        /*static void Main(string[] args)
        {
            // int number ;
            decimal p = 0;
            double r = 16;

          //  decimal a = ;
            for (double i = 0; i <= 100; i++)
            {
                long aa = (long)Math.Pow(r, i);
                Console.WriteLine(aa);
                double a = 1 /aa;
                double b = 4 / (8 * i + 1);
                double c = 2 / (8 * i + 4);
                double d = 1 / (8 * i + 5);
                double e = 1 / (8 * i + 6);

                p = p + a * (b - c - c - e);
                
            }
            Console.WriteLine(p);
            Console.WriteLine("Insert pi number after the decimal point: ");
            number = Convert.ToInt32(Console.ReadLine());
            String value = p.ToString();
            int startIndex = number+1;
            int length = 1;
            String substring = value.Substring(startIndex, length);
            Console.Write("Your number is ");
            Console.WriteLine(substring);
            
        }*/
        public static void Main()
        {
            float value = 16;
            float p = 0;

            for (float power = 0; power <= 10000000; power++)
            {
                p = p + (1/(float)Math.Pow(value, power) * ((4 / (8 * power + 1))- (2 / (8 * power + 4)) - (1 / (8 * power + 5)) - (1 / (8 * power + 6))));
                
            }
            p.ToString();
            Console.WriteLine(p);
        }
    }
}
