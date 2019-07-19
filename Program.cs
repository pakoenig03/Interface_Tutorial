using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fernbedinung_Test
{
    class Program
    {
        static void Main(string[] args)
        {

            Television television = new Television();

            television.On();

            Console.WriteLine("\nPress Enter to select program.");
            television.EnterNumber();

            television.VolumeUp();
            television.VolumeDown();

            television.Off();

            Console.ReadLine();
        }
    }
}


