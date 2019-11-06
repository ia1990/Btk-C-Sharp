using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArrayList_Click(object sender, EventArgs e)
        {
            ArrayList liste = new ArrayList();
            liste.Add("İsmail");
            liste.Add(25);
            liste.Add(2.3);
            listBox1.Items.Clear();
            //MessageBox.Show(liste.IndexOf(2.3).ToString());

            liste.Remove("İsmail");
            foreach (var item in liste)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<string> liste = new List<string>();
            listBox1.Items.Clear();
            liste.Add("5");
            liste.Add("Btk");
            liste.Add("Sami");
            //liste.Remove("5");
            //liste.RemoveAt(1);
            liste.Reverse();
            foreach (var item in liste)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
