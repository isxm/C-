using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunnyWarsMain
{
    class BunnyWarsMain
    {
        static void Main()
        {
            Bunny vankataBunny = new Bunny("Vankata");
            ulong currentVankataCarrots = vankataBunny.AddCarrots(100);

            Bunny peshoBunny = new Bunny("Pesho", "Blue");
            ulong currentPeshoCarrots = peshoBunny.AddCarrots(2000);

            string vankataName = vankataBunny.Name;

            vankataBunny.Color = "Blue";
            string color = vankataBunny.Color;

            vankataBunny.Retire();
            vankataBunny.Health -= 250;
             
        }
    }
}
