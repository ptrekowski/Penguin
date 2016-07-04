using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Penguin
{
    class PlayerObject
    {
        string name;
        bool active;
        float locationX;
        float locationY;
        bool friendly;

        public PlayerObject(string name, bool active)
        {
            this.name = name;
            this.active = active;
        }
    }
}
