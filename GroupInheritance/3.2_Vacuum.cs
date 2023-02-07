using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*  CONSTRAINTS:
 * 
 *      •	The first digit of the Item Number for vacuums is 2. 
 * 
 *      •	The Battery voltage value can be either 18 V (Low) or 24 V (High).
 * 
 *      •	ItemNumber;Brand;Quantity;Wattage;Color;Price;Grade;BatteryVoltage     
 *      
 *  INDIVIDUAL ATTRIBUTES:
 *  
 *      • Grade
 *      • BatteryVoltage  --  18V (low) or 24V (high) 
 *      
*/


namespace GroupInheritance
{
    public class Vacuum : Appliance
    {

        // Instances
        private string grade;
        private string batteryVoltage;

        // Getters and Setters
        public string Grade { get => grade; set => grade = value; }
        public string BatteryVoltage { get => batteryVoltage; set => batteryVoltage = value; }

        //Constructor
        public Vacuum(long itemNumber, string brand, int quantity, double wattage, string color, double price, string grade, string batteryVoltage) : base(itemNumber, brand, quantity, wattage, color, price)
        {
            this.grade = grade;
            this.batteryVoltage = batteryVoltage;
        }


        // Methods
        public override string ToString()
        {
            return "For Vacuum: \nItem Number: " + ItemNumber + "\nBrand: " + Brand + "\nQuantity: " + Quantity + "\nWattage: " + Wattage + "\nColor: " + Color
                    + "\nPrice: " + Price + "\nGrade: " + Grade + "\nBattery Voltage: " + batteryVoltage;
        }
    }   
}
