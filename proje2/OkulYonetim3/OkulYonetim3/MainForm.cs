using System;
using System.Windows.Forms;

namespace OkulYonetim3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = "OKUL YÖNETİM SİSTEMİ              " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");

            if (label2.Left > -250)
            {
                label2.Left -= 1;
            }
            else
            {
                label2.Left = 750;
            }
        }

        private void ogrenciToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            ogrenciToolStripMenuItem.ShowDropDown();
        }

        private void ogrenciToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void personelToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            personelToolStripMenuItem.ShowDropDown();
        }

        private void personelToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void dersToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            dersToolStripMenuItem.ShowDropDown();
        }

        private void dersToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void ogrenciDersToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            ogrenciDersToolStripMenuItem.ShowDropDown();
        }

        private void ogrenciDersToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void girisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciGiris form = new OgrenciGiris();
            form.Show();
        }

        private void girisToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DersGiris form = new DersGiris();
            form.Show();
        }

        private void dersToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void listeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DersListe form = new DersListe();
            form.Show();
        }

        private void listeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PersonelListe form = new PersonelListe();
            form.Show();
        }

        private void girisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PersonelGiris form = new PersonelGiris();
            form.Show();
        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciListe form = new OgrenciListe();
            form.Show();
        }

        private void girisToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            OgrenciDersGiris form = new OgrenciDersGiris();
            form.Show();
        }

        private void listeToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            OgrenciDersListe form = new OgrenciDersListe();
            form.Show();
        }
    }
}
