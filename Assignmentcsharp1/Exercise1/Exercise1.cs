using System;

namespace Assignmentcsharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            float b;
            bool c;
            
           //for integer
           
            Console.WriteLine("Enter Number to convert to integer");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number to covert to integer");
            int num2 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number to convert to integer");
            string r = Console.ReadLine();
            bool num3 = int.TryParse(r,out a);
            Console.WriteLine("The number is converted using intParse :" + num1);
            Console.WriteLine("the number is converted using Toint32 :"+ num2);
            Console.WriteLine("the number is converted usingTryParse :" + num3);

            //for float
            Console.WriteLine("Enter Number to convert to float using float.parse");
            float num4 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the input for float.tryparse");
            string m = Console.ReadLine();
            bool num5 = float.TryParse(m, out b);
            Console.WriteLine("The number was converted to float usinf float.parse: " + num4);
            Console.WriteLine("The number was converted to float using Try.parse: " + num5);
            
            //for boolean
            Console.WriteLine("Enter Number to convert to float using bool.parse");
            bool num6 = bool.Parse(Console.ReadLine());
            Console.WriteLine("Enter the input for bool.tryparse");
            string o = Console.ReadLine();
            bool num7 = bool.TryParse(m, out c);
            Console.WriteLine("The number was converted to float usinf bool.parse: " + num6);
            Console.WriteLine("The number was converted to float using bool.Tryparse: " + num7);







        }
    }
}
