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

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(this.Text +  " yükleniyor.");
            //cbCity.Items.Clear();
            cbCity.Items.Add("ÇORUM");
            cbCity.Items.Add("DÜZCE");
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //DialogResult val = MessageBox.Show("Programdan çıkmak istediğinizden emin misiniz?", "Program Kapat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (val == DialogResult.Yes)
            //{
            //    this.Close();
            //}

            //MessageBox.Show(cbCity.Text);

            //cbCity.Items.Remove("ANKARA");
            //cbCity.Items.RemoveAt(0);

            if (checkBox1.Checked)
            {
                MessageBox.Show("Futbol..");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Hide();
            //this.Close();
            frm.Show();
            //frm.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string tc = txtTc.Text;
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string cinsiyet; //1 erkek, 2 kız
            string city = cbCity.Text;

            //ArrayList sınıfı eleman sayısı belirtmeden dizi tanımlamak için kullanılır.
            //Bu sınıfı kullanabilmek için ilk olarak System.Collections sınıfını using anahtar
            //kelimesiyle projemize ekekliyoruz.
            ArrayList hobbies = new ArrayList();
            if (radioButton1.Checked)
            {
                cinsiyet = "Erkek";
            }
            else
            {
                cinsiyet = "Kız";
            }

            if (checkBox1.Checked)
            {
                hobbies.Add("Futbol");
            }
            if (checkBox2.Checked)
            {
                hobbies.Add("Yüzme");
            }

            string info = "Tc: " + tc + ", Ad : " + name + ", Soyad : " + surname + ", Cinsiyet : " + cinsiyet + ", Şehir : " + city + ", Hobbies : " ;

            foreach (var hobby in hobbies)
            {
                info += hobby + " "; 
            }

            MessageBox.Show(info, "Bilgiler",MessageBoxButtons.OK,MessageBoxIcon.Information);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            MessageBox.Show(openFileDialog1.FileName);
            Image img = Image.FromFile(openFileDialog1.FileName);

            pictureBox1.Image = img;
        }

        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmAlistirma1 frm = new FrmAlistirma1();
            frm.ShowDialog();
        }
    }
}
