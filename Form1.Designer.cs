namespace Lab10
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRules = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButtonSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.фруктыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.одеждаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мебельToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonDiagram = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelIncorrectAnswers = new System.Windows.Forms.Label();
            this.labelCorrectAnswers = new System.Windows.Forms.Label();
            this.ProgressBar = new Lab10.RJProgressBar();
            this.ButtonAnswer = new Lab10.RJButton();
            this.TextBoxAnswer = new Lab10.RJTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.pictureBoxExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 52);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.Location = new System.Drawing.Point(966, 4);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(48, 45);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxExit.TabIndex = 0;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonStart,
            this.toolStripButtonStop,
            this.toolStripButtonSave,
            this.toolStripButtonRules,
            this.toolStripDropDownButtonSettings,
            this.toolStripButtonDiagram});
            this.toolStrip.Location = new System.Drawing.Point(0, 52);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(6, 6, 15, 6);
            this.toolStrip.Size = new System.Drawing.Size(1017, 42);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButtonStart
            // 
            this.toolStripButtonStart.Enabled = false;
            this.toolStripButtonStart.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStart.Image")));
            this.toolStripButtonStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStart.Name = "toolStripButtonStart";
            this.toolStripButtonStart.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolStripButtonStart.Size = new System.Drawing.Size(114, 27);
            this.toolStripButtonStart.Text = "Начать";
            this.toolStripButtonStart.Click += new System.EventHandler(this.toolStripButtonStart_Click);
            // 
            // toolStripButtonStop
            // 
            this.toolStripButtonStop.Enabled = false;
            this.toolStripButtonStop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStop.Image")));
            this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStop.Name = "toolStripButtonStop";
            this.toolStripButtonStop.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.toolStripButtonStop.Size = new System.Drawing.Size(102, 27);
            this.toolStripButtonStop.Text = "Стоп";
            this.toolStripButtonStop.Click += new System.EventHandler(this.toolStripButtonStop_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.Enabled = false;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.toolStripButtonSave.Size = new System.Drawing.Size(155, 27);
            this.toolStripButtonSave.Text = "Сохранить";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButtonRules
            // 
            this.toolStripButtonRules.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRules.Image")));
            this.toolStripButtonRules.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRules.Name = "toolStripButtonRules";
            this.toolStripButtonRules.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.toolStripButtonRules.Size = new System.Drawing.Size(132, 27);
            this.toolStripButtonRules.Text = "Правила";
            this.toolStripButtonRules.Click += new System.EventHandler(this.toolStripButtonRules_Click);
            // 
            // toolStripDropDownButtonSettings
            // 
            this.toolStripDropDownButtonSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фруктыToolStripMenuItem,
            this.одеждаToolStripMenuItem,
            this.мебельToolStripMenuItem,
            this.всеToolStripMenuItem});
            this.toolStripDropDownButtonSettings.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonSettings.Image")));
            this.toolStripDropDownButtonSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonSettings.Name = "toolStripDropDownButtonSettings";
            this.toolStripDropDownButtonSettings.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.toolStripDropDownButtonSettings.Size = new System.Drawing.Size(164, 27);
            this.toolStripDropDownButtonSettings.Text = "Настройки";
            // 
            // фруктыToolStripMenuItem
            // 
            this.фруктыToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.фруктыToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("фруктыToolStripMenuItem.Image")));
            this.фруктыToolStripMenuItem.Name = "фруктыToolStripMenuItem";
            this.фруктыToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.фруктыToolStripMenuItem.Text = "Фрукты";
            this.фруктыToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // одеждаToolStripMenuItem
            // 
            this.одеждаToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.одеждаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("одеждаToolStripMenuItem.Image")));
            this.одеждаToolStripMenuItem.Name = "одеждаToolStripMenuItem";
            this.одеждаToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.одеждаToolStripMenuItem.Text = "Одежда";
            this.одеждаToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // мебельToolStripMenuItem
            // 
            this.мебельToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.мебельToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("мебельToolStripMenuItem.Image")));
            this.мебельToolStripMenuItem.Name = "мебельToolStripMenuItem";
            this.мебельToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.мебельToolStripMenuItem.Text = "Мебель";
            this.мебельToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // всеToolStripMenuItem
            // 
            this.всеToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.всеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("всеToolStripMenuItem.Image")));
            this.всеToolStripMenuItem.Name = "всеToolStripMenuItem";
            this.всеToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.всеToolStripMenuItem.Text = "Все";
            this.всеToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // toolStripButtonDiagram
            // 
            this.toolStripButtonDiagram.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDiagram.Image")));
            this.toolStripButtonDiagram.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDiagram.Name = "toolStripButtonDiagram";
            this.toolStripButtonDiagram.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.toolStripButtonDiagram.Size = new System.Drawing.Size(184, 27);
            this.toolStripButtonDiagram.Text = "Статистика";
            this.toolStripButtonDiagram.Click += new System.EventHandler(this.toolStripButtonDiagram_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(270, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(438, 366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.BackColor = System.Drawing.Color.Silver;
            this.labelSeconds.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSeconds.Location = new System.Drawing.Point(311, 128);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Padding = new System.Windows.Forms.Padding(5);
            this.labelSeconds.Size = new System.Drawing.Size(93, 38);
            this.labelSeconds.TabIndex = 4;
            this.labelSeconds.Text = "label1";
            this.labelSeconds.Visible = false;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.BackColor = System.Drawing.Color.LightGray;
            this.labelResult.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.ForeColor = System.Drawing.Color.DarkRed;
            this.labelResult.Location = new System.Drawing.Point(352, 662);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(83, 28);
            this.labelResult.TabIndex = 8;
            this.labelResult.Text = "label1";
            this.labelResult.Visible = false;
            // 
            // timer
            // 
            this.timer.Interval = 900;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.labelIncorrectAnswers);
            this.panel2.Controls.Add(this.labelCorrectAnswers);
            this.panel2.Controls.Add(this.ProgressBar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 739);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1017, 62);
            this.panel2.TabIndex = 10;
            // 
            // labelIncorrectAnswers
            // 
            this.labelIncorrectAnswers.AutoSize = true;
            this.labelIncorrectAnswers.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIncorrectAnswers.Location = new System.Drawing.Point(537, 30);
            this.labelIncorrectAnswers.Name = "labelIncorrectAnswers";
            this.labelIncorrectAnswers.Size = new System.Drawing.Size(69, 20);
            this.labelIncorrectAnswers.TabIndex = 2;
            this.labelIncorrectAnswers.Text = "label2";
            this.labelIncorrectAnswers.Visible = false;
            // 
            // labelCorrectAnswers
            // 
            this.labelCorrectAnswers.AutoSize = true;
            this.labelCorrectAnswers.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCorrectAnswers.Location = new System.Drawing.Point(287, 30);
            this.labelCorrectAnswers.Name = "labelCorrectAnswers";
            this.labelCorrectAnswers.Size = new System.Drawing.Size(69, 20);
            this.labelCorrectAnswers.TabIndex = 1;
            this.labelCorrectAnswers.Text = "label1";
            this.labelCorrectAnswers.Visible = false;
            // 
            // ProgressBar
            // 
            this.ProgressBar.ChannelColor = System.Drawing.Color.DarkSlateGray;
            this.ProgressBar.ChannelHeight = 17;
            this.ProgressBar.ForeBackColor = System.Drawing.Color.White;
            this.ProgressBar.ForeColor = System.Drawing.Color.Black;
            this.ProgressBar.Location = new System.Drawing.Point(23, 6);
            this.ProgressBar.Maximum = 60;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProgressBar.ShowMaximun = false;
            this.ProgressBar.ShowValue = Lab10.TextPosition.None;
            this.ProgressBar.Size = new System.Drawing.Size(213, 44);
            this.ProgressBar.SliderColor = System.Drawing.Color.MediumTurquoise;
            this.ProgressBar.SliderHeight = 24;
            this.ProgressBar.SymbolAfter = "";
            this.ProgressBar.SymbolBefore = "";
            this.ProgressBar.TabIndex = 0;
            this.ProgressBar.Visible = false;
            // 
            // ButtonAnswer
            // 
            this.ButtonAnswer.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAnswer.BackgroundColor = System.Drawing.Color.Transparent;
            this.ButtonAnswer.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonAnswer.BorderRadius = 25;
            this.ButtonAnswer.BorderSize = 0;
            this.ButtonAnswer.FlatAppearance.BorderSize = 0;
            this.ButtonAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAnswer.ForeColor = System.Drawing.Color.White;
            this.ButtonAnswer.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAnswer.Image")));
            this.ButtonAnswer.Location = new System.Drawing.Point(621, 565);
            this.ButtonAnswer.Name = "ButtonAnswer";
            this.ButtonAnswer.Size = new System.Drawing.Size(87, 68);
            this.ButtonAnswer.TabIndex = 7;
            this.ButtonAnswer.TextColor = System.Drawing.Color.White;
            this.ButtonAnswer.UseVisualStyleBackColor = false;
            this.ButtonAnswer.Visible = false;
            this.ButtonAnswer.Click += new System.EventHandler(this.ButtonAnswer_Click);
            // 
            // TextBoxAnswer
            // 
            this.TextBoxAnswer.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxAnswer.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.TextBoxAnswer.BorderFocusColor = System.Drawing.Color.Purple;
            this.TextBoxAnswer.BorderRadius = 0;
            this.TextBoxAnswer.BorderSize = 2;
            this.TextBoxAnswer.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxAnswer.ForeColor = System.Drawing.Color.Black;
            this.TextBoxAnswer.Location = new System.Drawing.Point(356, 581);
            this.TextBoxAnswer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxAnswer.Multiline = false;
            this.TextBoxAnswer.Name = "TextBoxAnswer";
            this.TextBoxAnswer.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TextBoxAnswer.PasswordChar = false;
            this.TextBoxAnswer.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBoxAnswer.PlaceholderText = "";
            this.TextBoxAnswer.Size = new System.Drawing.Size(250, 42);
            this.TextBoxAnswer.TabIndex = 5;
            this.TextBoxAnswer.Texts = "";
            this.TextBoxAnswer.UnderlinedStyle = false;
            this.TextBoxAnswer.Visible = false;
            this.TextBoxAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAnswer_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(802, 236);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(215, 294);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(637, 505);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(380, 241);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 618);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(285, 121);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(0, 212);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(215, 294);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1017, 801);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.ButtonAnswer);
            this.Controls.Add(this.TextBoxAnswer);
            this.Controls.Add(this.labelSeconds);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Learning English";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonStart;
        private System.Windows.Forms.ToolStripButton toolStripButtonStop;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonRules;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonSettings;
        private System.Windows.Forms.ToolStripMenuItem фруктыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem одеждаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мебельToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelSeconds;
        private RJTextBox TextBoxAnswer;
        private RJButton ButtonAnswer;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripButton toolStripButtonDiagram;
        private RJProgressBar ProgressBar;
        private System.Windows.Forms.Label labelIncorrectAnswers;
        private System.Windows.Forms.Label labelCorrectAnswers;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

