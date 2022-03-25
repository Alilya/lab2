using System.Text;

namespace lab2 {
    public interface ICipher {
        string Encode(string str);
        string Decode(string str);
    }
    public class AffineCipher : ICipher {
        int a, b;
        public AffineCipher(int a, int b) {
            this.a = a;
            this.b = b;
        }
        public string Encode(string str) {
            string cipher = "";

            for (int i = 0; i < str.Length; i++) {
                if (str[i] != ' ') {
                    if (str[i] >= 'A' && str[i] <= 'Z')
                        cipher += (char)((((a * (str[i] - 'A')) + b) % 26) + 'A');
                    else if (str[i] >= 'a' && str[i] <= 'z')
                        cipher += (char)((((a * (str[i] - 'a')) + b) % 26) + 'a');
                    else if (str[i] >= 'А' && str[i] <= 'Я')
                        cipher += (char)((((a * (str[i] - 'А')) + b) % 32) + 'А');
                    else if (str[i] >= 'а' && str[i] <= 'я')
                        cipher += (char)((((a * (str[i] - 'а')) + b) % 32) + 'а');
                }
                else {
                    cipher += str[i];
                }
            }

            return cipher;
        }
        string msg = "";
        public string Decode(string cipher) {
            for (int i = 0; i < cipher.Length; i++) {
                if ((cipher[i] >= 'A' && cipher[i] <= 'Z') || (cipher[i] >= 'a' && cipher[i] <= 'z')) {
                    DecodeEn(cipher[i], a, b);
                }
                else if (cipher[i] >= 'А' && cipher[i] <= 'я') {
                    DecodeRu(cipher[i], a, b);
                }
                else {
                    msg += cipher[i];
                }

            }
            return msg;
        }
        public void DecodeEn(char cipher, int a, int b) {
            int a_inv = 0;
            int flag;
            // Находим ^ -1 (мультипликативный обратный
            // в группе целых чисел по модулю m.)
            for (int i = 0; i < 26; i++) {
                flag = (a * i) % 26;
                // Проверьте, если (a * i)% 26 == 1,
                // тогда я буду мультипликативным обратным к
                if (flag == 1) {
                    a_inv = i;
                }
            }
            if (cipher >= 'A' && cipher <= 'Z')
                msg += (char)((a_inv * (cipher + 'A' - b) % 26) + 'A');
            else if (cipher >= 'a' && cipher <= 'z') {
                msg += ((char)((a_inv * (char.Parse(cipher.ToString().ToUpper()) + 'A' - b) % 26) + 'A')).ToString().ToLower();
            }

        }
        public void DecodeRu(char cipher, int a, int b) {

            int a_inv = 0;
            int flag;
            for (int i = 0; i < 32; i++) {
                flag = (a * i) % 32;
                if (flag == 1) {
                    a_inv = i;
                }
            }
            if (cipher >= 'А' && cipher <= 'Я')
                msg += ((char)((a_inv * (cipher + 'А' - b) % 32) + 'А')).ToString().ToUpper();
            else if (cipher >= 'а' && cipher <= 'я')
                msg += ((char)((a_inv * (char.Parse(cipher.ToString().ToUpper()) + 'а' - b) % 32) + 'а')).ToString().ToLower();
        }
    }

    public class Rot13 : ICipher {
        public string Encode(string textEncode) {

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < textEncode.Length; i++) {
                if (char.IsLetter(textEncode[i])) {
                    if (textEncode[i] >= 'А' && textEncode[i] <= 'Я') {
                        sb.Append(Encoding(textEncode[i], 'А', 'Я'));
                    }
                    else if (textEncode[i] >= 'а' && textEncode[i] <= 'я') {
                        sb.Append(Encoding(textEncode[i], 'а', 'я'));
                    }
                    if (textEncode[i] >= 'A' && textEncode[i] <= 'Z') {
                        sb.Append(Encoding(textEncode[i], 'A', 'Z'));
                    }
                    else if (textEncode[i] >= 'a' && textEncode[i] <= 'z') {
                        sb.Append(Encoding(textEncode[i], 'a', 'z'));
                    }
                }
                else sb.Append(textEncode[i]);
            }
            return sb.ToString();
        }


        private char Encoding(char encodingChar, char first, char last) {
            if (encodingChar >= first && encodingChar <= last - 13)
                return (char)(encodingChar + 13);
            else
                return ((char)(first + last - encodingChar));
        }


        public string Decode(string textEncode) {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < textEncode.Length; i++) {
                if (char.IsLetter(textEncode[i])) {
                    if (textEncode[i] >= 'А' && textEncode[i] <= 'Я') {
                        sb.Append(Decoding(textEncode[i], 'А', 'Я'));

                    }
                    else if (textEncode[i] >= 'а' && textEncode[i] <= 'я') {
                        sb.Append(Decoding(textEncode[i], 'а', 'я'));
                    }

                    else if ((textEncode[i] >= 'A' && textEncode[i] <= 'Z')) {
                        sb.Append(Decoding(textEncode[i], 'A', 'Z'));

                    }
                    else if ((textEncode[i] >= 'a' && textEncode[i] <= 'z')) {
                        sb.Append(Decoding(textEncode[i], 'a', 'z'));
                    }
                }
                else sb.Append(textEncode[i]);
            }
            return sb.ToString();
        }
        private char Decoding(char decodingChar, char first, char last) {
            if ((decodingChar >= first + 13 && decodingChar <= last))
                return (char)(decodingChar - 13);
            else {
                return (char)(last + (first - decodingChar));
            }
        }

    }

}
