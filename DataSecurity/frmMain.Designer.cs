namespace Ceasar_Playfair_Vigenere
{
    partial class frmDataSecurity
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.plainTextFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenCipherText = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtOpenCipherText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKeyInput = new System.Windows.Forms.Button();
            this.txtGetKey = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.btnReceivePlain = new System.Windows.Forms.Button();
            this.txtPlainInputURL = new System.Windows.Forms.TextBox();
            this.lblBanRo = new System.Windows.Forms.Label();
            this.dialogGetPlainText = new System.Windows.Forms.OpenFileDialog();
            this.dialogGetKey = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOpenPlainText = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtOpenPlainText = new System.Windows.Forms.TextBox();
            this.lblOpenPlainText = new System.Windows.Forms.Label();
            this.btnGetKey2 = new System.Windows.Forms.Button();
            this.txtGetKey2 = new System.Windows.Forms.TextBox();
            this.lblKey2 = new System.Windows.Forms.Label();
            this.btnGetCipher = new System.Windows.Forms.Button();
            this.txtGetCipherURL = new System.Windows.Forms.TextBox();
            this.lblGetCipher = new System.Windows.Forms.Label();
            this.tabList = new System.Windows.Forms.TabControl();
            this.tabEncrypt = new System.Windows.Forms.TabPage();
            this.tabDecrypt = new System.Windows.Forms.TabPage();
            this.cbboxType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dialogGetCipherText = new System.Windows.Forms.OpenFileDialog();
            this.dialogGetKey2 = new System.Windows.Forms.OpenFileDialog();
            this.dialogSaveEncryption = new System.Windows.Forms.SaveFileDialog();
            this.dialogSaveDecryption = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabList.SuspendLayout();
            this.tabEncrypt.SuspendLayout();
            this.tabDecrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // plainTextFileDialog
            // 
            this.plainTextFileDialog.FileName = "openPlainTextFileDialog";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpenCipherText);
            this.groupBox1.Controls.Add(this.btnEncrypt);
            this.groupBox1.Controls.Add(this.txtOpenCipherText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnKeyInput);
            this.groupBox1.Controls.Add(this.txtGetKey);
            this.groupBox1.Controls.Add(this.lblKey);
            this.groupBox1.Controls.Add(this.btnReceivePlain);
            this.groupBox1.Controls.Add(this.txtPlainInputURL);
            this.groupBox1.Controls.Add(this.lblBanRo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mã hoá";
            // 
            // btnOpenCipherText
            // 
            this.btnOpenCipherText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.225F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenCipherText.ForeColor = System.Drawing.Color.Black;
            this.btnOpenCipherText.Location = new System.Drawing.Point(379, 168);
            this.btnOpenCipherText.Name = "btnOpenCipherText";
            this.btnOpenCipherText.Size = new System.Drawing.Size(75, 23);
            this.btnOpenCipherText.TabIndex = 9;
            this.btnOpenCipherText.Text = "Mở bản mã";
            this.btnOpenCipherText.UseVisualStyleBackColor = true;
            this.btnOpenCipherText.Click += new System.EventHandler(this.btnOpenCipherText_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.Color.Blue;
            this.btnEncrypt.Location = new System.Drawing.Point(199, 97);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(111, 34);
            this.btnEncrypt.TabIndex = 8;
            this.btnEncrypt.Text = "Mã hoá";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtOpenCipherText
            // 
            this.txtOpenCipherText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpenCipherText.Location = new System.Drawing.Point(73, 168);
            this.txtOpenCipherText.Name = "txtOpenCipherText";
            this.txtOpenCipherText.ReadOnly = true;
            this.txtOpenCipherText.Size = new System.Drawing.Size(300, 21);
            this.txtOpenCipherText.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bản mã";
            // 
            // btnKeyInput
            // 
            this.btnKeyInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.225F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeyInput.ForeColor = System.Drawing.Color.Black;
            this.btnKeyInput.Location = new System.Drawing.Point(379, 70);
            this.btnKeyInput.Name = "btnKeyInput";
            this.btnKeyInput.Size = new System.Drawing.Size(75, 23);
            this.btnKeyInput.TabIndex = 5;
            this.btnKeyInput.Text = "Nhập file";
            this.btnKeyInput.UseVisualStyleBackColor = true;
            this.btnKeyInput.Click += new System.EventHandler(this.btnKeyInput_Click);
            // 
            // txtGetKey
            // 
            this.txtGetKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGetKey.Location = new System.Drawing.Point(73, 70);
            this.txtGetKey.Name = "txtGetKey";
            this.txtGetKey.Size = new System.Drawing.Size(300, 21);
            this.txtGetKey.TabIndex = 4;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.ForeColor = System.Drawing.Color.Black;
            this.lblKey.Location = new System.Drawing.Point(15, 73);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(39, 15);
            this.lblKey.TabIndex = 3;
            this.lblKey.Text = "Khoá:";
            // 
            // btnReceivePlain
            // 
            this.btnReceivePlain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.225F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceivePlain.ForeColor = System.Drawing.Color.Black;
            this.btnReceivePlain.Location = new System.Drawing.Point(379, 30);
            this.btnReceivePlain.Name = "btnReceivePlain";
            this.btnReceivePlain.Size = new System.Drawing.Size(75, 23);
            this.btnReceivePlain.TabIndex = 2;
            this.btnReceivePlain.Text = "Nhập file";
            this.btnReceivePlain.UseVisualStyleBackColor = true;
            this.btnReceivePlain.Click += new System.EventHandler(this.btnReceivePlain_Click);
            // 
            // txtPlainInputURL
            // 
            this.txtPlainInputURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlainInputURL.Location = new System.Drawing.Point(73, 30);
            this.txtPlainInputURL.Name = "txtPlainInputURL";
            this.txtPlainInputURL.Size = new System.Drawing.Size(300, 21);
            this.txtPlainInputURL.TabIndex = 1;
            // 
            // lblBanRo
            // 
            this.lblBanRo.AutoSize = true;
            this.lblBanRo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanRo.ForeColor = System.Drawing.Color.Black;
            this.lblBanRo.Location = new System.Drawing.Point(15, 33);
            this.lblBanRo.Name = "lblBanRo";
            this.lblBanRo.Size = new System.Drawing.Size(46, 15);
            this.lblBanRo.TabIndex = 0;
            this.lblBanRo.Text = "Bản rõ:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOpenPlainText);
            this.groupBox2.Controls.Add(this.btnDecrypt);
            this.groupBox2.Controls.Add(this.txtOpenPlainText);
            this.groupBox2.Controls.Add(this.lblOpenPlainText);
            this.groupBox2.Controls.Add(this.btnGetKey2);
            this.groupBox2.Controls.Add(this.txtGetKey2);
            this.groupBox2.Controls.Add(this.lblKey2);
            this.groupBox2.Controls.Add(this.btnGetCipher);
            this.groupBox2.Controls.Add(this.txtGetCipherURL);
            this.groupBox2.Controls.Add(this.lblGetCipher);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 208);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giải mã";
            // 
            // btnOpenPlainText
            // 
            this.btnOpenPlainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.225F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenPlainText.ForeColor = System.Drawing.Color.Black;
            this.btnOpenPlainText.Location = new System.Drawing.Point(385, 168);
            this.btnOpenPlainText.Name = "btnOpenPlainText";
            this.btnOpenPlainText.Size = new System.Drawing.Size(75, 23);
            this.btnOpenPlainText.TabIndex = 9;
            this.btnOpenPlainText.Text = "Mở bản mã";
            this.btnOpenPlainText.UseVisualStyleBackColor = true;
            this.btnOpenPlainText.Click += new System.EventHandler(this.btnOpenPlainText_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.ForeColor = System.Drawing.Color.Blue;
            this.btnDecrypt.Location = new System.Drawing.Point(199, 97);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(111, 34);
            this.btnDecrypt.TabIndex = 8;
            this.btnDecrypt.Text = "Giải mã";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtOpenPlainText
            // 
            this.txtOpenPlainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpenPlainText.Location = new System.Drawing.Point(73, 168);
            this.txtOpenPlainText.Name = "txtOpenPlainText";
            this.txtOpenPlainText.ReadOnly = true;
            this.txtOpenPlainText.Size = new System.Drawing.Size(306, 21);
            this.txtOpenPlainText.TabIndex = 7;
            // 
            // lblOpenPlainText
            // 
            this.lblOpenPlainText.AutoSize = true;
            this.lblOpenPlainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenPlainText.ForeColor = System.Drawing.Color.Black;
            this.lblOpenPlainText.Location = new System.Drawing.Point(15, 171);
            this.lblOpenPlainText.Name = "lblOpenPlainText";
            this.lblOpenPlainText.Size = new System.Drawing.Size(46, 15);
            this.lblOpenPlainText.TabIndex = 6;
            this.lblOpenPlainText.Text = "Bản rõ:";
            // 
            // btnGetKey2
            // 
            this.btnGetKey2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.225F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetKey2.ForeColor = System.Drawing.Color.Black;
            this.btnGetKey2.Location = new System.Drawing.Point(385, 70);
            this.btnGetKey2.Name = "btnGetKey2";
            this.btnGetKey2.Size = new System.Drawing.Size(75, 23);
            this.btnGetKey2.TabIndex = 5;
            this.btnGetKey2.Text = "Nhập file";
            this.btnGetKey2.UseVisualStyleBackColor = true;
            this.btnGetKey2.Click += new System.EventHandler(this.btnGetKey2_Click);
            // 
            // txtGetKey2
            // 
            this.txtGetKey2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGetKey2.Location = new System.Drawing.Point(73, 70);
            this.txtGetKey2.Name = "txtGetKey2";
            this.txtGetKey2.Size = new System.Drawing.Size(306, 21);
            this.txtGetKey2.TabIndex = 4;
            // 
            // lblKey2
            // 
            this.lblKey2.AutoSize = true;
            this.lblKey2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey2.ForeColor = System.Drawing.Color.Black;
            this.lblKey2.Location = new System.Drawing.Point(15, 73);
            this.lblKey2.Name = "lblKey2";
            this.lblKey2.Size = new System.Drawing.Size(39, 15);
            this.lblKey2.TabIndex = 3;
            this.lblKey2.Text = "Khoá:";
            // 
            // btnGetCipher
            // 
            this.btnGetCipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.225F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetCipher.ForeColor = System.Drawing.Color.Black;
            this.btnGetCipher.Location = new System.Drawing.Point(385, 30);
            this.btnGetCipher.Name = "btnGetCipher";
            this.btnGetCipher.Size = new System.Drawing.Size(75, 23);
            this.btnGetCipher.TabIndex = 2;
            this.btnGetCipher.Text = "Nhập file";
            this.btnGetCipher.UseVisualStyleBackColor = true;
            this.btnGetCipher.Click += new System.EventHandler(this.btnGetCipher_Click);
            // 
            // txtGetCipherURL
            // 
            this.txtGetCipherURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGetCipherURL.Location = new System.Drawing.Point(73, 30);
            this.txtGetCipherURL.Name = "txtGetCipherURL";
            this.txtGetCipherURL.Size = new System.Drawing.Size(306, 21);
            this.txtGetCipherURL.TabIndex = 1;
            // 
            // lblGetCipher
            // 
            this.lblGetCipher.AutoSize = true;
            this.lblGetCipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetCipher.ForeColor = System.Drawing.Color.Black;
            this.lblGetCipher.Location = new System.Drawing.Point(15, 33);
            this.lblGetCipher.Name = "lblGetCipher";
            this.lblGetCipher.Size = new System.Drawing.Size(53, 15);
            this.lblGetCipher.TabIndex = 0;
            this.lblGetCipher.Text = "Bản mã:";
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.tabEncrypt);
            this.tabList.Controls.Add(this.tabDecrypt);
            this.tabList.Location = new System.Drawing.Point(1, 63);
            this.tabList.Name = "tabList";
            this.tabList.SelectedIndex = 0;
            this.tabList.Size = new System.Drawing.Size(483, 264);
            this.tabList.TabIndex = 11;
            // 
            // tabEncrypt
            // 
            this.tabEncrypt.Controls.Add(this.groupBox1);
            this.tabEncrypt.Location = new System.Drawing.Point(4, 22);
            this.tabEncrypt.Name = "tabEncrypt";
            this.tabEncrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tabEncrypt.Size = new System.Drawing.Size(475, 238);
            this.tabEncrypt.TabIndex = 0;
            this.tabEncrypt.Text = "Mã hoá";
            this.tabEncrypt.UseVisualStyleBackColor = true;
            // 
            // tabDecrypt
            // 
            this.tabDecrypt.Controls.Add(this.groupBox2);
            this.tabDecrypt.Location = new System.Drawing.Point(4, 22);
            this.tabDecrypt.Name = "tabDecrypt";
            this.tabDecrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tabDecrypt.Size = new System.Drawing.Size(475, 238);
            this.tabDecrypt.TabIndex = 1;
            this.tabDecrypt.Text = "Giải mã";
            this.tabDecrypt.UseVisualStyleBackColor = true;
            // 
            // cbboxType
            // 
            this.cbboxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxType.FormattingEnabled = true;
            this.cbboxType.Items.AddRange(new object[] {
            "Ceasar",
            "Playfair",
            "Vigenere",
            "A5/1",
            "DES"});
            this.cbboxType.Location = new System.Drawing.Point(133, 25);
            this.cbboxType.Name = "cbboxType";
            this.cbboxType.Size = new System.Drawing.Size(121, 21);
            this.cbboxType.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Loại mã:";
            // 
            // frmDataSecurity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 329);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbboxType);
            this.Controls.Add(this.tabList);
            this.Name = "frmDataSecurity";
            this.Text = "Chương trình Mã hoá - Giải mã";
            this.Load += new System.EventHandler(this.frmDataSecurity_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabList.ResumeLayout(false);
            this.tabEncrypt.ResumeLayout(false);
            this.tabDecrypt.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog plainTextFileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReceivePlain;
        private System.Windows.Forms.TextBox txtPlainInputURL;
        private System.Windows.Forms.Label lblBanRo;
        private System.Windows.Forms.OpenFileDialog dialogGetPlainText;
        private System.Windows.Forms.Button btnKeyInput;
        private System.Windows.Forms.TextBox txtGetKey;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtOpenCipherText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog dialogGetKey;
        private System.Windows.Forms.Button btnOpenCipherText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOpenPlainText;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtOpenPlainText;
        private System.Windows.Forms.Label lblOpenPlainText;
        private System.Windows.Forms.Button btnGetKey2;
        private System.Windows.Forms.TextBox txtGetKey2;
        private System.Windows.Forms.Label lblKey2;
        private System.Windows.Forms.Button btnGetCipher;
        private System.Windows.Forms.TextBox txtGetCipherURL;
        private System.Windows.Forms.Label lblGetCipher;
        private System.Windows.Forms.TabControl tabList;
        private System.Windows.Forms.TabPage tabEncrypt;
        private System.Windows.Forms.TabPage tabDecrypt;
        private System.Windows.Forms.ComboBox cbboxType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog dialogGetCipherText;
        private System.Windows.Forms.OpenFileDialog dialogGetKey2;
        private System.Windows.Forms.SaveFileDialog dialogSaveEncryption;
        private System.Windows.Forms.SaveFileDialog dialogSaveDecryption;
    }
}

