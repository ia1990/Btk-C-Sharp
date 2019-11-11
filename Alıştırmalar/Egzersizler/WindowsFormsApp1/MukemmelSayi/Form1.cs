using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MukemmelSayi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool Mukemmel(int say)
        {
            int toplam = 0;
            for (int i = 1; i < say; i++)
            {
                if (say % i == 0 )
                {
                    toplam += i;
                }
            }
            return toplam == say;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 1; i < 1001; i++)
            {
                if (Mukemmel(i))
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}
