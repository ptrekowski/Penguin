﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Penguin
{
    public static class MouseActions
    {
        // import the necessary API function so .NET can
        // marshall parameters appropriately
        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        // constants for the mouse_input() API function
        private const int MOUSEEVENTF_MOVE = 0x0001;
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const int MOUSEEVENTF_RIGHTUP = 0x0010;
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        private const int MOUSEEVENTF_MIDDLEUP = 0x0040;
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;

        // simulates movement of the mouse.  parameters specify changes
        // in relative position.  positive values indicate movement
        // right or down
        public static void Move(int xDelta, int yDelta)
        {
            mouse_event(MOUSEEVENTF_MOVE, xDelta, yDelta, 0, 0);
        }

        // simulates movement of the mouse.  parameters specify an
        // absolute location, with the top left corner being the
        // origin
        public static void MoveTo(int x, int y)
        {
            // x and y are 0 => 65,535 units....
            mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, x, y, 0, 0);
        }

        public static void MoveMouseByXandY(int x, int y)
        {
            SetCursorPos(x, y);
        }

        // simulates a click-and-release action of the left mouse
        // button at its current position
        public static void LeftClick()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
        }

        public static void LeftMouseButtonDown()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, 880, 540, 0, 0);
        }

        public static void LeftMouseButtonUp()
        {
            mouse_event(MOUSEEVENTF_LEFTUP, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
        }

        public static void RightClick()
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
            mouse_event(MOUSEEVENTF_RIGHTUP, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
            MovementCommands.pressQuickbarNumber("0", 0);
        }
        public static void MiddleDownClick()
        {
            mouse_event(MOUSEEVENTF_MIDDLEDOWN, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
        }
        public static void MiddleUpClick()
        {
            mouse_event(MOUSEEVENTF_MIDDLEUP, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
        }
        public static void RightDownClick()
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN, Control.MousePosition.X + 5, Control.MousePosition.Y, 0, 0);
        }
        public static void RightUpClick()
        {
            mouse_event(MOUSEEVENTF_RIGHTUP, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
        }
        public static void LeftUpClick()
        {
            mouse_event(MOUSEEVENTF_LEFTUP, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
        }
        public static void LeftDownClick()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
        }
    }
}
