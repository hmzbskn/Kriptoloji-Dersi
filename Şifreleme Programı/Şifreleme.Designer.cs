namespace Şifreleme_Programı
{
    partial class Şifreleme
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Tur = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbox_sonucMetin = new System.Windows.Forms.RichTextBox();
            this.txtbox_amacMetin = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.num_key = new System.Windows.Forms.NumericUpDown();
            this.lbl_Anahtar2 = new System.Windows.Forms.Label();
            this.num_key2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_EpostaGonder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_key)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_key2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(991, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sonuç Metin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(593, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Şifreleme Türü";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Şifrelemek İstediğiniz Metin";
            // 
            // cmb_Tur
            // 
            this.cmb_Tur.FormattingEnabled = true;
            this.cmb_Tur.Items.AddRange(new object[] {
            "Sezar Algoritması",
            "Kaydırmalı Algoritma",
            "Doğrusal Şifreleme",
            "Yer Değiştirme ",
            "Yer Değiştirme ( Sayı Anahtarlı) ",
            "Permutasyon Şifreleme",
            "Rota Şifreleme",
            "Zig Zag Şifreleme"});
            this.cmb_Tur.Location = new System.Drawing.Point(532, 261);
            this.cmb_Tur.Name = "cmb_Tur";
            this.cmb_Tur.Size = new System.Drawing.Size(232, 28);
            this.cmb_Tur.TabIndex = 10;
            this.cmb_Tur.SelectedIndexChanged += new System.EventHandler(this.cmb_Tur_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 65);
            this.button1.TabIndex = 9;
            this.button1.Text = "Şifrele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbox_sonucMetin
            // 
            this.txtbox_sonucMetin.Location = new System.Drawing.Point(794, 229);
            this.txtbox_sonucMetin.Name = "txtbox_sonucMetin";
            this.txtbox_sonucMetin.Size = new System.Drawing.Size(480, 346);
            this.txtbox_sonucMetin.TabIndex = 8;
            this.txtbox_sonucMetin.Text = "";
            // 
            // txtbox_amacMetin
            // 
            this.txtbox_amacMetin.Location = new System.Drawing.Point(12, 229);
            this.txtbox_amacMetin.Name = "txtbox_amacMetin";
            this.txtbox_amacMetin.Size = new System.Drawing.Size(480, 346);
            this.txtbox_amacMetin.TabIndex = 7;
            this.txtbox_amacMetin.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(613, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Anahtar";
            // 
            // num_key
            // 
            this.num_key.Location = new System.Drawing.Point(532, 323);
            this.num_key.Name = "num_key";
            this.num_key.Size = new System.Drawing.Size(232, 26);
            this.num_key.TabIndex = 25;
            // 
            // lbl_Anahtar2
            // 
            this.lbl_Anahtar2.AutoSize = true;
            this.lbl_Anahtar2.Location = new System.Drawing.Point(613, 356);
            this.lbl_Anahtar2.Name = "lbl_Anahtar2";
            this.lbl_Anahtar2.Size = new System.Drawing.Size(81, 20);
            this.lbl_Anahtar2.TabIndex = 28;
            this.lbl_Anahtar2.Text = "Anahtar B";
            // 
            // num_key2
            // 
            this.num_key2.Location = new System.Drawing.Point(532, 379);
            this.num_key2.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.num_key2.Name = "num_key2";
            this.num_key2.Size = new System.Drawing.Size(232, 26);
            this.num_key2.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1062, 754);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "233311134 - Hamza Başkan";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 604);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(480, 56);
            this.button2.TabIndex = 30;
            this.button2.Text = "Dosya Seç";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_EpostaGonder
            // 
            this.btn_EpostaGonder.Location = new System.Drawing.Point(794, 604);
            this.btn_EpostaGonder.Name = "btn_EpostaGonder";
            this.btn_EpostaGonder.Size = new System.Drawing.Size(480, 56);
            this.btn_EpostaGonder.TabIndex = 31;
            this.btn_EpostaGonder.Text = "E-posta Gönder";
            this.btn_EpostaGonder.UseVisualStyleBackColor = true;
            this.btn_EpostaGonder.Click += new System.EventHandler(this.btn_EpostaGonder_Click);
            // 
            // Şifreleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1286, 783);
            this.Controls.Add(this.btn_EpostaGonder);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_Anahtar2);
            this.Controls.Add(this.num_key2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.num_key);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Tur);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbox_sonucMetin);
            this.Controls.Add(this.txtbox_amacMetin);
            this.Name = "Şifreleme";
            this.Text = "Şifreleme";
            this.Load += new System.EventHandler(this.Şifreleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_key)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_key2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Tur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtbox_sonucMetin;
        private System.Windows.Forms.RichTextBox txtbox_amacMetin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num_key;
        private System.Windows.Forms.Label lbl_Anahtar2;
        private System.Windows.Forms.NumericUpDown num_key2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_EpostaGonder;
    }
}