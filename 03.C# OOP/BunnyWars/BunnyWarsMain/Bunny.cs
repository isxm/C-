using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunnyWarsMain
{
   public class Bunny
    {
        private int InitialHealth = 200;
        private const int InitialCarrots = 0;

        private readonly string name;
        private string color;
        private ulong carrotsCount;
        

        public Bunny(string bunnyName)
        {
            this.name = bunnyName;
            this.Health = InitialHealth;
            this.carrotsCount = InitialCarrots;
            this.IsRetired  = false;
        }

        public Bunny(string bunnyName,string playerColor):this(bunnyName)
        {
            this.Color = playerColor;
        }

        public ulong AddCarrots(uint carrots)
        {
            this.carrotsCount += carrots;
            return this.carrotsCount;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                if (value != "Blue" && value != "Red")
                {
                    throw new ArgumentException("Change your color");
                }
                this.color = value;
            }
        }
        public int Health { get; set; }

        public bool IsRetired { get; private set; }

        public void Retire()
        {
            if (this.Health < 0)
            {
                this.IsRetired = true;
            }
        }
    }
}
