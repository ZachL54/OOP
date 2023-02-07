using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*  CONSTRAINTS:
 * 
 *  SHARED ATTRIBUTES: 
 *  
 *      • itemNumber
 *      • Brand
 *      • Quantity
 *      • Wattage
 *      • Color
 *      • Price
 *      
*/


namespace GroupInheritance
{
    public class Appliance : Object
    {

        // Instances
        private long itemNumber;
        private string brand;
        private int quantity;
        private double wattage;
        private string color;
        private double price;

        // Setters and Getters
        public long ItemNumber { get => itemNumber; set => itemNumber = value; }
        public string Brand { get => brand; set => brand = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double Wattage { get => wattage; set => wattage = value; }
        public string Color { get => color; set => color = value; }
        public double Price { get => price; set => price = value; }

        //Constructor
        public Appliance(long itemNumber, string brand, int quantity, double wattage, string color, double price)
        {
            ItemNumber = itemNumber;
            Brand = brand;
            Quantity = quantity;
            Wattage = wattage;
            Color = color;
            Price = price;
        }


        //Methods
        /*
         * isAvailable  --  bool
         * checkout  --  void
         * formatForFile  --  string
         * toString  --  string
         */


        public static bool isAvailable(List<Appliance> applianceList, int itemNumberInput)
        {
            foreach (Appliance appliance in applianceList)
            {
                if (appliance.itemNumber == itemNumberInput)
                {
                    if (appliance.Quantity == 0)
                    {
                        Console.WriteLine("Appliance is there, but not available");
                        return false;
                    }
                    else
                    {
                        Console.WriteLine("Appliance has been checked out!\n");
                        appliance.quantity--;
                        return true;
                    }
                }
            }
            Console.WriteLine("Appliance does not exist.");
            return false;    
        }

        public static void checkout(List<Appliance> applianceList, string input, int brandOrType)

        {
            foreach (Appliance appliance in applianceList)
            {

                if (appliance.Brand.Contains(input) && brandOrType == 1)
                {
                    Console.WriteLine("\n" + appliance + "\n");
                }

                if(appliance.GetType().Name == input && brandOrType == 2)
                {
                    Console.WriteLine("\n" + appliance + "\n");
                }
            }
        }


        //could make this virtual and add .ToString() to all my cw(appliance)
        public override string ToString()
        {
            return "";
        }
    }
}
