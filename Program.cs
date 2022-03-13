using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2 {
    internal static class Program {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormCode());

          /*  String msg = "AFFINE CIPHER";



            // Вызов функции шифрования

            String cipherText = Encode(msg.ToCharArray());

            Console.WriteLine("Encrypted Message is : " + cipherText);



            // Вызываем функцию расшифровки

            Console.WriteLine("Decrypted Message is: " + Decode(cipherText));
*/
        }
    }
}
