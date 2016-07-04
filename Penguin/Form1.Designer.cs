namespace Penguin
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startBot = new System.Windows.Forms.Button();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.zLabel = new System.Windows.Forms.Label();
            this.curZ = new System.Windows.Forms.Label();
            this.curY = new System.Windows.Forms.Label();
            this.curX = new System.Windows.Forms.Label();
            this.facingLabel = new System.Windows.Forms.Label();
            this.lblCurrentFacing = new System.Windows.Forms.Label();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.locationListBox = new System.Windows.Forms.ListBox();
            this.MakePathTimer = new System.Windows.Forms.Timer(this.components);
            this.recordingLabel = new System.Windows.Forms.Label();
            this.MacroPage = new System.Windows.Forms.TabControl();
            this.StartTab = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSteer = new System.Windows.Forms.Button();
            this.btnPictQuest = new System.Windows.Forms.Button();
            this.btnSaveScreenShot = new System.Windows.Forms.Button();
            this.lblCurrentDelta = new System.Windows.Forms.Label();
            this.lblCurrentZone = new System.Windows.Forms.Label();
            this.pctBoxLocation = new System.Windows.Forms.PictureBox();
            this.lblTargetID = new System.Windows.Forms.Label();
            this.lblFightTimerStatus = new System.Windows.Forms.Label();
            this.btnFaceTarget = new System.Windows.Forms.Button();
            this.chkBoxFightEnabled = new System.Windows.Forms.CheckBox();
            this.lblFightWorker = new System.Windows.Forms.Label();
            this.chkBoxContinueQuest = new System.Windows.Forms.CheckBox();
            this.lblBackWorker = new System.Windows.Forms.Label();
            this.lblTurnWorker = new System.Windows.Forms.Label();
            this.btnClearXpPath = new System.Windows.Forms.Button();
            this.lblPathIndex = new System.Windows.Forms.Label();
            this.btnNextPoint = new System.Windows.Forms.Button();
            this.lblCurrentPoint = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DragonQuestListBox = new System.Windows.Forms.ListBox();
            this.updateBox = new System.Windows.Forms.ListBox();
            this.lblQuestStep = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rdoGlassLoop = new System.Windows.Forms.RadioButton();
            this.rdoDragonLoop = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMakePath = new System.Windows.Forms.Button();
            this.lblQuestNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThreadStart = new System.Windows.Forms.Button();
            this.btnSeekForward = new System.Windows.Forms.Button();
            this.btnSeekRight = new System.Windows.Forms.Button();
            this.btnSeekLeft = new System.Windows.Forms.Button();
            this.btnJump = new System.Windows.Forms.Button();
            this.lblCurrentQuestCount = new System.Windows.Forms.Label();
            this.btnStartKillRoutine = new System.Windows.Forms.Button();
            this.lblPathStep = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDestinationReached = new System.Windows.Forms.Label();
            this.btnSetPathList = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddWaypoint = new System.Windows.Forms.Button();
            this.lblCurrentFacingDelta = new System.Windows.Forms.Label();
            this.destZ = new System.Windows.Forms.Label();
            this.destY = new System.Windows.Forms.Label();
            this.destX = new System.Windows.Forms.Label();
            this.distanceLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDestinationDirection = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pathingToggleBtn = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.lblLowestDistance = new System.Windows.Forms.Label();
            this.btnForward = new System.Windows.Forms.Button();
            this.lblTargetHealth = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCurrentTarget = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PathsTab = new System.Windows.Forms.TabPage();
            this.pathToSaveLabel = new System.Windows.Forms.Label();
            this.loadedPathLabel = new System.Windows.Forms.Label();
            this.savePathButton = new System.Windows.Forms.Button();
            this.makePathButton = new System.Windows.Forms.Button();
            this.loadPathButton = new System.Windows.Forms.Button();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.TestsTab = new System.Windows.Forms.TabPage();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnShift1 = new System.Windows.Forms.Button();
            this.btnCtrl5 = new System.Windows.Forms.Button();
            this.btnCtrl4 = new System.Windows.Forms.Button();
            this.btnCtrl3 = new System.Windows.Forms.Button();
            this.btnCtrl2 = new System.Windows.Forms.Button();
            this.btnCtrl1 = new System.Windows.Forms.Button();
            this.MacroTab = new System.Windows.Forms.TabPage();
            this.txtBoxKeyFour = new System.Windows.Forms.TextBox();
            this.txtBoxKeyThree = new System.Windows.Forms.TextBox();
            this.txtBoxKeyTwo = new System.Windows.Forms.TextBox();
            this.btnFollow = new System.Windows.Forms.Button();
            this.btnHeal = new System.Windows.Forms.Button();
            this.txtBoxFirstKeyToPress = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoxEnd = new System.Windows.Forms.TextBox();
            this.txtBoxStart = new System.Windows.Forms.TextBox();
            this.btnSetPrice = new System.Windows.Forms.Button();
            this.lblSlotNumber = new System.Windows.Forms.Label();
            this.lblBagNumber = new System.Windows.Forms.Label();
            this.btnSalvage = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxDelay = new System.Windows.Forms.TextBox();
            this.txtBoxKeyToPress = new System.Windows.Forms.TextBox();
            this.lblDelay = new System.Windows.Forms.Label();
            this.btnToggleMacro = new System.Windows.Forms.Button();
            this.SetupTab = new System.Windows.Forms.TabPage();
            this.PlayerStack = new System.Windows.Forms.TabPage();
            this.lstBoxHib = new System.Windows.Forms.ListBox();
            this.lstBoxPlayer = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblMemoryEnd = new System.Windows.Forms.Label();
            this.lblMemoryStart = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.pathingLoopTimer = new System.Windows.Forms.Timer(this.components);
            this.DragonQuestTimer = new System.Windows.Forms.Timer(this.components);
            this.FightLoopTimer = new System.Windows.Forms.Timer(this.components);
            this.MacroTimer = new System.Windows.Forms.Timer(this.components);
            this.SalvageTimer = new System.Windows.Forms.Timer(this.components);
            this.tmrPlayerStackTest = new System.Windows.Forms.Timer(this.components);
            this.lstBoxMemoryLocs = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.txtBoxFindInt = new System.Windows.Forms.TextBox();
            this.lblNotFound = new System.Windows.Forms.Label();
            this.lblFound = new System.Windows.Forms.Label();
            this.btnFindXYStruct = new System.Windows.Forms.Button();
            this.txtBoxFindXYStruct = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.MacroPage.SuspendLayout();
            this.StartTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLocation)).BeginInit();
            this.PathsTab.SuspendLayout();
            this.TestsTab.SuspendLayout();
            this.MacroTab.SuspendLayout();
            this.PlayerStack.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startBot
            // 
            this.startBot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.startBot.FlatAppearance.BorderSize = 2;
            this.startBot.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBot.Location = new System.Drawing.Point(3, 3);
            this.startBot.Name = "startBot";
            this.startBot.Size = new System.Drawing.Size(66, 42);
            this.startBot.TabIndex = 1;
            this.startBot.Text = "Start";
            this.startBot.UseVisualStyleBackColor = true;
            this.startBot.Click += new System.EventHandler(this.startBot_Click);
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(6, 84);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(17, 13);
            this.xLabel.TabIndex = 2;
            this.xLabel.Text = "X:";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(6, 97);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(17, 13);
            this.yLabel.TabIndex = 3;
            this.yLabel.Text = "Y:";
            // 
            // zLabel
            // 
            this.zLabel.AutoSize = true;
            this.zLabel.Location = new System.Drawing.Point(6, 110);
            this.zLabel.Name = "zLabel";
            this.zLabel.Size = new System.Drawing.Size(17, 13);
            this.zLabel.TabIndex = 4;
            this.zLabel.Text = "Z:";
            // 
            // curZ
            // 
            this.curZ.AutoSize = true;
            this.curZ.Location = new System.Drawing.Point(47, 110);
            this.curZ.Name = "curZ";
            this.curZ.Size = new System.Drawing.Size(23, 13);
            this.curZ.TabIndex = 7;
            this.curZ.Text = "null";
            // 
            // curY
            // 
            this.curY.AutoSize = true;
            this.curY.Location = new System.Drawing.Point(47, 97);
            this.curY.Name = "curY";
            this.curY.Size = new System.Drawing.Size(23, 13);
            this.curY.TabIndex = 6;
            this.curY.Text = "null";
            // 
            // curX
            // 
            this.curX.AutoSize = true;
            this.curX.Location = new System.Drawing.Point(47, 84);
            this.curX.Name = "curX";
            this.curX.Size = new System.Drawing.Size(23, 13);
            this.curX.TabIndex = 5;
            this.curX.Text = "null";
            // 
            // facingLabel
            // 
            this.facingLabel.AutoSize = true;
            this.facingLabel.Location = new System.Drawing.Point(5, 125);
            this.facingLabel.Name = "facingLabel";
            this.facingLabel.Size = new System.Drawing.Size(44, 13);
            this.facingLabel.TabIndex = 8;
            this.facingLabel.Text = "Current:";
            // 
            // lblCurrentFacing
            // 
            this.lblCurrentFacing.AutoSize = true;
            this.lblCurrentFacing.Location = new System.Drawing.Point(64, 125);
            this.lblCurrentFacing.Name = "lblCurrentFacing";
            this.lblCurrentFacing.Size = new System.Drawing.Size(23, 13);
            this.lblCurrentFacing.TabIndex = 9;
            this.lblCurrentFacing.Text = "null";
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Interval = 20;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // locationListBox
            // 
            this.locationListBox.FormattingEnabled = true;
            this.locationListBox.Location = new System.Drawing.Point(0, 141);
            this.locationListBox.Name = "locationListBox";
            this.locationListBox.Size = new System.Drawing.Size(307, 342);
            this.locationListBox.TabIndex = 11;
            // 
            // MakePathTimer
            // 
            this.MakePathTimer.Interval = 500;
            this.MakePathTimer.Tick += new System.EventHandler(this.MakePathTimer_Tick);
            // 
            // recordingLabel
            // 
            this.recordingLabel.AutoSize = true;
            this.recordingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordingLabel.ForeColor = System.Drawing.Color.Crimson;
            this.recordingLabel.Location = new System.Drawing.Point(100, 39);
            this.recordingLabel.Name = "recordingLabel";
            this.recordingLabel.Size = new System.Drawing.Size(115, 17);
            this.recordingLabel.TabIndex = 14;
            this.recordingLabel.Text = "RECORDING...";
            this.recordingLabel.Visible = false;
            // 
            // MacroPage
            // 
            this.MacroPage.Controls.Add(this.StartTab);
            this.MacroPage.Controls.Add(this.PathsTab);
            this.MacroPage.Controls.Add(this.SettingsTab);
            this.MacroPage.Controls.Add(this.TestsTab);
            this.MacroPage.Controls.Add(this.MacroTab);
            this.MacroPage.Controls.Add(this.SetupTab);
            this.MacroPage.Controls.Add(this.PlayerStack);
            this.MacroPage.Controls.Add(this.tabPage1);
            this.MacroPage.Location = new System.Drawing.Point(2, 1);
            this.MacroPage.Name = "MacroPage";
            this.MacroPage.SelectedIndex = 0;
            this.MacroPage.Size = new System.Drawing.Size(441, 783);
            this.MacroPage.TabIndex = 17;
            // 
            // StartTab
            // 
            this.StartTab.Controls.Add(this.button3);
            this.StartTab.Controls.Add(this.btnSteer);
            this.StartTab.Controls.Add(this.btnPictQuest);
            this.StartTab.Controls.Add(this.btnSaveScreenShot);
            this.StartTab.Controls.Add(this.lblCurrentDelta);
            this.StartTab.Controls.Add(this.lblCurrentZone);
            this.StartTab.Controls.Add(this.pctBoxLocation);
            this.StartTab.Controls.Add(this.lblTargetID);
            this.StartTab.Controls.Add(this.lblFightTimerStatus);
            this.StartTab.Controls.Add(this.btnFaceTarget);
            this.StartTab.Controls.Add(this.chkBoxFightEnabled);
            this.StartTab.Controls.Add(this.lblFightWorker);
            this.StartTab.Controls.Add(this.chkBoxContinueQuest);
            this.StartTab.Controls.Add(this.lblBackWorker);
            this.StartTab.Controls.Add(this.lblTurnWorker);
            this.StartTab.Controls.Add(this.btnClearXpPath);
            this.StartTab.Controls.Add(this.lblPathIndex);
            this.StartTab.Controls.Add(this.btnNextPoint);
            this.StartTab.Controls.Add(this.lblCurrentPoint);
            this.StartTab.Controls.Add(this.label9);
            this.StartTab.Controls.Add(this.DragonQuestListBox);
            this.StartTab.Controls.Add(this.updateBox);
            this.StartTab.Controls.Add(this.lblQuestStep);
            this.StartTab.Controls.Add(this.label8);
            this.StartTab.Controls.Add(this.rdoGlassLoop);
            this.StartTab.Controls.Add(this.rdoDragonLoop);
            this.StartTab.Controls.Add(this.label7);
            this.StartTab.Controls.Add(this.btnMakePath);
            this.StartTab.Controls.Add(this.lblQuestNumber);
            this.StartTab.Controls.Add(this.label6);
            this.StartTab.Controls.Add(this.btnThreadStart);
            this.StartTab.Controls.Add(this.btnSeekForward);
            this.StartTab.Controls.Add(this.btnSeekRight);
            this.StartTab.Controls.Add(this.btnSeekLeft);
            this.StartTab.Controls.Add(this.btnJump);
            this.StartTab.Controls.Add(this.lblCurrentQuestCount);
            this.StartTab.Controls.Add(this.btnStartKillRoutine);
            this.StartTab.Controls.Add(this.lblPathStep);
            this.StartTab.Controls.Add(this.label5);
            this.StartTab.Controls.Add(this.lblDestinationReached);
            this.StartTab.Controls.Add(this.btnSetPathList);
            this.StartTab.Controls.Add(this.button1);
            this.StartTab.Controls.Add(this.btnAddWaypoint);
            this.StartTab.Controls.Add(this.lblCurrentFacingDelta);
            this.StartTab.Controls.Add(this.destZ);
            this.StartTab.Controls.Add(this.destY);
            this.StartTab.Controls.Add(this.destX);
            this.StartTab.Controls.Add(this.distanceLbl);
            this.StartTab.Controls.Add(this.label4);
            this.StartTab.Controls.Add(this.lblDestinationDirection);
            this.StartTab.Controls.Add(this.label3);
            this.StartTab.Controls.Add(this.pathingToggleBtn);
            this.StartTab.Controls.Add(this.btnRight);
            this.StartTab.Controls.Add(this.btnLeft);
            this.StartTab.Controls.Add(this.btnBackward);
            this.StartTab.Controls.Add(this.lblLowestDistance);
            this.StartTab.Controls.Add(this.btnForward);
            this.StartTab.Controls.Add(this.lblTargetHealth);
            this.StartTab.Controls.Add(this.label2);
            this.StartTab.Controls.Add(this.lblCurrentTarget);
            this.StartTab.Controls.Add(this.label1);
            this.StartTab.Controls.Add(this.startBot);
            this.StartTab.Controls.Add(this.zLabel);
            this.StartTab.Controls.Add(this.xLabel);
            this.StartTab.Controls.Add(this.yLabel);
            this.StartTab.Controls.Add(this.curX);
            this.StartTab.Controls.Add(this.curY);
            this.StartTab.Controls.Add(this.lblCurrentFacing);
            this.StartTab.Controls.Add(this.curZ);
            this.StartTab.Controls.Add(this.facingLabel);
            this.StartTab.Location = new System.Drawing.Point(4, 22);
            this.StartTab.Name = "StartTab";
            this.StartTab.Padding = new System.Windows.Forms.Padding(3);
            this.StartTab.Size = new System.Drawing.Size(433, 757);
            this.StartTab.TabIndex = 0;
            this.StartTab.Text = "Start";
            this.StartTab.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(318, 460);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 76;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSteer
            // 
            this.btnSteer.Location = new System.Drawing.Point(318, 430);
            this.btnSteer.Name = "btnSteer";
            this.btnSteer.Size = new System.Drawing.Size(75, 23);
            this.btnSteer.TabIndex = 75;
            this.btnSteer.Text = "Steer";
            this.btnSteer.UseVisualStyleBackColor = true;
            this.btnSteer.Click += new System.EventHandler(this.btnSteer_Click);
            // 
            // btnPictQuest
            // 
            this.btnPictQuest.Location = new System.Drawing.Point(355, 377);
            this.btnPictQuest.Name = "btnPictQuest";
            this.btnPictQuest.Size = new System.Drawing.Size(75, 23);
            this.btnPictQuest.TabIndex = 74;
            this.btnPictQuest.Text = "Pict";
            this.btnPictQuest.UseVisualStyleBackColor = true;
            this.btnPictQuest.Click += new System.EventHandler(this.btnPictQuest_Click);
            // 
            // btnSaveScreenShot
            // 
            this.btnSaveScreenShot.Location = new System.Drawing.Point(307, 319);
            this.btnSaveScreenShot.Name = "btnSaveScreenShot";
            this.btnSaveScreenShot.Size = new System.Drawing.Size(75, 23);
            this.btnSaveScreenShot.TabIndex = 73;
            this.btnSaveScreenShot.Text = "SS";
            this.btnSaveScreenShot.UseVisualStyleBackColor = true;
            this.btnSaveScreenShot.Click += new System.EventHandler(this.btnSaveScreenShot_Click);
            // 
            // lblCurrentDelta
            // 
            this.lblCurrentDelta.AutoSize = true;
            this.lblCurrentDelta.Location = new System.Drawing.Point(8, 191);
            this.lblCurrentDelta.Name = "lblCurrentDelta";
            this.lblCurrentDelta.Size = new System.Drawing.Size(65, 13);
            this.lblCurrentDelta.TabIndex = 72;
            this.lblCurrentDelta.Text = "currentDelta";
            // 
            // lblCurrentZone
            // 
            this.lblCurrentZone.AutoSize = true;
            this.lblCurrentZone.Location = new System.Drawing.Point(3, 71);
            this.lblCurrentZone.Name = "lblCurrentZone";
            this.lblCurrentZone.Size = new System.Drawing.Size(41, 13);
            this.lblCurrentZone.TabIndex = 71;
            this.lblCurrentZone.Text = "label11";
            // 
            // pctBoxLocation
            // 
            this.pctBoxLocation.InitialImage = null;
            this.pctBoxLocation.Location = new System.Drawing.Point(226, 3);
            this.pctBoxLocation.Name = "pctBoxLocation";
            this.pctBoxLocation.Size = new System.Drawing.Size(120, 120);
            this.pctBoxLocation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBoxLocation.TabIndex = 70;
            this.pctBoxLocation.TabStop = false;
            this.pctBoxLocation.Paint += new System.Windows.Forms.PaintEventHandler(this.pctBoxLocation_Paint);
            // 
            // lblTargetID
            // 
            this.lblTargetID.AutoSize = true;
            this.lblTargetID.Location = new System.Drawing.Point(175, 243);
            this.lblTargetID.Name = "lblTargetID";
            this.lblTargetID.Size = new System.Drawing.Size(18, 13);
            this.lblTargetID.TabIndex = 69;
            this.lblTargetID.Text = "ID";
            this.lblTargetID.TextChanged += new System.EventHandler(this.lblTargetID_TextChanged);
            // 
            // lblFightTimerStatus
            // 
            this.lblFightTimerStatus.AutoSize = true;
            this.lblFightTimerStatus.Location = new System.Drawing.Point(210, 316);
            this.lblFightTimerStatus.Name = "lblFightTimerStatus";
            this.lblFightTimerStatus.Size = new System.Drawing.Size(56, 13);
            this.lblFightTimerStatus.TabIndex = 68;
            this.lblFightTimerStatus.Text = "FightTimer";
            // 
            // btnFaceTarget
            // 
            this.btnFaceTarget.Location = new System.Drawing.Point(196, 431);
            this.btnFaceTarget.Name = "btnFaceTarget";
            this.btnFaceTarget.Size = new System.Drawing.Size(65, 23);
            this.btnFaceTarget.TabIndex = 67;
            this.btnFaceTarget.Text = "Face";
            this.btnFaceTarget.UseVisualStyleBackColor = true;
            this.btnFaceTarget.Click += new System.EventHandler(this.btnFaceTarget_Click);
            // 
            // chkBoxFightEnabled
            // 
            this.chkBoxFightEnabled.AutoSize = true;
            this.chkBoxFightEnabled.Checked = true;
            this.chkBoxFightEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxFightEnabled.Location = new System.Drawing.Point(83, 6);
            this.chkBoxFightEnabled.Name = "chkBoxFightEnabled";
            this.chkBoxFightEnabled.Size = new System.Drawing.Size(49, 17);
            this.chkBoxFightEnabled.TabIndex = 66;
            this.chkBoxFightEnabled.Text = "Fight";
            this.chkBoxFightEnabled.UseVisualStyleBackColor = true;
            // 
            // lblFightWorker
            // 
            this.lblFightWorker.AutoSize = true;
            this.lblFightWorker.Location = new System.Drawing.Point(353, 32);
            this.lblFightWorker.Name = "lblFightWorker";
            this.lblFightWorker.Size = new System.Drawing.Size(62, 13);
            this.lblFightWorker.TabIndex = 65;
            this.lblFightWorker.Text = "fightWorker";
            // 
            // chkBoxContinueQuest
            // 
            this.chkBoxContinueQuest.AutoSize = true;
            this.chkBoxContinueQuest.Location = new System.Drawing.Point(359, 123);
            this.chkBoxContinueQuest.Name = "chkBoxContinueQuest";
            this.chkBoxContinueQuest.Size = new System.Drawing.Size(65, 17);
            this.chkBoxContinueQuest.TabIndex = 64;
            this.chkBoxContinueQuest.Text = "Enabled";
            this.chkBoxContinueQuest.UseVisualStyleBackColor = true;
            // 
            // lblBackWorker
            // 
            this.lblBackWorker.AutoSize = true;
            this.lblBackWorker.Location = new System.Drawing.Point(352, 17);
            this.lblBackWorker.Name = "lblBackWorker";
            this.lblBackWorker.Size = new System.Drawing.Size(66, 13);
            this.lblBackWorker.TabIndex = 63;
            this.lblBackWorker.Text = "backWorker";
            // 
            // lblTurnWorker
            // 
            this.lblTurnWorker.AutoSize = true;
            this.lblTurnWorker.Location = new System.Drawing.Point(352, 3);
            this.lblTurnWorker.Name = "lblTurnWorker";
            this.lblTurnWorker.Size = new System.Drawing.Size(60, 13);
            this.lblTurnWorker.TabIndex = 62;
            this.lblTurnWorker.Text = "turnWorker";
            // 
            // btnClearXpPath
            // 
            this.btnClearXpPath.Location = new System.Drawing.Point(331, 290);
            this.btnClearXpPath.Name = "btnClearXpPath";
            this.btnClearXpPath.Size = new System.Drawing.Size(75, 23);
            this.btnClearXpPath.TabIndex = 61;
            this.btnClearXpPath.Text = "Clear XpPath";
            this.btnClearXpPath.UseVisualStyleBackColor = true;
            this.btnClearXpPath.Click += new System.EventHandler(this.btnClearXpPath_Click);
            // 
            // lblPathIndex
            // 
            this.lblPathIndex.AutoSize = true;
            this.lblPathIndex.Location = new System.Drawing.Point(279, 247);
            this.lblPathIndex.Name = "lblPathIndex";
            this.lblPathIndex.Size = new System.Drawing.Size(29, 13);
            this.lblPathIndex.TabIndex = 60;
            this.lblPathIndex.Text = "Step";
            // 
            // btnNextPoint
            // 
            this.btnNextPoint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNextPoint.Location = new System.Drawing.Point(306, 207);
            this.btnNextPoint.Name = "btnNextPoint";
            this.btnNextPoint.Size = new System.Drawing.Size(75, 23);
            this.btnNextPoint.TabIndex = 59;
            this.btnNextPoint.Text = "Next Point";
            this.btnNextPoint.UseVisualStyleBackColor = true;
            this.btnNextPoint.Click += new System.EventHandler(this.btnNextPoint_Click);
            // 
            // lblCurrentPoint
            // 
            this.lblCurrentPoint.AutoSize = true;
            this.lblCurrentPoint.Location = new System.Drawing.Point(314, 247);
            this.lblCurrentPoint.Name = "lblCurrentPoint";
            this.lblCurrentPoint.Size = new System.Drawing.Size(67, 13);
            this.lblCurrentPoint.TabIndex = 58;
            this.lblCurrentPoint.Text = "xxxxxxxxxxxx";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(314, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "Current Point";
            // 
            // DragonQuestListBox
            // 
            this.DragonQuestListBox.FormattingEnabled = true;
            this.DragonQuestListBox.Items.AddRange(new object[] {
            "Turn-in",
            "Porter",
            "Credit",
            "Back"});
            this.DragonQuestListBox.Location = new System.Drawing.Point(139, 6);
            this.DragonQuestListBox.Name = "DragonQuestListBox";
            this.DragonQuestListBox.Size = new System.Drawing.Size(77, 69);
            this.DragonQuestListBox.TabIndex = 56;
            // 
            // updateBox
            // 
            this.updateBox.FormattingEnabled = true;
            this.updateBox.Location = new System.Drawing.Point(0, 319);
            this.updateBox.Name = "updateBox";
            this.updateBox.Size = new System.Drawing.Size(204, 82);
            this.updateBox.TabIndex = 10;
            // 
            // lblQuestStep
            // 
            this.lblQuestStep.AutoSize = true;
            this.lblQuestStep.Location = new System.Drawing.Point(237, 185);
            this.lblQuestStep.Name = "lblQuestStep";
            this.lblQuestStep.Size = new System.Drawing.Size(17, 13);
            this.lblQuestStep.TabIndex = 55;
            this.lblQuestStep.Text = "nil";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(168, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Quest Step: ";
            // 
            // rdoGlassLoop
            // 
            this.rdoGlassLoop.AutoSize = true;
            this.rdoGlassLoop.Location = new System.Drawing.Point(346, 170);
            this.rdoGlassLoop.Name = "rdoGlassLoop";
            this.rdoGlassLoop.Size = new System.Drawing.Size(75, 17);
            this.rdoGlassLoop.TabIndex = 53;
            this.rdoGlassLoop.TabStop = true;
            this.rdoGlassLoop.Text = "GlassLoop";
            this.rdoGlassLoop.UseVisualStyleBackColor = true;
            // 
            // rdoDragonLoop
            // 
            this.rdoDragonLoop.AutoSize = true;
            this.rdoDragonLoop.Location = new System.Drawing.Point(345, 147);
            this.rdoDragonLoop.Name = "rdoDragonLoop";
            this.rdoDragonLoop.Size = new System.Drawing.Size(84, 17);
            this.rdoDragonLoop.TabIndex = 52;
            this.rdoDragonLoop.TabStop = true;
            this.rdoDragonLoop.Text = "DragonLoop";
            this.rdoDragonLoop.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "label7";
            // 
            // btnMakePath
            // 
            this.btnMakePath.Location = new System.Drawing.Point(250, 290);
            this.btnMakePath.Name = "btnMakePath";
            this.btnMakePath.Size = new System.Drawing.Size(75, 23);
            this.btnMakePath.TabIndex = 50;
            this.btnMakePath.Text = "Make Path";
            this.btnMakePath.UseVisualStyleBackColor = true;
            this.btnMakePath.Click += new System.EventHandler(this.btnMakePath_Click);
            // 
            // lblQuestNumber
            // 
            this.lblQuestNumber.AutoSize = true;
            this.lblQuestNumber.Location = new System.Drawing.Point(352, 71);
            this.lblQuestNumber.Name = "lblQuestNumber";
            this.lblQuestNumber.Size = new System.Drawing.Size(13, 13);
            this.lblQuestNumber.TabIndex = 49;
            this.lblQuestNumber.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Quest#";
            // 
            // btnThreadStart
            // 
            this.btnThreadStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThreadStart.Location = new System.Drawing.Point(352, 92);
            this.btnThreadStart.Name = "btnThreadStart";
            this.btnThreadStart.Size = new System.Drawing.Size(75, 23);
            this.btnThreadStart.TabIndex = 47;
            this.btnThreadStart.Text = "Workers";
            this.btnThreadStart.UseVisualStyleBackColor = true;
            this.btnThreadStart.Click += new System.EventHandler(this.btnThreadStart_Click);
            // 
            // btnSeekForward
            // 
            this.btnSeekForward.BackColor = System.Drawing.Color.Silver;
            this.btnSeekForward.Location = new System.Drawing.Point(117, 405);
            this.btnSeekForward.Name = "btnSeekForward";
            this.btnSeekForward.Size = new System.Drawing.Size(45, 23);
            this.btnSeekForward.TabIndex = 46;
            this.btnSeekForward.Text = "Off";
            this.btnSeekForward.UseVisualStyleBackColor = false;
            this.btnSeekForward.Click += new System.EventHandler(this.btnSeekForward_Click);
            // 
            // btnSeekRight
            // 
            this.btnSeekRight.BackColor = System.Drawing.Color.Silver;
            this.btnSeekRight.Location = new System.Drawing.Point(226, 460);
            this.btnSeekRight.Name = "btnSeekRight";
            this.btnSeekRight.Size = new System.Drawing.Size(45, 23);
            this.btnSeekRight.TabIndex = 44;
            this.btnSeekRight.Text = "Off";
            this.btnSeekRight.UseVisualStyleBackColor = false;
            this.btnSeekRight.Click += new System.EventHandler(this.btnSeekRight_Click);
            // 
            // btnSeekLeft
            // 
            this.btnSeekLeft.BackColor = System.Drawing.Color.Silver;
            this.btnSeekLeft.Location = new System.Drawing.Point(4, 460);
            this.btnSeekLeft.Name = "btnSeekLeft";
            this.btnSeekLeft.Size = new System.Drawing.Size(45, 23);
            this.btnSeekLeft.TabIndex = 42;
            this.btnSeekLeft.Text = "Off";
            this.btnSeekLeft.UseVisualStyleBackColor = false;
            this.btnSeekLeft.Click += new System.EventHandler(this.btnSeekLeft_Click);
            // 
            // btnJump
            // 
            this.btnJump.Location = new System.Drawing.Point(106, 460);
            this.btnJump.Name = "btnJump";
            this.btnJump.Size = new System.Drawing.Size(65, 23);
            this.btnJump.TabIndex = 41;
            this.btnJump.Text = "Jump";
            this.btnJump.UseVisualStyleBackColor = true;
            this.btnJump.Click += new System.EventHandler(this.btnJump_Click);
            // 
            // lblCurrentQuestCount
            // 
            this.lblCurrentQuestCount.AutoSize = true;
            this.lblCurrentQuestCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentQuestCount.Location = new System.Drawing.Point(265, 155);
            this.lblCurrentQuestCount.Name = "lblCurrentQuestCount";
            this.lblCurrentQuestCount.Size = new System.Drawing.Size(60, 25);
            this.lblCurrentQuestCount.TabIndex = 40;
            this.lblCurrentQuestCount.Text = "quest";
            // 
            // btnStartKillRoutine
            // 
            this.btnStartKillRoutine.Location = new System.Drawing.Point(222, 125);
            this.btnStartKillRoutine.Name = "btnStartKillRoutine";
            this.btnStartKillRoutine.Size = new System.Drawing.Size(125, 23);
            this.btnStartKillRoutine.TabIndex = 39;
            this.btnStartKillRoutine.Text = "Start Kill Routine";
            this.btnStartKillRoutine.UseVisualStyleBackColor = true;
            this.btnStartKillRoutine.Click += new System.EventHandler(this.btnStartKillRoutine_Click);
            // 
            // lblPathStep
            // 
            this.lblPathStep.AutoSize = true;
            this.lblPathStep.Location = new System.Drawing.Point(125, 130);
            this.lblPathStep.Name = "lblPathStep";
            this.lblPathStep.Size = new System.Drawing.Size(35, 13);
            this.lblPathStep.TabIndex = 38;
            this.lblPathStep.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "DisDelta: ";
            // 
            // lblDestinationReached
            // 
            this.lblDestinationReached.AutoSize = true;
            this.lblDestinationReached.Location = new System.Drawing.Point(155, 265);
            this.lblDestinationReached.Name = "lblDestinationReached";
            this.lblDestinationReached.Size = new System.Drawing.Size(107, 13);
            this.lblDestinationReached.TabIndex = 36;
            this.lblDestinationReached.Text = "Destination Reached";
            // 
            // btnSetPathList
            // 
            this.btnSetPathList.Location = new System.Drawing.Point(165, 290);
            this.btnSetPathList.Name = "btnSetPathList";
            this.btnSetPathList.Size = new System.Drawing.Size(75, 23);
            this.btnSetPathList.TabIndex = 31;
            this.btnSetPathList.Text = "Set This Path";
            this.btnSetPathList.UseVisualStyleBackColor = true;
            this.btnSetPathList.Click += new System.EventHandler(this.btnSetPathList_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Clear Listbox";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnClearPathList);
            // 
            // btnAddWaypoint
            // 
            this.btnAddWaypoint.Location = new System.Drawing.Point(3, 290);
            this.btnAddWaypoint.Name = "btnAddWaypoint";
            this.btnAddWaypoint.Size = new System.Drawing.Size(75, 23);
            this.btnAddWaypoint.TabIndex = 29;
            this.btnAddWaypoint.Text = "Add Waypoint";
            this.btnAddWaypoint.UseVisualStyleBackColor = true;
            this.btnAddWaypoint.Click += new System.EventHandler(this.btnAddWaypoint_Click);
            // 
            // lblCurrentFacingDelta
            // 
            this.lblCurrentFacingDelta.AutoSize = true;
            this.lblCurrentFacingDelta.Location = new System.Drawing.Point(181, 164);
            this.lblCurrentFacingDelta.Name = "lblCurrentFacingDelta";
            this.lblCurrentFacingDelta.Size = new System.Drawing.Size(53, 13);
            this.lblCurrentFacingDelta.TabIndex = 28;
            this.lblCurrentFacingDelta.Text = "DisDelta: ";
            // 
            // destZ
            // 
            this.destZ.AutoSize = true;
            this.destZ.Location = new System.Drawing.Point(125, 110);
            this.destZ.Name = "destZ";
            this.destZ.Size = new System.Drawing.Size(35, 13);
            this.destZ.TabIndex = 27;
            this.destZ.Text = "label7";
            // 
            // destY
            // 
            this.destY.AutoSize = true;
            this.destY.Location = new System.Drawing.Point(125, 97);
            this.destY.Name = "destY";
            this.destY.Size = new System.Drawing.Size(35, 13);
            this.destY.TabIndex = 26;
            this.destY.Text = "label6";
            // 
            // destX
            // 
            this.destX.AutoSize = true;
            this.destX.Location = new System.Drawing.Point(125, 84);
            this.destX.Name = "destX";
            this.destX.Size = new System.Drawing.Size(35, 13);
            this.destX.TabIndex = 25;
            this.destX.Text = "label5";
            // 
            // distanceLbl
            // 
            this.distanceLbl.AutoSize = true;
            this.distanceLbl.Location = new System.Drawing.Point(78, 164);
            this.distanceLbl.Name = "distanceLbl";
            this.distanceLbl.Size = new System.Drawing.Size(23, 13);
            this.distanceLbl.TabIndex = 24;
            this.distanceLbl.Text = "null";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Distance:";
            // 
            // lblDestinationDirection
            // 
            this.lblDestinationDirection.AutoSize = true;
            this.lblDestinationDirection.Location = new System.Drawing.Point(75, 147);
            this.lblDestinationDirection.Name = "lblDestinationDirection";
            this.lblDestinationDirection.Size = new System.Drawing.Size(23, 13);
            this.lblDestinationDirection.TabIndex = 22;
            this.lblDestinationDirection.Text = "null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Destination:";
            // 
            // pathingToggleBtn
            // 
            this.pathingToggleBtn.Location = new System.Drawing.Point(3, 44);
            this.pathingToggleBtn.Name = "pathingToggleBtn";
            this.pathingToggleBtn.Size = new System.Drawing.Size(75, 23);
            this.pathingToggleBtn.TabIndex = 20;
            this.pathingToggleBtn.Text = "Pathing";
            this.pathingToggleBtn.UseVisualStyleBackColor = true;
            this.pathingToggleBtn.Click += new System.EventHandler(this.togglePathingBtn_Click);
            this.pathingToggleBtn.MouseHover += new System.EventHandler(this.pathingToggleBtn_MouseHover);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(177, 460);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(45, 23);
            this.btnRight.TabIndex = 19;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(55, 460);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(45, 23);
            this.btnLeft.TabIndex = 18;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.Location = new System.Drawing.Point(107, 489);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(65, 23);
            this.btnBackward.TabIndex = 17;
            this.btnBackward.Text = "Backward";
            this.btnBackward.UseVisualStyleBackColor = true;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // lblLowestDistance
            // 
            this.lblLowestDistance.AutoSize = true;
            this.lblLowestDistance.Location = new System.Drawing.Point(75, 185);
            this.lblLowestDistance.Name = "lblLowestDistance";
            this.lblLowestDistance.Size = new System.Drawing.Size(35, 13);
            this.lblLowestDistance.TabIndex = 16;
            this.lblLowestDistance.Text = "label3";
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(107, 431);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(65, 23);
            this.btnForward.TabIndex = 15;
            this.btnForward.Text = "Forward";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnFoward_Click);
            // 
            // lblTargetHealth
            // 
            this.lblTargetHealth.AutoSize = true;
            this.lblTargetHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetHealth.Location = new System.Drawing.Point(93, 234);
            this.lblTargetHealth.Name = "lblTargetHealth";
            this.lblTargetHealth.Size = new System.Drawing.Size(64, 25);
            this.lblTargetHealth.TabIndex = 14;
            this.lblTargetHealth.Text = "label3";
            this.lblTargetHealth.TextChanged += new System.EventHandler(this.lblTargetHealth_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Target\'s Health";
            // 
            // lblCurrentTarget
            // 
            this.lblCurrentTarget.AutoSize = true;
            this.lblCurrentTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTarget.Location = new System.Drawing.Point(93, 198);
            this.lblCurrentTarget.Name = "lblCurrentTarget";
            this.lblCurrentTarget.Size = new System.Drawing.Size(64, 25);
            this.lblCurrentTarget.TabIndex = 12;
            this.lblCurrentTarget.Text = "label2";
            this.lblCurrentTarget.TextChanged += new System.EventHandler(this.lblCurrentTarget_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Current Target: ";
            // 
            // PathsTab
            // 
            this.PathsTab.Controls.Add(this.pathToSaveLabel);
            this.PathsTab.Controls.Add(this.loadedPathLabel);
            this.PathsTab.Controls.Add(this.savePathButton);
            this.PathsTab.Controls.Add(this.locationListBox);
            this.PathsTab.Controls.Add(this.makePathButton);
            this.PathsTab.Controls.Add(this.loadPathButton);
            this.PathsTab.Controls.Add(this.recordingLabel);
            this.PathsTab.Location = new System.Drawing.Point(4, 22);
            this.PathsTab.Name = "PathsTab";
            this.PathsTab.Padding = new System.Windows.Forms.Padding(3);
            this.PathsTab.Size = new System.Drawing.Size(433, 757);
            this.PathsTab.TabIndex = 1;
            this.PathsTab.Text = "Paths";
            this.PathsTab.UseVisualStyleBackColor = true;
            // 
            // pathToSaveLabel
            // 
            this.pathToSaveLabel.AutoSize = true;
            this.pathToSaveLabel.Location = new System.Drawing.Point(103, 74);
            this.pathToSaveLabel.Name = "pathToSaveLabel";
            this.pathToSaveLabel.Size = new System.Drawing.Size(16, 13);
            this.pathToSaveLabel.TabIndex = 19;
            this.pathToSaveLabel.Text = "...";
            // 
            // loadedPathLabel
            // 
            this.loadedPathLabel.AutoSize = true;
            this.loadedPathLabel.Location = new System.Drawing.Point(103, 17);
            this.loadedPathLabel.Name = "loadedPathLabel";
            this.loadedPathLabel.Size = new System.Drawing.Size(16, 13);
            this.loadedPathLabel.TabIndex = 18;
            this.loadedPathLabel.Text = "...";
            // 
            // savePathButton
            // 
            this.savePathButton.Location = new System.Drawing.Point(7, 65);
            this.savePathButton.Name = "savePathButton";
            this.savePathButton.Size = new System.Drawing.Size(75, 23);
            this.savePathButton.TabIndex = 17;
            this.savePathButton.Text = "Save Path";
            this.savePathButton.UseVisualStyleBackColor = true;
            this.savePathButton.Click += new System.EventHandler(this.savePathButton_Click);
            // 
            // makePathButton
            // 
            this.makePathButton.Location = new System.Drawing.Point(7, 36);
            this.makePathButton.Name = "makePathButton";
            this.makePathButton.Size = new System.Drawing.Size(75, 23);
            this.makePathButton.TabIndex = 16;
            this.makePathButton.Text = "Make Path";
            this.makePathButton.UseVisualStyleBackColor = true;
            this.makePathButton.Click += new System.EventHandler(this.makePathButton_Click_1);
            // 
            // loadPathButton
            // 
            this.loadPathButton.Location = new System.Drawing.Point(7, 7);
            this.loadPathButton.Name = "loadPathButton";
            this.loadPathButton.Size = new System.Drawing.Size(75, 23);
            this.loadPathButton.TabIndex = 15;
            this.loadPathButton.Text = "Load Path";
            this.loadPathButton.UseVisualStyleBackColor = true;
            this.loadPathButton.Click += new System.EventHandler(this.loadPathButton_Click);
            // 
            // SettingsTab
            // 
            this.SettingsTab.Location = new System.Drawing.Point(4, 22);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTab.Size = new System.Drawing.Size(433, 757);
            this.SettingsTab.TabIndex = 2;
            this.SettingsTab.Text = "Settings";
            this.SettingsTab.UseVisualStyleBackColor = true;
            // 
            // TestsTab
            // 
            this.TestsTab.Controls.Add(this.btnSouth);
            this.TestsTab.Controls.Add(this.btnEast);
            this.TestsTab.Controls.Add(this.btnWest);
            this.TestsTab.Controls.Add(this.btnNorth);
            this.TestsTab.Controls.Add(this.btnShift1);
            this.TestsTab.Controls.Add(this.btnCtrl5);
            this.TestsTab.Controls.Add(this.btnCtrl4);
            this.TestsTab.Controls.Add(this.btnCtrl3);
            this.TestsTab.Controls.Add(this.btnCtrl2);
            this.TestsTab.Controls.Add(this.btnCtrl1);
            this.TestsTab.Location = new System.Drawing.Point(4, 22);
            this.TestsTab.Name = "TestsTab";
            this.TestsTab.Padding = new System.Windows.Forms.Padding(3);
            this.TestsTab.Size = new System.Drawing.Size(433, 757);
            this.TestsTab.TabIndex = 3;
            this.TestsTab.Text = "Tests";
            this.TestsTab.UseVisualStyleBackColor = true;
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(181, 45);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(23, 23);
            this.btnSouth.TabIndex = 76;
            this.btnSouth.Text = "S";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click_1);
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(203, 26);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(23, 23);
            this.btnEast.TabIndex = 75;
            this.btnEast.Text = "E";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.btnEast_Click_1);
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(159, 26);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(23, 23);
            this.btnWest.TabIndex = 74;
            this.btnWest.Text = "W";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.btnWest_Click_1);
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(181, 6);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(23, 23);
            this.btnNorth.TabIndex = 73;
            this.btnNorth.Text = "N";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click_1);
            // 
            // btnShift1
            // 
            this.btnShift1.Location = new System.Drawing.Point(62, 6);
            this.btnShift1.Name = "btnShift1";
            this.btnShift1.Size = new System.Drawing.Size(50, 23);
            this.btnShift1.TabIndex = 72;
            this.btnShift1.Text = "Sht 1";
            this.btnShift1.UseVisualStyleBackColor = true;
            this.btnShift1.Click += new System.EventHandler(this.btnShift1_Click_1);
            // 
            // btnCtrl5
            // 
            this.btnCtrl5.Location = new System.Drawing.Point(6, 122);
            this.btnCtrl5.Name = "btnCtrl5";
            this.btnCtrl5.Size = new System.Drawing.Size(50, 23);
            this.btnCtrl5.TabIndex = 71;
            this.btnCtrl5.Text = "Ctrl 5";
            this.btnCtrl5.UseVisualStyleBackColor = true;
            // 
            // btnCtrl4
            // 
            this.btnCtrl4.Location = new System.Drawing.Point(6, 93);
            this.btnCtrl4.Name = "btnCtrl4";
            this.btnCtrl4.Size = new System.Drawing.Size(50, 23);
            this.btnCtrl4.TabIndex = 70;
            this.btnCtrl4.Text = "Ctrl 4";
            this.btnCtrl4.UseVisualStyleBackColor = true;
            // 
            // btnCtrl3
            // 
            this.btnCtrl3.Location = new System.Drawing.Point(6, 64);
            this.btnCtrl3.Name = "btnCtrl3";
            this.btnCtrl3.Size = new System.Drawing.Size(50, 23);
            this.btnCtrl3.TabIndex = 69;
            this.btnCtrl3.Text = "Ctrl 3";
            this.btnCtrl3.UseVisualStyleBackColor = true;
            // 
            // btnCtrl2
            // 
            this.btnCtrl2.Location = new System.Drawing.Point(6, 35);
            this.btnCtrl2.Name = "btnCtrl2";
            this.btnCtrl2.Size = new System.Drawing.Size(50, 23);
            this.btnCtrl2.TabIndex = 68;
            this.btnCtrl2.Text = "Ctrl 2";
            this.btnCtrl2.UseVisualStyleBackColor = true;
            // 
            // btnCtrl1
            // 
            this.btnCtrl1.Location = new System.Drawing.Point(6, 6);
            this.btnCtrl1.Name = "btnCtrl1";
            this.btnCtrl1.Size = new System.Drawing.Size(50, 23);
            this.btnCtrl1.TabIndex = 67;
            this.btnCtrl1.Text = "Ctrl 1";
            this.btnCtrl1.UseVisualStyleBackColor = true;
            this.btnCtrl1.Click += new System.EventHandler(this.btnCtrl1_Click_1);
            // 
            // MacroTab
            // 
            this.MacroTab.Controls.Add(this.txtBoxKeyFour);
            this.MacroTab.Controls.Add(this.txtBoxKeyThree);
            this.MacroTab.Controls.Add(this.txtBoxKeyTwo);
            this.MacroTab.Controls.Add(this.btnFollow);
            this.MacroTab.Controls.Add(this.btnHeal);
            this.MacroTab.Controls.Add(this.txtBoxFirstKeyToPress);
            this.MacroTab.Controls.Add(this.label13);
            this.MacroTab.Controls.Add(this.txtBoxPrice);
            this.MacroTab.Controls.Add(this.label12);
            this.MacroTab.Controls.Add(this.label11);
            this.MacroTab.Controls.Add(this.txtBoxEnd);
            this.MacroTab.Controls.Add(this.txtBoxStart);
            this.MacroTab.Controls.Add(this.btnSetPrice);
            this.MacroTab.Controls.Add(this.lblSlotNumber);
            this.MacroTab.Controls.Add(this.lblBagNumber);
            this.MacroTab.Controls.Add(this.btnSalvage);
            this.MacroTab.Controls.Add(this.label10);
            this.MacroTab.Controls.Add(this.txtBoxDelay);
            this.MacroTab.Controls.Add(this.txtBoxKeyToPress);
            this.MacroTab.Controls.Add(this.lblDelay);
            this.MacroTab.Controls.Add(this.btnToggleMacro);
            this.MacroTab.Location = new System.Drawing.Point(4, 22);
            this.MacroTab.Name = "MacroTab";
            this.MacroTab.Padding = new System.Windows.Forms.Padding(3);
            this.MacroTab.Size = new System.Drawing.Size(433, 757);
            this.MacroTab.TabIndex = 4;
            this.MacroTab.Text = "Macro";
            this.MacroTab.UseVisualStyleBackColor = true;
            // 
            // txtBoxKeyFour
            // 
            this.txtBoxKeyFour.Location = new System.Drawing.Point(350, 8);
            this.txtBoxKeyFour.Name = "txtBoxKeyFour";
            this.txtBoxKeyFour.Size = new System.Drawing.Size(38, 20);
            this.txtBoxKeyFour.TabIndex = 21;
            // 
            // txtBoxKeyThree
            // 
            this.txtBoxKeyThree.Location = new System.Drawing.Point(306, 9);
            this.txtBoxKeyThree.Name = "txtBoxKeyThree";
            this.txtBoxKeyThree.Size = new System.Drawing.Size(38, 20);
            this.txtBoxKeyThree.TabIndex = 20;
            // 
            // txtBoxKeyTwo
            // 
            this.txtBoxKeyTwo.Location = new System.Drawing.Point(262, 8);
            this.txtBoxKeyTwo.Name = "txtBoxKeyTwo";
            this.txtBoxKeyTwo.Size = new System.Drawing.Size(38, 20);
            this.txtBoxKeyTwo.TabIndex = 19;
            // 
            // btnFollow
            // 
            this.btnFollow.Location = new System.Drawing.Point(3, 108);
            this.btnFollow.Name = "btnFollow";
            this.btnFollow.Size = new System.Drawing.Size(75, 23);
            this.btnFollow.TabIndex = 18;
            this.btnFollow.Text = "Follow";
            this.btnFollow.UseVisualStyleBackColor = true;
            this.btnFollow.Click += new System.EventHandler(this.btnFollow_Click);
            // 
            // btnHeal
            // 
            this.btnHeal.Location = new System.Drawing.Point(3, 79);
            this.btnHeal.Name = "btnHeal";
            this.btnHeal.Size = new System.Drawing.Size(75, 23);
            this.btnHeal.TabIndex = 17;
            this.btnHeal.Text = "Heal Me";
            this.btnHeal.UseVisualStyleBackColor = true;
            this.btnHeal.Click += new System.EventHandler(this.btnHeal_Click);
            // 
            // txtBoxFirstKeyToPress
            // 
            this.txtBoxFirstKeyToPress.Location = new System.Drawing.Point(106, 8);
            this.txtBoxFirstKeyToPress.Name = "txtBoxFirstKeyToPress";
            this.txtBoxFirstKeyToPress.Size = new System.Drawing.Size(38, 20);
            this.txtBoxFirstKeyToPress.TabIndex = 16;
            this.txtBoxFirstKeyToPress.Text = "1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(273, 273);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "price";
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Location = new System.Drawing.Point(262, 304);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(51, 20);
            this.txtBoxPrice.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(188, 273);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "end";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(117, 273);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "start";
            // 
            // txtBoxEnd
            // 
            this.txtBoxEnd.Location = new System.Drawing.Point(173, 304);
            this.txtBoxEnd.Name = "txtBoxEnd";
            this.txtBoxEnd.Size = new System.Drawing.Size(51, 20);
            this.txtBoxEnd.TabIndex = 11;
            // 
            // txtBoxStart
            // 
            this.txtBoxStart.Location = new System.Drawing.Point(106, 304);
            this.txtBoxStart.Name = "txtBoxStart";
            this.txtBoxStart.Size = new System.Drawing.Size(51, 20);
            this.txtBoxStart.TabIndex = 10;
            // 
            // btnSetPrice
            // 
            this.btnSetPrice.Location = new System.Drawing.Point(3, 263);
            this.btnSetPrice.Name = "btnSetPrice";
            this.btnSetPrice.Size = new System.Drawing.Size(92, 23);
            this.btnSetPrice.TabIndex = 9;
            this.btnSetPrice.Text = "Set Prices";
            this.btnSetPrice.UseVisualStyleBackColor = true;
            this.btnSetPrice.Click += new System.EventHandler(this.btnSetPrice_Click);
            // 
            // lblSlotNumber
            // 
            this.lblSlotNumber.AutoSize = true;
            this.lblSlotNumber.Location = new System.Drawing.Point(156, 226);
            this.lblSlotNumber.Name = "lblSlotNumber";
            this.lblSlotNumber.Size = new System.Drawing.Size(23, 13);
            this.lblSlotNumber.TabIndex = 8;
            this.lblSlotNumber.Text = "slot";
            // 
            // lblBagNumber
            // 
            this.lblBagNumber.AutoSize = true;
            this.lblBagNumber.Location = new System.Drawing.Point(153, 197);
            this.lblBagNumber.Name = "lblBagNumber";
            this.lblBagNumber.Size = new System.Drawing.Size(25, 13);
            this.lblBagNumber.TabIndex = 7;
            this.lblBagNumber.Text = "bag";
            // 
            // btnSalvage
            // 
            this.btnSalvage.Location = new System.Drawing.Point(3, 188);
            this.btnSalvage.Name = "btnSalvage";
            this.btnSalvage.Size = new System.Drawing.Size(92, 23);
            this.btnSalvage.TabIndex = 6;
            this.btnSalvage.Text = "Salvage is Off";
            this.btnSalvage.UseVisualStyleBackColor = true;
            this.btnSalvage.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(170, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "key";
            // 
            // txtBoxDelay
            // 
            this.txtBoxDelay.Location = new System.Drawing.Point(219, 36);
            this.txtBoxDelay.Name = "txtBoxDelay";
            this.txtBoxDelay.Size = new System.Drawing.Size(51, 20);
            this.txtBoxDelay.TabIndex = 4;
            // 
            // txtBoxKeyToPress
            // 
            this.txtBoxKeyToPress.Location = new System.Drawing.Point(219, 9);
            this.txtBoxKeyToPress.Name = "txtBoxKeyToPress";
            this.txtBoxKeyToPress.Size = new System.Drawing.Size(38, 20);
            this.txtBoxKeyToPress.TabIndex = 3;
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(170, 43);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(32, 13);
            this.lblDelay.TabIndex = 2;
            this.lblDelay.Text = "delay";
            // 
            // btnToggleMacro
            // 
            this.btnToggleMacro.Location = new System.Drawing.Point(6, 6);
            this.btnToggleMacro.Name = "btnToggleMacro";
            this.btnToggleMacro.Size = new System.Drawing.Size(75, 23);
            this.btnToggleMacro.TabIndex = 0;
            this.btnToggleMacro.Text = "Off";
            this.btnToggleMacro.UseVisualStyleBackColor = true;
            this.btnToggleMacro.Click += new System.EventHandler(this.btnToggleMacro_Click);
            // 
            // SetupTab
            // 
            this.SetupTab.Location = new System.Drawing.Point(4, 22);
            this.SetupTab.Name = "SetupTab";
            this.SetupTab.Padding = new System.Windows.Forms.Padding(3);
            this.SetupTab.Size = new System.Drawing.Size(433, 757);
            this.SetupTab.TabIndex = 5;
            this.SetupTab.Text = "Setup";
            this.SetupTab.UseVisualStyleBackColor = true;
            // 
            // PlayerStack
            // 
            this.PlayerStack.Controls.Add(this.lstBoxHib);
            this.PlayerStack.Controls.Add(this.lstBoxPlayer);
            this.PlayerStack.Controls.Add(this.button2);
            this.PlayerStack.Location = new System.Drawing.Point(4, 22);
            this.PlayerStack.Name = "PlayerStack";
            this.PlayerStack.Padding = new System.Windows.Forms.Padding(3);
            this.PlayerStack.Size = new System.Drawing.Size(433, 757);
            this.PlayerStack.TabIndex = 6;
            this.PlayerStack.Text = "Player Stack";
            this.PlayerStack.UseVisualStyleBackColor = true;
            // 
            // lstBoxHib
            // 
            this.lstBoxHib.ForeColor = System.Drawing.Color.ForestGreen;
            this.lstBoxHib.FormattingEnabled = true;
            this.lstBoxHib.Items.AddRange(new object[] {
            "Hibs"});
            this.lstBoxHib.Location = new System.Drawing.Point(302, 31);
            this.lstBoxHib.Name = "lstBoxHib";
            this.lstBoxHib.Size = new System.Drawing.Size(120, 472);
            this.lstBoxHib.Sorted = true;
            this.lstBoxHib.TabIndex = 3;
            // 
            // lstBoxPlayer
            // 
            this.lstBoxPlayer.BackColor = System.Drawing.SystemColors.Window;
            this.lstBoxPlayer.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lstBoxPlayer.FormattingEnabled = true;
            this.lstBoxPlayer.Items.AddRange(new object[] {
            "Players"});
            this.lstBoxPlayer.Location = new System.Drawing.Point(3, 31);
            this.lstBoxPlayer.Name = "lstBoxPlayer";
            this.lstBoxPlayer.Size = new System.Drawing.Size(276, 472);
            this.lstBoxPlayer.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.txtBoxFindXYStruct);
            this.tabPage1.Controls.Add(this.btnFindXYStruct);
            this.tabPage1.Controls.Add(this.lblFound);
            this.tabPage1.Controls.Add(this.lblNotFound);
            this.tabPage1.Controls.Add(this.txtBoxFindInt);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.lstBoxMemoryLocs);
            this.tabPage1.Controls.Add(this.lblMemoryEnd);
            this.tabPage1.Controls.Add(this.lblMemoryStart);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(433, 757);
            this.tabPage1.TabIndex = 7;
            this.tabPage1.Text = "Memory";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblMemoryEnd
            // 
            this.lblMemoryEnd.AutoSize = true;
            this.lblMemoryEnd.Location = new System.Drawing.Point(181, 60);
            this.lblMemoryEnd.Name = "lblMemoryEnd";
            this.lblMemoryEnd.Size = new System.Drawing.Size(73, 13);
            this.lblMemoryEnd.TabIndex = 2;
            this.lblMemoryEnd.Text = "lblMemoryEnd";
            // 
            // lblMemoryStart
            // 
            this.lblMemoryStart.AutoSize = true;
            this.lblMemoryStart.Location = new System.Drawing.Point(181, 29);
            this.lblMemoryStart.Name = "lblMemoryStart";
            this.lblMemoryStart.Size = new System.Drawing.Size(76, 13);
            this.lblMemoryStart.TabIndex = 1;
            this.lblMemoryStart.Text = "lblMemoryStart";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(23, 29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Get Start/End";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pathingLoopTimer
            // 
            this.pathingLoopTimer.Tick += new System.EventHandler(this.pathingLoopTimer_Tick);
            // 
            // DragonQuestTimer
            // 
            this.DragonQuestTimer.Interval = 1000;
            this.DragonQuestTimer.Tick += new System.EventHandler(this.DragonQuestTimer_Tick);
            // 
            // FightLoopTimer
            // 
            this.FightLoopTimer.Interval = 2000;
            this.FightLoopTimer.Tick += new System.EventHandler(this.FightLoopTimer_Tick);
            // 
            // MacroTimer
            // 
            this.MacroTimer.Tick += new System.EventHandler(this.MacroTimer_Tick);
            // 
            // tmrPlayerStackTest
            // 
            this.tmrPlayerStackTest.Tick += new System.EventHandler(this.tmrPlayerStackTest_Tick);
            // 
            // lstBoxMemoryLocs
            // 
            this.lstBoxMemoryLocs.FormattingEnabled = true;
            this.lstBoxMemoryLocs.Location = new System.Drawing.Point(23, 221);
            this.lstBoxMemoryLocs.Name = "lstBoxMemoryLocs";
            this.lstBoxMemoryLocs.Size = new System.Drawing.Size(399, 459);
            this.lstBoxMemoryLocs.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(23, 86);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Find Int";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtBoxFindInt
            // 
            this.txtBoxFindInt.Location = new System.Drawing.Point(184, 86);
            this.txtBoxFindInt.Name = "txtBoxFindInt";
            this.txtBoxFindInt.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFindInt.TabIndex = 5;
            // 
            // lblNotFound
            // 
            this.lblNotFound.AutoSize = true;
            this.lblNotFound.Location = new System.Drawing.Point(283, 198);
            this.lblNotFound.Name = "lblNotFound";
            this.lblNotFound.Size = new System.Drawing.Size(64, 13);
            this.lblNotFound.TabIndex = 6;
            this.lblNotFound.Text = "lblNotFound";
            // 
            // lblFound
            // 
            this.lblFound.AutoSize = true;
            this.lblFound.Location = new System.Drawing.Point(375, 198);
            this.lblFound.Name = "lblFound";
            this.lblFound.Size = new System.Drawing.Size(47, 13);
            this.lblFound.TabIndex = 7;
            this.lblFound.Text = "lblFound";
            // 
            // btnFindXYStruct
            // 
            this.btnFindXYStruct.Location = new System.Drawing.Point(23, 127);
            this.btnFindXYStruct.Name = "btnFindXYStruct";
            this.btnFindXYStruct.Size = new System.Drawing.Size(75, 23);
            this.btnFindXYStruct.TabIndex = 8;
            this.btnFindXYStruct.Text = "Find X,Y Struct";
            this.btnFindXYStruct.UseVisualStyleBackColor = true;
            this.btnFindXYStruct.Click += new System.EventHandler(this.btnFindXYStruct_Click);
            // 
            // txtBoxFindXYStruct
            // 
            this.txtBoxFindXYStruct.Location = new System.Drawing.Point(184, 127);
            this.txtBoxFindXYStruct.Name = "txtBoxFindXYStruct";
            this.txtBoxFindXYStruct.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFindXYStruct.TabIndex = 9;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(290, 124);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "Get Hex Float";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(286, 83);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(87, 23);
            this.button7.TabIndex = 11;
            this.button7.Text = "Get Hex Int";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 706);
            this.Controls.Add(this.MacroPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(1400, 10);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MacroPage.ResumeLayout(false);
            this.StartTab.ResumeLayout(false);
            this.StartTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLocation)).EndInit();
            this.PathsTab.ResumeLayout(false);
            this.PathsTab.PerformLayout();
            this.TestsTab.ResumeLayout(false);
            this.MacroTab.ResumeLayout(false);
            this.MacroTab.PerformLayout();
            this.PlayerStack.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startBot;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label zLabel;
        private System.Windows.Forms.Label curZ;
        private System.Windows.Forms.Label curY;
        private System.Windows.Forms.Label curX;
        private System.Windows.Forms.Label facingLabel;
        private System.Windows.Forms.Label lblCurrentFacing;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.ListBox locationListBox;
        private System.Windows.Forms.Timer MakePathTimer;
        private System.Windows.Forms.Label recordingLabel;
        private System.Windows.Forms.TabControl MacroPage;
        private System.Windows.Forms.TabPage StartTab;
        private System.Windows.Forms.TabPage PathsTab;
        private System.Windows.Forms.Label pathToSaveLabel;
        private System.Windows.Forms.Label loadedPathLabel;
        private System.Windows.Forms.Button savePathButton;
        private System.Windows.Forms.Button makePathButton;
        private System.Windows.Forms.Button loadPathButton;
        private System.Windows.Forms.TabPage SettingsTab;
        private System.Windows.Forms.ListBox updateBox;
        private System.Windows.Forms.Label lblCurrentTarget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTargetHealth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button pathingToggleBtn;
        protected System.Windows.Forms.Label lblLowestDistance;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblDestinationDirection;
        private System.Windows.Forms.Label distanceLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label destZ;
        private System.Windows.Forms.Label destY;
        private System.Windows.Forms.Label destX;
        private System.Windows.Forms.Label lblCurrentFacingDelta;
        private System.Windows.Forms.Button btnAddWaypoint;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSetPathList;
        internal System.Windows.Forms.Timer pathingLoopTimer;
        private System.Windows.Forms.Label lblDestinationReached;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPathStep;
        private System.Windows.Forms.Button btnStartKillRoutine;
        private System.Windows.Forms.Timer DragonQuestTimer;
        private System.Windows.Forms.Label lblCurrentQuestCount;
        private System.Windows.Forms.Button btnJump;
        private System.Windows.Forms.Button btnSeekRight;
        private System.Windows.Forms.Button btnSeekLeft;
        private System.Windows.Forms.Button btnSeekForward;
        private System.Windows.Forms.Button btnThreadStart;
        private System.Windows.Forms.Label lblQuestNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMakePath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdoGlassLoop;
        private System.Windows.Forms.RadioButton rdoDragonLoop;
        private System.Windows.Forms.Label lblQuestStep;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox DragonQuestListBox;
        private System.Windows.Forms.TabPage TestsTab;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnShift1;
        private System.Windows.Forms.Button btnCtrl5;
        private System.Windows.Forms.Button btnCtrl4;
        private System.Windows.Forms.Button btnCtrl3;
        private System.Windows.Forms.Button btnCtrl2;
        private System.Windows.Forms.Button btnCtrl1;
        private System.Windows.Forms.Label lblCurrentPoint;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnNextPoint;
        private System.Windows.Forms.Label lblPathIndex;
        private System.Windows.Forms.Button btnClearXpPath;
        private System.Windows.Forms.Label lblBackWorker;
        private System.Windows.Forms.Label lblTurnWorker;
        private System.Windows.Forms.CheckBox chkBoxContinueQuest;
        private System.Windows.Forms.Label lblFightWorker;
        private System.Windows.Forms.Timer FightLoopTimer;
        private System.Windows.Forms.CheckBox chkBoxFightEnabled;
        private System.Windows.Forms.Button btnFaceTarget;
        private System.Windows.Forms.Label lblFightTimerStatus;
        private System.Windows.Forms.Label lblTargetID;
        private System.Windows.Forms.TabPage MacroTab;
        private System.Windows.Forms.TextBox txtBoxKeyToPress;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.Button btnToggleMacro;
        private System.Windows.Forms.Timer MacroTimer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBoxDelay;
        private System.Windows.Forms.PictureBox pctBoxLocation;
        private System.Windows.Forms.Label lblCurrentZone;
        private System.Windows.Forms.Label lblCurrentDelta;
        private System.Windows.Forms.Button btnSaveScreenShot;
        private System.Windows.Forms.TabPage SetupTab;
        private System.Windows.Forms.Label lblSlotNumber;
        private System.Windows.Forms.Label lblBagNumber;
        private System.Windows.Forms.Button btnSalvage;
        private System.Windows.Forms.Timer SalvageTimer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBoxEnd;
        private System.Windows.Forms.TextBox txtBoxStart;
        private System.Windows.Forms.Button btnSetPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.Button btnPictQuest;
        private System.Windows.Forms.TabPage PlayerStack;
        private System.Windows.Forms.ListBox lstBoxPlayer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer tmrPlayerStackTest;
        private System.Windows.Forms.ListBox lstBoxHib;
        private System.Windows.Forms.TextBox txtBoxFirstKeyToPress;
        private System.Windows.Forms.Button btnHeal;
        private System.Windows.Forms.Button btnFollow;
        private System.Windows.Forms.TextBox txtBoxKeyFour;
        private System.Windows.Forms.TextBox txtBoxKeyThree;
        private System.Windows.Forms.TextBox txtBoxKeyTwo;
        private System.Windows.Forms.Button btnSteer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblMemoryEnd;
        private System.Windows.Forms.Label lblMemoryStart;
        private System.Windows.Forms.ListBox lstBoxMemoryLocs;
        private System.Windows.Forms.TextBox txtBoxFindInt;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblFound;
        private System.Windows.Forms.Label lblNotFound;
        private System.Windows.Forms.TextBox txtBoxFindXYStruct;
        private System.Windows.Forms.Button btnFindXYStruct;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
    }
}

