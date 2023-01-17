namespace OkulYonetim3
{
    partial class OgrenciDersGiris
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cmbDers = new System.Windows.Forms.ComboBox();
            this.cmbOgrenci = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbOgrenci);
            this.groupBox1.Controls.Add(this.cmbDers);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 205);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgiler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(24, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Öğrenci";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(44, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ders";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.PowderBlue;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(111, 235);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(121, 38);
            this.btnKaydet.TabIndex = 16;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmbDers
            // 
            this.cmbDers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDers.FormattingEnabled = true;
            this.cmbDers.Location = new System.Drawing.Point(99, 65);
            this.cmbDers.Name = "cmbDers";
            this.cmbDers.Size = new System.Drawing.Size(121, 24);
            this.cmbDers.TabIndex = 4;
            // 
            // cmbOgrenci
            // 
            this.cmbOgrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOgrenci.FormattingEnabled = true;
            this.cmbOgrenci.Location = new System.Drawing.Point(99, 108);
            this.cmbOgrenci.Name = "cmbOgrenci";
            this.cmbOgrenci.Size = new System.Drawing.Size(121, 24);
            this.cmbOgrenci.TabIndex = 5;
            // 
            // OgrenciDersGiris
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
            this.Name = "OgrenciDersGiris";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Ders Giriş";
            this.Load += new System.EventHandler(this.OgrenciDersGiris_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cmbOgrenci;
        private System.Windows.Forms.ComboBox cmbDers;
    }
}