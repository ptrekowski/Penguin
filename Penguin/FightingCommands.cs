using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsInput;
using Penguin;

namespace Penguin
{
    class FightingCommands
    {
        public static void faceTarget(int processNumber)
        {
            MovementCommands.setGameWindowFocus(processNumber);
            PressKey.Send_Key(PressKey.ScanCodeShort.KEY_B, PressKey.KEYEVENTF.SCANCODE);
            InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_B);
        }

        public static void findTarget(int processNumber)
        {
            MovementCommands.setGameWindowFocus(processNumber);
            PressKey.Send_Key(PressKey.ScanCodeShort.TAB, PressKey.KEYEVENTF.SCANCODE);
            InputSimulator.SimulateKeyPress(VirtualKeyCode.TAB);
        }

        public static void attack(int processNumber)
        {
            MovementCommands.setGameWindowFocus(processNumber);
            PressKey.Send_Key(PressKey.ScanCodeShort.KEY_3, PressKey.KEYEVENTF.SCANCODE);
            InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_3);
        }

        public static void stickTarget(int processNumber)
        {
            MovementCommands.setGameWindowFocus(processNumber);
            PressKey.Send_Key(PressKey.ScanCodeShort.KEY_G, PressKey.KEYEVENTF.SCANCODE);
            InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_G);
        }
    }
}
