using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Penguin
{
    [Serializable]
    class XpPathData
    {
          // ************************************************************************************************
        // ................................................................................................

        // List that holds CapturedPathingPoints
        // x, y, z, facing of the recorded path
        private List<CapturedPathingPoints> xpPath;
        private int length;

        private float destinationDirection = 999.0f;

        // ************************************************************************************************
        // ................................................................................................

        // Constructor
        public XpPathData()
        {
            // new instance of the list
            xpPath = new List<CapturedPathingPoints>();
            length = 0;
        }

        // Getters
        // ************************************************************************************************
        // ................................................................................................

        // Implement classic C# Getter/Setter
        // access one element at a time ONLY!
        public CapturedPathingPoints getPointAtIndex(int indexOfList)
        {
            return xpPath[indexOfList];
        }

        // ************************************************************************************************
        // ................................................................................................

        // Implement classic C# Getter/Setter
        // access one element at a time ONLY!


        // ************************************************************************************************
        // ................................................................................................

        // Setters

        public void setPointInPathList(CapturedPathingPoints XPpoint)
        {
            xpPath.Add(XPpoint);
            length++;
            // MessageBox.Show(XPpoint.x.ToString());
        }

        // Getters

        public int getLength()
        {
            return length;
        }
    }
}
