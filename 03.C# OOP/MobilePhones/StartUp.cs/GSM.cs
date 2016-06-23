using System;
using System.Collections.Generic;

namespace MobilePhones
{
    // class that holds information about a mobile phone device: model, manufacturer, price, owner
    public class GSM
    {

        private const decimal pricePerSecond = 0.37m;
        // static field for iPhone4S. Task 6
        public static GSM iPhone4S = new GSM("4S", "Apple", 1200.00m, "Me",
                                     new Battery("AppleBat", 200, 100, BatteryType.NiMH),
                                     new Display(300, 150, 2000000));

        //fields
        private string model;               //task 1
        private string manufactures;        //task 1
        private decimal price;              //task 1
        private string owner;               //task 1
        private Battery battery;            //task 1
        private Display display;            //task 1
        private List<Call> CallHistory;     //task 9

        //constructors task 2
        //with less info
        public GSM()
        {
            this.model = "Standart";
            this.manufactures = "Unknown";
            this.price = 0m;
            this.owner = "None";
        }

        //with full info
        public GSM(string Model, string Manufactures, decimal Price, string Owner, Battery battery, Display display)
        {
            this.model = Model;
            this.manufactures = Manufactures;
            this.price = Price;
            this.owner = Owner;
            this.battery = battery;
            this.display = display;
            this.CallHistory = new List<Call>();
        }

        //proparties task 5
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model can not be null or empty");
                }
                this.model = value;
            }
        }

        public string Manufactures
        {
            get
            {
                return this.manufactures;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Manufactures can not be null or empty");
                }
                this.manufactures = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price can not be less ot equal than 0");
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Owner can not be null or empty");
                }
                this.owner = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;  //allready validated in Battery class 
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value; // allready validated in Display class
            }
        }

        //Property for Task 6
        public static GSM IPhone4S
        {
            get { return iPhone4S; }
        }

        //Method task 4
        public override string ToString()
        {
            Console.WriteLine(new string('-', 50));
            var GSMInfo = "Model: " + this.Model + "\r\n Manufacture: " + this.Manufactures +
                          "\r\n Price: " + this.Price + "\r\n Owner: " + this.Owner;
            var BatteryInfo = "\r\n Battery Model: " + this.Battery.BatteryModel + "\r\n Batter Type: " + this.Battery.BatteryType +
                              "\r\n Hours Idle: " + this.Battery.HoursIdle + "\r\n Hours Talk :" + this.Battery.HoursTalk;
            var DisplayInfo = "\r\n Display Height: " + this.Display.Height + "\r\n Display Width: " + this.Display.Width +
                              "\r\n Number of colors: " + this.Display.NumberOfColors;
            return string.Join(" ", GSMInfo, BatteryInfo, DisplayInfo);
        }

        //add call method (takes number as a string and duaration - dateTime is always NOW)
        //task 10
        

        public static decimal CalculateTotalCallPrice(List<Call> call, decimal price)
        {
            int totalDuration = 0;
            for (int i = 0; i < call.Count; i++)
            {
                totalDuration += call[i].Duration;
            }
            decimal totalPrice = totalDuration * price;
            return totalPrice;
        }
        public static void PrintCallHistory(List<Call> calls)
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Call History");
            for (int i = 0; i < calls.Count; i++)
            {
                Console.WriteLine("Call History{0}: {1}", i + 1, string.Join(" ", calls[i]));
                Console.WriteLine(new string('-', 50));
            }
        }
    }



}
