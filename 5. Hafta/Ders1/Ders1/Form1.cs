using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            txtTc.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            cbCity.Text = "";
            cbDepartment.Text = "";
        }

        bool TcKimlikKontrol(string tc)
        {
            bool dogrumu = true;
            if (tc.Length == 11)
            {
                int hanelertoplam = 0;
                for (int i = 0; i < 10; i++)
                {
                    hanelertoplam += Convert.ToInt32(tc[i].ToString());
                }
                int birlerbasamagi = hanelertoplam % 10;
                int sonhane = Convert.ToInt32(tc[10].ToString());
                if (birlerbasamagi != sonhane)
                {
                    dogrumu = false;
                }
            }
            else
            {
                dogrumu = false;
            }
            return dogrumu;
        }

        /// <summary>
        /// Form doldurulurken zorunlu alan kontrolü
        /// </summary>
        /// <returns>Eğer listenin eleman sayısı</returns>
        private List<string> AnyMissingEntries()
        {
            List<string> messages = new List<string>();
            if (!TcKimlikKontrol(txtTc.Text))
            {
                messages.Add("Hatalı Tc girişi!");
            }
            if (string.IsNullOrEmpty(txtTc.Text))
            {
                messages.Add("Tc alanı boş bırakılamaz!");

            }

            if (string.IsNullOrEmpty(txtName.Text))
            {
                messages.Add("İsim alanı boş bırakılamaz!");
            }

            if (string.IsNullOrEmpty(txtSurname.Text))
            {
                messages.Add("Sayad alanı boş bırakılamaz!");
            }

            if (string.IsNullOrEmpty(cbCity.Text))
            {
                messages.Add("Şehir alanı boş bırakılamaz!");
            }

            if (string.IsNullOrEmpty(cbDepartment.Text))
            {
                messages.Add("Bölüm alanı boş bırakılamaz!");
            }
            return messages;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void LoadStudent()
        {
            StudentAdap studentAdap = new StudentAdap();
            dgStudents.DataSource = studentAdap.GetAll();
            dgStudents.Columns[0].Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //gerekli alanlar ve dogru bir tc girilmişmi kontrolü
            if (AnyMissingEntries().Count > 0)
            {
                string message = String.Join(",", AnyMissingEntries());
                MessageBox.Show(message, "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StudentDto student = new StudentDto();
            StudentAdap studentAdap = new StudentAdap();

            student.Tc = txtTc.Text;
            student.Name = txtName.Text;
            student.Surname = txtSurname.Text;

            student.Bolum = cbDepartment.Text;
            student.City = cbCity.Text;
            int i = studentAdap.Add(student);
            if (i > 0)
            {
                MessageBox.Show("Kayıt başarı ile eklendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStudent();
            }
            else if (i == -1)
            {
                MessageBox.Show("Bu Tc daha önce eklenmiş!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("İşlem başarısız oldu!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ////zorunlu alanlar ve dogru bir tc girilmişmi kontrolü
            if (AnyMissingEntries().Count > 0)
            {
                string message = String.Join(",", AnyMissingEntries());
                MessageBox.Show(message, "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StudentDto student = new StudentDto();
            StudentAdap studentAdap = new StudentAdap();

            //eğer DataGridView 'den herhangi bir kayıt seçilmeden Update butonuna basıldığında
            //programın kırılmasını engelleyip, kullanıcıyı uyarmak için try - catch kullandık.
            try
            {
                student.Id = Convert.ToInt32(dgStudents.CurrentRow.Cells[0].Value);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz kaydı seçiniz!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            student.Id = Convert.ToInt32(dgStudents.CurrentRow.Cells[0].Value);
            student.Tc = txtTc.Text;
            student.Name = txtName.Text;
            student.Surname = txtSurname.Text;
            student.Bolum = cbDepartment.Text;
            student.City = cbCity.Text;

            int i = studentAdap.Update(student);
            if (i > 0)
            {
                MessageBox.Show("Kayıt başarıyle güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStudent();
            }
            else
            {
                MessageBox.Show("İşlem başarısız olmuştur!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = 0;
            //eğer DataGridView 'den herhangi bir kayıt seçilmeden Sil butonuna basıldığında
            //programın kırılmasını engelleyip, kullanıcıyı uyarmak için try - catch kullandık.
            try
            {
                 id = Convert.ToInt32(dgStudents.CurrentRow.Cells[0].Value);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Lütfen silmek istediğiniz kaydı seçiniz!!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            
            StudentAdap studentAdap = new StudentAdap();
            int i = studentAdap.Delete(id);
            if (i > 0)
            {
                MessageBox.Show("İşlem başarılı olmuştur.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStudent();
            }
            else
            {
                MessageBox.Show("Kayıt silinememiştir!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTc.Text = dgStudents.CurrentRow.Cells[1].Value.ToString();
            txtName.Text = dgStudents.CurrentRow.Cells[2].Value.ToString();
            txtSurname.Text = dgStudents.CurrentRow.Cells[3].Value.ToString();
            cbDepartment.Text = dgStudents.CurrentRow.Cells[4].Value.ToString();
            cbCity.Text = dgStudents.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
