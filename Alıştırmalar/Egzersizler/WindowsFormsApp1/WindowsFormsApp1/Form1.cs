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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            
        }
        private void btnIsPirime_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(txtNumber.Text);
            bool result =  IsPrime(number);
            if (result)
            {
                MessageBox.Show(String.Format("{0} bir asal sayıdır.",txtNumber.Text), "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(String.Format("{0} bir asal sayı değildir!", txtNumber.Text),"Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 2; i <= 100; i++)
            {
                if (IsPrime(i))
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}
