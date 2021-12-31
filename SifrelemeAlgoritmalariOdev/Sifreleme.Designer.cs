
namespace SifrelemeAlgoritmalariOdev
{
    partial class Sifreleme
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCevir = new System.Windows.Forms.Button();
            this.rotCheck = new System.Windows.Forms.CheckBox();
            this.sha256Check = new System.Windows.Forms.CheckBox();
            this.TxtGirilecek = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Dosya = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.TxtCevirilmis = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txName = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_chat = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCevir);
            this.groupBox1.Controls.Add(this.rotCheck);
            this.groupBox1.Controls.Add(this.sha256Check);
            this.groupBox1.Controls.Add(this.TxtGirilecek);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(398, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnCevir
            // 
            this.btnCevir.BackColor = System.Drawing.Color.DarkGray;
            this.btnCevir.Location = new System.Drawing.Point(218, 179);
            this.btnCevir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCevir.Name = "btnCevir";
            this.btnCevir.Size = new System.Drawing.Size(115, 31);
            this.btnCevir.TabIndex = 4;
            this.btnCevir.Text = "Cevir";
            this.btnCevir.UseVisualStyleBackColor = false;
            this.btnCevir.Click += new System.EventHandler(this.btnCevir_Click);
            // 
            // rotCheck
            // 
            this.rotCheck.AutoSize = true;
            this.rotCheck.Location = new System.Drawing.Point(16, 186);
            this.rotCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rotCheck.Name = "rotCheck";
            this.rotCheck.Size = new System.Drawing.Size(74, 24);
            this.rotCheck.TabIndex = 3;
            this.rotCheck.Text = "ROT13";
            this.rotCheck.UseVisualStyleBackColor = true;
            // 
            // sha256Check
            // 
            this.sha256Check.AutoSize = true;
            this.sha256Check.Location = new System.Drawing.Point(16, 144);
            this.sha256Check.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sha256Check.Name = "sha256Check";
            this.sha256Check.Size = new System.Drawing.Size(88, 24);
            this.sha256Check.TabIndex = 2;
            this.sha256Check.Text = "SHA 256";
            this.sha256Check.UseVisualStyleBackColor = true;
            // 
            // TxtGirilecek
            // 
            this.TxtGirilecek.Location = new System.Drawing.Point(7, 49);
            this.TxtGirilecek.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtGirilecek.Multiline = true;
            this.TxtGirilecek.Name = "TxtGirilecek";
            this.TxtGirilecek.Size = new System.Drawing.Size(365, 76);
            this.TxtGirilecek.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Girilecek Text";
            // 
            // btn_Dosya
            // 
            this.btn_Dosya.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Dosya.Location = new System.Drawing.Point(426, 510);
            this.btn_Dosya.Name = "btn_Dosya";
            this.btn_Dosya.Size = new System.Drawing.Size(161, 56);
            this.btn_Dosya.TabIndex = 7;
            this.btn_Dosya.Text = "Dosya Gönder";
            this.btn_Dosya.UseVisualStyleBackColor = false;
            this.btn_Dosya.Click += new System.EventHandler(this.btn_Dosya_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.DarkGray;
            this.btnSend.Location = new System.Drawing.Point(268, 510);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(136, 56);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Gönder";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // TxtCevirilmis
            // 
            this.TxtCevirilmis.AutoSize = true;
            this.TxtCevirilmis.Location = new System.Drawing.Point(7, 25);
            this.TxtCevirilmis.Name = "TxtCevirilmis";
            this.TxtCevirilmis.Size = new System.Drawing.Size(104, 20);
            this.TxtCevirilmis.TabIndex = 1;
            this.TxtCevirilmis.Text = "Çevirilmiş Text";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtCevirilmis);
            this.groupBox2.Location = new System.Drawing.Point(6, 341);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(398, 149);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(420, 80);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(154, 270);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(6, 28);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(137, 224);
            this.listBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "İsminiz: ";
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(64, 41);
            this.txName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(114, 27);
            this.txName.TabIndex = 8;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.DarkGray;
            this.btnConnect.Location = new System.Drawing.Point(185, 41);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(86, 31);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "Bağlan";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 565);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "--";
            // 
            // rb_chat
            // 
            this.rb_chat.Location = new System.Drawing.Point(603, 108);
            this.rb_chat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_chat.Name = "rb_chat";
            this.rb_chat.Size = new System.Drawing.Size(193, 127);
            this.rb_chat.TabIndex = 11;
            this.rb_chat.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(603, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Gelen Mesaj";
            // 
            // Sifreleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(804, 594);
            this.Controls.Add(this.btn_Dosya);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rb_chat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Sifreleme";
            this.Text = "Sifreleme";
            this.Load += new System.EventHandler(this.Sifreleme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox rotCheck;
        private System.Windows.Forms.CheckBox sha256Check;
        private System.Windows.Forms.TextBox TxtGirilecek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TxtCevirilmis;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCevir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rb_chat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Dosya;
        public System.Windows.Forms.TextBox txName;
        public System.Windows.Forms.ListBox listBox1;
    }
}

