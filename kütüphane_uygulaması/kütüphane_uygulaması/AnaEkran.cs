using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphane_uygulaması
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapEklemeEkranı kitapEklemeEkranı = new KitapEklemeEkranı(this);
            kitapEklemeEkranı.Show();
            this.Hide();
        }
  
        public void kitapEkle(string kitapAdı)
        {
            listBox1.Items.Add(kitapAdı);
            button1.Visible = true;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Silmek istiyor musunuz?", "Sil", MessageBoxButtons.YesNo);
            if (soru == DialogResult.Yes)
            {
                int secilen = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(secilen);

                if (listBox1.Items.Count == 0)
                {
                    button1.Visible = false;
                    button2.Visible = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilen = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(secilen);
            KitapEklemeEkranı kitapEklemeEkranı = new KitapEklemeEkranı(this);
            kitapEklemeEkranı.Show();
            this.Hide();
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            button1.Visible = false; 
            button2.Visible = false;
        }
    }
}
