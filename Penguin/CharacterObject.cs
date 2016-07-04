using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using Penguin;
using System.Diagnostics;
using WindowsInput;
// *****
/**  Considerations:
-The Arrays contain two String values read from OCR for reach field (health, mana, location)
-If player uses a capture box for EACH health, mana and location value I'll have to make some changes
-to both the Arrays and the method to read the values in.



*/

// This class holds all of the characters attributes
// ** provide an update loop to reset these values
public class CharacterObject
{
    // ************************************************************************************************
    // .........................................Memory Offsets......................................

    public struct PlayerOffsets
    {
        public static uint PlayerFacing = 0x00aa9080; //d9be00
        public static uint PlayerWorldX = 0x22c6ccc;
        public static uint PlayerLocationX = 0x1B64180 + 0x1000;
        public static uint PlayerWorldY = 0x22c6cd0;
        public static uint PlayerLocationY = 0x1B64184 + 0x1000;
        public static uint PlayerLocationZ = 0x1B64188 + 0x1000;
        public static uint PlayerCurrentTarget = 0x108E570 + 0x1000;
        public static uint PlayerCurrentTargetHealth = 0x108E0FC + 0x1000;
        public static uint ChatLogData = 0x6C23CA;
        public static uint CurrentTargetID = 0x10A4E30;
        public static uint CurrentZone = 0xBEE784;
        public static uint StartOfPlayerStack = 0xaa9028;
        public static uint XworldOffset = 0x22c6ccc;
        public static uint YworldOffset = 0x22c6cd0; // this may be the same as XworldOffset

        // Temporary quest add
        public static uint questAdd = 0x00AC14E7 + 0x1000; // changes
    }

    private long gameBaseAddress = 0x00400000;
    public double distance;
    public float direction;
    public int questStep;
    public bool questContinue = false;
    public int currentDelta;

    // ************************************************************************************************
    // ......................................... Delegates / Events ...................................
    //
    // delegate to toggle various timers on/off in the Main form
    public delegate void StopStartTimers(object sender, EventArgs e);

    public event StopStartTimers UpdateUI;
    public event StopStartTimers TogglePathTimer;
    public event StopStartTimers ToggleFindTargetTimer;
    public event StopStartTimers ToggleFightingRoutineTimer;
    public event StopStartTimers ToggleTurnLeft;
    public event StopStartTimers ToggleTurnRight;
    public event StopStartTimers ToggleMoveForward;
    public event StopStartTimers TogglePictQuestLoop;
    public event StopStartTimers TapTurnLeft;
    public event StopStartTimers TapTurnRight;
    
    // ************************************************************************************************
    // .........................................Events and Instances...................................

    private List<CapturedPathingPoints> xpPath = new List<CapturedPathingPoints>();
    bool destinationReached = false;
    bool targetAcquired = false;
    

    // Hardcode this into Settings tab
    //public static String gameWindowName = "game.dll"; // daoc
    public static String gameWindowName = "Wow-64";


    // ************************************************************************************************
    // ........................................Locals.................................................. 

    //                      Initialize with *.ini
    //*** Temp locations
    private static float[] xLoc = { 34703f, 35312f, 34863f, 34043f, 33630f, 33372f };
    private static float[] yLoc = { 49842f, 50560f, 51163f, 51189f, 50753f, 50094f };

    // locals
    private int baseHP;
    private int currentHP;
    private int baseMana;
    private int currentMana;

    private static float currentWorldX; // coords on entire world map
    private static float XzoneOffset; // subtract from currentWorldX to get relative zone location
    private static float currentX;
    private static float YzoneOffset; // subtract from currentWorldY to get relative zone location
    private static float currentWorldY; // coords on entire world map
    private static float currentY;
    private static float currentZ;
    private static int currentFacing;
    private static String currentTargetName;
    private static int currentTargetID;
    private static int currentTargetHealth;
    private String currentQuestCount;
    private String currentZone;
    private StringBuilder questBytesString = new StringBuilder();

    public int nextStep = 1;
    public bool isCharMoving = false;
    public bool isTurning = false;
    public int destinationDirection;

    public string chatLogData;

    // for dragonscale loop
    public int index = 0;
    public int maxLoops = 100;
    // Remove later

    int lowestDistance;
    int distanceEpsilon = 0;
    DateTime now = DateTime.Now;
    DateTime safetyTimer;

    public CapturedPathingPoints turninDestination = new CapturedPathingPoints(47240.0f, 2771.0f);
    public CapturedPathingPoints porterDestination = new CapturedPathingPoints(46932.0f, 3058.0f);
    public CapturedPathingPoints creditDestination = new CapturedPathingPoints(45291.0f, 10538.0f);
    public CapturedPathingPoints backDestination = new CapturedPathingPoints(44923.0f, 6952.0f);

    CapturedPathingPoints destPoint = new CapturedPathingPoints();
    CapturedPathingPoints currentPoint = new CapturedPathingPoints(currentX, currentY); // Prime the Current Point

    // ************************************************************************************************
    // ................................................................................................

    // constructor
    public CharacterObject(String processName)
    {
        // should add an intializing constructor to help set the basic components
        // of the character
        
        // Opens game process for reading memory
        ReadGameMemory.OpenProcess(processName);

    }

    // ************************************************************************************************
    // ................................................................................................

    public void updateCharacter()
    {
        // Read game memory
        long facingAdd = (long)gameBaseAddress + (long)PlayerOffsets.PlayerFacing;

        // ** hardcoded **

        long xAdd = gameBaseAddress + PlayerOffsets.PlayerLocationX;
        long worldXAdd = gameBaseAddress + PlayerOffsets.PlayerWorldX;
        long yAdd = gameBaseAddress + PlayerOffsets.PlayerWorldX;
        long worldYAdd = gameBaseAddress + PlayerOffsets.PlayerWorldY;
        long zAdd = gameBaseAddress + PlayerOffsets.PlayerLocationZ;
        long targetNameStringAdd = gameBaseAddress + PlayerOffsets.PlayerCurrentTarget;
        long targetHealthAdd = gameBaseAddress + PlayerOffsets.PlayerCurrentTargetHealth;
        long currentTargetIdAdd = gameBaseAddress + PlayerOffsets.CurrentTargetID;
        long currentZoneAdd = gameBaseAddress + PlayerOffsets.CurrentZone;

        long chatLogDataAdd = gameBaseAddress + PlayerOffsets.ChatLogData;
        //long currentTargetAdd = (long)

        //////////////////////////////////////////////////////////////////////
        /////////////      Temporary   ///////////////////////////////////////
        //////////////////////////////////////////////////////////////////////

        currentFacing = ReadGameMemory.readInt(PlayerOffsets.PlayerFacing);

        //////////////////////////////////////////////////////////////////////

        //currentX = ReadGameMemory.readFloat(xAdd);
        //currentY = ReadGameMemory.readFloat(yAdd);
        float worldX = ReadGameMemory.readFloat(PlayerOffsets.PlayerWorldX);
        float worldY = ReadGameMemory.readFloat(PlayerOffsets.PlayerWorldY);
        float XworldOffset = ReadGameMemory.readFloat(PlayerOffsets.XworldOffset);
        float YworldOffset = ReadGameMemory.readFloat(PlayerOffsets.YworldOffset);


        currentX = worldX - XworldOffset;
        currentY = worldY - YworldOffset;
        currentZ = Math.Abs(ReadGameMemory.readFloat(zAdd));
        currentTargetName = ReadGameMemory.ReadAsciiString(targetNameStringAdd, 100);
        currentTargetID = ReadGameMemory.readInt(currentTargetIdAdd);
        currentTargetHealth = ReadGameMemory.readInt(targetHealthAdd);
        currentQuestCount = null;
        currentQuestCount = ReadGameMemory.ReadAsciiString(PlayerOffsets.questAdd, 100);
        destinationDirection = MovementCommands.calculateDestinationDirection(currentPoint, destPoint);
        currentZone = ReadGameMemory.ReadAsciiString(PlayerOffsets.CurrentZone, 30).ToString();

        chatLogData = ReadGameMemory.ReadAsciiString(chatLogDataAdd, 100);

        //if (currentQuestCount.Length > 0 && currentQuestCount.Length > 3)
          //  currentQuestCount = currentQuestCount.Substring(0, 2); // Hack fix to resolve the appended "*" in string... Idk how i was getting that value


        UpdateCurrentPoint(currentX, currentY);
        UpdateDestDistance();

        UpdateUI(this, null); // Cross-Thread violation Calling this delegate from another thread
    }

    public void UpdateDestDistance()
    {
        distance = Math.Abs(Math.Floor(MovementCommands.calculateDistanceToNextPoint(currentPoint, destPoint)));
    }

    public void UpdateCurrentPoint(float x, float y)
    {
        currentPoint.x = x;
        currentPoint.y = y;
    }

    public void UpdateDestinationFacing()
    {
      
    }
    
    public void glassQuestLoop()
    {

    }

    //public void pictQuestLoop(int processNumber)
    //{
    //    //float turninDestinationX = 47275.0f;
    //    //float turninDestinationY = 2709.0f;
    //    CapturedPathingPoints turninDestination = new CapturedPathingPoints(47275.0f, 2709.0f);
    //    //float porterDestinationX = 44923.0f;
    //    //float porterDestinationY = 6990.0f;
    //    CapturedPathingPoints porterDestination = new CapturedPathingPoints(44923.0f, 6990.0f);
    //    //float creditDestinationX = 45101.0f;
    //    //float creditDestinationY = 10829.0f;
    //    CapturedPathingPoints creditDestination = new CapturedPathingPoints(45291.0f, 10538.0f);
    //    //float backDestinationX = 46994.0f;
    //    //float backDestinationY = 3050.0f;
    //    CapturedPathingPoints backDestination = new CapturedPathingPoints(46994.0f, 3050.0f);

        

    //    // Step 1 Start with quest accepted and near NPC quest giver
    //    // step 2 Face porter
    //    //      Run forward
    //    // Step 3 Say xp location keyword
    //    // Step 4 Face Credit location
    //    //      Run forward
    //    // step 5 Wait until 25/25
    //    // step 6 Face turnin porter
    //    //      Run forward
    //    // step 7 Say turnin keyword
    //    // step 8 Face xp turnin npc
    //    //      Run forward
    //    // step 9 Right click screen center
    //    // step 10 Left click screen center ( Finish button )
    //    // step 11 Left click screen center ( Accept button )

    //    //questContinue = true;

    //    //while (index < maxLoops)
    //    //{
    //    questStep = 0;

    //    // Step 1 

    //    questStep++; // 1

    //    // Step 2 (Press 1)
    //    System.Threading.Thread.Sleep(1000);
    //    MovementCommands.pressQuickbarNumber("1", processNumber);
    //    MovementCommands.pressQuickbarNumber("1");
    //    System.Threading.Thread.Sleep(1000);
    //    //TogglePictQuestLoop(this, null);

    //    questStep++; // 2

    //    // run toward backDestination
    //    destPoint = backDestination;
    //    runningRoutine(5);
    //    //TogglePictQuestLoop(this, null);

    //    //Step 3 ( Press 2 )
    //    System.Threading.Thread.Sleep(1000);
    //    MovementCommands.pressQuickbarNumber("2");
    //    MovementCommands.pressQuickbarNumber("2");
    //    System.Threading.Thread.Sleep(1000);
    //    //TogglePictQuestLoop(this, null);

    //    questStep++; // 3

    //    // Step 4 ( Press 3 )
    //    System.Threading.Thread.Sleep(1000);
    //    MovementCommands.pressQuickbarNumber("3");
    //    MovementCommands.pressQuickbarNumber("3");
    //    System.Threading.Thread.Sleep(1000);
    //    //TogglePictQuestLoop(this, null);

        

    //    //// running
    //    destPoint = creditDestination;
    //    runningRoutine(20);
    //    //TogglePictQuestLoop(this, null);

    //    questStep++; // 4

    //    // Step 5// Read from memory
    //    String questFinished = "25";
    //    updateCharacter();

    //    while (currentQuestCount != questFinished)
    //    {
    //        //Wait
    //        UpdateUI(this, null);
    //        updateCharacter();
    //        Thread.Sleep(1000);
    //    }
    //    //TogglePictQuestLoop(this, null);

    //    questStep++; // 5

    //    // Step 6
    //    Thread.Sleep(1000);
    //    MovementCommands.pressQuickbarNumber("4");
    //    MovementCommands.pressQuickbarNumber("4");
    //    Thread.Sleep(1000);
    //    //TogglePictQuestLoop(this, null);

    //    // Running Again
    //    destPoint = porterDestination;
    //    runningRoutine(20);
    //    //TogglePictQuestLoop(this, null);

    //    questStep++; // 6

    //    // Step 7
    //    System.Threading.Thread.Sleep(1000);
    //    MovementCommands.pressQuickbarNumber("5");
    //    MovementCommands.pressQuickbarNumber("5");
    //    System.Threading.Thread.Sleep(1000);
    //    //TogglePictQuestLoop(this, null);

    //    questStep++; // 7

    //    ////Step 8

    //        System.Threading.Thread.Sleep(1000);
    //        MovementCommands.pressQuickbarNumber("6");
    //        MovementCommands.pressQuickbarNumber("6");
    //        System.Threading.Thread.Sleep(1000);
    //        //TogglePictQuestLoop(this, null);

    //        //// running
    //        destPoint = turninDestination;
    //        runningRoutine(5);
    //        //TogglePictQuestLoop(this, null);

    //        //// Face Fionn for turnin
    //        System.Threading.Thread.Sleep(1000);
    //        MovementCommands.pressQuickbarNumber("7");
    //        MovementCommands.pressQuickbarNumber("7");
    //        System.Threading.Thread.Sleep(1000);
    //        //TogglePictQuestLoop(this, null);

    //        questStep++; // 8

    //        ////Step 9 ( Rt click screen center ) Start Npc dialog
    //        MovementCommands.moveToScreenCenter();
    //        MouseActions.RightClick();
    //        updateCharacter();

    //        now = DateTime.Now;
    //        safetyTimer = now.AddSeconds(15);
    //        //TogglePictQuestLoop(this, null);

    //        //if (currentTargetName == "Fionn mac Cumhaill")
    //        //{
    //        //    MovementCommands.pressQuickbarNumber("0");
    //        //}

    //        while (currentTargetName != "Fionn mac Cumhaill+")
    //        {
    //            updateCharacter();

    //            if (currentTargetName == "Fionn mac Cumhaill+")
    //                break;

    //            now = DateTime.Now;
    //            if (safetyTimer >= now)
    //            {
    //                MouseActions.Move(0, 5);
    //                Thread.Sleep(50);
    //                MouseActions.RightClick();
    //                Thread.Sleep(50);
    //                updateCharacter();
    //            }

    //            else
    //            {
    //                // Not Found Break
    //                break;
    //            }

    //        }

    //        //TogglePictQuestLoop(this, null);

    //        questStep++; // 9

    //        //// Step 10 ( Lt click screen center ) Finish Quest
    //        System.Threading.Thread.Sleep(1000);
    //        MouseActions.MoveTo(32750, 35550);
    //        System.Threading.Thread.Sleep(1000);
    //        MouseActions.LeftClick();
    //        System.Threading.Thread.Sleep(1000);

    //        questStep++; // 10

    //        //// Step 11 ( Lt click screen center ) Accept Quest
    //        System.Threading.Thread.Sleep(1000);
    //        MouseActions.MoveTo(32750, 35550);
    //        System.Threading.Thread.Sleep(1000);
    //        MouseActions.LeftClick();
    //        System.Threading.Thread.Sleep(1000);

    //        questStep++; // 11

    //        index++;
    //    ////}
    //}

    //public bool runningRoutine(int safety)
    //{
    //    MovementCommands.setGameWindowFocus();
    //    now = DateTime.Now;
    //    safetyTimer = now.AddSeconds(safety);
    //    lowestDistance = 9999; // prime this value

    //    // Move Forward 
    //    ToggleMoveForward(this, null); //Start Move Forward

    //    while (destinationReached == false) // && now < safetyTimer
    //    {
    //        now = DateTime.Now;

    //        if (distance <= distanceEpsilon || distance > lowestDistance) //
    //        {
    //            ToggleMoveForward(this, null); // Stop Move Forward
    //            destinationReached = true;
    //        }
    //        else if (distance < lowestDistance)
    //        {
    //            lowestDistance = (int)distance;
    //        }
    //    }

    //    destinationReached = false;
    //    return true;
    //}

    public void alignCharacterToDestination()
    {
        if (true)
        {
            currentDelta = (int)currentFacing +360 - destinationDirection;
            //currentDelta = (int)currentFacing - destinationDirection;
            //currentDelta = currentDelta - 180;

            //if (currentDelta <= 0)
            //{
            //    if (Math.Abs(currentDelta) <= 10)
            //    {

            //    }

            //    else
            //    {
            //        //TapTurnRight(this, null);
            //    }
            //}
            //else
            //{
            //    if (Math.Abs(currentDelta) <= 10)
            //    {

            //    }

            //    else
            //    {
            //        TapTurnLeft(this, null);
            //    }
            //}
        }

        if (currentFacing >= destinationDirection)
        {
            currentDelta = (int)currentFacing + 360  - destinationDirection;
            //currentDelta = currentDelta - 180;

            //if (currentDelta <= 0)
            //{
            //    if(Math.Abs(currentDelta) <= 10)
            //    {
            //        // Small tap
            //    }
            //    else
            //    {
            //        // Regular tap
            //        TapTurnLeft(this, null); 
            //    }
            //}
            //else
            //{
            //    //TapTurnRight(this, null);
            //}
        }
    }

    /// <Remove after refactoring movement events>
    /// 
    /// </summary>
    public void startMoveForward()
    {
        MovementCommands.startMoveForward();
        isCharMoving = true;
    }
    /// <Remove after refactoring movement events>
    /// 
    /// </summary>
    public void stopMoveForward()
    {
        MovementCommands.stopMoveForward();
        isCharMoving = false;
    }

    // ************************************************************************************************
    // ................................................................................................


    // ************************************************************************************************
    // ................................................................................................
    #region Getters
    // GETTERS

    public CapturedPathingPoints getXpPointAt(int index)
    {
        return xpPath.ElementAt(index);
    }

    public int getXpPathCount()
    {
        return xpPath.Count;
    }

    public int getQuestStep()
    {
        return questStep;
    }

    public double getLowestDistance()
    {
        return lowestDistance;
    }

    public string getQuestCountString()
    {
        return questBytesString.ToString();
    }

    public string getCurrentQuestCount()
    {
        return currentQuestCount;
    }

    public int getCharacterHPBase()
    {
        return baseHP;
    }

    public int getCharacterHPCurrent()
    {
        return currentHP;
    }

    public int getCharacterManaBase()
    {
        return baseMana;
    }

    public int getCharacterManaCurrent()
    {
        return currentMana;
    }

    public float getCharacterX()
    {
        return currentX;
    }

    public float getCharacterY()
    {
        return currentY;
    }

    public float getCharacterZ()
    {
        return currentZ;
    }

    public float getCharacterFacing()
    {
        return currentFacing;
    }

    public float getCharacterDestinationDirection()
    {
        return destinationDirection;
    }

    public double getDistanceToNextPoint()
    {
        return distance;
    }

    public String getTargetName()
    {
        return currentTargetName;
    }

    public int getTargetHealth()
    {
        return currentTargetHealth;
    }

    public float getDestX()
    {
        return destPoint.x;
    }

    public float getDestY()
    {
        return destPoint.y;
    }

    public float getDestZ()
    {
        return destPoint.z;
    }

    public int getCurrentFacingDelta()
    {
        return destinationDirection;
    }

    public bool getDestinationReachedBool()
    {
        return destinationReached;
    }

    public string getChatLogData()
    {
        return chatLogData;
    }

    public int getCurrentTargetID()
    {
        return currentTargetID;
    }

    public String getCurrentZone()
    {
        return currentZone;
    }

    public int getCurrentFacing()
    {
        return (int)currentFacing;
    }

    public int getDestinationDirection()
    {
        return destinationDirection;
    }

    #endregion

    // ************************************************************************************************
    // ................................................................................................

    #region Setters
    // SETTERS
    public void setDestPoint(CapturedPathingPoints destination)
    {
        destPoint = destination;
    }

    public void setCharacterHPBase(int baseHP)
    {
        this.baseHP = baseHP;
    }

    public void setCharacterHPCurrent(int currentHP)
    {
        this.currentHP = currentHP;
    }

    public void setCharacterManaBase(int baseMana)
    {
        this.baseMana = baseMana;
    }

    public void setCharacterManaCurrent(int currentMana)
    {
        this.currentMana = currentMana;
    }

    public void setLocationX(float x)
    {
        currentX = x;
    }

    public void setLocationY(float y)
    {
        currentY = y;
    }

    public void setLocationZ(float z)
    {
        currentZ = z;
    }

    public void setLocationFacing(int facing)
    {
        currentFacing = facing;
    }

    public void setDestinationReached(bool state)
    {
        destinationReached = state;
    }

    public void clearXpPath()
    {
        xpPath.Clear();
    }

    public void addXpPathDataPoint(CapturedPathingPoints capturedPoint)
    {
        xpPath.Add(capturedPoint);
    }
    #endregion


}