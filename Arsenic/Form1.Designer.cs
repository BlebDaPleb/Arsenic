namespace Arsenic
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
            this.Panel_Main = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ShowTeamSnapline = new System.Windows.Forms.CheckBox();
            this.ShowEnemySnap = new System.Windows.Forms.CheckBox();
            this.SnaplineEnabled = new System.Windows.Forms.CheckBox();
            this.ShowTeam = new System.Windows.Forms.CheckBox();
            this.ShowEnemy = new System.Windows.Forms.CheckBox();
            this.WHEnabled = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BodyShotCheck = new System.Windows.Forms.CheckBox();
            this.FovAmountUD = new System.Windows.Forms.NumericUpDown();
            this.ShowFov = new System.Windows.Forms.CheckBox();
            this.WallAimCheck = new System.Windows.Forms.CheckBox();
            this.AimbotEnabled = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SprayCheck = new System.Windows.Forms.CheckBox();
            this.TriggerbotEnabled = new System.Windows.Forms.CheckBox();
            this.Panel_Name = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BHopCheck = new System.Windows.Forms.CheckBox();
            this.Panel_Main.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FovAmountUD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Panel_Name.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Main
            // 
            this.Panel_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Panel_Main.Controls.Add(this.groupBox4);
            this.Panel_Main.Controls.Add(this.groupBox3);
            this.Panel_Main.Controls.Add(this.groupBox2);
            this.Panel_Main.Controls.Add(this.groupBox1);
            this.Panel_Main.Controls.Add(this.Panel_Name);
            this.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Main.Location = new System.Drawing.Point(0, 0);
            this.Panel_Main.Name = "Panel_Main";
            this.Panel_Main.Size = new System.Drawing.Size(541, 299);
            this.Panel_Main.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ShowTeamSnapline);
            this.groupBox3.Controls.Add(this.ShowEnemySnap);
            this.groupBox3.Controls.Add(this.SnaplineEnabled);
            this.groupBox3.Controls.Add(this.ShowTeam);
            this.groupBox3.Controls.Add(this.ShowEnemy);
            this.groupBox3.Controls.Add(this.WHEnabled);
            this.groupBox3.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.groupBox3.Location = new System.Drawing.Point(376, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(162, 218);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ESP n Visuals";
            // 
            // ShowTeamSnapline
            // 
            this.ShowTeamSnapline.AutoSize = true;
            this.ShowTeamSnapline.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowTeamSnapline.Location = new System.Drawing.Point(17, 153);
            this.ShowTeamSnapline.Name = "ShowTeamSnapline";
            this.ShowTeamSnapline.Size = new System.Drawing.Size(130, 25);
            this.ShowTeamSnapline.TabIndex = 5;
            this.ShowTeamSnapline.Text = "Team Snapline";
            this.ShowTeamSnapline.UseVisualStyleBackColor = true;
            this.ShowTeamSnapline.CheckedChanged += new System.EventHandler(this.ShowTeamSnapline_CheckedChanged);
            // 
            // ShowEnemySnap
            // 
            this.ShowEnemySnap.AutoSize = true;
            this.ShowEnemySnap.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowEnemySnap.Location = new System.Drawing.Point(17, 129);
            this.ShowEnemySnap.Name = "ShowEnemySnap";
            this.ShowEnemySnap.Size = new System.Drawing.Size(139, 25);
            this.ShowEnemySnap.TabIndex = 4;
            this.ShowEnemySnap.Text = "Enemy Snapline";
            this.ShowEnemySnap.UseVisualStyleBackColor = true;
            this.ShowEnemySnap.CheckedChanged += new System.EventHandler(this.ShowEnemySnap_CheckedChanged);
            // 
            // SnaplineEnabled
            // 
            this.SnaplineEnabled.AutoSize = true;
            this.SnaplineEnabled.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SnaplineEnabled.Location = new System.Drawing.Point(17, 105);
            this.SnaplineEnabled.Name = "SnaplineEnabled";
            this.SnaplineEnabled.Size = new System.Drawing.Size(90, 25);
            this.SnaplineEnabled.TabIndex = 3;
            this.SnaplineEnabled.Text = "Snapline";
            this.SnaplineEnabled.UseVisualStyleBackColor = true;
            this.SnaplineEnabled.CheckedChanged += new System.EventHandler(this.SnaplineEnabled_CheckedChanged);
            // 
            // ShowTeam
            // 
            this.ShowTeam.AutoSize = true;
            this.ShowTeam.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowTeam.Location = new System.Drawing.Point(17, 74);
            this.ShowTeam.Name = "ShowTeam";
            this.ShowTeam.Size = new System.Drawing.Size(106, 25);
            this.ShowTeam.TabIndex = 2;
            this.ShowTeam.Text = "Show Team";
            this.ShowTeam.UseVisualStyleBackColor = true;
            this.ShowTeam.CheckedChanged += new System.EventHandler(this.ShowTeam_CheckedChanged);
            // 
            // ShowEnemy
            // 
            this.ShowEnemy.AutoSize = true;
            this.ShowEnemy.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowEnemy.Location = new System.Drawing.Point(17, 52);
            this.ShowEnemy.Name = "ShowEnemy";
            this.ShowEnemy.Size = new System.Drawing.Size(115, 25);
            this.ShowEnemy.TabIndex = 1;
            this.ShowEnemy.Text = "Show Enemy";
            this.ShowEnemy.UseVisualStyleBackColor = true;
            this.ShowEnemy.CheckedChanged += new System.EventHandler(this.ShowEnemy_CheckedChanged);
            // 
            // WHEnabled
            // 
            this.WHEnabled.AutoSize = true;
            this.WHEnabled.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WHEnabled.Location = new System.Drawing.Point(17, 31);
            this.WHEnabled.Name = "WHEnabled";
            this.WHEnabled.Size = new System.Drawing.Size(86, 25);
            this.WHEnabled.TabIndex = 0;
            this.WHEnabled.Text = "Enabled";
            this.WHEnabled.UseVisualStyleBackColor = true;
            this.WHEnabled.CheckedChanged += new System.EventHandler(this.WHEnabled_CheckedChanged_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BodyShotCheck);
            this.groupBox2.Controls.Add(this.FovAmountUD);
            this.groupBox2.Controls.Add(this.ShowFov);
            this.groupBox2.Controls.Add(this.WallAimCheck);
            this.groupBox2.Controls.Add(this.AimbotEnabled);
            this.groupBox2.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.groupBox2.Location = new System.Drawing.Point(138, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(232, 218);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aimbot";
            // 
            // BodyShotCheck
            // 
            this.BodyShotCheck.AutoSize = true;
            this.BodyShotCheck.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BodyShotCheck.Location = new System.Drawing.Point(17, 97);
            this.BodyShotCheck.Name = "BodyShotCheck";
            this.BodyShotCheck.Size = new System.Drawing.Size(99, 25);
            this.BodyShotCheck.TabIndex = 4;
            this.BodyShotCheck.Text = "Body Shot";
            this.BodyShotCheck.UseVisualStyleBackColor = true;
            // 
            // FovAmountUD
            // 
            this.FovAmountUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.FovAmountUD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FovAmountUD.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FovAmountUD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.FovAmountUD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.FovAmountUD.Location = new System.Drawing.Point(17, 129);
            this.FovAmountUD.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.FovAmountUD.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.FovAmountUD.Name = "FovAmountUD";
            this.FovAmountUD.ReadOnly = true;
            this.FovAmountUD.Size = new System.Drawing.Size(142, 25);
            this.FovAmountUD.TabIndex = 3;
            this.FovAmountUD.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.FovAmountUD.ValueChanged += new System.EventHandler(this.FovAmountUD_ValueChanged);
            // 
            // ShowFov
            // 
            this.ShowFov.AutoSize = true;
            this.ShowFov.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowFov.Location = new System.Drawing.Point(17, 74);
            this.ShowFov.Name = "ShowFov";
            this.ShowFov.Size = new System.Drawing.Size(142, 25);
            this.ShowFov.TabIndex = 2;
            this.ShowFov.Text = "Show FOV Circle";
            this.ShowFov.UseVisualStyleBackColor = true;
            this.ShowFov.CheckedChanged += new System.EventHandler(this.ShowFov_CheckedChanged);
            // 
            // WallAimCheck
            // 
            this.WallAimCheck.AutoSize = true;
            this.WallAimCheck.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WallAimCheck.Location = new System.Drawing.Point(17, 52);
            this.WallAimCheck.Name = "WallAimCheck";
            this.WallAimCheck.Size = new System.Drawing.Size(156, 25);
            this.WallAimCheck.TabIndex = 1;
            this.WallAimCheck.Text = "Aim Through Walls";
            this.WallAimCheck.UseVisualStyleBackColor = true;
            // 
            // AimbotEnabled
            // 
            this.AimbotEnabled.AutoSize = true;
            this.AimbotEnabled.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AimbotEnabled.Location = new System.Drawing.Point(17, 30);
            this.AimbotEnabled.Name = "AimbotEnabled";
            this.AimbotEnabled.Size = new System.Drawing.Size(86, 25);
            this.AimbotEnabled.TabIndex = 0;
            this.AimbotEnabled.Text = "Enabled";
            this.AimbotEnabled.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SprayCheck);
            this.groupBox1.Controls.Add(this.TriggerbotEnabled);
            this.groupBox1.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.groupBox1.Location = new System.Drawing.Point(3, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(129, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Triggerbot";
            // 
            // SprayCheck
            // 
            this.SprayCheck.AutoSize = true;
            this.SprayCheck.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SprayCheck.Location = new System.Drawing.Point(17, 52);
            this.SprayCheck.Name = "SprayCheck";
            this.SprayCheck.Size = new System.Drawing.Size(68, 25);
            this.SprayCheck.TabIndex = 1;
            this.SprayCheck.Text = "Spray";
            this.SprayCheck.UseVisualStyleBackColor = true;
            // 
            // TriggerbotEnabled
            // 
            this.TriggerbotEnabled.AutoSize = true;
            this.TriggerbotEnabled.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TriggerbotEnabled.Location = new System.Drawing.Point(17, 30);
            this.TriggerbotEnabled.Name = "TriggerbotEnabled";
            this.TriggerbotEnabled.Size = new System.Drawing.Size(86, 25);
            this.TriggerbotEnabled.TabIndex = 0;
            this.TriggerbotEnabled.Text = "Enabled";
            this.TriggerbotEnabled.UseVisualStyleBackColor = true;
            // 
            // Panel_Name
            // 
            this.Panel_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Panel_Name.Controls.Add(this.label1);
            this.Panel_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Name.ForeColor = System.Drawing.Color.Black;
            this.Panel_Name.Location = new System.Drawing.Point(0, 0);
            this.Panel_Name.Name = "Panel_Name";
            this.Panel_Name.Size = new System.Drawing.Size(541, 72);
            this.Panel_Name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Toxico", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.label1.Location = new System.Drawing.Point(101, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ArseNic";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BHopCheck);
            this.groupBox4.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.groupBox4.Location = new System.Drawing.Point(3, 206);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox4.Size = new System.Drawing.Size(129, 90);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "BHop";
            // 
            // BHopCheck
            // 
            this.BHopCheck.AutoSize = true;
            this.BHopCheck.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BHopCheck.Location = new System.Drawing.Point(17, 30);
            this.BHopCheck.Name = "BHopCheck";
            this.BHopCheck.Size = new System.Drawing.Size(86, 25);
            this.BHopCheck.TabIndex = 0;
            this.BHopCheck.Text = "Enabled";
            this.BHopCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 299);
            this.Controls.Add(this.Panel_Main);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel_Main.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FovAmountUD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Panel_Name.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Main;
        private System.Windows.Forms.Panel Panel_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox SprayCheck;
        private System.Windows.Forms.CheckBox TriggerbotEnabled;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox WallAimCheck;
        private System.Windows.Forms.CheckBox AimbotEnabled;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ShowEnemy;
        private System.Windows.Forms.CheckBox WHEnabled;
        private System.Windows.Forms.CheckBox SnaplineEnabled;
        private System.Windows.Forms.CheckBox ShowTeam;
        private System.Windows.Forms.CheckBox ShowTeamSnapline;
        private System.Windows.Forms.CheckBox ShowEnemySnap;
        private System.Windows.Forms.CheckBox ShowFov;
        private System.Windows.Forms.NumericUpDown FovAmountUD;
        private System.Windows.Forms.CheckBox BodyShotCheck;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox BHopCheck;
    }
}

