
namespace SifrelemeAlgoritmalariOdev
{
    partial class DosyaGonder
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
            this.btn_yükle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btn_Zip = new System.Windows.Forms.Button();
            this.btn_Gonder = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBox1Dosya = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_yükle
            // 
            this.btn_yükle.Location = new System.Drawing.Point(390, 139);
            this.btn_yükle.Name = "btn_yükle";
            this.btn_yükle.Size = new System.Drawing.Size(110, 27);
            this.btn_yükle.TabIndex = 0;
            this.btn_yükle.Text = "Dosya Yükle";
            this.btn_yükle.UseVisualStyleBackColor = true;
            this.btn_yükle.Click += new System.EventHandler(this.btn_yUkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seçilen dosya: ";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(62, 139);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(309, 27);
            this.txtUrl.TabIndex = 2;
            // 
            // btn_Zip
            // 
            this.btn_Zip.Location = new System.Drawing.Point(31, 54);
            this.btn_Zip.Name = "btn_Zip";
            this.btn_Zip.Size = new System.Drawing.Size(114, 29);
            this.btn_Zip.TabIndex = 4;
            this.btn_Zip.Text = "Dosya ziple";
            this.btn_Zip.UseVisualStyleBackColor = true;
            this.btn_Zip.Click += new System.EventHandler(this.btn_Zip_Click);
            // 
            // btn_Gonder
            // 
            this.btn_Gonder.Location = new System.Drawing.Point(214, 200);
            this.btn_Gonder.Name = "btn_Gonder";
            this.btn_Gonder.Size = new System.Drawing.Size(157, 35);
            this.btn_Gonder.TabIndex = 6;
            this.btn_Gonder.Text = "Gönder";
            this.btn_Gonder.UseVisualStyleBackColor = true;
            this.btn_Gonder.Click += new System.EventHandler(this.btn_Gonder_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBox1Dosya
            // 
            this.listBox1Dosya.FormattingEnabled = true;
            this.listBox1Dosya.ItemHeight = 20;
            this.listBox1Dosya.Location = new System.Drawing.Point(62, 187);
            this.listBox1Dosya.Name = "listBox1Dosya";
            this.listBox1Dosya.Size = new System.Drawing.Size(137, 84);
            this.listBox1Dosya.TabIndex = 7;
            // 
            // DosyaGonder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 359);
            this.Controls.Add(this.listBox1Dosya);
            this.Controls.Add(this.btn_Gonder);
            this.Controls.Add(this.btn_Zip);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_yükle);
            this.Name = "DosyaGonder";
            this.Text = "s1";
            this.Load += new System.EventHandler(this.DosyaGonder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_yükle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Zip;
        private System.Windows.Forms.Button btn_Gonder;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.ListBox listBox1Dosya;
    }
}