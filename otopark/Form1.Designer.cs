namespace otopark
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblOToparkadı = new System.Windows.Forms.Label();
            this.lblAraçSayısı = new System.Windows.Forms.Label();
            this.BtnOtoparkOluştur = new System.Windows.Forms.Button();
            this.BtnAraçGiriş = new System.Windows.Forms.Button();
            this.BtnAraçÇıkış = new System.Windows.Forms.Button();
            this.BtnKapasite = new System.Windows.Forms.Button();
            this.BtnBakiye = new System.Windows.Forms.Button();
            this.chkOtomobilMi = new System.Windows.Forms.CheckBox();
            this.TxtOtoparkAdı = new System.Windows.Forms.TextBox();
            this.TxtKapasite = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblOToparkadı
            // 
            this.LblOToparkadı.AutoSize = true;
            this.LblOToparkadı.Location = new System.Drawing.Point(92, 57);
            this.LblOToparkadı.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblOToparkadı.Name = "LblOToparkadı";
            this.LblOToparkadı.Size = new System.Drawing.Size(140, 24);
            this.LblOToparkadı.TabIndex = 0;
            this.LblOToparkadı.Text = "Otopark Adı:";
            // 
            // lblAraçSayısı
            // 
            this.lblAraçSayısı.AutoSize = true;
            this.lblAraçSayısı.Location = new System.Drawing.Point(126, 121);
            this.lblAraçSayısı.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAraçSayısı.Name = "lblAraçSayısı";
            this.lblAraçSayısı.Size = new System.Drawing.Size(106, 24);
            this.lblAraçSayısı.TabIndex = 1;
            this.lblAraçSayısı.Text = "Kapasite:";
            // 
            // BtnOtoparkOluştur
            // 
            this.BtnOtoparkOluştur.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOtoparkOluştur.Location = new System.Drawing.Point(496, 55);
            this.BtnOtoparkOluştur.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnOtoparkOluştur.Name = "BtnOtoparkOluştur";
            this.BtnOtoparkOluştur.Size = new System.Drawing.Size(191, 90);
            this.BtnOtoparkOluştur.TabIndex = 2;
            this.BtnOtoparkOluştur.Text = "Otopark Oluştur";
            this.BtnOtoparkOluştur.UseVisualStyleBackColor = true;
            this.BtnOtoparkOluştur.Click += new System.EventHandler(this.BtnOtoparkOluştur_Click);
            // 
            // BtnAraçGiriş
            // 
            this.BtnAraçGiriş.Location = new System.Drawing.Point(123, 237);
            this.BtnAraçGiriş.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnAraçGiriş.Name = "BtnAraçGiriş";
            this.BtnAraçGiriş.Size = new System.Drawing.Size(158, 94);
            this.BtnAraçGiriş.TabIndex = 3;
            this.BtnAraçGiriş.Text = "Otopark Araç Girişi";
            this.BtnAraçGiriş.UseVisualStyleBackColor = true;
            this.BtnAraçGiriş.Click += new System.EventHandler(this.BtnAraçGiriş_Click);
            // 
            // BtnAraçÇıkış
            // 
            this.BtnAraçÇıkış.Location = new System.Drawing.Point(291, 237);
            this.BtnAraçÇıkış.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnAraçÇıkış.Name = "BtnAraçÇıkış";
            this.BtnAraçÇıkış.Size = new System.Drawing.Size(158, 94);
            this.BtnAraçÇıkış.TabIndex = 4;
            this.BtnAraçÇıkış.Text = "Otopark Araç Çıkışı";
            this.BtnAraçÇıkış.UseVisualStyleBackColor = true;
            this.BtnAraçÇıkış.Click += new System.EventHandler(this.BtnAraçÇıkış_Click);
            // 
            // BtnKapasite
            // 
            this.BtnKapasite.Location = new System.Drawing.Point(291, 339);
            this.BtnKapasite.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnKapasite.Name = "BtnKapasite";
            this.BtnKapasite.Size = new System.Drawing.Size(158, 81);
            this.BtnKapasite.TabIndex = 5;
            this.BtnKapasite.Text = "Anlık Kapasite";
            this.BtnKapasite.UseVisualStyleBackColor = true;
            this.BtnKapasite.Click += new System.EventHandler(this.BtnKapasite_Click);
            // 
            // BtnBakiye
            // 
            this.BtnBakiye.Location = new System.Drawing.Point(123, 339);
            this.BtnBakiye.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnBakiye.Name = "BtnBakiye";
            this.BtnBakiye.Size = new System.Drawing.Size(158, 81);
            this.BtnBakiye.TabIndex = 6;
            this.BtnBakiye.Text = "Bakiye";
            this.BtnBakiye.UseVisualStyleBackColor = true;
            this.BtnBakiye.Click += new System.EventHandler(this.BtnBakiye_Click);
            // 
            // chkOtomobilMi
            // 
            this.chkOtomobilMi.AutoSize = true;
            this.chkOtomobilMi.Location = new System.Drawing.Point(96, 188);
            this.chkOtomobilMi.Name = "chkOtomobilMi";
            this.chkOtomobilMi.Size = new System.Drawing.Size(224, 28);
            this.chkOtomobilMi.TabIndex = 7;
            this.chkOtomobilMi.Text = "Araç otomobil mi?";
            this.chkOtomobilMi.UseVisualStyleBackColor = true;
            // 
            // TxtOtoparkAdı
            // 
            this.TxtOtoparkAdı.Location = new System.Drawing.Point(240, 57);
            this.TxtOtoparkAdı.Name = "TxtOtoparkAdı";
            this.TxtOtoparkAdı.Size = new System.Drawing.Size(174, 31);
            this.TxtOtoparkAdı.TabIndex = 8;
            // 
            // TxtKapasite
            // 
            this.TxtKapasite.Location = new System.Drawing.Point(240, 118);
            this.TxtKapasite.Name = "TxtKapasite";
            this.TxtKapasite.Size = new System.Drawing.Size(174, 31);
            this.TxtKapasite.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 467);
            this.Controls.Add(this.TxtKapasite);
            this.Controls.Add(this.TxtOtoparkAdı);
            this.Controls.Add(this.chkOtomobilMi);
            this.Controls.Add(this.BtnBakiye);
            this.Controls.Add(this.BtnKapasite);
            this.Controls.Add(this.BtnAraçÇıkış);
            this.Controls.Add(this.BtnAraçGiriş);
            this.Controls.Add(this.BtnOtoparkOluştur);
            this.Controls.Add(this.lblAraçSayısı);
            this.Controls.Add(this.LblOToparkadı);
            this.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblOToparkadı;
        private System.Windows.Forms.Label lblAraçSayısı;
        private System.Windows.Forms.Button BtnOtoparkOluştur;
        private System.Windows.Forms.Button BtnAraçGiriş;
        private System.Windows.Forms.Button BtnAraçÇıkış;
        private System.Windows.Forms.Button BtnKapasite;
        private System.Windows.Forms.Button BtnBakiye;
        private System.Windows.Forms.CheckBox chkOtomobilMi;
        private System.Windows.Forms.TextBox TxtOtoparkAdı;
        private System.Windows.Forms.TextBox TxtKapasite;
    }
}

