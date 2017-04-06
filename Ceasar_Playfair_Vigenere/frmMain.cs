using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ceasar_Playfair_Vigenere
{
    public partial class frmDataSecurity : Form
    {
        public frmDataSecurity()
        {
            InitializeComponent();
        }


        private void btnInputPlainText_Click(object sender, EventArgs e)
        {
            plainTextFileDialog.Filter = "Text File| *.txt";
            plainTextFileDialog.ShowDialog();
        }

        private void btnGeneratCipher_Click(object sender, EventArgs e)
        {
            /* try
            {
                //Đọc ND từ StreamReader sang string
                StreamReader srPlainText = new StreamReader(plainTextFileDialog.OpenFile());
                string plain_text = srPlainText.ReadToEnd();
                plain_text = plain_text.Trim().ToLower().Replace(" ", string.Empty);

                //Mã hoá
                StringBuilder sb = new StringBuilder();
                foreach (char c in plain_text)
                {
                    char c1 = (char)((c - 97 + key)%26 + 65 );
                    sb.Append(c1);
                }
                string cipher_text = sb.ToString();
                MessageBox.Show("Plain text: " + plain_text + "\r\nKey: " + key.ToString() + "\r\nCipher text: " + cipher_text);

                //Ghi vào file mã hoá
                StreamWriter sw = File.CreateText(plainTextFileDialog.FileName.Replace(".txt", "-cipher.txt"));
                foreach (char c in cipher_text)
                    sw.Write(c);
                sw.Close();
                srPlainText.Close();

                //Khoá nút Mã hoá, mở nút Mở tập tin Mã hoá
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập khoá!");
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("Vui lòng nhập bản rõ!");
            }   */
        }

        private void btnReceivePlain_Click(object sender, EventArgs e)
        {
            dialogGetPlainText.Filter = "Text File| *.txt";
            dialogGetPlainText.ShowDialog();
            txtPlainInputURL.Text = dialogGetPlainText.FileName;
        }

        private void btnKeyInput_Click(object sender, EventArgs e)
        {
            dialogGetKey.Filter = "Text File| *.txt";
            dialogGetKey.ShowDialog();
            txtGetKey.Text = dialogGetKey.FileName;
        }
        string CeasarEncrypt(string plain, string key)
        {
            return plain;
        }
        string PlayfairEncrypt(string plain, string key)
        {
            return plain;
        }
        string VigenereEncrypt(string plain, string key)
        {
            return plain;
        }
        string TinyA5Encrypt(string plain, string key)
        {
            return plain;
        }
        string A5Encrypt(string plain, string key)
        {
            return plain;
        }
        string TinyDESEncrypt(string plain, string key)
        {
            return plain;
        }
        string DESEncrypt(string plain, string key)
        {
            return plain;
        }
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                //Chép bản rõ vào biến string
                StreamReader srPlainText = new StreamReader(dialogGetPlainText.OpenFile());
                string plain_text = srPlainText.ReadToEnd();
                plain_text = plain_text.Trim().ToLower().Replace(" ", string.Empty);

                //Chép khoá vào biến string
                StreamReader srKey = new StreamReader(dialogGetKey.OpenFile());
                string key = srKey.ReadToEnd();
                key = key.Trim().ToLower().Replace(" ", string.Empty);

                //Thực hiện mã hoá theo lựa chọn
                string cipher = "";
                switch (cbboxType.SelectedItem.ToString())
                {
                    case "Ceasar": cipher = CeasarEncrypt(plain_text, key); break;
                    case "Playfair": cipher = PlayfairEncrypt(plain_text, key); break;
                    case "Vigenere": cipher = VigenereEncrypt(plain_text, key); break;
                    case "Tiny A5/1": cipher = TinyA5Encrypt(plain_text, key); break;
                    case "A5/1": cipher = A5Encrypt(plain_text, key); break;
                    case "Tiny DES": cipher = TinyDESEncrypt(plain_text, key); break;
                    case "DES": cipher = DESEncrypt(plain_text, key); break;
                }

                dialogSaveEncryption.Filter = "Text file | *.txt";
                dialogSaveEncryption.ShowDialog();
                txtOpenCipherText.Text = dialogSaveEncryption.FileName;

                StreamWriter sw = new StreamWriter(dialogSaveEncryption.OpenFile());
                sw.WriteLine(cipher);
                sw.Close();
                MessageBox.Show("Mã hoá thành công!");

                dialogSaveEncryption.Reset();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Thiếu tập tin Bản rõ/Khoá/Bản mã! Yêu cầu nhập đầy đủ!");
            }
        }
        private void frmDataSecurity_Load(object sender, EventArgs e)
        {
            cbboxType.SelectedIndex = 0;
        }
        private void btnOpenCipherText_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(txtOpenCipherText.Text);
        }

        private void btnGetCipher_Click(object sender, EventArgs e)
        {
            dialogGetCipherText.Filter = "Text File| *.txt";
            dialogGetCipherText.ShowDialog();
            txtGetCipherURL.Text = dialogGetCipherText.FileName;
        }
        private void btnGetKey2_Click(object sender, EventArgs e)
        {
            dialogGetKey2.Filter = "Text File| *.txt";
            dialogGetKey2.ShowDialog();
            txtGetKey2.Text = dialogGetKey2.FileName;
        }
        string CeasarDecrypt(string cipher_text, string key)
        {
            return cipher_text;
        }
        string PlayfairDecrypt(string cipher_text, string key)
        {
            return cipher_text;
        }
        string VigenereDecrypt(string cipher_text, string key)
        {
            return cipher_text;
        }
        string TinyA5Decrypt(string cipher_text, string key)
        {
            return cipher_text;
        }
        string A5Decrypt(string cipher_text, string key)
        {
            return cipher_text;
        }
        string TinyDESDecrypt(string cipher_text, string key)
        {
            return cipher_text;
        }
        string DESDecrypt(string cipher_text, string key)
        {
            return cipher_text;
        }
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                //Chép bản mã vào biến string
                StreamReader srCipherText = new StreamReader(dialogGetCipherText.OpenFile());
                string cipher_text = srCipherText.ReadToEnd();
                cipher_text = cipher_text.Trim().ToLower().Replace(" ", string.Empty);

                //Chép khoá vào biến string
                StreamReader srKey = new StreamReader(dialogGetKey2.OpenFile());
                string key = srKey.ReadToEnd();
                key = key.Trim().ToLower().Replace(" ", string.Empty);

                //Thực hiện giải mã theo lựa chọn
                string plain = "";
                switch (cbboxType.SelectedItem.ToString())
                {
                    case "Ceasar": plain = CeasarDecrypt(cipher_text, key); break;
                    case "Playfair": plain = PlayfairDecrypt(cipher_text, key); break;
                    case "Vigenere": plain = VigenereDecrypt(cipher_text, key); break;
                    case "Tiny A5/1": plain = TinyA5Decrypt(cipher_text, key); break;
                    case "A5/1": plain = A5Decrypt(cipher_text, key); break;
                    case "Tiny DES": plain = TinyDESDecrypt(cipher_text, key); break;
                    case "DES": plain = DESDecrypt(cipher_text, key); break;
                }

                dialogSaveDecryption.Filter = "Text file | *.txt";
                dialogSaveDecryption.ShowDialog();
                txtOpenPlainText.Text = dialogSaveDecryption.FileName;

                StreamWriter sw = new StreamWriter(dialogSaveDecryption.OpenFile());
                sw.WriteLine(plain);
                sw.Close();
                MessageBox.Show("Giải mã thành công!");

                dialogSaveDecryption.Reset();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Thiếu tập tin Bản rõ/Khoá/Bản mã! Yêu cầu nhập đầy đủ!");
            }
        }
        private void btnOpenPlainText_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(txtOpenPlainText.Text);
        }

    }
}
