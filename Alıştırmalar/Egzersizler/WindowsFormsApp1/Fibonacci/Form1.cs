using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            uint elemansayisi = (uint)numericUpDown1.Value;
            uint[] sayilar = new uint[elemansayisi];
            sayilar[0] = 1;
            sayilar[1] = 1;
            uint toplam = 2;
            listBox1.Items.Add(sayilar[0]);
            listBox1.Items.Add(sayilar[1]);
            for (uint i = 2; i < elemansayisi; i++)
            {
                sayilar[i] = sayilar[i - 1] + sayilar[i - 2];
                toplam += sayilar[i];
                listBox1.Items.Add(sayilar[i]);
            }

            lblCountOfList.Text = listBox1.Items.Count.ToString();
        }
    }
}
