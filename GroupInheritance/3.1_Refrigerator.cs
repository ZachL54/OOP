using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  CONSTRAINTS:
 * 
 *      •	ItemNumber;Brand;Quantity;Wattage;Color;Price;NumberOfDoors;Height;Width
 *      
 *      •	The number of doors value can be either 2 (double doors), 3 (three doors) or 4 (four doors).
 * 
 *      •	The first digit of the Item Number for refrigerators is 1. 
 *      
 *      
 *  INDIVIDUAL ATTRIBUTES:
 *  
 *      • NumberOfDoors  --  2 (Double Doors),  
 *      • Height
 *      • Width
 *      
*/

namespace GroupInheritance
{
    public class Refrigerator : Appliance
    {

        // Instances
        private string numberOfDoors;
        private int height;
        private int width;

        // Getters and Setters
        public string NumberOfDoors { get => numberOfDoors; set => numberOfDoors = value; }
        public int Height { get => height; set => height = value; }
        public int Width { get => width; set => width = value; }

        // Constructor
        public Refrigerator(long itemNumber, string brand, int quantity, double wattage, string color, double price, string numberOfDoors, int height, int width) : base(itemNumber, brand, quantity, wattage, color, price)
        {
            this.numberOfDoors = numberOfDoors;
            this.height = height;
            this.width = width;
        }


        // Methods
        public override string ToString()
        {
            return "For Refrigerator: \nItem Number: " + ItemNumber + "\nBrand: " + Brand + "\nQuantity: " + Quantity + "\nWattage: " + Wattage + "\nColor: " + Color
                    + "\nPrice: " + Price + "\nNumber Of Doors: " + NumberOfDoors + "\nHeight: " + Height + "\nWidth: " + Width;
        }
    }
}
