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
            System.IO.File.WriteAllText(fileName, text);
           
            MessageBox.Show("Файл сохранен");
        }
        public void SaveData(string text, string keyA, string keyB) {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string fileName = saveFileDialog.FileName;
            // сохраняем текст в файл
            string arr = text +" "+keyA+" "+keyB;
            System.IO.File.WriteAllText(fileName, arr);
            
            MessageBox.Show("Файл сохранен");


        }
       
        public string OpenFile() {
            string text;
            var openFileDialog = new OpenFileDialog();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return null;
            //получаем выбранный файл
            string fileName = openFileDialog.FileName;
            //читаем файл в строку
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
