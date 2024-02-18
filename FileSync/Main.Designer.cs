namespace FileSync
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.header_panel = new System.Windows.Forms.Panel();
            this.siticoneButton5 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton3 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.header_title = new System.Windows.Forms.Label();
            this.setting_panel = new System.Windows.Forms.Panel();
            this.sync_path = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.select_game_label = new System.Windows.Forms.Label();
            this.game_select = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneProgressBar1 = new Siticone.Desktop.UI.WinForms.SiticoneProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.siticoneButton4 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.header_panel.SuspendLayout();
            this.setting_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // header_panel
            // 
            this.header_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.header_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.header_panel.Controls.Add(this.siticoneButton5);
            this.header_panel.Controls.Add(this.siticoneButton3);
            this.header_panel.Controls.Add(this.header_title);
            this.header_panel.Location = new System.Drawing.Point(-3, -3);
            this.header_panel.Name = "header_panel";
            this.header_panel.Size = new System.Drawing.Size(697, 42);
            this.header_panel.TabIndex = 0;
            this.header_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.header_panel_Paint);
            this.header_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Event);
            this.header_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Event);
            this.header_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_Event);
            // 
            // siticoneButton5
            // 
            this.siticoneButton5.Animated = true;
            this.siticoneButton5.BorderColor = System.Drawing.Color.DimGray;
            this.siticoneButton5.BorderThickness = 1;
            this.siticoneButton5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton5.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton5.ForeColor = System.Drawing.Color.White;
            this.siticoneButton5.Location = new System.Drawing.Point(534, 10);
            this.siticoneButton5.Name = "siticoneButton5";
            this.siticoneButton5.Size = new System.Drawing.Size(35, 23);
            this.siticoneButton5.TabIndex = 2;
            this.siticoneButton5.Text = "X";
            this.siticoneButton5.Click += new System.EventHandler(this.siticoneButton5_Click);
            // 
            // siticoneButton3
            // 
            this.siticoneButton3.Animated = true;
            this.siticoneButton3.BorderColor = System.Drawing.Color.DimGray;
            this.siticoneButton3.BorderThickness = 1;
            this.siticoneButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton3.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton3.ForeColor = System.Drawing.Color.White;
            this.siticoneButton3.Location = new System.Drawing.Point(496, 10);
            this.siticoneButton3.Name = "siticoneButton3";
            this.siticoneButton3.Size = new System.Drawing.Size(35, 23);
            this.siticoneButton3.TabIndex = 1;
            this.siticoneButton3.Text = "-";
            this.siticoneButton3.Click += new System.EventHandler(this.siticoneButton3_Click);
            // 
            // header_title
            // 
            this.header_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header_title.AutoSize = true;
            this.header_title.BackColor = System.Drawing.Color.Transparent;
            this.header_title.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_title.ForeColor = System.Drawing.Color.AliceBlue;
            this.header_title.Location = new System.Drawing.Point(11, 10);
            this.header_title.Name = "header_title";
            this.header_title.Size = new System.Drawing.Size(217, 23);
            this.header_title.TabIndex = 0;
            this.header_title.Text = "CS2-HVH | Server File Sync";
            this.header_title.Click += new System.EventHandler(this.header_title_Click);
            // 
            // setting_panel
            // 
            this.setting_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.setting_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setting_panel.Controls.Add(this.sync_path);
            this.setting_panel.Controls.Add(this.label3);
            this.setting_panel.Controls.Add(this.siticoneButton1);
            this.setting_panel.Controls.Add(this.select_game_label);
            this.setting_panel.Controls.Add(this.game_select);
            this.setting_panel.Location = new System.Drawing.Point(7, 74);
            this.setting_panel.Name = "setting_panel";
            this.setting_panel.Size = new System.Drawing.Size(560, 228);
            this.setting_panel.TabIndex = 1;
            this.setting_panel.Click += new System.EventHandler(this.setting_panel_Click);
            this.setting_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.setting_panel_Paint);
            // 
            // sync_path
            // 
            this.sync_path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.sync_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sync_path.Enabled = false;
            this.sync_path.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sync_path.ForeColor = System.Drawing.SystemColors.Window;
            this.sync_path.Location = new System.Drawing.Point(3, 103);
            this.sync_path.Multiline = true;
            this.sync_path.Name = "sync_path";
            this.sync_path.Size = new System.Drawing.Size(552, 36);
            this.sync_path.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(1, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Path:";
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.Animated = true;
            this.siticoneButton1.BorderColor = System.Drawing.Color.DimGray;
            this.siticoneButton1.BorderThickness = 1;
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.Location = new System.Drawing.Point(2, 179);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(553, 45);
            this.siticoneButton1.TabIndex = 4;
            this.siticoneButton1.Text = "Save Settings";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // select_game_label
            // 
            this.select_game_label.AutoSize = true;
            this.select_game_label.BackColor = System.Drawing.Color.Transparent;
            this.select_game_label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_game_label.ForeColor = System.Drawing.SystemColors.Control;
            this.select_game_label.Location = new System.Drawing.Point(-1, 11);
            this.select_game_label.Name = "select_game_label";
            this.select_game_label.Size = new System.Drawing.Size(157, 18);
            this.select_game_label.TabIndex = 1;
            this.select_game_label.Text = "Selected HvH Server:";
            // 
            // game_select
            // 
            this.game_select.BackColor = System.Drawing.Color.Transparent;
            this.game_select.BorderColor = System.Drawing.Color.DimGray;
            this.game_select.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.game_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.game_select.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.game_select.FocusedColor = System.Drawing.Color.DimGray;
            this.game_select.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.game_select.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.game_select.FocusedState.ForeColor = System.Drawing.Color.White;
            this.game_select.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.game_select.ForeColor = System.Drawing.Color.White;
            this.game_select.ItemHeight = 30;
            this.game_select.Items.AddRange(new object[] {
            "AWESOME NETWORK"});
            this.game_select.Location = new System.Drawing.Point(3, 32);
            this.game_select.Name = "game_select";
            this.game_select.Size = new System.Drawing.Size(552, 36);
            this.game_select.TabIndex = 0;
            this.game_select.SelectedIndexChanged += new System.EventHandler(this.game_select_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Settings";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-3, 503);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 36);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(12, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "CS2-HVH File Sync | Coded by Stoned";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(5, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Informations";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.siticoneProgressBar1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.siticoneButton4);
            this.panel2.Location = new System.Drawing.Point(7, 335);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 149);
            this.panel2.TabIndex = 3;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(221, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sync Completed";
            this.label1.Visible = false;
            // 
            // siticoneProgressBar1
            // 
            this.siticoneProgressBar1.BorderColor = System.Drawing.Color.DimGray;
            this.siticoneProgressBar1.BorderThickness = 1;
            this.siticoneProgressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.siticoneProgressBar1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneProgressBar1.ForeColor = System.Drawing.SystemColors.Control;
            this.siticoneProgressBar1.Location = new System.Drawing.Point(2, 63);
            this.siticoneProgressBar1.Name = "siticoneProgressBar1";
            this.siticoneProgressBar1.ProgressColor = System.Drawing.Color.Green;
            this.siticoneProgressBar1.ProgressColor2 = System.Drawing.Color.GreenYellow;
            this.siticoneProgressBar1.ShowText = true;
            this.siticoneProgressBar1.Size = new System.Drawing.Size(553, 30);
            this.siticoneProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.siticoneProgressBar1.TabIndex = 8;
            this.siticoneProgressBar1.Text = "siticoneProgressBar1";
            this.siticoneProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(-1, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Last Sync: 10.02.2024";
            // 
            // siticoneButton4
            // 
            this.siticoneButton4.Animated = true;
            this.siticoneButton4.BorderColor = System.Drawing.Color.DimGray;
            this.siticoneButton4.BorderThickness = 1;
            this.siticoneButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.siticoneButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton4.ForeColor = System.Drawing.Color.White;
            this.siticoneButton4.Location = new System.Drawing.Point(2, 100);
            this.siticoneButton4.Name = "siticoneButton4";
            this.siticoneButton4.Size = new System.Drawing.Size(553, 45);
            this.siticoneButton4.TabIndex = 4;
            this.siticoneButton4.Text = "Sync Server Files";
            this.siticoneButton4.Click += new System.EventHandler(this.siticoneButton4_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(573, 533);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.setting_panel);
            this.Controls.Add(this.header_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Click += new System.EventHandler(this.Main_Click);
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            this.setting_panel.ResumeLayout(false);
            this.setting_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header_panel;
        private System.Windows.Forms.Label header_title;
        private System.Windows.Forms.Panel setting_panel;
        private System.Windows.Forms.Label select_game_label;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox game_select;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton4;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton5;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton3;
        private System.Windows.Forms.Label label6;
        private Siticone.Desktop.UI.WinForms.SiticoneProgressBar siticoneProgressBar1;
        private System.Windows.Forms.TextBox sync_path;
        private System.Windows.Forms.Label label1;
    }
}