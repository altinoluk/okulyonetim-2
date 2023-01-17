namespace OkulYonetim3
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ogrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girisToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ogrenciDersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girisToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(-2, 315);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(583, 27);
            this.textBox1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "000000000000";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::OkulYonetim3.Properties.Resources.icons8_management_64__1_;
            this.pictureBox1.Location = new System.Drawing.Point(521, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ogrenciToolStripMenuItem,
            this.personelToolStripMenuItem,
            this.dersToolStripMenuItem,
            this.ogrenciDersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(578, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ogrenciToolStripMenuItem
            // 
            this.ogrenciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girisToolStripMenuItem,
            this.listeToolStripMenuItem});
            this.ogrenciToolStripMenuItem.Name = "ogrenciToolStripMenuItem";
            this.ogrenciToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ogrenciToolStripMenuItem.Text = "Öğrenci";
            this.ogrenciToolStripMenuItem.MouseLeave += new System.EventHandler(this.ogrenciToolStripMenuItem_MouseLeave);
            this.ogrenciToolStripMenuItem.MouseHover += new System.EventHandler(this.ogrenciToolStripMenuItem_MouseHover);
            // 
            // girisToolStripMenuItem
            // 
            this.girisToolStripMenuItem.Name = "girisToolStripMenuItem";
            this.girisToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.girisToolStripMenuItem.Text = "Giriş";
            this.girisToolStripMenuItem.Click += new System.EventHandler(this.girisToolStripMenuItem_Click);
            // 
            // listeToolStripMenuItem
            // 
            this.listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            this.listeToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.listeToolStripMenuItem.Text = "Liste";
            this.listeToolStripMenuItem.Click += new System.EventHandler(this.listeToolStripMenuItem_Click);
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girisToolStripMenuItem1,
            this.listeToolStripMenuItem1});
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.personelToolStripMenuItem.Text = "Personel";
            this.personelToolStripMenuItem.MouseLeave += new System.EventHandler(this.personelToolStripMenuItem_MouseLeave);
            this.personelToolStripMenuItem.MouseHover += new System.EventHandler(this.personelToolStripMenuItem_MouseHover);
            // 
            // girisToolStripMenuItem1
            // 
            this.girisToolStripMenuItem1.Name = "girisToolStripMenuItem1";
            this.girisToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.girisToolStripMenuItem1.Text = "Giriş";
            this.girisToolStripMenuItem1.Click += new System.EventHandler(this.girisToolStripMenuItem1_Click);
            // 
            // listeToolStripMenuItem1
            // 
            this.listeToolStripMenuItem1.Name = "listeToolStripMenuItem1";
            this.listeToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.listeToolStripMenuItem1.Text = "Liste";
            this.listeToolStripMenuItem1.Click += new System.EventHandler(this.listeToolStripMenuItem1_Click);
            // 
            // dersToolStripMenuItem
            // 
            this.dersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girisToolStripMenuItem2,
            this.listeToolStripMenuItem2});
            this.dersToolStripMenuItem.Name = "dersToolStripMenuItem";
            this.dersToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.dersToolStripMenuItem.Text = "Ders";
            this.dersToolStripMenuItem.Click += new System.EventHandler(this.dersToolStripMenuItem_Click);
            this.dersToolStripMenuItem.MouseLeave += new System.EventHandler(this.dersToolStripMenuItem_MouseLeave);
            this.dersToolStripMenuItem.MouseHover += new System.EventHandler(this.dersToolStripMenuItem_MouseHover);
            // 
            // girisToolStripMenuItem2
            // 
            this.girisToolStripMenuItem2.Name = "girisToolStripMenuItem2";
            this.girisToolStripMenuItem2.Size = new System.Drawing.Size(98, 22);
            this.girisToolStripMenuItem2.Text = "Giriş";
            this.girisToolStripMenuItem2.Click += new System.EventHandler(this.girisToolStripMenuItem2_Click);
            // 
            // listeToolStripMenuItem2
            // 
            this.listeToolStripMenuItem2.Name = "listeToolStripMenuItem2";
            this.listeToolStripMenuItem2.Size = new System.Drawing.Size(98, 22);
            this.listeToolStripMenuItem2.Text = "Liste";
            this.listeToolStripMenuItem2.Click += new System.EventHandler(this.listeToolStripMenuItem2_Click);
            // 
            // ogrenciDersToolStripMenuItem
            // 
            this.ogrenciDersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girisToolStripMenuItem3,
            this.listeToolStripMenuItem3});
            this.ogrenciDersToolStripMenuItem.Name = "ogrenciDersToolStripMenuItem";
            this.ogrenciDersToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.ogrenciDersToolStripMenuItem.Text = "Öğrenci Ders";
            this.ogrenciDersToolStripMenuItem.MouseLeave += new System.EventHandler(this.ogrenciDersToolStripMenuItem_MouseLeave);
            this.ogrenciDersToolStripMenuItem.MouseHover += new System.EventHandler(this.ogrenciDersToolStripMenuItem_MouseHover);
            // 
            // girisToolStripMenuItem3
            // 
            this.girisToolStripMenuItem3.Name = "girisToolStripMenuItem3";
            this.girisToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.girisToolStripMenuItem3.Text = "Giriş";
            this.girisToolStripMenuItem3.Click += new System.EventHandler(this.girisToolStripMenuItem3_Click);
            // 
            // listeToolStripMenuItem3
            // 
            this.listeToolStripMenuItem3.Name = "listeToolStripMenuItem3";
            this.listeToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.listeToolStripMenuItem3.Text = "Liste";
            this.listeToolStripMenuItem3.Click += new System.EventHandler(this.listeToolStripMenuItem3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::OkulYonetim3.Properties.Resources.blue_abstract_gradient_wave_vector_background_53876_111548;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(578, 340);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ogrenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girisToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girisToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ogrenciDersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girisToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem3;
    }
}

