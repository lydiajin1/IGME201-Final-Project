using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGME201_Final_Project
{
    public class FoodItem
    {
        /*Variables for the FoodItem class */
        public int price;
        public string name;
        public string type;
        public int quantity = 0;
        
        /*constructor for the FoodItem class asking for the price, name, and type of the food item. */
        public FoodItem(int price, string name, string type) {
            this.price = price;
            this.name = name;
            this.type = type;
        
        }

        /*get methods */
        public int getPrice() { return price; }
        public string getName() { return name; }
        public string getType() { return type; }
        public int getQuantity() { return quantity; }


        /*set methods*/
        public void setQuantity(int quantity) {
            this.quantity = quantity;
        }

        public void setPrice(int price) { this.price = price; }

        public void setType(string type) { this.type = type; }

        public void setName(string name) { this.name = name; }



    }
}
