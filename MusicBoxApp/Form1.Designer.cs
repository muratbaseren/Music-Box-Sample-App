namespace MusicBoxApp
{
    partial class Form1
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
            this.cmbTurler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSarkicilar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAlbumler = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstSarkilar = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSarkiAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBesteci = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpCikisTar = new System.Windows.Forms.DateTimePicker();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnAlbumEkle = new System.Windows.Forms.Button();
            this.btnSarkiciEkle = new System.Windows.Forms.Button();
            this.btnTurEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbTurler
            // 
            this.cmbTurler.FormattingEnabled = true;
            this.cmbTurler.Location = new System.Drawing.Point(77, 17);
            this.cmbTurler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTurler.Name = "cmbTurler";
            this.cmbTurler.Size = new System.Drawing.Size(187, 26);
            this.cmbTurler.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tür :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbSarkicilar
            // 
            this.cmbSarkicilar.FormattingEnabled = true;
            this.cmbSarkicilar.Location = new System.Drawing.Point(77, 51);
            this.cmbSarkicilar.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSarkicilar.Name = "cmbSarkicilar";
            this.cmbSarkicilar.Size = new System.Drawing.Size(187, 26);
            this.cmbSarkicilar.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şarkıcı :";
            // 
            // cmbAlbumler
            // 
            this.cmbAlbumler.FormattingEnabled = true;
            this.cmbAlbumler.Location = new System.Drawing.Point(77, 85);
            this.cmbAlbumler.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAlbumler.Name = "cmbAlbumler";
            this.cmbAlbumler.Size = new System.Drawing.Size(187, 26);
            this.cmbAlbumler.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Albüm :";
            // 
            // lstSarkilar
            // 
            this.lstSarkilar.FormattingEnabled = true;
            this.lstSarkilar.ItemHeight = 18;
            this.lstSarkilar.Location = new System.Drawing.Point(77, 118);
            this.lstSarkilar.Name = "lstSarkilar";
            this.lstSarkilar.Size = new System.Drawing.Size(187, 166);
            this.lstSarkilar.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Şarkılar :";
            // 
            // txtSarkiAdi
            // 
            this.txtSarkiAdi.Location = new System.Drawing.Point(404, 17);
            this.txtSarkiAdi.Name = "txtSarkiAdi";
            this.txtSarkiAdi.Size = new System.Drawing.Size(222, 26);
            this.txtSarkiAdi.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Şarkı Adı :";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Beste :";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBesteci
            // 
            this.txtBesteci.Location = new System.Drawing.Point(404, 49);
            this.txtBesteci.Name = "txtBesteci";
            this.txtBesteci.Size = new System.Drawing.Size(222, 26);
            this.txtBesteci.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(330, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "S.Yazar :";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(404, 81);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(222, 26);
            this.txtYazar.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Çıkış T. :";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpCikisTar
            // 
            this.dtpCikisTar.Location = new System.Drawing.Point(404, 113);
            this.dtpCikisTar.Name = "dtpCikisTar";
            this.dtpCikisTar.Size = new System.Drawing.Size(222, 26);
            this.dtpCikisTar.TabIndex = 5;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Image = global::MusicBoxApp.Properties.Resources._1468409370_EditDocument;
            this.btnGuncelle.Location = new System.Drawing.Point(404, 145);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(97, 34);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Image = global::MusicBoxApp.Properties.Resources._1468409366_Add;
            this.btnEkle.Location = new System.Drawing.Point(529, 145);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(97, 34);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Image = global::MusicBoxApp.Properties.Resources._1468409373_Cancel;
            this.btnSil.Location = new System.Drawing.Point(270, 250);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(97, 34);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnAlbumEkle
            // 
            this.btnAlbumEkle.Image = global::MusicBoxApp.Properties.Resources._1468409366_Add;
            this.btnAlbumEkle.Location = new System.Drawing.Point(271, 85);
            this.btnAlbumEkle.Name = "btnAlbumEkle";
            this.btnAlbumEkle.Size = new System.Drawing.Size(39, 26);
            this.btnAlbumEkle.TabIndex = 2;
            this.btnAlbumEkle.UseVisualStyleBackColor = true;
            this.btnAlbumEkle.Click += new System.EventHandler(this.btnAlbumEkle_Click);
            // 
            // btnSarkiciEkle
            // 
            this.btnSarkiciEkle.Image = global::MusicBoxApp.Properties.Resources._1468409366_Add;
            this.btnSarkiciEkle.Location = new System.Drawing.Point(271, 51);
            this.btnSarkiciEkle.Name = "btnSarkiciEkle";
            this.btnSarkiciEkle.Size = new System.Drawing.Size(39, 26);
            this.btnSarkiciEkle.TabIndex = 2;
            this.btnSarkiciEkle.UseVisualStyleBackColor = true;
            this.btnSarkiciEkle.Click += new System.EventHandler(this.btnSarkiciEkle_Click);
            // 
            // btnTurEkle
            // 
            this.btnTurEkle.Image = global::MusicBoxApp.Properties.Resources._1468409366_Add;
            this.btnTurEkle.Location = new System.Drawing.Point(271, 17);
            this.btnTurEkle.Name = "btnTurEkle";
            this.btnTurEkle.Size = new System.Drawing.Size(39, 26);
            this.btnTurEkle.TabIndex = 2;
            this.btnTurEkle.UseVisualStyleBackColor = true;
            this.btnTurEkle.Click += new System.EventHandler(this.btnTurEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 292);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dtpCikisTar);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.txtBesteci);
            this.Controls.Add(this.txtSarkiAdi);
            this.Controls.Add(this.lstSarkilar);
            this.Controls.Add(this.btnAlbumEkle);
            this.Controls.Add(this.btnSarkiciEkle);
            this.Controls.Add(this.btnTurEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAlbumler);
            this.Controls.Add(this.cmbSarkicilar);
            this.Controls.Add(this.cmbTurler);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Box App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTurler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTurEkle;
        private System.Windows.Forms.ComboBox cmbSarkicilar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSarkiciEkle;
        private System.Windows.Forms.ComboBox cmbAlbumler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAlbumEkle;
        private System.Windows.Forms.ListBox lstSarkilar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSarkiAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBesteci;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpCikisTar;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
    }
}

