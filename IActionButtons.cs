using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fernbedinung_Test
{
    interface IActionButtons
    {
        void On();
        void Off();
        void VolumeUp();
        void VolumeDown();
        void EnterNumber();

    }
}
