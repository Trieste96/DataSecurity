using DataSecurity.SymmetricKey;
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
        string Ceasar_Encrypt(string plain, string key)
        {
			int k = 0;
			try
			{
				k = Convert.ToInt32(key);
			}
			catch(Exception)
			{
				MessageBox.Show("Bạn chỉ có thể nhập vào một số nguyên cho loại mã hoá này.", "Lưu Ý"
					, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return "";
			}

            return Ceasar.Encrypt(plain, k);
        }
        string Playfair_Encrypt(string plain, string key)
        {
            return Playfair.Encrypt(plain, key);
        }
        string Vigenere_Encrypt(string plain, string key)
        {
            return Vigenere.Encrypt(plain, key);
        }
        string TinyA5_Encrypt(string plain, string key)
        {
            return plain;
        }
        string A5_Encrypt(string br, string k)
        {
            //khai báo biến
            string khoa, khoaX, khoaY, khoaZ, t, br_binary;
            int m;
            StringBuilder X, Y, Z, S;
            X = new StringBuilder();
            X.Length = 19;
            Y = new StringBuilder();
            Y.Length = 22;
            Z = new StringBuilder();
            Z.Length = 23;
            S = new StringBuilder();

            //chia khoá thành các khoá X,Y,Z
            khoa = k;
            if (khoa.Length < 64)
            {
                int l = khoa.Length;
                for (int i = 0; i < 64 - l; i++)
                {
                    khoa = "0" + khoa;
                }
            }
            khoaX = khoa.Substring(0, 19);

            khoaY = khoa.Substring(19, 22);

            khoaZ = khoa.Substring(41, 23);

            //tạo string bản mã
            StringBuilder bm = new StringBuilder();

            //Mã hoá A5/1
            for (int n = 0; n < br.Length; n++)
            {
                //chuyển sang chuỗi nhị phân
                br_binary = Convert.ToString(Convert.ToChar(br[n]), 2);
                S = new StringBuilder();
                S.Length = br_binary.Length;

                //tính S
                for (int i = 0; i < br_binary.Length; i++)
                {
                    //tính m;
                    m = Convert.ToInt32(khoaX[8].ToString()) + Convert.ToInt32(khoaY[10].ToString()) + Convert.ToInt32(khoaZ[10].ToString());
                    //quay X,Y,Z tuỳ thuộc vào m;
                    //trường hợp m = 1
                    if (m >= 2)
                    {
                        if (Convert.ToInt32(khoaX[8].ToString()) == 1)
                        {
                            t = Convert.ToString(Convert.ToInt32(khoaX[13].ToString()) ^ Convert.ToInt32(khoaX[16].ToString()) ^ Convert.ToInt32(khoaX[17].ToString()) ^ Convert.ToInt32(khoaX[18].ToString()), 2);
                            for (int j = 18; j > 0; j--)
                            {
                                X[j] = khoaX[j - 1];
                            }
                            X[0] = Convert.ToChar(t);
                            khoaX = X.ToString();
                        }

                        if (Convert.ToInt32(khoaY[10].ToString()) == 1)
                        {
                            t = Convert.ToString(Convert.ToInt32(khoaY[20].ToString()) ^ Convert.ToInt32(khoaY[21].ToString()), 2);
                            for (int j = 21; j > 0; j--)
                            {
                                Y[j] = khoaY[j - 1];
                            }
                            Y[0] = Convert.ToChar(t);
                            khoaY = Y.ToString();
                        }

                        if (Convert.ToInt32(khoaZ[10].ToString()) == 1)
                        {
                            t = Convert.ToString(Convert.ToInt32(khoaZ[7].ToString()) ^ Convert.ToInt32(khoaZ[20].ToString()) ^ Convert.ToInt32(khoaZ[21].ToString()) ^ Convert.ToInt32(khoaZ[22].ToString()), 2);
                            for (int j = 22; j > 0; j--)
                            {
                                Z[j] = khoaZ[j - 1];
                            }
                            Z[0] = Convert.ToChar(t);
                            khoaZ = Z.ToString();
                        }
                    }
                    //trường hợp m=0
                    else
                    {
                        if (Convert.ToInt32(khoaX[8].ToString()) == 0)
                        {
                            t = Convert.ToString(Convert.ToInt32(khoaX[13].ToString()) ^ Convert.ToInt32(khoaX[16].ToString()) ^ Convert.ToInt32(khoaX[17].ToString()) ^ Convert.ToInt32(khoaX[18].ToString()), 2);
                            for (int j = 18; j > 0; j--)
                            {
                                X[j] = khoaX[j - 1];
                            }
                            X[0] = Convert.ToChar(t);
                            khoaX = X.ToString();
                        }

                        if (Convert.ToInt32(khoaY[10].ToString()) == 0)
                        {
                            t = Convert.ToString(Convert.ToInt32(khoaY[20].ToString()) ^ Convert.ToInt32(khoaY[21].ToString()), 2);
                            for (int j = 21; j > 0; j--)
                            {
                                Y[j] = khoaY[j - 1];
                            }
                            Y[0] = Convert.ToChar(t);
                            khoaY = Y.ToString();
                        }

                        if (Convert.ToInt32(khoaZ[10].ToString()) == 0)
                        {
                            t = Convert.ToString(Convert.ToInt32(khoaZ[7].ToString()) ^ Convert.ToInt32(khoaZ[20].ToString()) ^ Convert.ToInt32(khoaZ[21].ToString()) ^ Convert.ToInt32(khoaZ[22].ToString()), 2);
                            for (int j = 22; j > 0; j--)
                            {
                                Z[j] = khoaZ[j - 1];
                            }
                            Z[0] = Convert.ToChar(t);
                            khoaZ = Z.ToString();
                        }
                    }

                    //thêm bit vào S
                    S[i] = Convert.ToChar(Convert.ToString(Convert.ToInt32(khoaX[18].ToString()) ^ Convert.ToInt32(khoaY[21].ToString()) ^ Convert.ToInt32(khoaZ[22].ToString()), 2));
                }
                // thêm kí tự vào bản mã
                bm.Append(Convert.ToChar(Convert.ToInt32(Convert.ToString(Convert.ToInt32(br_binary, 2) ^ Convert.ToInt32(S.ToString(), 2), 2), 2)));
            }
            return bm.ToString();
        }
        string TinyDES_Encrypt(string plain, string key)
        {
            return plain;
        }
        string DES_Encrypt(string plain, string key)
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
                    case "Ceasar":      cipher = Ceasar_Encrypt(plain_text, key); break;
                    case "Playfair":    cipher = Playfair_Encrypt(plain_text, key); break;
                    case "Vigenere":    cipher = Vigenere_Encrypt(plain_text, key); break;
                    case "Tiny A5/1":   cipher = TinyA5_Encrypt(plain_text, key); break;
                    case "A5/1":        cipher = A5_Encrypt(plain_text, key); break;
                    case "Tiny DES":    cipher = TinyDES_Encrypt(plain_text, key); break;
                    case "DES":         cipher = DES_Encrypt(plain_text, key); break;
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
        string Ceasar_Decrypt(string cipher_text, string key)
        {
			int k = 0;
			try
			{
				k = Convert.ToInt32(key);
			}
			catch (Exception)
			{
				MessageBox.Show("Bạn chỉ có thể nhập vào một số nguyên cho loại mã hoá này.", "Lưu Ý"
					, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return "";
			}

			return Ceasar.Decrypt(cipher_text, k);
		}
        string Playfair_Decrypt(string cipher_text, string key)
        {
            return Playfair.Decrypt(cipher_text, key);
        }
        string Vigenere_Decrypt(string cipher_text, string key)
        {
            return Vigenere.Decrypt(cipher_text, key);
        }
        string TinyA5_Decrypt(string cipher_text, string key)
        {
            return cipher_text;
        }
        string A5_Decrypt(string cipher_text, string key)
        {
            return cipher_text;
        }
        string TinyDES_Decrypt(string cipher_text, string key)
        {
            return cipher_text;
        }
        string DES_Decrypt(string cipher_text, string key)
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
                    case "Ceasar":      plain = Ceasar_Decrypt(cipher_text, key); break;
                    case "Playfair":    plain = Playfair_Decrypt(cipher_text, key); break;
                    case "Vigenere":    plain = Vigenere_Decrypt(cipher_text, key); break;
                    case "Tiny A5/1":   plain = TinyA5_Decrypt(cipher_text, key); break;
                    case "A5/1":        plain = A5_Decrypt(cipher_text, key); break;
                    case "Tiny DES":    plain = TinyDES_Decrypt(cipher_text, key); break;
                    case "DES":         plain = DES_Decrypt(cipher_text, key); break;
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
