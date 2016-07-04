namespace Penguin
{
    partial class xpPathForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pathsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pathsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pathsToolStripMenuItem
            // 
            this.pathsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makePathToolStripMenuItem,
            this.loadPathToolStripMenuItem,
            this.savePathToolStripMenuItem});
            this.pathsToolStripMenuItem.Name = "pathsToolStripMenuItem";
            this.pathsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.pathsToolStripMenuItem.Text = "Paths";
            // 
            // makePathToolStripMenuItem
            // 
            this.makePathToolStripMenuItem.Name = "makePathToolStripMenuItem";
            this.makePathToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.makePathToolStripMenuItem.Text = "Make Path";
            // 
            // loadPathToolStripMenuItem
            // 
            this.loadPathToolStripMenuItem.Name = "loadPathToolStripMenuItem";
            this.loadPathToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadPathToolStripMenuItem.Text = "Load Path";
            // 
            // savePathToolStripMenuItem
            // 
            this.savePathToolStripMenuItem.Name = "savePathToolStripMenuItem";
            this.savePathToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.savePathToolStripMenuItem.Text = "Save Path";
            // 
            // xpPathForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "xpPathForm";
            this.Text = "xpPathForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pathsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makePathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePathToolStripMenuItem;
    }
}