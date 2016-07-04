using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using System.Threading;
using WindowsInput;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
//using Interceptor;
using System.Diagnostics;

namespace Penguin
{
    public partial class Form1 : Form
    {
        ///* intercepter *///
        ///
        //input.MoveMouseTo(5, 5);  // Please note this doesn't use the driver to move the mouse; it uses System.Windows.Forms.Cursor.Position
        //input.MoveMouseBy(25, 25); //  Same as above ^
        //input.SendLeftClick();

        //input.KeyDelay = 1; // See below for explanation; not necessary in non-game apps
        //input.SendKeys(Keys.Enter);  // Presses the ENTER key down and then up (this constitutes a key press)

        //// Or you can do the same thing above using these two lines of code
        //input.SendKeys(Keys.Enter, KeyState.Down);
        //Thread.Sleep(1); // For use in games, be sure to sleep the thread so the game can capture all events. A lagging game cannot process input quickly, and you so you may have to adjust this to as much as 40 millisecond delay. Outside of a game, a delay of even 0 milliseconds can work (instant key presses).
        //input.SendKeys(Keys.Enter, KeyState.Up);

        //input.SendText("hello, I am typing!");

        ///* All these following characters / numbers / symbols work */
        //input.SendText("abcdefghijklmnopqrstuvwxyz");
        //input.SendText("1234567890");
        //input.SendText("!@#$%^&*()");
        //input.SendText("[]\\;',./");
        //input.SendText("{}|:\"<>?");


        //// And finally
        //input.Unload();

        //Input input = new Input();

        /////////////////////////////////////////////////
        int tempPID = 2016;
        int slot;
        int bag;
        bool on = false; // for Steer button

        // Points for the Salvage page

        // 17 pixel offset on X-axis
        public static Point slotOne = new Point(1753, 311);
        public static Point slotTwo = new Point(1753, 327);
        public static Point slotThree = new Point(1753, 345);
        public static Point slotFour = new Point(1753, 362);
        public static Point slotFive = new Point(1753, 378);
        public static Point slotSix = new Point(1753, 395);
        public static Point slotSeven = new Point(1753, 412);
        public static Point slotEight = new Point(1753, 429);

        public static Point[] slotArray = new Point[8] { slotOne, slotTwo, slotThree, slotFour, slotFive, slotSix, slotSeven, slotEight };

        // 26 pixel offset on Y-axis
        public static Point bagOne = new Point(1913, 321);
        public static Point bagTwo = new Point(1913, 347);
        public static Point bagThree = new Point(1913, 373);
        public static Point bagFour = new Point(1913, 399);
        public static Point bagFive = new Point(1913, 425);

        public static Point[] bagArray = new Point[5] { bagOne, bagTwo, bagThree, bagFour, bagFive };

        ///////////////////////////////////////////////

        // Private members for click methods
        bool seekForwardEnabled = false;
        bool seekLeftEnabled = false;
        bool seekRightEnabled = false;

        // Hardcode this into Settings tab
        String gameWindowName = "Wow-64";

        CharacterObject firstChar;
        private bool questContinue;
        private int maxLoops = 500;
        private int questLoopCounter = 1;
        private int xpPathIndex = 1;

        // for macro
        String secondButtonToPress;

        //Background worker thread
        BackgroundWorker backgroundWorker = new BackgroundWorker();
        BackgroundWorker alignmentWorker = new BackgroundWorker();
        BackgroundWorker runWorker = new BackgroundWorker();
        BackgroundWorker updateWorker = new BackgroundWorker();
        BackgroundWorker fightWorker = new BackgroundWorker();
        BackgroundWorker turnWorker = new BackgroundWorker();

        bool keepRunning = true;
        int sleepPause = 20;

        // ********************************************

        // ****** end *********************************

        // Default file name for temporary storage
        public static String FILENAME = "C:tempPathFile.bin";

        // for serializing the XpPathData Class
        // Saves the path data to a file, stored as binary
        BinaryFormatter binFormat = new BinaryFormatter();
        FileStream outFile = new FileStream(FILENAME, FileMode.Create, FileAccess.Write);

        static bool recordLabelIsVisible = false;   // recording label

        public Form1()
        {
            InitializeComponent();
            //input.Load();
            //input.KeyboardFilterMode = Interceptor.KeyboardFilterMode.All;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            firstChar = new CharacterObject("Wow-64");

            // Add Subscribers
            firstChar.UpdateUI += new CharacterObject.StopStartTimers(UpdateTimer_Tick);
            firstChar.ToggleTurnLeft += new CharacterObject.StopStartTimers(btnSeekLeft_Click);
            firstChar.ToggleTurnRight += new CharacterObject.StopStartTimers(btnSeekRight_Click);
            firstChar.ToggleMoveForward += new CharacterObject.StopStartTimers(btnSeekForward_Click);
            firstChar.TogglePictQuestLoop += new CharacterObject.StopStartTimers(DragonQuestTimer_Tick);
            firstChar.TapTurnLeft += new CharacterObject.StopStartTimers(btnLeft_Click);
            firstChar.TapTurnRight += new CharacterObject.StopStartTimers(btnRight_Click);

            // Background Worker Subscribers
            backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_Tasks);
            backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(backGroundWorker_ProgessChanged);
            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backGroundWorker_Completed);
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.WorkerReportsProgress = true;

            turnWorker.DoWork += new DoWorkEventHandler(turnWorker_Tasks);
            turnWorker.WorkerSupportsCancellation = true;
            turnWorker.WorkerReportsProgress = true;

            fightWorker.DoWork += new DoWorkEventHandler(fightWorker_Tasks);
            fightWorker.WorkerSupportsCancellation = true;
            fightWorker.WorkerReportsProgress = true;

            alignmentWorker.DoWork += new DoWorkEventHandler(alignmentWorker_DoWork);
            alignmentWorker.WorkerSupportsCancellation = true;

            runWorker.DoWork += new DoWorkEventHandler(runWorker_Tasks);
            runWorker.WorkerSupportsCancellation = true;

            updateWorker.DoWork += new DoWorkEventHandler(updateWorker_DoWork);

            if (!runWorker.IsBusy)
                backgroundWorker.RunWorkerAsync();

            //pctBoxLocation_Paint(this, null);

        }

        private void fightWorker_Tasks(object sender, DoWorkEventArgs e)
        {
            //addToUpdateBox("Entering FightWorker");
            //if (fightWorker.CancellationPending)
            //{
            //    e.Cancel = true;
            //    addToUpdateBox("Stopping Bot!!!");
            //    return;
            //}
            //else
            //{
            //    if (firstChar.getTargetHealth() != -1)
            //    {
            //        addToUpdateBox("FightWorker Tasks if");
            //        MovementCommands.pressQuickbarNumber("1");
            //        MovementCommands.pressQuickbarNumber("2");
            //        firstChar.updateCharacter();
            //        //Thread.Sleep(2000);
            //    }
            //    else
            //        addToUpdateBox("FightWorker Tasks else");
            //        fightWorker.CancelAsync();
            //}
        }

        private void turnWorker_Tasks(object sender, DoWorkEventArgs e)
        {
            while (firstChar.getCurrentFacing() != firstChar.getDestinationDirection())
            {
                firstChar.updateCharacter();
                firstChar.alignCharacterToDestination();
                if (turnWorker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

            }
        }

        private void updateWorker_DoWork(object sender, DoWorkEventArgs e)
        {

        }


        private void alignmentWorker_DoWork(Object sender, DoWorkEventArgs e)
        {
            setGameWindowFocus();
            while (Math.Abs(2100.0f - firstChar.getCharacterFacing()) > 200)
            {
                btnFaceTarget_Click(this, e);
                firstChar.updateCharacter();
            }
        }

        private void runWorker_Tasks(Object sender, DoWorkEventArgs e)
        {

            //if (rdoDragonLoop.Checked)
            //{
            //    while (keepRunning)
            //    {
            //        //firstChar.pictQuestLoop();
            //    }
            //}

            //if (rdoGlassLoop.Checked)
            //{
            //    //Start the xp path by updating the dest point 0
            //    //btnNextPoint_Click(this, null);

            //    for (int i = 0; i <= firstChar.getXpPathCount(); i++)
            //    {
            //        bool readyForNextStep = false;
            //        readyForNextStep = firstChar.runningRoutine(20);

            //        if (readyForNextStep)
            //        {
            //            //firstChar.setDestPoint(firstChar.getXpPointAt(i));
            //            btnNextPoint_Click(this, null);
            //            readyForNextStep = false;
            //        }
            //    }
            //}
        }

        private void backgroundWorker_Tasks(Object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            //lblDestinationReached.Text = "Updating...";
            //while (true)
            //{
            firstChar.updateCharacter();

            //System.Threading.Thread.Sleep(sleepPause);

            //}

        }

        private void backGroundWorker_ProgessChanged(Object sender, ProgressChangedEventArgs e)
        {
            this.updateBox.Items.Add(e.ProgressPercentage.ToString() + "%");
        }

        private void backGroundWorker_Completed(Object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {
                this.updateBox.Items.Add("Canceled!");
            }

            else if (!(e.Error == null))
            {
                this.updateBox.Items.Add("Error: " + e.Error.Message);
            }

            else
            {
                this.updateBox.Items.Add("Done!");
            }
        }

        private void SetText(Control control, string text)
        {
            if (control.InvokeRequired)
                this.Invoke(new Action<Control>((c) => c.Text = text), control);
            else
                control.Text = text;
        }

        // Focus main Window
        private void setGameWindowFocus()
        {
            WinHandleMethods winHandle = new WinHandleMethods(gameWindowName);
            //winHandle.getGameWindowHandle(processNumber);
            winHandle.setGameToFocusWindow();
        }


        // 0x8f8fff8 temp start address
        private void getAllPlayersData(long startAddress, long stopAddress)
        {
            long playerOffset = 0x1a08;
            startAddress -= playerOffset;

            long nameAdd = startAddress + 0x0;
            long targetIDAdd = startAddress + 0x0;
            long revolvingLinkIdAdd = startAddress + 0x0;
            long currentXAdd = 0x0;
            //long currentXAdd = 0xA0;
            //long currentXAdd = 0x24;
            long currentYAdd = 0x4;
            //long currentYAdd = 0x7C;
            //long currentYAdd = 0x0;
            long currentZAdd = 0x8;
            //long currentZAdd = 0xFC;
            long currentDirectionAdd = startAddress + 0x0;

            for (int i = 0; i < 100; i++)
            {
                //if (ReadGameMemory.readFloat(startAddress) > 0)
                {
                    float x = ReadGameMemory.readFloat(startAddress + currentXAdd);
                    float y = ReadGameMemory.readFloat(startAddress + currentYAdd);
                    float z = ReadGameMemory.readFloat(startAddress + currentZAdd);

                    float logicalX = x - ReadGameMemory.readFloat(0x14aa140);
                    float logicalY = y - ReadGameMemory.readFloat(0x14aa144);

                    //lstBoxPlayer.Items.Add(startAddress);
                    lstBoxPlayer.Items.Add("x: " + x);
                    //lstBoxPlayer.Items.Add(logicalX);
                    //lstBoxPlayer.Items.Add(currentYAdd);
                    lstBoxPlayer.Items.Add("y: " + y);
                    //lstBoxPlayer.Items.Add(logicalY);
                    //lstBoxPlayer.Items.Add(currentZAdd);
                    lstBoxPlayer.Items.Add("z: " + z);
                    //lstBoxPlayer.Items.Add(startAddress);
                    lstBoxPlayer.Items.Add(" ");
                    //startAddress = startAddress - playerOffset;
                    //lstBoxPlayer.Items.Add(currentMemoryAddress);
                }
            }

        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            ////firstChar.updateCharacter();            
            //// paint the labels with updated information
            //curX.Text = firstChar.getCharacterX().ToString();
            //curY.Text = firstChar.getCharacterY().ToString();
            //curZ.Text = firstChar.getCharacterZ().ToString();
            //lblCurrentFacing.Text = firstChar.getCharacterFacing().ToString();

            //lblTargetHealth.Text = firstChar.getTargetHealth().ToString();
            ////lblLowestDistance.Text = firstChar.distance.ToString();
            ////destDirectionLbl.Text = firstChar.getCharacterDestinationDirection().ToString();
            //lblDestinationDirection.Text = firstChar.getCurrentFacingDelta().ToString();
            //distanceLbl.Text = firstChar.getDistanceToNextPoint().ToString();
            //destX.Text = firstChar.getDestX().ToString();
            //destY.Text = firstChar.getDestY().ToString();
            //destZ.Text = firstChar.getDestZ().ToString();
            //lblCurrentFacingDelta.Text = firstChar.getCurrentFacingDelta().ToString();
            ////firstChar.pathingLoop(); // remove?
            //lblPathStep.Text = firstChar.nextStep.ToString();

            //String currentQuestString = firstChar.getCurrentQuestCount();
            //if (currentQuestString != null)
            //{
            //    lblCurrentQuestCount.Text = currentQuestString;
            //}

            //lblQuestStep.Text = firstChar.getQuestStep().ToString();
            //lblLowestDistance.Text = firstChar.getLowestDistance().ToString();
            //lblCurrentPoint.Text = firstChar.getDestX().ToString() + ", " + firstChar.getDestY().ToString();
            //lblPathIndex.Text = xpPathIndex.ToString();
            //lblCurrentZone.Text = firstChar.getCurrentZone();
            //lblCurrentDelta.Text = firstChar.currentDelta.ToString();

            //string currentTargetID = firstChar.getCurrentTargetID().ToString();
            //if (currentTargetID != lblTargetID.Text)
            //{
            //    lblTargetID.Text = currentTargetID;
            //}
            //// Clear for adding the chat box data
            ////updateBox.Items.Clear();
            //string chatLogData = firstChar.getChatLogData();
            //string[] logDataArray = chatLogData.Split(new Char[] { ' ' });

            //if (!updateBox.Items.Contains(chatLogData))
            //{
            //    if (logDataArray[0].Contains("The".ToString()) || logDataArray[0].Contains("You".ToString()))
            //    {
            //        addToUpdateBox(firstChar.getChatLogData());
            //    }
            //}

            //string newTargetText = firstChar.getTargetName();
            //if (lblTargetID.Text != newTargetText)
            //    lblCurrentTarget.Text = newTargetText;

            //if (turnWorker.IsBusy)
            //    lblTurnWorker.ForeColor = Color.Red;
            //else
            //    lblTurnWorker.ForeColor = Color.Black;

            //if (backgroundWorker.IsBusy)
            //    lblBackWorker.ForeColor = Color.Red;
            //else
            //    lblBackWorker.ForeColor = Color.Black;

            //if (fightWorker.IsBusy)
            //    lblFightWorker.ForeColor = Color.Red;
            //else
            //    lblFightWorker.ForeColor = Color.Black;

            //if (firstChar.getDestinationReachedBool())
            //{
            //    lblDestinationReached.ForeColor = Color.Red;
            //}
            //else
            //{
            //    lblDestinationReached.ForeColor = Color.Black;
            //}

            //if (firstChar.getXpPathCount() > 0)
            //{
            //    btnNextPoint.Enabled = true;
            //}
            //else
            //    btnNextPoint.Enabled = false;

            //if (FightLoopTimer.Enabled)
            //    lblFightTimerStatus.ForeColor = Color.Red;
            //else
            //    lblFightTimerStatus.ForeColor = Color.Black;
        }

        private void startBot_Click(object sender, EventArgs e)
        {
            if (UpdateTimer.Enabled == true)
            {
                UpdateTimer.Enabled = false;
                pathingLoopTimer.Enabled = false;
                //alignmentWorker.CancelAsync();

                startBot.Text = "Start";
                startBot.BackColor = Color.White;
            }
            else
            {

                setGameWindowFocus();
                Thread.Sleep(500);
                UpdateTimer.Enabled = true;
                pathingLoopTimer.Enabled = true;
                //alignmentWorker.RunWorkerAsync();

                startBot.Text = "Stop";
                startBot.BackColor = Color.Red;
                firstChar.nextStep = 1;
                firstChar.setDestinationReached(false);
            }
        }

        private void MakePathTimer_Tick(object sender, EventArgs e)
        {
            // Recording Label
            if (recordLabelIsVisible == false)
            {
                recordingLabel.Visible = true;
                recordLabelIsVisible = true;
                btnAddWaypoint_Click(this, e);
            }
            else
            {
                recordingLabel.Visible = false;
                recordLabelIsVisible = false;
            }

            // Add path data to the list
            //xpPath.setPointInPathList(firstChar.thisCapturedPathingPoint);
            //testListBox();
        }

        private void makePathButton_Click_1(object sender, EventArgs e)
        {
            recordingLabel.Visible = false;

            if (MakePathTimer.Enabled == false)
            {
                MakePathTimer.Enabled = true;
            }
            else
            {
                MakePathTimer.Enabled = false;
            }
        }

        private void loadPathButton_Click(object sender, EventArgs e)
        {
            // Creates a new Openfiledialog object to open a dialog window
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
        }

        private void savePathButton_Click(object sender, EventArgs e)
        {
            //  binFormat.Serialize(outFile, xpPath);

            //// Creates a new Savefiledialog object to open a dialog window
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.ShowDialog();
        }

        private void btnFoward_Click(object sender, EventArgs e)
        {
            //MovementCommands.moveForward();
            setGameWindowFocus();
            for (int i = 0; i < 30; i++)
            {
                //input.SendKey(Interceptor.Keys.A);
                InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_A);

                System.Threading.Thread.Sleep(30);
            }
            System.Threading.Thread.Sleep(10);
            InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_A);

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            setGameWindowFocus();
            //MovementCommands.turnLeft();
            //PressKey.Post_Message(PressKey.ScanCodeShort.KEY_D, PressKey.PMKEYEVENTF.KEY_DOWN, 0);
            MovementCommands.turnLeft();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            setGameWindowFocus();
            MovementCommands.turnRight();
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            setGameWindowFocus();
            MovementCommands.moveBackward();
        }

        private void togglePathingBtn_Click(object sender, EventArgs e)
        {
            if (pathingToggleBtn.ForeColor == SystemColors.ControlText)
            {
                pathingLoopTimer.Enabled = true;
                //findTargetTimer.Enabled = true;
                pathingToggleBtn.ForeColor = SystemColors.ControlLight;
            }

            else
            {
                pathingLoopTimer.Enabled = false;
                //findTargetTimer.Enabled = false;
                pathingToggleBtn.ForeColor = SystemColors.ControlText;
            }
        }

        private void btnAddWaypoint_Click(object sender, EventArgs e)
        {
            firstChar.updateCharacter();
            addToUpdateBox(firstChar.getCharacterX().ToString() + ", " + firstChar.getCharacterY().ToString());
            firstChar.addXpPathDataPoint(new CapturedPathingPoints(firstChar.getCharacterX(), firstChar.getCharacterY()));
            setGameWindowFocus();
        }

        private void addToUpdateBox(String str)
        {
            updateBox.Items.Add(str);
            updateBox.SelectedIndex = updateBox.Items.Count - 1;
            updateBox.ClearSelected();
        }

        private void btnClearPathList(object sender, EventArgs e)
        {
            updateBox.Items.Clear();
        }

        private void pathingToggleBtn_MouseHover(object sender, EventArgs e)
        {
            pathingToggleBtn.Focus();
        }

        private void btnSetPathList_Click(object sender, EventArgs e)
        {


        }

        private void findTargetTimer_Tick(object sender, EventArgs e)
        {

        }

        private void btnStartKillRoutine_Click(object sender, EventArgs e)
        {
            fightWorker.RunWorkerAsync();
            //addToUpdateBox("Entering btnStartKillRoutine");
            //haveCharPullTarget("Bow");
            //if (chkBoxFightEnabled.Checked)
            //{
            //    // Start fight Timer
            //    //FightLoopTimer.Enabled = true;
            //    chkBoxFightEnabled.ForeColor = Color.Red;
            //    // Run the fight routine
            //    if (!fightWorker.IsBusy)
            //        fightWorker.RunWorkerAsync();
            //}
            //if (!chkBoxFightEnabled.Checked)
            //{
            //    // Stop the timer
            //    //FightLoopTimer.Enabled = false;
            //    chkBoxFightEnabled.ForeColor = Color.Black;
            //    // Stop the fight routine
            //    fightWorker.CancelAsync();
            //}

        }

        private void DragonQuestTimer_Tick(object sender, EventArgs e)
        {
            updateBox.Items.Add("working");
        }

        private void btnJump_Click(object sender, EventArgs e)
        {
            MovementCommands.jump();
        }

        private void btnSeekLeft_Click(object sender, EventArgs e)
        {
            if (seekLeftEnabled)
            {
                seekLeftEnabled = false;
                MovementCommands.stopSeekLeft();
                btnSeekLeft.BackColor = Color.Silver;
                btnSeekLeft.Text = "Off";
            }
            else
            {
                seekLeftEnabled = true;

                if (seekRightEnabled)
                    btnSeekRight_Click(this, null);

                MovementCommands.startSeekLeft();
                btnSeekLeft.BackColor = Color.Pink;
                btnSeekLeft.Text = "Off";
            }
        }

        private void btnSeekRight_Click(object sender, EventArgs e)
        {
            if (seekRightEnabled)
            {
                seekRightEnabled = false;
                MovementCommands.stopSeekRight();
                btnSeekRight.BackColor = Color.Silver;
                btnSeekRight.Text = "Off";
            }
            else
            {
                seekRightEnabled = true;

                if (seekLeftEnabled)
                    btnSeekLeft_Click(this, null);

                MovementCommands.startSeekRight();
                btnSeekRight.BackColor = Color.Pink;
                btnSeekRight.Text = "On";
            }
        }

        private void btnSeekForward_Click(object sender, EventArgs e)
        {
            if (seekForwardEnabled)
            {
                seekForwardEnabled = false;
                MovementCommands.stopMoveForward();
                btnSeekForward.BackColor = Color.Silver;
                btnSeekForward.Text = "Off";
            }
            else
            {
                seekForwardEnabled = true;
                MovementCommands.startMoveForward();
                btnSeekForward.BackColor = Color.Pink;
                btnSeekForward.Text = "On";
            }
        }

        private void btnThreadStart_Click(object sender, EventArgs e)
        {
            // Wait for user to alt tab main screen for full-screen mode
            //Thread.Sleep(1000);

            if (btnThreadStart.ForeColor == SystemColors.ControlText)
            {
                backgroundWorker.RunWorkerAsync();
                UpdateTimer.Enabled = true;
                // for hack ** Remove **
                runWorker.RunWorkerAsync();
                btnThreadStart.ForeColor = SystemColors.ControlDark;
                if (runWorker.IsBusy != true)
                    runWorker.RunWorkerAsync();
                if (turnWorker.IsBusy != true)
                    turnWorker.RunWorkerAsync();

                btnThreadStart.Text = "Running";
                questContinue = true;

            }

            else
            {
                if (backgroundWorker.WorkerSupportsCancellation)
                {
                    backgroundWorker.CancelAsync();
                    UpdateTimer.Enabled = false;
                    btnThreadStart.ForeColor = SystemColors.ControlText;
                    runWorker.CancelAsync();
                    turnWorker.CancelAsync();
                    turnWorker.Dispose();
                    btnThreadStart.Text = "Workers";
                    questContinue = false;
                }
            }
        }

        private void btnMakePath_Click(object sender, EventArgs e)
        {
            if (MakePathTimer.Enabled)
            {
                MakePathTimer.Enabled = false;
            }
            else
            {
                MakePathTimer.Enabled = true;
            }
        }

        private void btnNorth_Click_1(object sender, EventArgs e)
        {
            //MovementCommands.setGameWindowFocus(0);
            //MovementCommands.faceNorth(firstChar);
            setGameWindowFocus();
            //input.SendKey(Interceptor.Keys.A, KeyState.Down);
            //input.KeyPressDelay = 40;
            //input.SendKey(Interceptor.Keys.A, KeyState.Up);
        }

        private void btnWest_Click_1(object sender, EventArgs e)
        {
            //MovementCommands.setGameWindowFocus(0);
            //MovementCommands.faceWest(firstChar);
            setGameWindowFocus();
            //input.SendKey(Interceptor.Keys.D);
        }

        private void btnEast_Click_1(object sender, EventArgs e)
        {
            //MovementCommands.setGameWindowFocus(0);
            //MovementCommands.faceEast(firstChar);
            setGameWindowFocus();
            //input.SendKey(Interceptor.Keys.F);
        }

        private void btnSouth_Click_1(object sender, EventArgs e)
        {
            //MovementCommands.setGameWindowFocus(0);
            //MovementCommands.faceSouth(firstChar);
            setGameWindowFocus();

        }

        private void btnCtrl1_Click_1(object sender, EventArgs e)
        {
            MovementCommands.setGameWindowFocus(0);
            MovementCommands.pressQuickbarNumber("Ctrl 1", 0);
        }

        private void btnShift1_Click_1(object sender, EventArgs e)
        {
            MovementCommands.setGameWindowFocus(0);
            MovementCommands.pressQuickbarNumber("Shift 1", 0);
        }

        private void btnNextPoint_Click(object sender, EventArgs e)
        {
            if (xpPathIndex < firstChar.getXpPathCount() - 1)
                xpPathIndex++;
            else
                xpPathIndex = 1;

            firstChar.setDestPoint(firstChar.getXpPointAt(xpPathIndex - 1));
            //firstChar.runningRoutine(20);
        }

        private void btnClearXpPath_Click(object sender, EventArgs e)
        {
            firstChar.clearXpPath();
        }

        private void FightLoopTimer_Tick(object sender, EventArgs e)
        {
            addToUpdateBox("Entering FightLoopTimer_Tick");
            if (!fightWorker.IsBusy)
            {
                fightWorker.RunWorkerAsync();
                addToUpdateBox("Starting fight work");
            }
            else
            {
                addToUpdateBox("fightWorker is busy..");
            }

        }

        private void haveCharPullTarget(String typeOfPull)
        {
            //face target

            MovementCommands.faceTarget();

            if (typeOfPull == "Bow")
            {
                int shootBowPause = 5000;
                //wield bow
                MovementCommands.pressQuickbarNumber("Alt 0", 0);
                //draw bow
                MovementCommands.pressQuickbarNumber("Alt 0", 0);
                //shoot arrow
                MovementCommands.pressQuickbarNumber("Alt 0", 0);

                // wait to switch to main weapon
                Thread.Sleep(shootBowPause);
                // main weapon
                MovementCommands.pressQuickbarNumber("Alt 9", 0);

            }

            if (typeOfPull == "Spell")
            {
                // cast spell
            }

        }

        private void lblTargetHealth_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCurrentTarget_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTargetID_TextChanged(object sender, EventArgs e)
        {
            addToUpdateBox("Entering lblTargetID_TextChanged");
            if (lblTargetHealth.Text == "-1")
            {
                FightLoopTimer.Enabled = false;
                addToUpdateBox(FightLoopTimer.Enabled.ToString());
            }
            else
            {
                if (!FightLoopTimer.Enabled)
                {
                    addToUpdateBox("Enabling Fight Timer");
                    FightLoopTimer.Enabled = true;
                    addToUpdateBox(FightLoopTimer.Enabled.ToString());
                }
                else
                    addToUpdateBox("Still looping on change");

            }
        }

        private void btnToggleMacro_Click(object sender, EventArgs e)
        {
            //switch (trkBarDelay.Value)
            //{
            //    case 0:
            //        MacroTimer.Interval = 2000;
            //        break;
            //    case 1:
            //        MacroTimer.Interval = 5000;
            //        break;

            //}
            double txtValue = Double.Parse(txtBoxDelay.Text);
            txtValue = txtValue * 1000;
            int delayInterval = (int)(txtValue);
            MacroTimer.Interval = delayInterval; // Sets the value of the delay from the trackbar

            if (txtBoxFirstKeyToPress.Text == "Tab")
            {
                MovementCommands.pressQuickbarNumber("Tab", 0);
            }
            secondButtonToPress = txtBoxKeyToPress.Text; // Sets the key

            //MovementCommands.pressQuickbarNumber(secondButtonToPress, 0);
            //input.SendKey(Interceptor.Keys.One);
            Thread.Sleep(100);

            if (txtBoxKeyTwo.Text != null)
            {
                string keyToPress = txtBoxKeyTwo.Text;
                MovementCommands.pressQuickbarNumber(keyToPress, 0);
                Thread.Sleep(100);
            }

            if (txtBoxKeyThree.Text != null)
            {
                string keyToPress = txtBoxKeyThree.Text;
                MovementCommands.pressQuickbarNumber(keyToPress, 0);
                Thread.Sleep(100);
            }

            if (txtBoxKeyFour.Text != null)
            {
                string keyToPress = txtBoxKeyFour.Text;
                MovementCommands.pressQuickbarNumber(keyToPress, 0);
                Thread.Sleep(100);
            }

            if (MacroTimer.Enabled)
            {
                MacroTimer.Enabled = false;
                btnToggleMacro.Text = "Off";
            }
            else
            {
                MacroTimer.Enabled = true;
                btnToggleMacro.Text = "On";
            }

        }

        private void MacroTimer_Tick(object sender, EventArgs e)
        {
            MovementCommands.pressQuickbarNumber(txtBoxFirstKeyToPress.Text, 0);
            MovementCommands.pressQuickbarNumber(secondButtonToPress, 0);
        }

        private void pctBoxLocation_Paint(object sender, PaintEventArgs e)
        {

            int width = 65535;
            int height = 65535;

            // ************ Steps to make this work propertly **********
            //
            //              Need to save the image into a larger resolution
            //              Load the image into the picture box

            // All of this should go into another method
            // Reference to graphics object
            Graphics gfx = e.Graphics;

            Point polyOne = new Point(10, 0);
            Point PolyTwo = new Point(0, 10);
            Point PolyThree = new Point(20, 10);

            Point[] polyArray = { polyOne, PolyTwo, PolyThree };

            SolidBrush ltGraySolidBrush = new SolidBrush(Color.LightGray);
            SolidBrush blackSolidBrush = new SolidBrush(Color.Black);

            Pen blackPen = new System.Drawing.Pen(blackSolidBrush);

            Rectangle backgroundRect = new Rectangle(new Point(0, 0), new Size(width, height));
            //gfx.FillRectangle(ltGraySolidBrush, backgroundRect);
            //gfx.DrawEllipse(blackPen, new Rectangle(new Point(250, 10), new Size(5, 5)));
            //gfx.FillPolygon(blackSolidBrush,polyArray , FillMode.Alternate);
        }

        private void pathingLoopTimer_Tick(object sender, EventArgs e)
        {
            firstChar.updateCharacter();
            firstChar.alignCharacterToDestination();

        }

        private void btnSaveScreenShot_Click(object sender, EventArgs e)
        {
            string filename = "ClickFinder.png";
            MovementCommands.setGameWindowFocus(0);

            this.WindowState = FormWindowState.Minimized;
            Thread.Sleep(500);
            Bitmap screenShot = CaptureScreenShot();
            this.WindowState = FormWindowState.Normal;

            screenShot.Save(filename, ImageFormat.Png);
            //MessageBox.Show("Picture Taken!");
            btnCloseForm fullScreenFormWindow = new btnCloseForm();
            fullScreenFormWindow.Show();
            fullScreenFormWindow.WindowState = FormWindowState.Maximized;
            fullScreenFormWindow.BackgroundImage = screenShot;
            //fullScreenFormWindow.Focus();

        }

        private Bitmap CaptureScreenShot()
        {
            // get the screen size
            Rectangle bounds = Screen.GetBounds(Point.Empty);

            // create the empty bitmap canvas
            Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height);

            using (Graphics gr = Graphics.FromImage(bitmap))
            {
                gr.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
            }

            return bitmap;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (btnSalvage.Text == "Salvage is Off")
            {
                btnSalvage.Text = "Salvage is On";
                SalvageTimer.Enabled = true;
                setGameWindowFocus();
                float resPatchX = 34.1328125f;
                float resPatchY = 60.6805556f;

                // comparison will be equal to the number of the bags being used 
                // ie if we want bags 1,2,3,4; numOfBags = 4
                for (int i = 0; i < 4; i++)
                {
                    MouseActions.MoveTo(((int)(resPatchX * bagArray[i].X)), ((int)(resPatchY * bagArray[i].Y)));
                    MouseActions.LeftClick();
                    Thread.Sleep(1000);

                    // Inner loop for iterating through each page of bag slots
                    // ie bags 1 - 8; 0 - 7
                    for (int j = 0; j < 8; j++)
                    {
                        MouseActions.MoveTo(((int)(resPatchX * slotArray[j].X)), ((int)(resPatchY * slotArray[j].Y)));
                        MouseActions.RightClick();
                        Thread.Sleep(1000);
                        MouseActions.MoveTo((int)(1698 * resPatchX), (int)(resPatchY * 141));
                        MouseActions.LeftClick();
                        Thread.Sleep(17000);
                    }
                }

            }

            else
            {
                btnSalvage.Text = "Salvage is Off";
                SalvageTimer.Enabled = false;
            }
        }

        private void btnSetPrice_Click(object sender, EventArgs e)
        {
            setGameWindowFocus();
            for (int start = Int32.Parse(txtBoxStart.Text); start <= Int32.Parse(txtBoxEnd.Text); start++)
            {
                PressKey.Send_Key(PressKey.ScanCodeShort.OEM_2, PressKey.KEYEVENTF.SCANCODE);
                Thread.Sleep(100);
                InputSimulator.SimulateKeyUp(VirtualKeyCode.OEM_2);
                Thread.Sleep(100);
                InputSimulator.SimulateTextEntry("setprice " + start.ToString() + " " + Int32.Parse(txtBoxPrice.Text));
                Thread.Sleep(100);
                PressKey.Send_Key(PressKey.ScanCodeShort.RETURN, PressKey.KEYEVENTF.SCANCODE);
                Thread.Sleep(100);
                InputSimulator.SimulateKeyUp(VirtualKeyCode.RETURN);
                Thread.Sleep(100);
            }
        }

        private void btnPictQuest_Click(object sender, EventArgs e)
        {
            //while(true)
            //firstChar.pictQuestLoop();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            lstBoxPlayer.Items.Clear();
            long start = 0x08f8fff8;
            long start2 = 0x08f96444;
            long startLogicalXY = 0x290b0aa0;
            long stop = 0x08f82bdc;
            //tmrPlayerStackTest.Enabled = true;
            //getAllPlayersData(start, stop );
            for (int i = 0; i < 10; i++)
            {
                float x = ReadGameMemory.readFloat(0x22c5e6c);
                float xOffset = ReadGameMemory.readFloat(0x14aa144);
                float logicalX = x - xOffset;

                float y = ReadGameMemory.readFloat(0x22c5e70);
                float yOffset = ReadGameMemory.readFloat(0x14aa140);
                float logicalY = y - yOffset;

                int dir = ReadGameMemory.readInt(0xaa8c20);

                lstBoxPlayer.Items.Add(logicalX);
                //lstBoxPlayer.Items.Add(xOffset);
                lstBoxPlayer.Items.Add(logicalY);
                //lstBoxPlayer.Items.Add(yOffset);

                lstBoxPlayer.Items.Add(dir);
            }
        }

        private void tmrPlayerStackTest_Tick(object sender, EventArgs e)
        {
            updatePlayerStack(0xaa90dc, 200);
        }

        private void updatePlayerStack(long startAddress, int numOfPlayers)
        {
            lstBoxPlayer.Items.Clear();
            //lstBoxAlb.Items.Clear();
            lstBoxHib.Items.Clear();
            for (int i = 0; i < numOfPlayers; i++)
            {
                string bufferString = "";

                byte isActive = ReadGameMemory.readByte(startAddress - 0x4);
                if (isActive != 0xFF)
                {
                    bufferString = ReadGameMemory.ReadAsciiString(startAddress, 50);
                }

                //if (bufferString == "Inconnu" || bufferString == "Highlander" || bufferString == "Avalonian" || bufferString == "Half Ogre" || bufferString == "Saracen" || bufferString == "Briton" || bufferString == "Korazh")
                //    lstBoxAlb.Items.Add(bufferString);
                if (bufferString == "Lurikeen" || bufferString == "Firbolg" || bufferString == "Celt" || bufferString == "Shar" || bufferString == "Graoch" || bufferString == "Sylvan" || bufferString == "Elf")
                    lstBoxHib.Items.Add(bufferString);
                else if (bufferString == "Frostalf" || bufferString == "Deifrang" || bufferString == "Kobold" || bufferString == "Troll" || bufferString == "Valkyn" || bufferString == "Dwarf" || bufferString == "Norseman")
                    lstBoxPlayer.Items.Add(bufferString);
                else if (bufferString != "")
                    lstBoxPlayer.Items.Add(bufferString);
                startAddress += 0xB0;
                bufferString = "";
                //buffer = null;
            }
            lstBoxPlayer.Sorted = true;
            lstBoxPlayer.Items.Add(lstBoxPlayer.Items.Count.ToString());
            //lstBoxAlb.Items.Add(lstBoxAlb.Items.Count.ToString());
            lstBoxHib.Items.Add(lstBoxHib.Items.Count.ToString());
            int playerCount = lstBoxPlayer.Items.Count;
            if (playerCount == 1)
                lstBoxPlayer.BackColor = SystemColors.Window;
            else
                lstBoxPlayer.BackColor = Color.LightBlue;

            //if (lstBoxAlb.Items.Count > 1)
            //    lstBoxAlb.BackColor = Color.LightBlue;
            //else
            //    lstBoxAlb.BackColor = SystemColors.Window;

            if (lstBoxHib.Items.Count != 1)
                lstBoxHib.BackColor = Color.LightBlue;
            else
                lstBoxHib.BackColor = SystemColors.Window;

        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            //setGameWindowFocus(0);
            //Thread.Sleep(50);
            //MovementCommands.pressQuickbarNumber("3", 0);
            //Thread.Sleep(200);
            //MovementCommands.pressQuickbarNumber("1", 0);
            //Thread.Sleep(50);
            setGameWindowFocus();
        }

        private void btnFollow_Click(object sender, EventArgs e)
        {
            setGameWindowFocus();
            Thread.Sleep(50);
            MovementCommands.pressQuickbarNumber("3", 0);
            Thread.Sleep(200);
            MovementCommands.pressQuickbarNumber("0", 0);
            Thread.Sleep(100);
            this.Show();
            Thread.Sleep(200);
            setGameWindowFocus();
        }

        private void btnFaceTarget_Click(object sender, EventArgs e)
        {
            int tooFar = 0;
            setGameWindowFocus();
            firstChar.updateCharacter();
            float hardCodeFacing = firstChar.getCharacterDestinationDirection();
            float facingDelta = Math.Abs(2100.0f - firstChar.getCharacterFacing());
            lblDestinationDirection.Text = hardCodeFacing.ToString();
            //updateBox.Items.Add(facingDelta.ToString());

            //input.SendKey(Interceptor.Keys.D, KeyState.Down);
            //input.SendKey(Interceptor.Keys.D, KeyState.Down);
            //input.SendKey(Interceptor.Keys.D, KeyState.Down);
            //input.SendKey(Interceptor.Keys.D, KeyState.Down);
            //input.SendKey(Interceptor.Keys.D, KeyState.Down);
            //input.SendKey(Interceptor.Keys.D, KeyState.Down);
            //input.SendKey(Interceptor.Keys.D, KeyState.Down);

            //firstChar.updateCharacter();
            //facingDelta = Math.Abs(2100.0f - firstChar.getCharacterFacing());
            //lblCurrentFacingDelta.Text = facingDelta.ToString();

            //input.SendKey(Interceptor.Keys.D, KeyState.Up);

        }

        private void btnSteer_Click(object sender, EventArgs e)
        {

            if (on)
            {
                // turn off

                btnSteer.BackColor = SystemColors.Control;
                btnSteer.ForeColor = SystemColors.WindowText;
                on = false;
                alignmentWorker.CancelAsync();
            }
            else
            {
                // turn on

                btnSteer.BackColor = Color.Red;
                btnSteer.ForeColor = Color.White;
                on = true;
                alignmentWorker.RunWorkerAsync();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setGameWindowFocus();
            int halfWidth = 1860;
            int halfHeight = 540;
            Thread.Sleep(1000);
            //MouseActions.MoveTo(halfWidth, halfHeight);
            //input.MoveMouseTo(860, 540);
            Thread.Sleep(1000);

            //input.SendLeftClick();
            //input.SendRightClick();
            Thread.Sleep(20);



        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process proc = ReadGameMemory.gameProc;
            IntPtr startAdd = proc.MainModule.BaseAddress;
            lblMemoryStart.Text = ReadGameMemory.gameStartAddress.ToString("X");
            lblMemoryEnd.Text = ReadGameMemory.gameEndAddress.ToString("X");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lstBoxMemoryLocs.Items.Add("------------------------------");
            lstBoxMemoryLocs.Items.Add(DateTime.Now.ToShortTimeString());
            lstBoxMemoryLocs.Items.Add("------------------------------");

            int notFound = 0;
            int found = 0;
            IntPtr currentAddress = ReadGameMemory.gameStartAddress;
            int possible_steps = ReadGameMemory.gameProc.MainModule.ModuleMemorySize / 4;
            //int possible_steps = 200000;
            for (int i = 0; i < possible_steps; i++)
            {
                if (ReadGameMemory.readInt((long)currentAddress).ToString() != txtBoxFindInt.Text)
                {
                    notFound++;
                }
                else
                {
                    found++;
                    lstBoxMemoryLocs.Items.Add(currentAddress.ToString("X"));
                }
                currentAddress = IntPtr.Add(currentAddress, 4);
                lblNotFound.Text = notFound.ToString();
                lblFound.Text = found.ToString();
                lblNotFound.Refresh();
                lblFound.Refresh();
            }
        }

        private void btnFindXYStruct_Click(object sender, EventArgs e)
        {
            byte[] byteArray = { 0x69, 0xf1, 0x22, 0x3f };

            lstBoxMemoryLocs.Items.Add("------------------------------");
            lstBoxMemoryLocs.Items.Add(DateTime.Now.ToShortTimeString());
            lstBoxMemoryLocs.Items.Add("------------------------------");

            int notFound = 0;
            int found = 0;
            IntPtr currentAddress = ReadGameMemory.gameStartAddress;
            int possible_steps = ReadGameMemory.gameProc.MainModule.ModuleMemorySize / 4;
            //int possible_steps = 200000;
            for (int i = 0; i < possible_steps; i++)
            {
                byte currentByte = ReadGameMemory.readByte((long)currentAddress);
                if (currentByte != byteArray[0])
                {
                    notFound++;
                }
                else
                {
                    byte secondByte = ReadGameMemory.readByte((long)IntPtr.Add(currentAddress, 1));
                    if (secondByte == byteArray[1])
                    {
                        byte thirdByte = ReadGameMemory.readByte((long)IntPtr.Add(currentAddress, 2));
                        if (thirdByte == byteArray[2])
                        {
                            byte fourthByte = ReadGameMemory.readByte((long)IntPtr.Add(currentAddress, 3));
                            if (fourthByte == byteArray[3])
                            {
                                found++;
                                lstBoxMemoryLocs.Items.Add(currentAddress.ToString("X"));
                            }
                        }
                    }
                    
                }
                currentAddress = IntPtr.Add(currentAddress, 1);
                lblNotFound.Text = notFound.ToString();
                lblFound.Text = found.ToString();
                lblNotFound.Refresh();
                lblFound.Refresh();
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            byte[] block = ReadGameMemory.getBytesFromInt(Int32.Parse(txtBoxFindInt.Text));
            for (int i = block.Length-1; i >=0; i-- )
            {
                lstBoxMemoryLocs.Items.Add(block[i].ToString("x"));

            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            byte[] block = ReadGameMemory.getBytesFromFloat(float.Parse(txtBoxFindXYStruct.Text));

            for (int i = block.Length - 1; i >= 0; i--)
            {
                lstBoxMemoryLocs.Items.Add(block[i].ToString("x"));
            }
        }
    }
}
