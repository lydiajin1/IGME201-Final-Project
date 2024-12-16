using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGME201_Final_Project
{
    public class foodItem
    {
        /*Variables for the FoodItem class */
        public int price;
        public string name;
        public int quantity = 0;
        public int cost = 0;
       
        
        /*constructor for the FoodItem class asking for the price, name, and type of the food item. */
        public foodItem(int price, string name) {
            this.price = price;
            this.name = name;
          
        }

        /*get methods */
        public int getPrice() { return price; }
        public string getName() { return name; }
        public int getQuantity() { return quantity; }


        /*set methods*/
        public void setQuantity(int quantity) {
            this.quantity = quantity;
        }

        public void setPrice(int price) { this.price = price; }


        public void setName(string name) { this.name = name; }

        public int getCost() {
            int total = this.cost * this.quantity;
            this.cost = total;
            return this.cost;

        }

    }
}
