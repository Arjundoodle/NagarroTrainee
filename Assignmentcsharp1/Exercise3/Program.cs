using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag;
            Console.WriteLine("Enter the First Number which should be lesser than second between 2 and 1000");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number which should be greater than first between 2 and 1000");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                while (num1 > num2)
                {
                    Console.WriteLine("re-enter the first number");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Re-enter the second number which should be greater than first");
                    num2= Convert.ToInt32(Console.ReadLine());

                }

            }
            for (int i = num1; i <= num2; i++)
            {

              

                flag = 1;

                for (int j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }

                
                if (flag == 1)
                    Console.WriteLine(i);
            }
        }
    }

}

