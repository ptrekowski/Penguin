using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Penguin
{
    class TimerSender
    {
        public delegate void StartKeyDownEventHandler(Object sender, MovementEvents e);

        public event StartKeyDownEventHandler StartUpdateTimerEventHandler;

    }
}
