namespace Lab10
{
    partial class NameGamer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NameGamer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.TextBoxName = new Lab10.RJTextBox();
            this.ButtonOk = new Lab10.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel1.Controls.Add(this.pictureBoxExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 46);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.Location = new System.Drawing.Point(527, 4);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(43, 39);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxExit.TabIndex = 1;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(31, 126);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(240, 40);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Введите свое имя:";
            // 
            // TextBoxName
            // 
            this.TextBoxName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextBoxName.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.TextBoxName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TextBoxName.BorderRadius = 0;
            this.TextBoxName.BorderSize = 2;
            this.TextBoxName.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxName.ForeColor = System.Drawing.Color.Black;
            this.TextBoxName.Location = new System.Drawing.Point(291, 121);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxName.Multiline = false;
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TextBoxName.PasswordChar = false;
            this.TextBoxName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBoxName.PlaceholderText = "";
            this.TextBoxName.Size = new System.Drawing.Size(202, 38);
            this.TextBoxName.TabIndex = 3;
            this.TextBoxName.Texts = "";
            this.TextBoxName.UnderlinedStyle = true;
            this.TextBoxName._TextChanged += new System.EventHandler(this.TextBoxName__TextChanged);
            this.TextBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxName_KeyPress);
            // 
            // ButtonOk
            // 
            this.ButtonOk.BackColor = System.Drawing.Color.OliveDrab;
            this.ButtonOk.BackgroundColor = System.Drawing.Color.OliveDrab;
            this.ButtonOk.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonOk.BorderRadius = 25;
            this.ButtonOk.BorderSize = 0;
            this.ButtonOk.Enabled = false;
            this.ButtonOk.FlatAppearance.BorderSize = 0;
            this.ButtonOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.ButtonOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ButtonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOk.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonOk.ForeColor = System.Drawing.Color.White;
            this.ButtonOk.Location = new System.Drawing.Point(38, 188);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(157, 54);
            this.ButtonOk.TabIndex = 1;
            this.ButtonOk.Text = "OK";
            this.ButtonOk.TextColor = System.Drawing.Color.White;
            this.ButtonOk.UseVisualStyleBackColor = false;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // NameGamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(573, 426);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NameGamer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NameGamer";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private RJButton ButtonOk;
        private System.Windows.Forms.Label labelName;
        private RJTextBox TextBoxName;
    }
}