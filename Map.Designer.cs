namespace TwoThousandFortyEight
{
    partial class Map
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map));
            this.panel_display = new System.Windows.Forms.Panel();
            this.cell33 = new System.Windows.Forms.Label();
            this.cell32 = new System.Windows.Forms.Label();
            this.cell31 = new System.Windows.Forms.Label();
            this.cell30 = new System.Windows.Forms.Label();
            this.cell23 = new System.Windows.Forms.Label();
            this.cell22 = new System.Windows.Forms.Label();
            this.cell21 = new System.Windows.Forms.Label();
            this.cell20 = new System.Windows.Forms.Label();
            this.cell13 = new System.Windows.Forms.Label();
            this.cell12 = new System.Windows.Forms.Label();
            this.cell11 = new System.Windows.Forms.Label();
            this.cell10 = new System.Windows.Forms.Label();
            this.cell03 = new System.Windows.Forms.Label();
            this.cell02 = new System.Windows.Forms.Label();
            this.cell01 = new System.Windows.Forms.Label();
            this.cell00 = new System.Windows.Forms.Label();
            this.panel_game_field = new System.Windows.Forms.Panel();
            this.panel_statistics = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_sensor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topmost_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.open_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.save_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_menu_item = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.new_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_clock = new System.Windows.Forms.Timer(this.components);
            this.timer_anim = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel_game_field.SuspendLayout();
            this.panel_statistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_sensor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_display
            // 
            this.panel_display.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel_display.Location = new System.Drawing.Point(625, 0);
            this.panel_display.Name = "panel_display";
            this.panel_display.Size = new System.Drawing.Size(255, 528);
            this.panel_display.TabIndex = 0;
            // 
            // cell33
            // 
            this.cell33.BackColor = System.Drawing.Color.White;
            this.cell33.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell33.Location = new System.Drawing.Point(470, 396);
            this.cell33.Name = "cell33";
            this.cell33.Size = new System.Drawing.Size(149, 125);
            this.cell33.TabIndex = 15;
            this.cell33.Text = "0";
            this.cell33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell32
            // 
            this.cell32.BackColor = System.Drawing.Color.White;
            this.cell32.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell32.Location = new System.Drawing.Point(315, 396);
            this.cell32.Name = "cell32";
            this.cell32.Size = new System.Drawing.Size(149, 125);
            this.cell32.TabIndex = 14;
            this.cell32.Text = "4096";
            this.cell32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell31
            // 
            this.cell31.BackColor = System.Drawing.Color.White;
            this.cell31.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell31.Location = new System.Drawing.Point(160, 396);
            this.cell31.Name = "cell31";
            this.cell31.Size = new System.Drawing.Size(149, 125);
            this.cell31.TabIndex = 13;
            this.cell31.Text = "2048";
            this.cell31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell30
            // 
            this.cell30.BackColor = System.Drawing.Color.White;
            this.cell30.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell30.Location = new System.Drawing.Point(5, 396);
            this.cell30.Name = "cell30";
            this.cell30.Size = new System.Drawing.Size(149, 125);
            this.cell30.TabIndex = 12;
            this.cell30.Text = "1024";
            this.cell30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell23
            // 
            this.cell23.BackColor = System.Drawing.Color.White;
            this.cell23.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell23.Location = new System.Drawing.Point(470, 265);
            this.cell23.Name = "cell23";
            this.cell23.Size = new System.Drawing.Size(149, 125);
            this.cell23.TabIndex = 11;
            this.cell23.Text = "512";
            this.cell23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell22
            // 
            this.cell22.BackColor = System.Drawing.Color.White;
            this.cell22.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell22.Location = new System.Drawing.Point(315, 265);
            this.cell22.Name = "cell22";
            this.cell22.Size = new System.Drawing.Size(149, 125);
            this.cell22.TabIndex = 10;
            this.cell22.Text = "256";
            this.cell22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell21
            // 
            this.cell21.BackColor = System.Drawing.Color.White;
            this.cell21.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell21.Location = new System.Drawing.Point(160, 265);
            this.cell21.Name = "cell21";
            this.cell21.Size = new System.Drawing.Size(149, 125);
            this.cell21.TabIndex = 9;
            this.cell21.Text = "128";
            this.cell21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell20
            // 
            this.cell20.BackColor = System.Drawing.Color.White;
            this.cell20.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell20.Location = new System.Drawing.Point(5, 265);
            this.cell20.Name = "cell20";
            this.cell20.Size = new System.Drawing.Size(149, 125);
            this.cell20.TabIndex = 8;
            this.cell20.Text = "64";
            this.cell20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell13
            // 
            this.cell13.BackColor = System.Drawing.Color.White;
            this.cell13.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell13.Location = new System.Drawing.Point(470, 136);
            this.cell13.Name = "cell13";
            this.cell13.Size = new System.Drawing.Size(149, 125);
            this.cell13.TabIndex = 7;
            this.cell13.Text = "32";
            this.cell13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell12
            // 
            this.cell12.BackColor = System.Drawing.Color.White;
            this.cell12.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell12.Location = new System.Drawing.Point(315, 136);
            this.cell12.Name = "cell12";
            this.cell12.Size = new System.Drawing.Size(149, 125);
            this.cell12.TabIndex = 6;
            this.cell12.Text = "16";
            this.cell12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell11
            // 
            this.cell11.BackColor = System.Drawing.Color.White;
            this.cell11.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell11.Location = new System.Drawing.Point(161, 136);
            this.cell11.Name = "cell11";
            this.cell11.Size = new System.Drawing.Size(149, 125);
            this.cell11.TabIndex = 5;
            this.cell11.Text = "8";
            this.cell11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell10
            // 
            this.cell10.BackColor = System.Drawing.Color.White;
            this.cell10.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell10.Location = new System.Drawing.Point(5, 136);
            this.cell10.Name = "cell10";
            this.cell10.Size = new System.Drawing.Size(149, 125);
            this.cell10.TabIndex = 4;
            this.cell10.Text = "0";
            this.cell10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell03
            // 
            this.cell03.BackColor = System.Drawing.Color.White;
            this.cell03.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell03.Location = new System.Drawing.Point(470, 6);
            this.cell03.Name = "cell03";
            this.cell03.Size = new System.Drawing.Size(149, 125);
            this.cell03.TabIndex = 3;
            this.cell03.Text = "4";
            this.cell03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell02
            // 
            this.cell02.BackColor = System.Drawing.Color.White;
            this.cell02.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell02.Location = new System.Drawing.Point(315, 6);
            this.cell02.Name = "cell02";
            this.cell02.Size = new System.Drawing.Size(149, 125);
            this.cell02.TabIndex = 2;
            this.cell02.Text = "2";
            this.cell02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell01
            // 
            this.cell01.BackColor = System.Drawing.Color.White;
            this.cell01.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell01.Location = new System.Drawing.Point(160, 6);
            this.cell01.Name = "cell01";
            this.cell01.Size = new System.Drawing.Size(149, 125);
            this.cell01.TabIndex = 1;
            this.cell01.Text = "0";
            this.cell01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell00
            // 
            this.cell00.BackColor = System.Drawing.Color.White;
            this.cell00.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell00.Location = new System.Drawing.Point(5, 6);
            this.cell00.Name = "cell00";
            this.cell00.Size = new System.Drawing.Size(149, 125);
            this.cell00.TabIndex = 0;
            this.cell00.Text = "0";
            this.cell00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_game_field
            // 
            this.panel_game_field.Controls.Add(this.cell00);
            this.panel_game_field.Controls.Add(this.panel_display);
            this.panel_game_field.Controls.Add(this.cell33);
            this.panel_game_field.Controls.Add(this.cell20);
            this.panel_game_field.Controls.Add(this.cell03);
            this.panel_game_field.Controls.Add(this.cell12);
            this.panel_game_field.Controls.Add(this.cell30);
            this.panel_game_field.Controls.Add(this.cell23);
            this.panel_game_field.Controls.Add(this.cell32);
            this.panel_game_field.Controls.Add(this.cell10);
            this.panel_game_field.Controls.Add(this.cell22);
            this.panel_game_field.Controls.Add(this.cell21);
            this.panel_game_field.Controls.Add(this.cell11);
            this.panel_game_field.Controls.Add(this.cell13);
            this.panel_game_field.Controls.Add(this.cell02);
            this.panel_game_field.Controls.Add(this.cell01);
            this.panel_game_field.Controls.Add(this.cell31);
            this.panel_game_field.Location = new System.Drawing.Point(-1, 29);
            this.panel_game_field.Name = "panel_game_field";
            this.panel_game_field.Size = new System.Drawing.Size(625, 528);
            this.panel_game_field.TabIndex = 16;
            // 
            // panel_statistics
            // 
            this.panel_statistics.Controls.Add(this.label2);
            this.panel_statistics.Controls.Add(this.label1);
            this.panel_statistics.Controls.Add(this.label_time);
            this.panel_statistics.Controls.Add(this.pictureBox2);
            this.panel_statistics.Location = new System.Drawing.Point(624, 29);
            this.panel_statistics.Name = "panel_statistics";
            this.panel_statistics.Size = new System.Drawing.Size(310, 365);
            this.panel_statistics.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Rockwell Extra Bold", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(-1, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 57);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome 2048";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(61, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time:";
            // 
            // label_time
            // 
            this.label_time.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_time.Location = new System.Drawing.Point(136, 164);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(113, 26);
            this.label_time.TabIndex = 1;
            this.label_time.Text = "00:00:00";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(307, 311);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel_sensor
            // 
            this.panel_sensor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_sensor.Controls.Add(this.pictureBox1);
            this.panel_sensor.Location = new System.Drawing.Point(624, 393);
            this.panel_sensor.Name = "panel_sensor";
            this.panel_sensor.Size = new System.Drawing.Size(310, 165);
            this.panel_sensor.TabIndex = 18;
            this.panel_sensor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_sensor_MouseDown);
            this.panel_sensor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_sensor_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(103, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_sensor_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_sensor_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(931, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topmost_menu,
            this.save_menu,
            this.open_menu,
            this.exit_menu_item});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // topmost_menu
            // 
            this.topmost_menu.CheckOnClick = true;
            this.topmost_menu.Name = "topmost_menu";
            this.topmost_menu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.topmost_menu.Size = new System.Drawing.Size(224, 26);
            this.topmost_menu.Text = "Topmost";
            this.topmost_menu.Click += new System.EventHandler(this.topmost_menu_Click);
            // 
            // open_menu
            // 
            this.open_menu.Name = "open_menu";
            this.open_menu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.open_menu.Size = new System.Drawing.Size(224, 26);
            this.open_menu.Text = "Open";
            this.open_menu.Click += new System.EventHandler(this.open_menu_Click);
            // 
            // save_menu
            // 
            this.save_menu.Name = "save_menu";
            this.save_menu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.save_menu.Size = new System.Drawing.Size(224, 26);
            this.save_menu.Text = "Save";
            this.save_menu.Click += new System.EventHandler(this.save_menu_Click);
            // 
            // exit_menu_item
            // 
            this.exit_menu_item.Name = "exit_menu_item";
            this.exit_menu_item.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exit_menu_item.Size = new System.Drawing.Size(224, 26);
            this.exit_menu_item.Text = "Exit";
            this.exit_menu_item.Click += new System.EventHandler(this.exit_menu_item_Click);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.new_menu,
            this.undoToolStripMenuItem,
            this.animateToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // new_menu
            // 
            this.new_menu.Name = "new_menu";
            this.new_menu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.new_menu.Size = new System.Drawing.Size(196, 26);
            this.new_menu.Text = "New";
            this.new_menu.Click += new System.EventHandler(this.new_menu_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // animateToolStripMenuItem
            // 
            this.animateToolStripMenuItem.Name = "animateToolStripMenuItem";
            this.animateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.animateToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.animateToolStripMenuItem.Text = "Animate";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.rulesToolStripMenuItem,
            this.recordToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.rulesToolStripMenuItem.Text = "Rules";
            // 
            // recordToolStripMenuItem
            // 
            this.recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            this.recordToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.recordToolStripMenuItem.Text = "Record";
            // 
            // timer_clock
            // 
            this.timer_clock.Interval = 20;
            this.timer_clock.Tick += new System.EventHandler(this.timer_clock_Tick);
            // 
            // timer_anim
            // 
            this.timer_anim.Tick += new System.EventHandler(this.timer_anim_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(931, 557);
            this.Controls.Add(this.panel_sensor);
            this.Controls.Add(this.panel_statistics);
            this.Controls.Add(this.panel_game_field);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Map";
            this.Text = "2048";
            this.Load += new System.EventHandler(this.Map_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Map_KeyDown);
            this.panel_game_field.ResumeLayout(false);
            this.panel_statistics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_sensor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel_display;
        private Label cell00;
        private Label cell33;
        private Label cell32;
        private Label cell31;
        private Label cell30;
        private Label cell23;
        private Label cell22;
        private Label cell21;
        private Label cell20;
        private Label cell13;
        private Label cell12;
        private Label cell11;
        private Label cell10;
        private Label cell03;
        private Label cell02;
        private Label cell01;
        private Panel panel_game_field;
        private Panel panel_statistics;
        private Panel panel_sensor;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exit_menu_item;
        private ToolStripMenuItem gameToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private Label label_time;
        private System.Windows.Forms.Timer timer_clock;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer_anim;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private ToolStripMenuItem topmost_menu;
        private ToolStripMenuItem new_menu;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem rulesToolStripMenuItem;
        private ToolStripMenuItem animateToolStripMenuItem;
        private ToolStripMenuItem recordToolStripMenuItem;
        private ToolStripMenuItem open_menu;
        private ToolStripMenuItem save_menu;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}