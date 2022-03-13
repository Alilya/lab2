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
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textCode = new System.Windows.Forms.RichTextBox();
            this.buttonEncode = new System.Windows.Forms.RadioButton();
            this.buttonDecode = new System.Windows.Forms.RadioButton();
            this.textKeyA = new System.Windows.Forms.TextBox();
            this.labelKeyA = new System.Windows.Forms.Label();
            this.textKeyB = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonRot13 = new System.Windows.Forms.RadioButton();
            this.labelKeyB = new System.Windows.Forms.Label();
            this.кToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textFirst = new System.Windows.Forms.RichTextBox();
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
            this.buttonAffine.Name = "buttonAffine";
            this.buttonAffine.Size = new System.Drawing.Size(139, 20);
            this.buttonAffine.TabIndex = 3;
            this.buttonAffine.Text = "Аффинный шифр";
            this.buttonAffine.UseVisualStyleBackColor = true;
            this.buttonAffine.CheckedChanged += new System.EventHandler(this.buttonAffine_CheckedChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonStart.Location = new System.Drawing.Point(52, 143);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(78, 30);
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
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кToolStripMenuItem});
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.aboutProgramToolStripMenuItem.Text = "About Program";
            // 
            // textCode
            // 
            this.textCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCode.Location = new System.Drawing.Point(203, 40);
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
            this.buttonEncode.Location = new System.Drawing.Point(52, 41);
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
            this.buttonDecode.Location = new System.Drawing.Point(52, 70);
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
            this.textKeyA.Name = "textKeyA";
            this.textKeyA.Size = new System.Drawing.Size(50, 22);
            this.textKeyA.TabIndex = 4;
            this.textKeyA.TextChanged += new System.EventHandler(this.TextKeyA_TextChanged);
            // 
            // labelKeyA
            // 
            this.labelKeyA.AutoSize = true;
            this.labelKeyA.Location = new System.Drawing.Point(200, 9);
            this.labelKeyA.Name = "labelKeyA";
            this.labelKeyA.Size = new System.Drawing.Size(18, 16);
            this.labelKeyA.TabIndex = 6;
            this.labelKeyA.Text = "а:";
            this.labelKeyA.Click += new System.EventHandler(this.LabelKey_Click);
            // 
            // textKeyB
            // 
            this.textKeyB.Location = new System.Drawing.Point(361, 6);
            this.textKeyB.Name = "textKeyB";
            this.textKeyB.Size = new System.Drawing.Size(57, 22);
            this.textKeyB.TabIndex = 10;
            this.textKeyB.TextChanged += new System.EventHandler(this.TextKeyB_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 31);
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
            this.splitContainer1.SplitterDistance = 205;
            this.splitContainer1.TabIndex = 11;
            // 
            // buttonRot13
            // 
            this.buttonRot13.AutoSize = true;
            this.buttonRot13.Location = new System.Drawing.Point(30, 48);
            this.buttonRot13.Name = "buttonRot13";
            this.buttonRot13.Size = new System.Drawing.Size(103, 20);
            this.buttonRot13.TabIndex = 6;
            this.buttonRot13.TabStop = true;
            this.buttonRot13.Text = "radioButton1";
            this.buttonRot13.UseVisualStyleBackColor = true;
            this.buttonRot13.CheckedChanged += new System.EventHandler(this.buttonRot13_CheckedChanged);
            // 
            // labelKeyB
            // 
            this.labelKeyB.AutoSize = true;
            this.labelKeyB.Location = new System.Drawing.Point(337, 9);
            this.labelKeyB.Name = "labelKeyB";
            this.labelKeyB.Size = new System.Drawing.Size(18, 16);
            this.labelKeyB.TabIndex = 11;
            this.labelKeyB.Text = "b:";
            // 
            // кToolStripMenuItem
            // 
            this.кToolStripMenuItem.Name = "кToolStripMenuItem";
            this.кToolStripMenuItem.Size = new System.Drawing.Size(668, 26);
            this.кToolStripMenuItem.Text = "Лабораторная работа №2 Вариант 4 Разработчик Колесникова Алина 403 группа.";
            this.кToolStripMenuItem.Click += new System.EventHandler(this.кToolStripMenuItem_Click);
            // 
            // textFirst
            // 
            this.textFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textFirst.Location = new System.Drawing.Point(203, 21);
            this.textFirst.Name = "textFirst";
            this.textFirst.Size = new System.Drawing.Size(575, 152);
            this.textFirst.TabIndex = 0;
            this.textFirst.Text = "";
            this.textFirst.TextChanged += new System.EventHandler(this.TextFirst_TextChanged);
            // 
            // FormCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "FormCode";
            this.Text = "Cipher";
            this.Load += new System.EventHandler(this.FormCode_Load);
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
    }
}

