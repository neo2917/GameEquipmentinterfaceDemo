using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEquipmentinterfaceDemo
{
    interface Item
    {
        string name { get; set; }
        int goldValue { get; set; }

        public void Equip();
        public void Sell();
    }
}
