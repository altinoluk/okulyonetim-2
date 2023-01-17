namespace OkulYonetim3
{
    partial class DersGuncelle
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
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.txtKredi = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.txtRenk);
            this.groupBox1.Controls.Add(this.txtKredi);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 293);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgiler";
            // 
            // txtRenk
            // 
            this.txtRenk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtRenk.Location = new System.Drawing.Point(101, 173);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(172, 23);
            this.txtRenk.TabIndex = 10;
            // 
            // txtKredi
            // 
            this.txtKredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtKredi.Location = new System.Drawing.Point(101, 131);
            this.txtKredi.Name = "txtKredi";
            this.txtKredi.Size = new System.Drawing.Size(172, 23);
            this.txtKredi.TabIndex = 2;
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
            this.label1.Location = new System.Drawing.Point(70, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(54, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kredi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(54, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Renk";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.PowderBlue;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Location = new System.Drawing.Point(113, 311);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(172, 38);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // DersGuncelle
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
            this.Name = "DersGuncelle";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ders Güncelle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DersGuncelle_FormClosed);
            this.Load += new System.EventHandler(this.DersGuncelle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.TextBox txtKredi;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuncelle;
    }
}