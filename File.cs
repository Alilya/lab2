using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2 {
    public class File {
        public void SaveResults(string text) {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string fileName = saveFileDialog.FileName;
            // сохраняем текст в файл

            // if (tabControl.SelectedIndex == 1) {
            System.IO.File.WriteAllText(fileName, text);
            MessageBox.Show("Файл сохранен");
            // }
            /*  else if (tabControl.SelectedIndex == 2) {
                  System.IO.File.WriteAllText(fileName, textTree.Text);
                  MessageBox.Show("Файл сохранен");
              }
              else if (tabControl.SelectedIndex == 0) {
                  System.IO.File.WriteAllText(fileName, textTree.Text);
                  MessageBox.Show("Файл сохранен");
              }*/
        }
        public void SaveData(string text) {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string fileName = saveFileDialog.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(fileName, text);
            MessageBox.Show("Файл сохранен");


        }
      //  string fileText;
        public string OpenFile() {
            string text;
            var openFileDialog = new OpenFileDialog();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
           // text = "";
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return null;
            //получаем выбранный файл
            string fileName = openFileDialog.FileName;
            //читаем файл в строку
            //text = "";
            text = System.IO.File.ReadAllText(fileName);
            if (text.Contains("Ключ")) {
                MessageBox.Show("Некорректный файл");
                return null;
            }
            else {
                
                MessageBox.Show("Файл открыт");
                return text;
            }          
        }
    }
}
