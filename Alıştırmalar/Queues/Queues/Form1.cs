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

namespace Queues
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddItem(ListBox listBox)
        {
            int waitingTime = 0;
            ArrayList arrayList = new ArrayList();

            if (rbPriority1.Checked)
            {
                arrayList.AddRange(listPriority1.Items);
            }
            else if (rbPriority2.Checked)
            {
                arrayList.AddRange(listPriority1.Items);
                arrayList.AddRange(listPriority2.Items);
            }
            else
            {
                arrayList.AddRange(listPriority1.Items);
                arrayList.AddRange(listPriority2.Items);
                arrayList.AddRange(listPriority3.Items);
            }

            foreach (var item in arrayList)
            {
                waitingTime += Convert.ToInt32(item.ToString().Split('-')[1].Trim());
            }

            if (waitingTime == 0)
            {
                string itemVal = txtName.Text + " - " + numProcessTime.Value.ToString() + " - 0";
                listBox.Items.Add(itemVal);
            }
            else
            {
                string itemVal = txtName.Text + " - " + numProcessTime.Value.ToString() + " - " + waitingTime;
                listBox.Items.Add(itemVal);
            }

            int itemCount = listPriority1.Items.Count + listPriority2.Items.Count + listPriority3.Items.Count;
            lblQueue.Text = "Queue Size = " + itemCount;
        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("Lütfen bir isim giriniş. İşlem başarısız oldu!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int itemCount = listPriority1.Items.Count + listPriority2.Items.Count + listPriority3.Items.Count;
            lblQueue.Text = "Queue Size = " + itemCount;

            if (itemCount < numMaxSize.Value)
            {
                if (rbPriority1.Checked)
                    AddItem(listPriority1);
                else if (rbPriority2.Checked)
                    AddItem(listPriority2);
                else
                    AddItem(listPriority3);
            }
            else
            {
                MessageBox.Show("Kuyruk Belirlenen Maximum Uzunluğa Ulaşmıştır.Yeni Eleman Eklenemez.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            if (listPriority1.Items.Count > 0)
                listPriority1.Items.RemoveAt(0);
            else if (listPriority2.Items.Count > 0)
                listPriority2.Items.RemoveAt(0);
            else if (listPriority3.Items.Count > 0)
                listPriority3.Items.RemoveAt(0);
            else
            {
                MessageBox.Show("Kuyrukta eleman bulunmuyor!", "UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
