using System;
using System.Windows.Forms;

namespace lab2 {
    public partial class FormHello : Form {
        public FormHello() {
            InitializeComponent();
        }

        private void FormHello_Load(object sender, EventArgs e) {

        }
        bool hideFormHello = false;
        private void CheckBoxHello_CheckedChanged(object sender, EventArgs e) {
            hideFormHello = true;
            Close();
        }

        private void CheckBoxHello_Load(object sender, EventArgs e) {
            if (hideFormHello)
                Close();
        }

        private void label1_Click(object sender, EventArgs e) {

        }
    }
}
