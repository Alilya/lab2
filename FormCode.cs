using System;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Generic;

namespace lab2 {
    public partial class FormCode : Form {
        public FormCode() {
            InitializeComponent();
        }
        private void TextFirst_TextChanged(object sender, EventArgs e) {

        }

        private void FormCode_Load(object sender, EventArgs e) {

        }

        private void ChangeGreeting(object sender, EventArgs e) {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["showHello"].Value = (!bool.Parse(ConfigurationManager.AppSettings["showHello"])).ToString();
            config.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }
        private void ShowHello(object sender, EventArgs e) {
            if (bool.Parse(ConfigurationManager.AppSettings["showHello"])) {
                FormHello formHello = new FormHello();
                formHello.ShowDialog();
            }
        }

        private void LabelKey_Click(object sender, EventArgs e) {

        }

        private void TextCode_TextChanged(object sender, EventArgs e) {

        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void ButtonStart_Click(object sender, EventArgs e) {


            ICipher cipher = null;
            if (buttonAffine.Checked) {
                cipher = new AffineCipher(int.Parse(textKeyA.Text), int.Parse(textKeyB.Text));

                List<string> arr = new List<string>() { "1", "3", "5", "7", "9", "11", "15", "17", "19", "21", "23", "25", "27", "29", "31" };
                if (arr.IndexOf(textKeyA.Text) == -1) {
                    MessageBox.Show("Коэффициент а должен быть взаимно простым с мощьностью алфавита.");
                    return;
                }
            }

            else if (buttonRot13.Checked) {
                cipher = new Rot13();
            }
            if (buttonEncode.Checked) {
                textCode.Text = cipher.Encode(textFirst.Text);
            }
            else if (buttonDecode.Checked) {
                textCode.Text = cipher.Decode(textFirst.Text);
            }


        }

        string wellStr = "";

        public void TextKeyA_TextChanged(object sender, EventArgs e) {
            string nowStr = textKeyA.Text;
            while (nowStr.Contains("  ")) {
                nowStr = nowStr.Replace("  ", " ");
            }
            textKeyA.Text = nowStr;
            return;
        }

        public void TextKeyB_TextChanged(object sender, EventArgs e) {
            string nowStr = textKeyB.Text;
            for (int i = 0; i < nowStr.Length; i++) {
                if (!(((nowStr.ElementAt(i) >= '0') && (nowStr.ElementAt(i) <= '9')) || (nowStr.ElementAt(i) == ' '))) {
                    textKeyB.Text = wellStr;
                    return;
                }
            }
            while (nowStr.Contains("  ")) {
                nowStr = nowStr.Replace("  ", " ");
            }
            wellStr = nowStr;
            textKeyB.Text = wellStr;
            return;
        }

        private void ButtonEncode_CheckedChanged(object sender, EventArgs e) {

        }

        private void ButtonDecode_CheckedChanged(object sender, EventArgs e) {

        }

        private void SaveDataToolStripMenuItem_Click(object sender, EventArgs e) {
            File save = new File();
            save.SaveData(textFirst.Text, "Ключ а: " + textKeyA.Text, "Ключ b: " + textKeyB.Text);
        }

        private void SaveResultsToolStripMenuItem_Click(object sender, EventArgs e) {
            File save = new File();
            save.SaveResults(textCode.Text);
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e) {
            File file = new File();
            textFirst.Text = file.OpenFile();
        }

        private void ButtonAffine_CheckedChanged(object sender, EventArgs e) {
            textKeyA.Visible = true;
            labelKeyA.Visible = true;
            textKeyB.Visible = true;
            labelKeyB.Visible = true;
        }

        private void ButtonRot13_CheckedChanged(object sender, EventArgs e) {
            textKeyA.Visible = false;
            labelKeyA.Visible = false;
            textKeyB.Visible = false;
            labelKeyB.Visible = false;
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void showGreetingsToolStripMenuItem_Click(object sender, EventArgs e) {
            ChangeGreeting(sender, e);
            showGreetingsToolStripMenuItem.Checked = bool.Parse(ConfigurationManager.AppSettings["showHello"]);

        }
    }
}
