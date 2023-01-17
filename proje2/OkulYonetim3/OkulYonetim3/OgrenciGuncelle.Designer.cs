namespace OkulYonetim3
{
    partial class OgrenciGuncelle
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
            this.txtBolum = new System.Windows.Forms.TextBox();
            this.txtOgrenciNo = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtBolum);
            this.groupBox1.Controls.Add(this.txtOgrenciNo);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(16, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 293);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgiler";
            // 
            // txtBolum
            // 
            this.txtBolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBolum.Location = new System.Drawing.Point(101, 172);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Size = new System.Drawing.Size(172, 23);
            this.txtBolum.TabIndex = 6;
            // 
            // txtOgrenciNo
            // 
            this.txtOgrenciNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtOgrenciNo.Location = new System.Drawing.Point(101, 131);
            this.txtOgrenciNo.Name = "txtOgrenciNo";
            this.txtOgrenciNo.Size = new System.Drawing.Size(172, 23);
            this.txtOgrenciNo.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAd.Location = new System.Drawing.Point(101, 88);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(172, 23);
            this.txtAd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(26, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(15, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Öğrenci No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(48, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bölüm";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.PowderBlue;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Location = new System.Drawing.Point(117, 327);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(172, 38);
            this.btnGuncelle.TabIndex = 16;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // OgrenciGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OkulYonetim3.Properties.Resources.blue_abstract_gradient_wave_vector_background_53876_111548;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(393, 392);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuncelle);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "OgrenciGuncelle";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Güncelle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OgrenciGuncelle_FormClosed);
            this.Load += new System.EventHandler(this.OgrenciGuncelle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOgrenciNo;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtBolum;
    }
}