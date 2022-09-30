
namespace SpacewareRBX
{
    partial class MainFRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFRM));
            this.codeBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InjectBTN = new System.Windows.Forms.Button();
            this.SendLuaCBTN = new System.Windows.Forms.Button();
            this.OpenFIleBTN = new System.Windows.Forms.Button();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.attchedLbl = new System.Windows.Forms.Label();
            this.creditLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MinLbl = new System.Windows.Forms.Label();
            this.DiscordBTN = new System.Windows.Forms.Button();
            this.SettingsBTN = new System.Windows.Forms.Button();
            this.SendluaBTN = new System.Windows.Forms.Button();
            this.SaveFileBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.codeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // codeBox
            // 
            this.codeBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.codeBox.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.codeBox.BackBrush = null;
            this.codeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.codeBox.BackgroundImage = global::SpacewareRBX.Properties.Resources.Spce;
            this.codeBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.codeBox.CaretColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.codeBox.CharHeight = 14;
            this.codeBox.CharWidth = 8;
            this.codeBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codeBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.codeBox.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.codeBox.ForeColor = System.Drawing.Color.Gray;
            this.codeBox.IsReplaceMode = false;
            this.codeBox.Location = new System.Drawing.Point(85, 40);
            this.codeBox.Name = "codeBox";
            this.codeBox.Paddings = new System.Windows.Forms.Padding(0);
            this.codeBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.codeBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("codeBox.ServiceColors")));
            this.codeBox.ServiceLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.codeBox.ShowLineNumbers = false;
            this.codeBox.Size = new System.Drawing.Size(573, 267);
            this.codeBox.TabIndex = 0;
            this.codeBox.Zoom = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(-45, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1388, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // InjectBTN
            // 
            this.InjectBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.InjectBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.InjectBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.InjectBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InjectBTN.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.InjectBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.InjectBTN.Location = new System.Drawing.Point(9, 40);
            this.InjectBTN.Name = "InjectBTN";
            this.InjectBTN.Size = new System.Drawing.Size(69, 33);
            this.InjectBTN.TabIndex = 2;
            this.InjectBTN.Text = "Inject";
            this.InjectBTN.UseVisualStyleBackColor = true;
            this.InjectBTN.Click += new System.EventHandler(this.Inject_Click);
            // 
            // SendLuaCBTN
            // 
            this.SendLuaCBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.SendLuaCBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.SendLuaCBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.SendLuaCBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SendLuaCBTN.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.SendLuaCBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SendLuaCBTN.Location = new System.Drawing.Point(9, 118);
            this.SendLuaCBTN.Name = "SendLuaCBTN";
            this.SendLuaCBTN.Size = new System.Drawing.Size(69, 33);
            this.SendLuaCBTN.TabIndex = 5;
            this.SendLuaCBTN.Text = "LUAC";
            this.SendLuaCBTN.UseVisualStyleBackColor = true;
            this.SendLuaCBTN.Click += new System.EventHandler(this.SendLuaCBTN_Click);
            // 
            // OpenFIleBTN
            // 
            this.OpenFIleBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.OpenFIleBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.OpenFIleBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.OpenFIleBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OpenFIleBTN.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.OpenFIleBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OpenFIleBTN.Location = new System.Drawing.Point(9, 157);
            this.OpenFIleBTN.Name = "OpenFIleBTN";
            this.OpenFIleBTN.Size = new System.Drawing.Size(69, 33);
            this.OpenFIleBTN.TabIndex = 6;
            this.OpenFIleBTN.Text = "Open";
            this.OpenFIleBTN.UseVisualStyleBackColor = true;
            this.OpenFIleBTN.Click += new System.EventHandler(this.OpenFIleBTN_Click);
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TitleLbl.Location = new System.Drawing.Point(6, 9);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(403, 17);
            this.TitleLbl.TabIndex = 7;
            this.TitleLbl.Text = "SpacewareRBX - Cheat Like  A God, Never Pay For Cheats Again!";
            this.TitleLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Object_MouseDown);
            this.TitleLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Object_MouseMove);
            this.TitleLbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Object_MouseUp);
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.statusLbl.Location = new System.Drawing.Point(12, 320);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(54, 17);
            this.statusLbl.TabIndex = 10;
            this.statusLbl.Text = "Status: ";
            // 
            // attchedLbl
            // 
            this.attchedLbl.AutoSize = true;
            this.attchedLbl.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attchedLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.attchedLbl.Location = new System.Drawing.Point(256, 320);
            this.attchedLbl.Name = "attchedLbl";
            this.attchedLbl.Size = new System.Drawing.Size(90, 17);
            this.attchedLbl.TabIndex = 11;
            this.attchedLbl.Text = "Injected: N/A";
            // 
            // creditLbl
            // 
            this.creditLbl.AutoSize = true;
            this.creditLbl.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.creditLbl.Location = new System.Drawing.Point(514, 320);
            this.creditLbl.Name = "creditLbl";
            this.creditLbl.Size = new System.Drawing.Size(144, 17);
            this.creditLbl.TabIndex = 12;
            this.creditLbl.Text = "Developed By: Joshua";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(635, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.Close_Click);
            // 
            // MinLbl
            // 
            this.MinLbl.AutoSize = true;
            this.MinLbl.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MinLbl.Location = new System.Drawing.Point(619, 8);
            this.MinLbl.Name = "MinLbl";
            this.MinLbl.Size = new System.Drawing.Size(13, 17);
            this.MinLbl.TabIndex = 14;
            this.MinLbl.Text = "_";
            this.MinLbl.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // DiscordBTN
            // 
            this.DiscordBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.DiscordBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.DiscordBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.DiscordBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DiscordBTN.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.DiscordBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DiscordBTN.Location = new System.Drawing.Point(9, 274);
            this.DiscordBTN.Name = "DiscordBTN";
            this.DiscordBTN.Size = new System.Drawing.Size(69, 33);
            this.DiscordBTN.TabIndex = 9;
            this.DiscordBTN.Text = "Discord";
            this.DiscordBTN.UseVisualStyleBackColor = true;
            this.DiscordBTN.Click += new System.EventHandler(this.DiscordBTN_Click);
            // 
            // SettingsBTN
            // 
            this.SettingsBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.SettingsBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.SettingsBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.SettingsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SettingsBTN.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.SettingsBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SettingsBTN.Location = new System.Drawing.Point(9, 235);
            this.SettingsBTN.Name = "SettingsBTN";
            this.SettingsBTN.Size = new System.Drawing.Size(69, 33);
            this.SettingsBTN.TabIndex = 8;
            this.SettingsBTN.Text = "Settings";
            this.SettingsBTN.UseVisualStyleBackColor = true;
            this.SettingsBTN.Visible = false;
            // 
            // SendluaBTN
            // 
            this.SendluaBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.SendluaBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.SendluaBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.SendluaBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SendluaBTN.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.SendluaBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SendluaBTN.Location = new System.Drawing.Point(9, 79);
            this.SendluaBTN.Name = "SendluaBTN";
            this.SendluaBTN.Size = new System.Drawing.Size(69, 33);
            this.SendluaBTN.TabIndex = 15;
            this.SendluaBTN.Text = "LUA";
            this.SendluaBTN.UseVisualStyleBackColor = true;
            this.SendluaBTN.Click += new System.EventHandler(this.SendluaBTN_Click);
            // 
            // SaveFileBTN
            // 
            this.SaveFileBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.SaveFileBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.SaveFileBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.SaveFileBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveFileBTN.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.SaveFileBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SaveFileBTN.Location = new System.Drawing.Point(9, 196);
            this.SaveFileBTN.Name = "SaveFileBTN";
            this.SaveFileBTN.Size = new System.Drawing.Size(69, 33);
            this.SaveFileBTN.TabIndex = 16;
            this.SaveFileBTN.Text = "Save";
            this.SaveFileBTN.UseVisualStyleBackColor = true;
            this.SaveFileBTN.Click += new System.EventHandler(this.SaveFileBTN_Click);
            // 
            // MainFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(669, 351);
            this.Controls.Add(this.SaveFileBTN);
            this.Controls.Add(this.SendluaBTN);
            this.Controls.Add(this.MinLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.creditLbl);
            this.Controls.Add(this.attchedLbl);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.DiscordBTN);
            this.Controls.Add(this.SettingsBTN);
            this.Controls.Add(this.codeBox);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.OpenFIleBTN);
            this.Controls.Add(this.SendLuaCBTN);
            this.Controls.Add(this.InjectBTN);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpacewareRBX - Cheat Like  A God, Never Pay For Cheats Again!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.codeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox codeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InjectBTN;
        private System.Windows.Forms.Button SendLuaCBTN;
        private System.Windows.Forms.Button OpenFIleBTN;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label attchedLbl;
        private System.Windows.Forms.Label creditLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label MinLbl;
        private System.Windows.Forms.Button DiscordBTN;
        private System.Windows.Forms.Button SettingsBTN;
        private System.Windows.Forms.Button SendluaBTN;
        private System.Windows.Forms.Button SaveFileBTN;
    }
}
