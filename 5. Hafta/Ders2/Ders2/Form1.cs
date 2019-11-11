using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders2
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
            string[] liste = textBox1.Text.Split('-');
            foreach (var item in liste)
            {
                listBox1.Items.Add(item.Trim());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text.Trim();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text.Replace(' ', '-');
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox4.Text.Substring(3, 3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //IndexOf metodu bir string içerisinde kendisine parametre olarak verilen bir ifade veya karakteri arar.
            //Eğer IndexOf metodu aradığını bulamazsa -1, aranan ifadenin bulunduğu index numarasını döner.
            int indexNum = textBox5.Text.IndexOf(textBox6.Text.Trim());
            if( indexNum > 0)
            {
                MessageBox.Show(indexNum.ToString());
            }
            else
            {
                MessageBox.Show("Aranılan kelime bulunamadı.");
            }


        }
    }
}
