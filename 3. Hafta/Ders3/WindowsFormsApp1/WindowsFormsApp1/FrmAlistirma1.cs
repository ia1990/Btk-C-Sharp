using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmAlistirma1 : Form
    {
        public FrmAlistirma1()
        {
            InitializeComponent();
        }

        bool status = true;
        private void button1_Click(object sender, EventArgs e)
        {
            if (status)
            {
                label1.Text += textBox1.Text + "\n";
            }
            else
            {
                label2.Text += textBox1.Text + "\n";
            }

            status = !status;
            textBox1.Clear();
            textBox1.Focus();
            
        }
    }
}
