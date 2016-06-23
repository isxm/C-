using System;
using System.Text;

namespace MobilePhones
{
    public class Call
    {
        //fields
        private DateTime dateTime;
        private string phoneNumber;
        private int duration;

        //Constructor - need only Phone number and duration
        public Call(string PhoneNumber, int Duration)
        {
            this.dateTime = DateTime.Now;
            this.phoneNumber = PhoneNumber;
            this.duration = Duration;
        }

        //Proparties
        public DateTime DateTime
        {
            get
            {
                return this.dateTime;
            }
            private set
            {
                this.dateTime = DateTime.Now;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Phone number can not be null or empty");
                }
                if ((value.Length != 10 && value.Length != 13) || (value[0] != '0' && value[0] != '+'))
                {
                    throw new ArgumentException("Possible phonenumber formats: +359xxxxxxxxx OR 0xxxxxxxxx !");
                }
                this.phoneNumber = value;
            }
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Duration can not be less than 0");
                }
                this.duration = value;
            }
        }

        public override string ToString()
        {
            StringBuilder stringCreator = new StringBuilder();
            stringCreator.AppendFormat("{0} : Duaration - {1} , made on {2}", this.phoneNumber, this.duration, this.dateTime);
            stringCreator.AppendLine();
            return stringCreator.ToString();

            //Another way
            //return string.Format("Date and time: {0:G}; Duration: {1} seconds;\nDialed number: {2}",
            //this.dateTime, this.duration, this.phoneNumber);
        }
    }
}