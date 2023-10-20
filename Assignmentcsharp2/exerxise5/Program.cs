using System;
public enum DuckType {Rubber,Mallard,ReadHead }

namespace exerxise5
{
    interface IDuck
    {
        void fly();
        void quack();

        

      

      

     
    }
    public abstract class Duck :IDuck
    {
        public int Weight { get; set; }
        public int NumberofWings { get; set; }
        public DuckType Type { get; set; }

        public abstract  void fly();
        public abstract void quack();
       public void Showdetails()
        {
            Console.WriteLine("Weight:"+ Weight + "\nNumberofWings" + NumberofWings + "\nDuckType:" + Type);
        }
    }

    public class Rubber : Duck
        

    {


        public Rubber()
        {
            Type = DuckType.Rubber;
        }
        public  override void  fly()
        {
            Console.WriteLine("I don,t fly");

        }
        public override void quack()
        {
            Console.WriteLine("I squak");
        }

        
    }
    public class Mallard : Duck
    {
     

        public Mallard()
        {
            Type = DuckType.Mallard;
        }
        public override  void fly()
        {
            Console.WriteLine("I fly fast");

        }
        public override  void quack()
        {
            Console.WriteLine("I quack loud");
        }
        
    }
    public class ReadHead : Duck
    {
       

        public ReadHead()
        {
            Type = DuckType.ReadHead;
        }

        public override  void fly()
        {
            Console.WriteLine("I fly slow");

        }
        public override void quack()
        {
            Console.WriteLine("I quack loud");
        }
       
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rubber duck1 = new Rubber();
          
            duck1.fly();
            duck1.quack();
            duck1.Weight = 35;
            duck1.NumberofWings = 40;
            duck1.Showdetails();

        }
    }
}
