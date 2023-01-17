namespace OkulYonetim3
{
    partial class DersGiris
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKredi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbRenk = new System.Windows.Forms.ComboBox();
            this.cmbOgretmen = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAd.Location = new System.Drawing.Point(104, 32);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(121, 23);
            this.txtAd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(73, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(57, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kredi";
            // 
            // txtKredi
            // 
            this.txtKredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtKredi.Location = new System.Drawing.Point(104, 75);
            this.txtKredi.Name = "txtKredi";
            this.txtKredi.Size = new System.Drawing.Size(121, 23);
            this.txtKredi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(57, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Renk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(27, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Öğretmen";
            // 
            // cmbRenk
            // 
            this.cmbRenk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbRenk.FormattingEnabled = true;
            this.cmbRenk.Items.AddRange(new object[] {
            "sd"});
            this.cmbRenk.Location = new System.Drawing.Point(104, 117);
            this.cmbRenk.Name = "cmbRenk";
            this.cmbRenk.Size = new System.Drawing.Size(121, 24);
            this.cmbRenk.TabIndex = 8;
            // 
            // cmbOgretmen
            // 
            this.cmbOgretmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbOgretmen.FormattingEnabled = true;
            this.cmbOgretmen.Items.AddRange(new object[] {
            "a"});
            this.cmbOgretmen.Location = new System.Drawing.Point(104, 158);
            this.cmbOgretmen.Name = "cmbOgretmen";
            this.cmbOgretmen.Size = new System.Drawing.Size(121, 24);
            this.cmbOgretmen.TabIndex = 9;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.PowderBlue;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(116, 237);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(121, 38);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtKredi);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.cmbOgretmen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbRenk);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 205);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgiler";
            // 
            // DersGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OkulYonetim3.Properties.Resources.blue_abstract_gradient_wave_vector_background_53876_111548;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(294, 287);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKaydet);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "DersGiris";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ders Giriş";
            this.Load += new System.EventHandler(this.DersGiris_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKredi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbRenk;
        private System.Windows.Forms.ComboBox cmbOgretmen;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}