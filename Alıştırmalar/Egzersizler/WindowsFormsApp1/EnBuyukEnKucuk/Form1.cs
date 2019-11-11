using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnBuyukEnKucuk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> sayilar = new List<int>();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            sayilar.Add(Convert.ToInt32(txtSayi.Text));
            txtSayi.Clear();
            txtSayi.Focus();
        }


        private void btnEnKucuk_Click(object sender, EventArgs e)
        {
            int enkucuk = sayilar[0];
            foreach (int eleman in sayilar)
            {
                if (eleman < enkucuk)
                    enkucuk = eleman;
            }
            MessageBox.Show(enkucuk.ToString());
        }

        private void btnEnBuyuk_Click(object sender, EventArgs e)
        {
            int enkucuk = sayilar[0];
            foreach (int eleman in sayilar)
            {
                if (eleman > enkucuk)
                    enkucuk = eleman;
            }
            MessageBox.Show(enkucuk.ToString());
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (int eleman in sayilar)
                listBox1.Items.Add(eleman);
        }
    }
}
