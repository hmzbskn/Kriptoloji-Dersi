namespace Şifreleme_Programı
{
    partial class Şifre_Çözme
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmBox_tur = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBox_Hedef = new System.Windows.Forms.RichTextBox();
            this.txtBox_amac = new System.Windows.Forms.RichTextBox();
            this.nmr_Key = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_key2 = new System.Windows.Forms.Label();
            this.nmr_Key2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_Key)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_Key2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Çözmek İstediğiniz Metin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(991, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Sonuç Metin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(592, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Şifreleme Türü";
            // 
            // cmBox_tur
            // 
            this.cmBox_tur.FormattingEnabled = true;
            this.cmBox_tur.Items.AddRange(new object[] {
            "Sezar Algoritması",
            "Kaydırmalı Algoritma",
            "Doğrusal Şifreleme",
            "Yer Değiştirme ",
            "Yer Değiştirme ( Sayı Anahtarlı) ",
            "Permutasyon Şifreleme",
            "Rota Şifreleme",
            "Zig Zag Şifreleme"});
            this.cmBox_tur.Location = new System.Drawing.Point(531, 230);
            this.cmBox_tur.Name = "cmBox_tur";
            this.cmBox_tur.Size = new System.Drawing.Size(232, 28);
            this.cmBox_tur.TabIndex = 17;
            this.cmBox_tur.SelectedIndexChanged += new System.EventHandler(this.cmBox_tur_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 65);
            this.button1.TabIndex = 16;
            this.button1.Text = "Deşifre Et";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBox_Hedef
            // 
            this.txtBox_Hedef.Location = new System.Drawing.Point(794, 195);
            this.txtBox_Hedef.Name = "txtBox_Hedef";
            this.txtBox_Hedef.Size = new System.Drawing.Size(480, 346);
            this.txtBox_Hedef.TabIndex = 15;
            this.txtBox_Hedef.Text = "";
            // 
            // txtBox_amac
            // 
            this.txtBox_amac.Location = new System.Drawing.Point(12, 195);
            this.txtBox_amac.Name = "txtBox_amac";
            this.txtBox_amac.Size = new System.Drawing.Size(480, 346);
            this.txtBox_amac.TabIndex = 14;
            this.txtBox_amac.Text = "";
            // 
            // nmr_Key
            // 
            this.nmr_Key.Location = new System.Drawing.Point(531, 299);
            this.nmr_Key.Name = "nmr_Key";
            this.nmr_Key.Size = new System.Drawing.Size(232, 26);
            this.nmr_Key.TabIndex = 23;
            this.nmr_Key.ValueChanged += new System.EventHandler(this.nmr_Key_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(612, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Anahtar";
            // 
            // lbl_key2
            // 
            this.lbl_key2.AutoSize = true;
            this.lbl_key2.Location = new System.Drawing.Point(612, 338);
            this.lbl_key2.Name = "lbl_key2";
            this.lbl_key2.Size = new System.Drawing.Size(79, 20);
            this.lbl_key2.TabIndex = 26;
            this.lbl_key2.Text = "Anahtar b";
            // 
            // nmr_Key2
            // 
            this.nmr_Key2.Location = new System.Drawing.Point(531, 361);
            this.nmr_Key2.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nmr_Key2.Name = "nmr_Key2";
            this.nmr_Key2.Size = new System.Drawing.Size(232, 26);
            this.nmr_Key2.TabIndex = 25;
            this.nmr_Key2.ValueChanged += new System.EventHandler(this.nmr_Key2_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1066, 653);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "233311134 - Hamza Başkan";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 564);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(480, 56);
            this.button2.TabIndex = 31;
            this.button2.Text = "Dosya Seç";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Şifre_Çözme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 682);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_key2);
            this.Controls.Add(this.nmr_Key2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nmr_Key);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmBox_tur);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBox_Hedef);
            this.Controls.Add(this.txtBox_amac);
            this.Controls.Add(this.label1);
            this.Name = "Şifre_Çözme";
            this.Text = "Şifre_Çözme";
            this.Load += new System.EventHandler(this.Şifre_Çözme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmr_Key)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_Key2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmBox_tur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtBox_Hedef;
        private System.Windows.Forms.RichTextBox txtBox_amac;
        private System.Windows.Forms.NumericUpDown nmr_Key;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_key2;
        private System.Windows.Forms.NumericUpDown nmr_Key2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}