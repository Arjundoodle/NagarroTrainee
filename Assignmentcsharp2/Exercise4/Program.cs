using System;

enum EquipmentType { Mobile,Immobile}

namespace Exercise4
{
    abstract class Equipment
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int DistanceMoved { get; set; }
        public int MaintenanceCost { get; set; }
        public EquipmentType Type { get; set; }
        public abstract void MoveBy(int distance);

        public virtual int GetMaintenanceCost(int distance)
        {
            return 0;
        }
        public void Print()
        {
            Console.WriteLine("Name:{0}\nDescription:{1}\nDistanceMoved:{2}\nMaintenanceCost:{3}\n", Name, Description, DistanceMoved, MaintenanceCost);
        }


    }

    class MobileEquipment : Equipment
    {
        public int NumberOfWheels { get; set; }
        public override void MoveBy(int distance)
        {
            DistanceMoved = DistanceMoved + distance;
            MaintenanceCost = MaintenanceCost + NumberOfWheels * distance;
        }
        public override int GetMaintenanceCost(int distance)
        {
            return MaintenanceCost;
        }
    }
    class ImmobileEquipment : Equipment
    {
        public int Weight { get; set; }
        public override void MoveBy(int distance)
        {
            DistanceMoved = DistanceMoved + distance;
            MaintenanceCost = MaintenanceCost + Weight * distance;
        }
        public override int GetMaintenanceCost(int distance)
        {
            return MaintenanceCost;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MobileEquipment jcb = new MobileEquipment { Name = "JCB", Description = "a moving sand picker machine", Type = EquipmentType.Mobile, NumberOfWheels = 5 };
            jcb.MoveBy(10);
            jcb.Print();

                ImmobileEquipment ladder = new ImmobileEquipment { Name = "JCB", Description = "a CLIMBING TOOL", Type = EquipmentType.Immobile, Weight = 5 };
            ladder.MoveBy(10);
            ladder.Print();
        }
    }
}
