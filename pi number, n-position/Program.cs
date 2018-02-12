using System;

namespace pi_number__n_position
{
    class Program
    {
        static void Main(string[] args)
        {
            int number ;
            double p = 0, i = 1;
            for (int j = 1; j <= 9999999; j++)
            {
                if (j > 1)
                {
                    i += 2;
                }
                if (j % 2 == 1)
                {
                    p = p + (4 / i);
                }
                else
                {
                    p = p - (4 / i);
                }
                
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
            
        }
    }
}
