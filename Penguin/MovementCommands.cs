using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Penguin;
using WindowsInput;
using System.Diagnostics;
//using System.Threading;
//using System.Timers.Timer;

/**
 * Need to add formatting to the following cardinal directions:
 * East
 * West
 * North
 * South
 */
public class MovementCommands
{
    //[StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;
    }

    // ************************************************************************************************
    // ................................................................................................



    // ************************************************************************************************
    // ................................................................................................

    public MovementCommands()
    {

    }

    // ************************************************************************************************
    // ................................................................................................

    // 
    // return Float or Point????
    //
    public static double calculateDistanceToNextPoint(CapturedPathingPoints currentPoint, CapturedPathingPoints nextPoint)
    {
        double distanceToNextPoint;
        distanceToNextPoint = Math.Sqrt(Math.Abs((nextPoint.x - currentPoint.x) + (nextPoint.y - currentPoint.y)));
        return distanceToNextPoint;
    }



    // ************************************************************************************************
    // ................................................................................................

    // 
    // return Float or Point????
    //

      public static int calculateDestinationDirection(CapturedPathingPoints currentPoint, CapturedPathingPoints destPoint) // Point startPoint, Point endPoint 
        {
               double degrees;
               double deltaX;
               double deltaY;
               double radians;

                deltaX = currentPoint.x - destPoint.x;
                deltaY = currentPoint.y - destPoint.y;

                radians = Math.Atan2(deltaY, deltaX);
                System.Console.WriteLine("radians: " + radians.ToString());

                //radians = Math.PI / 2 - radians;
                System.Console.WriteLine("radians2: " + radians.ToString());
                degrees = radians * (180 / Math.PI);

                System.Console.WriteLine("delta X: " + deltaX.ToString());
                System.Console.WriteLine("delta y: " + deltaY.ToString());

                degrees += 270.0f;
                if (degrees >= 360)
                {
                    degrees -= 360.0f;
                }
            

            return (int)Math.Ceiling(degrees);
        }

    // ************************************************************************************************
      // ................................................................................................
      # region Get Key Information
      public void getKeyStates()
      {
         // InputSimulator.IsKeyDownAsync(
      }
      #endregion

      #region Start of movement commands

      // Set center of screen for all movement
      public static void moveToScreenCenter()
      {
          WinHandleMethods winHandle = new WinHandleMethods(CharacterObject.gameWindowName);

          WinHandleMethods.RECT rect = winHandle.getGameWindowSize(5392);
          int centerX = (rect.Right) / 2;
          int centerY = (rect.Bottom) / 2;
          MessageBox.Show(rect.Right.ToString());
          MouseActions.MoveTo(centerX, centerY);
      }

    // ***********************************************************************************

    public static void leftClickMouse()
    {
        MouseActions.LeftClick();
    }

    // ***********************************************************************************

    public static void moveForward()
    {
        setGameWindowFocus(0);
        InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_A);
        System.Threading.Thread.Sleep(10);
        InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_A);
    }

    public static void startMoveForward()
    {
        setGameWindowFocus(0);
        InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_A);
        
    }

    public static void stopMoveForward()
    {
        setGameWindowFocus(0);
        InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_A);
    }

    // ***********************************************************************************

    public static void moveBackward()
    {
        setGameWindowFocus(0);
        InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_S);
        System.Threading.Thread.Sleep(20);
        InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_S);
    }

    public static void startMoveBackward()
    {
        setGameWindowFocus(0);
        InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_S);
    }

    public static void stopMoveBackward()
    {
        setGameWindowFocus(0);
        InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_S);
    }

    // ***********************************************************************************
    public static void turnLeft()
    {
        setGameWindowFocus(0);
        InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_D);
        System.Threading.Thread.Sleep(10);
        InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_D);
        //InputSimulator.SimulateKeyDown(VirtualKeyCode.RBUTTON);
        ////System.Threading.Thread.Sleep(1);
        //MouseActions.Move(-5, 0);
        ////InputSimulator.SimulateKeyUp(VirtualKeyCode.RBUTTON);
    }

    public static void startSeekLeft()
    {
        setGameWindowFocus(0);
        InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_D);
    }

    public static void stopSeekLeft()
    {
        setGameWindowFocus(0);
        InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_D);
    }

    // ***********************************************************************************

    public static void startSeekRight()
    {
        setGameWindowFocus(0);
        InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_F);
    }

    public static void stopSeekRight()
    {
        setGameWindowFocus(0);
        InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_F);
    }

    public static void turnRight()
    {
        bool down = false;
        setGameWindowFocus(0);
        InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_F);
        System.Threading.Thread.Sleep(100);
        InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_F);
    }
    // ***********************************************************************************

    public static void jump()
    {
        setGameWindowFocus(0);
        //InputSimulator.SimulateKeyDown(VirtualKeyCode.SPACE);
        //System.Threading.Thread.Sleep(200);
        //InputSimulator.SimulateKeyUp(VirtualKeyCode.SPACE);
        //InputSimulator.SimulateKeyPress(VirtualKeyCode.SPACE);
        //PressKey.Send_Key(PressKey.ScanCodeShort.SPACE, PressKey.KEYEVENTF.SCANCODE);
        PressKey.Send_Key(PressKey.ScanCodeShort.SPACE, PressKey.KEYEVENTF.SCANCODE);
        System.Threading.Thread.Sleep(200);
        //InputSimulator.SimulateKeyPress(VirtualKeyCode.SPACE);
    }

    public static void faceTarget()
    {
        setGameWindowFocus(0);
        PressKey.Send_Key(PressKey.ScanCodeShort.KEY_B, PressKey.KEYEVENTF.SCANCODE);
        System.Threading.Thread.Sleep(20);
        InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_B);
    }

    public static void faceNorth(CharacterObject charObj)
    {
        String x = (charObj.getCharacterX()).ToString();
        String y = (charObj.getCharacterY() - 1).ToString();

        PressKey.Send_Key(PressKey.ScanCodeShort.RETURN, PressKey.KEYEVENTF.SCANCODE);

        InputSimulator.SimulateKeyPress(VirtualKeyCode.DIVIDE);
        String inputString = "faceloc " + x + ", " + y;
        InputSimulator.SimulateTextEntry(inputString);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.RETURN);
    }

    public static void faceSouth(CharacterObject charObj)
    {
        String x = (charObj.getCharacterX()).ToString();
        String y = (charObj.getCharacterY() + 1).ToString();

        PressKey.Send_Key(PressKey.ScanCodeShort.RETURN, PressKey.KEYEVENTF.SCANCODE);

        InputSimulator.SimulateKeyPress(VirtualKeyCode.DIVIDE);
        String inputString = "faceloc " + x + ", " + y;
        InputSimulator.SimulateTextEntry(inputString);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.RETURN);
    }

    public static void faceEast(CharacterObject charObj)
    {
        String x = (charObj.getCharacterX() + 1).ToString();
        String y = (charObj.getCharacterY()).ToString();

        PressKey.Send_Key(PressKey.ScanCodeShort.RETURN, PressKey.KEYEVENTF.SCANCODE);

        InputSimulator.SimulateKeyPress(VirtualKeyCode.DIVIDE);
        String inputString = "faceloc " + x + ", " + y;
        InputSimulator.SimulateTextEntry(inputString);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.RETURN);
    }

    public static void faceWest(CharacterObject charObj)
    {
        String x = (charObj.getCharacterX() - 1).ToString();
        String y = (charObj.getCharacterY()).ToString();

        PressKey.Send_Key(PressKey.ScanCodeShort.RETURN, PressKey.KEYEVENTF.SCANCODE);

        InputSimulator.SimulateKeyPress(VirtualKeyCode.DIVIDE);
        String inputString = "faceloc " + x + ", " + y;
        InputSimulator.SimulateTextEntry(inputString);
        InputSimulator.SimulateKeyPress(VirtualKeyCode.RETURN);
    }

    // ***********************************************************************************

    #endregion

    // ************************************************************************************************

    // ***********************************************************************************

    public static void pressQuickbarNumber(String key, int processNumber)
    {
        setGameWindowFocus(processNumber);
        switch (key)
        {
            case "1":
                //PressKey.Send_Key(PressKey.ScanCodeShort.KEY_1, PressKey.KEYEVENTF.SCANCODE);
                //InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_1);
                //PressKey.Send_Key(PressKey.ScanCodeShort.KEY_1, PressKey.KEYEVENTF.KEYUP);
                InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_1);
                InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_1);
                break;
            case "2":
                PressKey.Send_Key(PressKey.ScanCodeShort.KEY_2, PressKey.KEYEVENTF.SCANCODE);
                InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_2);
                break;
            case "3":
                PressKey.Send_Key(PressKey.ScanCodeShort.KEY_3, PressKey.KEYEVENTF.SCANCODE);
                InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_3);
                break;
            case "4":
                PressKey.Send_Key(PressKey.ScanCodeShort.KEY_4, PressKey.KEYEVENTF.SCANCODE);
                InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_4);
                break;
            case "5":
                PressKey.Send_Key(PressKey.ScanCodeShort.KEY_5, PressKey.KEYEVENTF.SCANCODE);
                InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_5);
                break;
            case "6":
                PressKey.Send_Key(PressKey.ScanCodeShort.KEY_6, PressKey.KEYEVENTF.SCANCODE);
                InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_6);
                break;
            case "7":
                PressKey.Send_Key(PressKey.ScanCodeShort.KEY_7, PressKey.KEYEVENTF.SCANCODE);
                InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_7);
                break;
            case "8":
                PressKey.Send_Key(PressKey.ScanCodeShort.KEY_8, PressKey.KEYEVENTF.SCANCODE);
                InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_8);
                break;
            case "9":
                PressKey.Send_Key(PressKey.ScanCodeShort.KEY_9, PressKey.KEYEVENTF.SCANCODE);
                InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_9);
                break;
            case "0":
                PressKey.Send_Key(PressKey.ScanCodeShort.KEY_0, PressKey.KEYEVENTF.SCANCODE);
                InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_0);
                break;
            case "Ctrl 1":
                InputSimulator.SimulateKeyDown(VirtualKeyCode.CONTROL);
                pressQuickbarNumber("1", processNumber);
                System.Threading.Thread.Sleep(20);
                InputSimulator.SimulateKeyUp(VirtualKeyCode.CONTROL);
                break;
            case "Ctrl 2":
                InputSimulator.SimulateKeyDown(VirtualKeyCode.CONTROL);
                pressQuickbarNumber("2", processNumber);
                System.Threading.Thread.Sleep(20);
                InputSimulator.SimulateKeyUp(VirtualKeyCode.CONTROL);
                break;
            case "Ctrl 3":
                InputSimulator.SimulateKeyDown(VirtualKeyCode.CONTROL);
                pressQuickbarNumber("3", processNumber);
                System.Threading.Thread.Sleep(20);
                InputSimulator.SimulateKeyUp(VirtualKeyCode.CONTROL);
                break;
            case "Ctrl 4":
                InputSimulator.SimulateKeyDown(VirtualKeyCode.CONTROL);
                pressQuickbarNumber("4", processNumber);
                System.Threading.Thread.Sleep(20);
                InputSimulator.SimulateKeyUp(VirtualKeyCode.CONTROL);
                break;
            case "Ctrl 5":
                InputSimulator.SimulateKeyDown(VirtualKeyCode.CONTROL);
                pressQuickbarNumber("5", processNumber);
                System.Threading.Thread.Sleep(20);
                InputSimulator.SimulateKeyUp(VirtualKeyCode.CONTROL);
                break;
            case "Ctrl 6":
                InputSimulator.SimulateKeyDown(VirtualKeyCode.CONTROL);
                pressQuickbarNumber("6", processNumber);
                System.Threading.Thread.Sleep(20);
                InputSimulator.SimulateKeyUp(VirtualKeyCode.CONTROL);
                break;
            case "Ctrl 7":
                InputSimulator.SimulateKeyDown(VirtualKeyCode.CONTROL);
                pressQuickbarNumber("7", processNumber);
                System.Threading.Thread.Sleep(20);
                InputSimulator.SimulateKeyUp(VirtualKeyCode.CONTROL);
                break;
            case "Ctrl 8":
                InputSimulator.SimulateKeyDown(VirtualKeyCode.CONTROL);
                pressQuickbarNumber("8", processNumber);
                System.Threading.Thread.Sleep(20);
                InputSimulator.SimulateKeyUp(VirtualKeyCode.CONTROL);
                break;
            case "Ctrl 9":
                InputSimulator.SimulateKeyDown(VirtualKeyCode.CONTROL);
                pressQuickbarNumber("9", processNumber);
                System.Threading.Thread.Sleep(20);
                InputSimulator.SimulateKeyUp(VirtualKeyCode.CONTROL);
                break;
            case "Ctrl 0":
                InputSimulator.SimulateKeyDown(VirtualKeyCode.CONTROL);
                pressQuickbarNumber("0", processNumber);
                System.Threading.Thread.Sleep(20);
                InputSimulator.SimulateKeyUp(VirtualKeyCode.CONTROL);
                break;
            case "Shift 1":
                InputSimulator.SimulateKeyDown(VirtualKeyCode.SHIFT);
                pressQuickbarNumber("1", processNumber);
                System.Threading.Thread.Sleep(20);
                InputSimulator.SimulateKeyUp(VirtualKeyCode.SHIFT);
                break;
            case "Shift 2":
                InputSimulator.SimulateKeyDown(VirtualKeyCode.SHIFT);
                pressQuickbarNumber("2", processNumber);
                System.Threading.Thread.Sleep(20);
                InputSimulator.SimulateKeyUp(VirtualKeyCode.SHIFT);
                break;
            case "Shift 3":
                InputSimulator.SimulateKeyDown(VirtualKeyCode.SHIFT);
                pressQuickbarNumber("3", processNumber);
                System.Threading.Thread.Sleep(20);
                InputSimulator.SimulateKeyUp(VirtualKeyCode.SHIFT);
                break;
            case "Shift 4":
                InputSimulator.SimulateKeyDown(VirtualKeyCode.SHIFT);
                pressQuickbarNumber("4", processNumber);
                System.Threading.Thread.Sleep(20);
                InputSimulator.SimulateKeyUp(VirtualKeyCode.SHIFT);
                break;
            case "Shift 5":
                InputSimulator.SimulateKeyDown(VirtualKeyCode.SHIFT);
                pressQuickbarNumber("5", processNumber);
                System.Threading.Thread.Sleep(20);
                InputSimulator.SimulateKeyUp(VirtualKeyCode.SHIFT);
                break;
            case "Shift 6":
                InputSimulator.SimulateKeyDown(VirtualKeyCode.SHIFT);
                pressQuickbarNumber("6", processNumber);
                System.Threading.Thread.Sleep(20);
                InputSimulator.SimulateKeyUp(VirtualKeyCode.SHIFT);
                break;
            case "Shift 7":
                InputSimulator.SimulateKeyDown(VirtualKeyCode.SHIFT);
                pressQuickbarNumber("7", processNumber);
                System.Threading.Thread.Sleep(20);
                InputSimulator.SimulateKeyUp(VirtualKeyCode.SHIFT);
                break;
            case "Shift 8":
                InputSimulator.SimulateKeyDown(VirtualKeyCode.SHIFT);
                pressQuickbarNumber("8", processNumber);
                System.Threading.Thread.Sleep(20);
                InputSimulator.SimulateKeyUp(VirtualKeyCode.SHIFT);
                break;
            case "Shift 9":
                InputSimulator.SimulateKeyDown(VirtualKeyCode.SHIFT);
                pressQuickbarNumber("9", processNumber);
                System.Threading.Thread.Sleep(20);
                InputSimulator.SimulateKeyUp(VirtualKeyCode.SHIFT);
                break;
            case "Shift 0":
                InputSimulator.SimulateKeyDown(VirtualKeyCode.SHIFT);
                pressQuickbarNumber("0", processNumber);
                System.Threading.Thread.Sleep(20);
                InputSimulator.SimulateKeyUp(VirtualKeyCode.SHIFT);
                break;
            case "Alt 1":
                InputSimulator.SimulateKeyDown(VirtualKeyCode.MENU);
                pressQuickbarNumber("1", processNumber);
                System.Threading.Thread.Sleep(20);
                InputSimulator.SimulateKeyUp(VirtualKeyCode.MENU);
                break;
            case "Alt 2":
                InputSimulator.SimulateKeyDown(VirtualKeyCode.MENU);
                pressQuickbarNumber("2", processNumber);
                System.Threading.Thread.Sleep(20);
                InputSimulator.SimulateKeyUp(VirtualKeyCode.MENU);
                break;
            case "Alt 3":
                InputSimulator.SimulateKeyDown(VirtualKeyCode.MENU);
                pressQuickbarNumber("3", processNumber);
                System.Threading.Thread.Sleep(20);
                InputSimulator.SimulateKeyUp(VirtualKeyCode.MENU);
                break;
            case "Alt 4":
                InputSimulator.SimulateKeyDown(VirtualKeyCode.MENU);
                pressQuickbarNumber("4", processNumber);
                System.Threading.Thread.Sleep(20);
                InputSimulator.SimulateKeyUp(VirtualKeyCode.MENU);
                break;
            case "Alt 5":
                InputSimulator.SimulateKeyDown(VirtualKeyCode.MENU);
                pressQuickbarNumber("5", processNumber);
                System.Threading.Thread.Sleep(20);
                InputSimulator.SimulateKeyUp(VirtualKeyCode.MENU);
                break;
            case "Alt 6":
                InputSimulator.SimulateKeyDown(VirtualKeyCode.MENU);
                pressQuickbarNumber("6", processNumber);
                System.Threading.Thread.Sleep(20);
                InputSimulator.SimulateKeyUp(VirtualKeyCode.MENU);
                break;
            case "Alt 7":
                InputSimulator.SimulateKeyDown(VirtualKeyCode.MENU);
                pressQuickbarNumber("7", processNumber);
                System.Threading.Thread.Sleep(20);
                InputSimulator.SimulateKeyUp(VirtualKeyCode.MENU);
                break;
            case "Alt 8":
                InputSimulator.SimulateKeyDown(VirtualKeyCode.MENU);
                pressQuickbarNumber("8", processNumber);
                System.Threading.Thread.Sleep(20);
                InputSimulator.SimulateKeyUp(VirtualKeyCode.MENU);
                break;
            case "Alt 9":
                InputSimulator.SimulateKeyDown(VirtualKeyCode.MENU);
                pressQuickbarNumber("9", processNumber);
                System.Threading.Thread.Sleep(20);
                InputSimulator.SimulateKeyUp(VirtualKeyCode.MENU);
                break;
            case "Alt 0":
                InputSimulator.SimulateKeyDown(VirtualKeyCode.MENU);
                pressQuickbarNumber("0", processNumber);
                System.Threading.Thread.Sleep(20);
                InputSimulator.SimulateKeyUp(VirtualKeyCode.MENU);
                break;
            case "Tab":
                PressKey.Send_Key(PressKey.ScanCodeShort.TAB, PressKey.KEYEVENTF.SCANCODE);
                InputSimulator.SimulateKeyPress(VirtualKeyCode.TAB);
                break;
        }
    }

    public static void setGameWindowFocus(int processNumber)
    {
        WinHandleMethods winHandle = new WinHandleMethods(CharacterObject.gameWindowName);
        //winHandle.getGameWindowHandle(0);
        winHandle.setGameToFocusWindow();
    }


}