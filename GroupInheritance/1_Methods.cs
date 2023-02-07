using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;




namespace GroupInheritance
{
    public class Methods
    {
        public static int getOption()
        {
            Console.WriteLine("Welcome to Modern Appliances!\r\n" +
                              "How may we assist you?\r\n\n" +
                              "1 – Check out appliance\r\n" +
                              "2 – Find appliances by brand\r\n" +
                              "3 – Display appliances by type\r\n" +
                              "4 – Produce random appliance list\r\n" +
                              "5 – Save & exit\r\n\n" +
                              "Enter option:\r");         
            return Convert.ToInt32(Console.ReadLine());
        }


        public static int getTypeAppliance()
        {
            Console.WriteLine("\nAppliance Types:\r\n\n" +
                              "1 – Refrigerators\r\n" +
                              "2 – Vacuums\r\n" +
                              "3 – Microwaves\r\n" +
                              "4 – Dishwashers\r\n" +
                              "Enter type of appliance:");
            return Convert.ToInt32(Console.ReadLine());
        }


        public static List<Appliance> convertFileToList()
        {
            string filePath = @"C:\Users\zacha\OneDrive\Desktop\[4] Object Oriented Programming [CPRG-211-F]\Assignments\GroupInheritance\GroupInheritance\GroupInheritance\TextFiles\Appliances.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();

            List<Appliance> applianceList = new List<Appliance>();

            foreach (string line in lines)
            {
                string[] data = line.Split(';');
                int applianceType = Convert.ToInt32(data[0].Substring(0, 1));

                switch (applianceType)
                {                                                                     
                    case 1:
                        Appliance r = new Refrigerator(Convert.ToInt64(data[0]), data[1], Convert.ToInt32(data[2]), Convert.ToDouble(data[3]),
                                      data[4], Convert.ToDouble(data[5]), data[6], Convert.ToInt32(data[7]), Convert.ToInt32(data[8]));
                        applianceList.Add(r);
                        break;
                    case 2:
                        Appliance v = new Vacuum(Convert.ToInt64(data[0]), data[1], Convert.ToInt32(data[2]), Convert.ToDouble(data[3]),
                                          data[4], Convert.ToDouble(data[5]), data[6], data[7]);
                        applianceList.Add(v);
                        break;
                    case 3:
                        Appliance m = new Microwave(Convert.ToInt64(data[0]), data[1], Convert.ToInt32(data[2]), Convert.ToDouble(data[3]),
                                          data[4], Convert.ToDouble(data[5]), Convert.ToDouble(data[6]), data[7]);
                        applianceList.Add(m);
                        break;
                    case 4:
                    case 5:
                        Appliance d = new Dishwasher(Convert.ToInt64(data[0]), data[1], Convert.ToInt32(data[2]), Convert.ToDouble(data[3]),
                                      data[4], Convert.ToDouble(data[5]), data[6], data[7]);
                        applianceList.Add(d);
                        break;
                }
            }
            return applianceList;
        }
    }
}
