namespace lab2 {
    partial class FormCode {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.buttonAffine = new System.Windows.Forms.RadioButton();
            this.buttonStart = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showGreetingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textCode = new System.Windows.Forms.RichTextBox();
            this.buttonEncode = new System.Windows.Forms.RadioButton();
            this.buttonDecode = new System.Windows.Forms.RadioButton();
            this.textKeyA = new System.Windows.Forms.TextBox();
            this.labelKeyA = new System.Windows.Forms.Label();
            this.textKeyB = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonRot13 = new System.Windows.Forms.RadioButton();
            this.textFirst = new System.Windows.Forms.RichTextBox();
            this.labelKeyB = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAffine
            // 
            this.buttonAffine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAffine.AutoSize = true;
            this.buttonAffine.Location = new System.Drawing.Point(30, 22);
            this.buttonAffine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAffine.Name = "buttonAffine";
            this.buttonAffine.Size = new System.Drawing.Size(139, 20);
            this.buttonAffine.TabIndex = 3;
            this.buttonAffine.Text = "Аффинный шифр";
            this.buttonAffine.UseVisualStyleBackColor = true;
            this.buttonAffine.CheckedChanged += new System.EventHandler(this.ButtonAffine_CheckedChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonStart.Location = new System.Drawing.Point(52, 142);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(77, 30);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutProgramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveDataToolStripMenuItem,
            this.saveResultsToolStripMenuItem,
            this.openFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.FileToolStripMenuItem_Click);
            // 
            // saveDataToolStripMenuItem
            // 
            this.saveDataToolStripMenuItem.Name = "saveDataToolStripMenuItem";
            this.saveDataToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.saveDataToolStripMenuItem.Text = "Save data";
            this.saveDataToolStripMenuItem.Click += new System.EventHandler(this.SaveDataToolStripMenuItem_Click);
            // 
            // saveResultsToolStripMenuItem
            // 
            this.saveResultsToolStripMenuItem.Name = "saveResultsToolStripMenuItem";
            this.saveResultsToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.saveResultsToolStripMenuItem.Text = "Save results";
            this.saveResultsToolStripMenuItem.Click += new System.EventHandler(this.SaveResultsToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.openFileToolStripMenuItem.Text = "Open file";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showGreetingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // showGreetingsToolStripMenuItem
            // 
            this.showGreetingsToolStripMenuItem.Name = "showGreetingsToolStripMenuItem";
            this.showGreetingsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.showGreetingsToolStripMenuItem.Text = "Show gettings";
            this.showGreetingsToolStripMenuItem.Click += new System.EventHandler(this.showGreetingsToolStripMenuItem_Click);
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кToolStripMenuItem});
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.aboutProgramToolStripMenuItem.Text = "About Program";
            // 
            // кToolStripMenuItem
            // 
            this.кToolStripMenuItem.Name = "кToolStripMenuItem";
            this.кToolStripMenuItem.Size = new System.Drawing.Size(888, 26);
            this.кToolStripMenuItem.Text = "Лабораторная работа №2 Вариант 4 Разработчик Колесникова Алина 403 группа. Аффины" +
    "й шифр и шифр ROT13";
            this.кToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // textCode
            // 
            this.textCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCode.Location = new System.Drawing.Point(203, 39);
            this.textCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(575, 141);
            this.textCode.TabIndex = 1;
            this.textCode.Text = "";
            this.textCode.TextChanged += new System.EventHandler(this.TextCode_TextChanged);
            // 
            // buttonEncode
            // 
            this.buttonEncode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEncode.AutoSize = true;
            this.buttonEncode.Location = new System.Drawing.Point(54, 41);
            this.buttonEncode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(78, 20);
            this.buttonEncode.TabIndex = 7;
            this.buttonEncode.Text = " Encode";
            this.buttonEncode.UseVisualStyleBackColor = true;
            this.buttonEncode.CheckedChanged += new System.EventHandler(this.ButtonEncode_CheckedChanged);
            // 
            // buttonDecode
            // 
            this.buttonDecode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDecode.AutoSize = true;
            this.buttonDecode.Location = new System.Drawing.Point(53, 70);
            this.buttonDecode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(77, 20);
            this.buttonDecode.TabIndex = 8;
            this.buttonDecode.Text = "Decode";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.CheckedChanged += new System.EventHandler(this.ButtonDecode_CheckedChanged);
            // 
            // textKeyA
            // 
            this.textKeyA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textKeyA.Location = new System.Drawing.Point(224, 6);
            this.textKeyA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textKeyA.Name = "textKeyA";
            this.textKeyA.Size = new System.Drawing.Size(49, 22);
            this.textKeyA.TabIndex = 4;
            this.textKeyA.TextChanged += new System.EventHandler(this.TextKeyA_TextChanged);
            // 
            // labelKeyA
            // 
            this.labelKeyA.AutoSize = true;
            this.labelKeyA.Location = new System.Drawing.Point(95, 10);
            this.labelKeyA.Name = "labelKeyA";
            this.labelKeyA.Size = new System.Drawing.Size(119, 16);
            this.labelKeyA.TabIndex = 6;
            this.labelKeyA.Text = "Введите число а:";
            this.labelKeyA.Click += new System.EventHandler(this.LabelKey_Click);
            // 
            // textKeyB
            // 
            this.textKeyB.Location = new System.Drawing.Point(440, 6);
            this.textKeyB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textKeyB.Name = "textKeyB";
            this.textKeyB.Size = new System.Drawing.Size(57, 22);
            this.textKeyB.TabIndex = 10;
            this.textKeyB.TextChanged += new System.EventHandler(this.TextKeyB_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 31);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel1.Controls.Add(this.buttonRot13);
            this.splitContainer1.Panel1.Controls.Add(this.buttonStart);
            this.splitContainer1.Panel1.Controls.Add(this.textFirst);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAffine);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel2.Controls.Add(this.labelKeyB);
            this.splitContainer1.Panel2.Controls.Add(this.labelKeyA);
            this.splitContainer1.Panel2.Controls.Add(this.textKeyB);
            this.splitContainer1.Panel2.Controls.Add(this.buttonDecode);
            this.splitContainer1.Panel2.Controls.Add(this.buttonEncode);
            this.splitContainer1.Panel2.Controls.Add(this.textCode);
            this.splitContainer1.Panel2.Controls.Add(this.textKeyA);
            this.splitContainer1.Size = new System.Drawing.Size(800, 407);
            this.splitContainer1.SplitterDistance = 202;
            this.splitContainer1.TabIndex = 11;
            // 
            // buttonRot13
            // 
            this.buttonRot13.AutoSize = true;
            this.buttonRot13.Location = new System.Drawing.Point(21, 48);
            this.buttonRot13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRot13.Name = "buttonRot13";
            this.buttonRot13.Size = new System.Drawing.Size(63, 20);
            this.buttonRot13.TabIndex = 6;
            this.buttonRot13.TabStop = true;
            this.buttonRot13.Text = "Rot13";
            this.buttonRot13.UseVisualStyleBackColor = true;
            this.buttonRot13.CheckedChanged += new System.EventHandler(this.ButtonRot13_CheckedChanged);
            // 
            // textFirst
            // 
            this.textFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textFirst.Location = new System.Drawing.Point(203, 21);
            this.textFirst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textFirst.Name = "textFirst";
            this.textFirst.Size = new System.Drawing.Size(575, 152);
            this.textFirst.TabIndex = 0;
            this.textFirst.Text = "";
            this.textFirst.TextChanged += new System.EventHandler(this.TextFirst_TextChanged);
            // 
            // labelKeyB
            // 
            this.labelKeyB.AutoSize = true;
            this.labelKeyB.Location = new System.Drawing.Point(311, 10);
            this.labelKeyB.Name = "labelKeyB";
            this.labelKeyB.Size = new System.Drawing.Size(119, 16);
            this.labelKeyB.TabIndex = 11;
            this.labelKeyB.Text = "Введите число b:";
            // 
            // FormCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(818, 493);
            this.MinimumSize = new System.Drawing.Size(818, 493);
            this.Name = "FormCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cipher";
            this.Load += new System.EventHandler(this.FormCode_Load);
            this.Shown += new System.EventHandler(this.ShowHello);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton buttonAffine;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.RichTextBox textCode;
        private System.Windows.Forms.RadioButton buttonEncode;
        private System.Windows.Forms.RadioButton buttonDecode;
        private System.Windows.Forms.TextBox textKeyA;
        private System.Windows.Forms.Label labelKeyA;
        private System.Windows.Forms.TextBox textKeyB;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelKeyB;
        private System.Windows.Forms.ToolStripMenuItem saveDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.RadioButton buttonRot13;
        private System.Windows.Forms.ToolStripMenuItem кToolStripMenuItem;
        private System.Windows.Forms.RichTextBox textFirst;
        private System.Windows.Forms.ToolStripMenuItem showGreetingsToolStripMenuItem;
    }
}

