using System;

namespace GameEquipmentinterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Sword s = new Sword("MasterBlade");

            s.TakeDamage(15);
            s.Equip();
            s.Sell();
        }

        interface IDamagable
        {
            int durability { get; set; }
            void TakeDamage(int _amount);
        }
    }
}
