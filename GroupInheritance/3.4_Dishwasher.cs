using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*  CONSTRAINTS:
 * 
 *      •	The first digit of the Item Number for dishwashers is 4 or 5. 
 * 
 *      •	The Sound Rating of the dishwasher can be Qt (Quietest), Qr (Quieter), Qu (Quiet) or M (Moderate).
 *      
 *      •	ItemNumber;Brand;Quantity;Wattage;Color;Price;Feature;SoundRating
 *      
 *  INDIVIDUAL ATTRIBUTES:
 *  
 *      • Feature
 *      • SoundRating  --  Qt (Quietest), Qr (Quieter), Qu (Quiet) or M (Moderate)
 *     
*/


namespace GroupInheritance
{
    public class Dishwasher : Appliance
    {

        // Instances
        private string feature;
        private string soundRating;

        // Getters and Setters
        public string Feature { get => feature; set => feature = value; }
        public string SoundRating { get => soundRating; set => soundRating = value; }

        //Constructor
        public Dishwasher(long itemNumber, string brand, int quantity, double wattage, string color, double price, string feature, string soundRating) : base(itemNumber, brand, quantity, wattage, color, price)
        {
            this.feature = feature;
            this.soundRating = soundRating;
        }


        // Methods
        public override string ToString()
        {
            return "For Dishwasher: \nItem Number: " + ItemNumber + "\nBrand: " + Brand + "\nQuantity: " + Quantity + "\nWattage: " + Wattage + "\nColor: " + Color
                    + "\nPrice: " + Price + "\nFeature: " + Feature + "\nSound Rating: " + SoundRating;
        }
    }
}
