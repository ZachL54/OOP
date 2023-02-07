using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupInheritance
{
    internal class Driver
    {
        public static void Main(String[] args)
        {

            List<Appliance> applianceList = Methods.convertFileToList();
            int option = Methods.getOption();

            if(option == 1)
            {
                Console.WriteLine("\nEnter Item Number Of Appliance");
                int itemNumber = Convert.ToInt32(Console.ReadLine());

                bool isAvailable = Appliance.isAvailable(applianceList, itemNumber);
                if (isAvailable)
                {
                    var app = applianceList.Where(x => x.ItemNumber == itemNumber).FirstOrDefault();
                    Console.WriteLine(app);
                }
            }
            //add comment
            if(option == 2)
            {
                Console.WriteLine("\nEnter Brand To Search For: ");
                string brand = Console.ReadLine();
                Appliance.checkout(applianceList, brand, 1);              
            }

            if(option == 3)
            {
                int type = Methods.getTypeAppliance();

                switch (type)
                {
                    case 1:
                        Appliance.checkout(applianceList, "Refrigerator", 2);
                        break;
                    case 2:
                        Appliance.checkout(applianceList, "Vacuum", 2);
                        break;
                    case 3:
                        Appliance.checkout(applianceList, "Microwave", 2);
                        break;
                    case 4:
                        Appliance.checkout(applianceList, "Dishwasher", 2);
                        break;
                }
            }

            if(option == 4)
            {
                Random rnd = new Random();
                int num = rnd.Next(0, 26);

                Console.WriteLine("\nProgram will Display " + (num + 1) + " random appliances");

                List<Appliance> tempApplianceList = applianceList;
                for (int x = 0; x <= num; x++)
                {
                    int r = rnd.Next(tempApplianceList.Count);
                    Console.WriteLine("\n" + tempApplianceList[r] + "\n");
                    tempApplianceList.RemoveAt(r);
                }
            }

            if(option == 5)
            {

            }

            Console.ReadKey();
        }
    }
}
