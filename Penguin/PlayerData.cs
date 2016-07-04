using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Penguin
{
    class PlayerData
    {
        String name;
        int inCombat; // if 00; not in combat, if 01; in combat
        long targetID;
        long revolvingLinkID; // this associates the player name in the array with the player structure
        float currentX;
        float currentY;
        float currentZ;
        long direction; // this value is 0 => 4095 South is 0, increasing clockwise

        public PlayerData(string name, int inCombat, long targetID, long revolvingLinkID, float currentX, float currentY, float currentZ, long direction)
        {
            this.name = name;
            this.targetID = targetID;
            this.revolvingLinkID = revolvingLinkID;
            this.currentX = currentX;
            this.currentY = currentY;
            this.currentZ = currentZ;
            this.direction = direction;
        }
    }
}
