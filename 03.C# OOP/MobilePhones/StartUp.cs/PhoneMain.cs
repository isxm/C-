﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhones
{
    class PhoneMain
    {
        static void Main()
        {
            var testGSM = new GSM();

            Console.WriteLine(GSM.iPhone4S.ToString()); // Displaying Iphone info

            var GSMS = GSMTest.GenerateGSMs(); //Task 7 - GSM test class info 

            GSMTest.PrintGSMInfo(GSMS);

            var callsRegister = GSMCallHistoryTest.CreateCalltestHistory();  // Print Call History
            GSM.PrintCallHistory(callsRegister);
            GSMCallHistoryTest.CalculateAndPrintTestcallsPrice();   // Printing the total price of the Call History
            Console.WriteLine(new string('-', 50));
            GSMCallHistoryTest.RemoveLongestCall();                 // Printing the total price witout the longest call
            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Clearing Data........");             // Clearing call history and printing the empty List<Call>;
            callsRegister.Clear();
            GSM.PrintCallHistory(callsRegister);
            Console.WriteLine("Call History data cleared !");

        }
        
    }
}
