using System;
using System.Collections.Generic;
using System.Linq;

public enum EquipmentType { Mobile, Immobile }

namespace Exercise6
{
    public abstract class Equipment
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

    public class MobileEquipment : Equipment
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
   public  class ImmobileEquipment : Equipment
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

    public class Collection
    {
        List<Equipment> equipments = new List<Equipment>();
        public void AddEquipment(Equipment equip)
        {
            equipments.Add(equip);
        }
        public void RemoveEquipment(Equipment equip)
        {
            equipments.Remove(equip);
        }
        public void RemoveAll(Equipment equip)
        {
            equipments.Clear();
        }
        public void RemoveImmobile(Equipment equip)
        {
            foreach(var item in equipments)
            {
                if (item.Type == EquipmentType.Immobile)
                {
                    equipments.Remove(item);
                }
            }
        }
        public void Removemobile(Equipment equip)
        {
            foreach (var item in equipments)
            {
                if (item.Type == EquipmentType.Mobile)
                {
                    equipments.Remove(item);
                }
            }
        }
        public void ShowDetails()
        {
            foreach(var item in equipments)
            {
                Console.WriteLine(item.Name +  item.Description);
            }
        }
        public void ShowMobility()
        {
            foreach(var item in equipments)
            {
                if (item.Type==EquipmentType.Mobile){

                    Console.WriteLine("{0} is Mobile", item.Name);
                    
                }
                if(item.Type==EquipmentType.Immobile)
                {
                    Console.WriteLine("{0}is Immobile", item.Name);
                }
            }

        }
       
        

    }

    class Program
    {
        static void Main(string[] args)
        {
            Equipment jcb = new MobileEquipment { Name = "JCB", Description = "a moving sand picker machine", Type = EquipmentType.Mobile, NumberOfWheels = 5 };
            jcb.MoveBy(10);
            jcb.Print();

            Equipment ladder = new ImmobileEquipment { Name = "ladder", Description = "a CLIMBING TOOL", Type = EquipmentType.Immobile, Weight = 5 };
            ladder.MoveBy(10);
            ladder.Print();

            Collection first = new Collection();
            first.AddEquipment(jcb);
            first.AddEquipment(ladder);
            first.ShowDetails();
            first.ShowMobility();
            first.RemoveAll(jcb);
            


        }
    }
}

