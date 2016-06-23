namespace MobilePhones
{
    using System;

    //Task 7
    public class GSMTest
    {
        static string[] diffManufacturers = new string[] { "Samsung", "Sony", "Nokia", "Sagem", "Apple" };
        static string[] diffModels = new string[] { "Galaxy", "Experia", "Note", "NZ", "MacBook" };
        static decimal[] priceRange = new decimal[] { 1000m, 800m, 500m, 300m, 100m };
        static string[] someOwner = new string[] { "Marto", "Someone", "Pavel", "Bai Ristio", "Zlatka" };

        public static GSM [] GenerateGSMs()
        {
            GSM[] GSMarr = new GSM[5];
            var batt = new Battery("Kyrtach", 300, 100, BatteryType.NiCD);
            var disp = new Display(300, 200, 16000000);

            for (int i = 0; i < 5; i++)
            {
                GSMarr[i] = new GSM(diffModels[i], diffManufacturers[i], priceRange[i], someOwner[i], batt, disp);
            }

            return GSMarr; 
        }

        public static void PrintGSMInfo(GSM[] GSMarr)
        {
            for (int i = 0; i < GSMarr.Length; i++)
            {
                Console.WriteLine("Generated GSM {0} : {1}", i + 1, string.Join(" ", GSMarr[i]));
            }
            Console.WriteLine("iPhone4S Info: {0}", GSM.IPhone4S);
        }
    }
}
