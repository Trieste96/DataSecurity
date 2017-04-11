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

		// Form load
		private void frmDataSecurity_Load(object sender, EventArgs e)
		{
			cbboxType.SelectedIndex = 0;
		}

		#region Link đến các thuật toán

		// Mã hoá Ceasar
		string Ceasar_Encrypt(string plain, string key)
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

			return Ceasar.Encrypt(plain, k);
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

		// Mã hoá Playfair
		string Playfair_Encrypt(string plain, string key)
		{
			return Playfair.Encrypt(plain, key);
		}

		string Playfair_Decrypt(string cipher_text, string key)
		{
			return Playfair.Decrypt(cipher_text, key);
		}

		// Mã hoá Vigenere
		string Vigenere_Encrypt(string plain, string key)
		{
			return Vigenere.Encrypt(plain, key);
		}

		string Vigenere_Decrypt(string cipher_text, string key)
		{
			return Vigenere.Decrypt(cipher_text, key);
		}

		// Mã hoá TinyA5
		string TinyA5_Encrypt(string plain, string key)
		{
			return plain;
		}

		string TinyA5_Decrypt(string cipher_text, string key)
		{
			return cipher_text;
		}

		// Mã hoá A5
		string A5_Encrypt(string plain, string key)
		{
			return plain;
		}

		string A5_Decrypt(string cipher_text, string key)
		{
			return cipher_text;
		}

		// Mã hoá TinyDES
		string TinyDES_Encrypt(string plain, string key)
		{
			return plain;
		}

		string TinyDES_Decrypt(string cipher_text, string key)
		{
			return cipher_text;
		}

		// Mã hoá DES
		string DES_Encrypt(string plain, string key)
		{
			return plain;
		}

		string DES_Decrypt(string cipher_text, string key)
		{
			return cipher_text;
		}

		#endregion

		// Lấy file chứa bản rõ (mã hoá)
		private void btnReceivePlain_Click(object sender, EventArgs e)
		{
			dialogGetPlainText.Filter = "Text File| *.txt";
			dialogGetPlainText.ShowDialog();
			txtPlainInputURL.Text = dialogGetPlainText.FileName;
		}

		// Lấy file khoá (mã hoá)
		private void btnKeyInput_Click(object sender, EventArgs e)
		{
			dialogGetKey.Filter = "Text File| *.txt";
			dialogGetKey.ShowDialog();
			txtGetKey.Text = dialogGetKey.FileName;
		}

		// Chọn file xuất bản mã (mã hoá)
		private void btnOpenCipherText_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(txtOpenCipherText.Text);
        }


		// Lấy file chứa bản mã (giải mã)
        private void btnGetCipher_Click(object sender, EventArgs e)
        {
            dialogGetCipherText.Filter = "Text File| *.txt";
            dialogGetCipherText.ShowDialog();
            txtGetCipherURL.Text = dialogGetCipherText.FileName;
		}
		
		// Lấy file khoá (giải mã)
		private void btnGetKey2_Click(object sender, EventArgs e)
		{
			dialogGetKey2.Filter = "Text File| *.txt";
			dialogGetKey2.ShowDialog();
			txtGetKey2.Text = dialogGetKey2.FileName;
		}

		// Chọn file xuất bản rõ (giải mã)
		private void btnOpenPlainText_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(txtOpenPlainText.Text);
        }

		// Chức năng mã hoá
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
					case "Ceasar": cipher = Ceasar_Encrypt(plain_text, key); break;
					case "Playfair": cipher = Playfair_Encrypt(plain_text, key); break;
					case "Vigenere": cipher = Vigenere_Encrypt(plain_text, key); break;
					case "Tiny A5/1": cipher = TinyA5_Encrypt(plain_text, key); break;
					case "A5/1": cipher = A5_Encrypt(plain_text, key); break;
					case "Tiny DES": cipher = TinyDES_Encrypt(plain_text, key); break;
					case "DES": cipher = DES_Encrypt(plain_text, key); break;
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

		// Chức năng giải mã
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

    }
}
