﻿namespace KisiDefteriOnline6
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            btnEkle = new Button();
            lstKisiler = new ListBox();
            btnDuzenle = new Button();
            btnSil = new Button();
            btnYukari = new Button();
            btnAsagi = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 9);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 0;
            label2.Text = "Soyad";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(12, 27);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(118, 27);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 23);
            txtSoyad.TabIndex = 1;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(224, 27);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // lstKisiler
            // 
            lstKisiler.DisplayMember = "TamAd";
            lstKisiler.FormattingEnabled = true;
            lstKisiler.ItemHeight = 15;
            lstKisiler.Location = new Point(12, 56);
            lstKisiler.Name = "lstKisiler";
            lstKisiler.Size = new Size(287, 259);
            lstKisiler.TabIndex = 3;
            lstKisiler.KeyDown += lstKisiler_KeyDown;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Location = new Point(12, 321);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(75, 23);
            btnDuzenle.TabIndex = 4;
            btnDuzenle.Text = "DÜZENLE";
            btnDuzenle.UseVisualStyleBackColor = true;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(93, 321);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 5;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnYukari
            // 
            btnYukari.BackgroundImage = (Image)resources.GetObject("btnYukari.BackgroundImage");
            btnYukari.BackgroundImageLayout = ImageLayout.Zoom;
            btnYukari.Location = new Point(305, 145);
            btnYukari.Name = "btnYukari";
            btnYukari.Size = new Size(32, 32);
            btnYukari.TabIndex = 6;
            btnYukari.UseVisualStyleBackColor = true;
            btnYukari.Click += btnYukari_Click;
            // 
            // btnAsagi
            // 
            btnAsagi.BackgroundImage = (Image)resources.GetObject("btnAsagi.BackgroundImage");
            btnAsagi.BackgroundImageLayout = ImageLayout.Zoom;
            btnAsagi.Location = new Point(305, 183);
            btnAsagi.Name = "btnAsagi";
            btnAsagi.Size = new Size(32, 32);
            btnAsagi.TabIndex = 7;
            btnAsagi.UseVisualStyleBackColor = true;
            btnAsagi.Click += btnAsagi_Click;
            // 
            // Form1
            // 
            AcceptButton = btnEkle;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 355);
            Controls.Add(btnAsagi);
            Controls.Add(btnYukari);
            Controls.Add(btnSil);
            Controls.Add(btnDuzenle);
            Controls.Add(lstKisiler);
            Controls.Add(btnEkle);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kişi Defteri";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private Button btnEkle;
        private ListBox lstKisiler;
        private Button btnDuzenle;
        private Button btnSil;
        private Button btnYukari;
        private Button btnAsagi;
    }
}