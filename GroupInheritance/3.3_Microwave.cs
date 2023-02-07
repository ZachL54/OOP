using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*  CONSTRAINTS:
 * 
 *      •	The first digit of the Item Number for microwaves is 3. 
 * 
 *      •	The room type is where the microwave will be installed, and is either K (kitchen) or W (work site)
 * 
 *      •	ItemNumber;Brand;Quantity;Wattage;Color;Price;Capacity;RoomType
 *      
 *  INDIVIDUAL ATTRIBUTES:
 *  
 *      • Capacity
 *      • RoomType  --  K (Kitchen) or W (Work Site)
 *      
*/


namespace GroupInheritance
{
    public class Microwave : Appliance
    {

        // Instances
        private double capacity;
        private string roomType;

        // Getters and Setters
        public double Capacity { get => capacity; set => capacity = value; }
        public string RoomType { get => roomType; set => roomType = value; }

        // Constructor
        public Microwave(long itemNumber, string brand, int quantity, double wattage, string color, double price, double capacity, string roomType) : base(itemNumber, brand, quantity, wattage, color, price)
        {
            this.capacity = capacity;
            this.roomType = roomType;
        }


        // Methods
        public override string ToString()
        {
            return "For Microwave: \nItem Number: " + ItemNumber + "\nBrand: " + Brand + "\nQuantity: " + Quantity + "\nWattage: " + Wattage + "\nColor: " + Color
                    + "\nPrice: " + Price + "\nCapacity: " + Capacity + "\nRoom Type: " + roomType;
        }
    }
}
