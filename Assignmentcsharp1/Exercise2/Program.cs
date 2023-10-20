using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            object a1 = null;
            object a2 = 5;
            int x = 2;//object
            Console.WriteLine(x == 2.0);//"=="operator uses bitwise operator thats why it will be true
            Console.WriteLine(x.Equals(2.0));//.equals uses content only thats why it will be false
            Console.WriteLine(Console.ReferenceEquals(a1, a2));//referenc
        }
    }
}
