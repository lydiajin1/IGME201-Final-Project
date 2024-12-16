using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGME201_Final_Project
{
    internal class DrinkItem : foodItem
    {
        string size;

        public DrinkItem(string size,int price, string name) : base(price, name)
        {
            this.size = size;
        }
    }

    

}
