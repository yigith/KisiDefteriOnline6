namespace KisiDefteriOnline6
{
    partial class DuzenleForm
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
            btnKaydet = new Button();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnIptal = new Button();
            SuspendLayout();
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(25, 145);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 7;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(25, 99);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(156, 23);
            txtSoyad.TabIndex = 6;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(25, 44);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(156, 23);
            txtAd.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 81);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 26);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 5;
            label1.Text = "Ad";
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(106, 145);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(75, 23);
            btnIptal.TabIndex = 8;
            btnIptal.Text = "İPTAL";
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Click += btnIptal_Click;
            // 
            // DuzenleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(218, 206);
            Controls.Add(btnIptal);
            Controls.Add(btnKaydet);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DuzenleForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Düzenle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKaydet;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label2;
        private Label label1;
        private Button btnIptal;
    }
}