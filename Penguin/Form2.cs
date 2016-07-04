using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices; // for PInvoke calls

namespace Penguin
{
    public partial class btnCloseForm : Form
    {
        

        Point rectStartPoint;
        Point rectEndPoint;
        bool clicked = false;
        /// <summary>
        /// Struct representing a point.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;

            public static implicit operator Point(POINT point)
            {
                return new Point(point.X, point.Y);
            }
        }

        /// <summary>
        /// Retrieves the cursor's position, in screen coordinates.
        /// </summary>
        /// <see>See MSDN documentation for further information.</see>
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out POINT lpPoint);

        public static Point GetCursorPosition()
        {
            POINT lpPoint;
            GetCursorPos(out lpPoint);
            //bool success = User32.GetCursorPos(out lpPoint);
            // if (!success)

            return lpPoint;
        }


        public btnCloseForm()
        {
            InitializeComponent();
        }

        private void Form2_Click(object sender, EventArgs e)
        {
            //Point p;
            //p = GetCursorPosition();
            //MessageBox.Show("X: " + p.X.ToString() + "Y: " + p.Y.ToString());
            //Graphics gfx = CreateGraphics();
            //gfx.DrawLine(new Pen(new SolidBrush(Color.Blue)), 500, 500, 100, 10);
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            clicked = true;

            //make this the starting point
            rectStartPoint.X = e.X;
            rectStartPoint.Y = e.Y;
            //rectEndPoint.X = e.X;
            //rectEndPoint.Y = e.Y;

            //drawTheRectangle();
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            clicked = false;
            // make this the final rectangle area
            rectEndPoint.X = e.X;
            rectEndPoint.Y = e.Y;
            drawTheRectangle();
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (clicked)
            {
                // make this the ending point
                rectEndPoint.X = e.X;
                rectEndPoint.Y = e.Y;
                Form2_Paint(this, null);
                //drawTheRectangle();
            }

        }

        private void drawTheRectangle()
        {
            Graphics gfx = CreateGraphics();
            gfx.DrawRectangle(new Pen(new SolidBrush(Color.Black)),new Rectangle(rectStartPoint.X, rectStartPoint.Y, rectEndPoint.X - rectStartPoint.X, rectEndPoint.Y - rectStartPoint.Y));
            MessageBox.Show(rectStartPoint.X.ToString() + " " + rectStartPoint.Y.ToString() + " " + rectEndPoint.X.ToString() + " " + rectEndPoint.Y.ToString());
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
