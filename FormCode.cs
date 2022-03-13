using System;
using System.Linq;
using System.Windows.Forms;

namespace lab2 {
    public partial class FormCode : Form {
        public FormCode() {
            InitializeComponent();
        }
        private void TextFirst_TextChanged(object sender, EventArgs e) {

        }

        private void FormCode_Load(object sender, EventArgs e) {

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
        int keyA;
        int keyB;
        string wellStr = "";
        public void TextKeyA_TextChanged(object sender, EventArgs e) {
            string nowStr = textKeyA.Text;
            for (int i = 0; i < nowStr.Length; i++) {
                if (!(((nowStr.ElementAt(i) >= '0') && (nowStr.ElementAt(i) <= '9')) || (nowStr.ElementAt(i) == ' '))) {
                    textKeyA.Text = wellStr;
                    return;
                }
            }
            while (nowStr.Contains("  ")) {
                nowStr = nowStr.Replace("  ", " ");
            }
            wellStr = nowStr;
            textKeyA.Text = wellStr;
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
            save.SaveData(textFirst.Text);
            save.SaveData("Ключ а: " + textKeyA.Text);
            save.SaveData("Ключ b: " + textKeyB.Text);
        }

        private void SaveResultsToolStripMenuItem_Click(object sender, EventArgs e) {
            File save = new File();
            save.SaveResults(textCode.Text);
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e) {
            File file = new File();
            textFirst.Text = file.OpenFile();
        }

        private void buttonAffine_CheckedChanged(object sender, EventArgs e) {
            textKeyA.Visible = true;
            labelKeyA.Visible = true;
            textKeyB.Visible = true;
            labelKeyB.Visible = true;
        }

        private void buttonRot13_CheckedChanged(object sender, EventArgs e) {
            textKeyA.Visible = false;
            labelKeyA.Visible = false;
            textKeyB.Visible = false;
            labelKeyB.Visible = false;
        }

        private void кToolStripMenuItem_Click(object sender, EventArgs e) {

        }
    }
}
