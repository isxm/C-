namespace MobilePhones
{
    using System;
    public class Battery
    {
        // constants (instead of null values)
        private const string DefaultModel = "UnknownModel";
        private const int DefaultHoursIdle = 200;
        private const int DefaultHoursTalk = 100;
        private const BatteryType DefaultBatteryType = BatteryType.LiIon ;

        //fields
        private string batteryModel;            //task 1
        private int hoursIdle;                  //task 1
        private int hoursTalk;                  //task 1
        private BatteryType batteryType;        //task 3

        //Constructor task 2
        public Battery()                        
        {
            this.batteryModel = DefaultModel;
            this.hoursIdle = DefaultHoursIdle;
            this.hoursTalk = DefaultHoursTalk;
            this.batteryType = BatteryType.LiIon;
        }

        public Battery(string BatteryModel, int HoursIdle, int HoursTalk, BatteryType batteryType) //task2
        {
            this.batteryModel = BatteryModel;
            this.hoursIdle = HoursIdle;
            this.hoursTalk = HoursTalk;
            this.batteryType = batteryType;
        }

        //proparties task 5
        public string BatteryModel
        {
            get
            {
                return this.batteryModel;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The battery model can not be null or emtpy.");
                }
                else
                {
                    this.batteryModel = value;
                }
            }
        }

        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idle hours must be a possitive number.");
                }
                else
                {
                    this.hoursIdle = value;
                }
            }
        }

        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Hours of talk time must be a possitive number.");
                }
            }
        }

        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                this.batteryType = value;
            }
        }

        //looks like all done 
    }
}
