using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEquipmentinterfaceDemo
{
    public class Sword : Item, IDamagable
    {

        public string name { get; set; }
        public int goldValue { get; set; }
        //string Item.name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //int Item.goldValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int durability { get; set; }
        public Sword(string _name)
        {
            name = _name;
            goldValue = 100;
            durability = 100;
        }
        public void Equip()
        {
            //throw new NotImplementedException;
            Console.WriteLine($"{name} is equipped");
        }
        public void Sell()
        {
            //throw new NotImplementedException;
            Console.WriteLine($"{name} is sold for {goldValue} imaginary dollars!");

        }

      

        public void TakeDamage(int _amountofDamage)
        {
            durability -= _amountofDamage;

            Console.WriteLine($"{name} damaged by {_amountofDamage}. It now has a durability of {durability} !");
        }
    }
}
