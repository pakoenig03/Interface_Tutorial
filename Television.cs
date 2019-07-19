using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fernbedinung_Test
{
    class Television : IActionButtons
    {
        public int Volume { get; set; }

        public void On()
        {
            Console.Write("Press Enter to Start the TV.");
            Console.ReadLine();
            Console.WriteLine("Your TV is on");
        }

        public void Off()
        {
            Console.ReadLine();
            Console.WriteLine("Your TV is off.");
        }

        public void EnterNumber()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are now on programm: " + number);

        }

        public void VolumeUp()
        {
            Console.Write("Select a Volume: ");
            Volume = Convert.ToInt32(Console.ReadLine());
            
            if (Volume != 0) Volume++;
            Console.WriteLine($"The TV Volume is now {Volume}");
           

        }


        public void VolumeDown()
        {
            Console.Write("Select a Volume: ");
            Volume = Convert.ToInt32(Console.ReadLine());

            if (Volume != 0) Volume--;
            Console.WriteLine($"The TV Volume is now {Volume}");
        }

       
    }
}
