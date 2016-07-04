using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Penguin
{
    [Serializable]
    public class CapturedPathingPoints
    {
        public float x;
        public float y;
        public float z;
        //public float facing;


        public CapturedPathingPoints()
        {

        }

        public CapturedPathingPoints(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        //public void setX(float x)
        //{
        //    this.x = x;
        //}

        //public void setY(float y)
        //{
        //    this.y = y;
        //}
    }
}
