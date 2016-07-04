using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Penguin
{
    class WinHandleMethods
    {
        int tempPID = 2016;

        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        IntPtr pFoundWindow;
        String gameWindowName;

        public WinHandleMethods(String gameWindowName)
        {
            this.gameWindowName = gameWindowName;
        }

        public IntPtr getGameWindowHandle()
        {
            Process[] processes = Process.GetProcessesByName(gameWindowName);

            //foreach (Process p in processes)
            //{
                //pFoundWindow = p.MainWindowHandle;
            //}
            //System.Windows.Forms.MessageBox.Show(processes.Length.ToString());
            //pFoundWindow = processes[processNumber].MainWindowHandle;

           // pFoundWindow = Process.GetProcessById(tempPID).MainWindowHandle;
            pFoundWindow = processes[0].MainWindowHandle;
            int sessionID = processes[0].SessionId; // gets the session # of the process, 1 for first occurence, 2 for second...
            string pFoundWindowPName = processes[0].ProcessName;
            //System.Windows.Forms.MessageBox.Show(sessionID.ToString());
            return pFoundWindow;

        }
        public void setGameToFocusWindow()
        {
            SetForegroundWindow(getGameWindowHandle());
        }

        public RECT getGameWindowSize(int processNumber)
        {
            setGameToFocusWindow();
            System.Threading.Thread.Sleep(50);
            RECT rect = new RECT();
            GetWindowRect(GetForegroundWindow(), out rect);
            return rect;
        }
    }
}
