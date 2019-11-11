namespace EnBuyukEnKucuk
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEnBuyuk = new System.Windows.Forms.Button();
            this.btnEnKucuk = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGoruntule = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnBuyuk
            // 
            this.btnEnBuyuk.Location = new System.Drawing.Point(37, 157);
            this.btnEnBuyuk.Name = "btnEnBuyuk";
            this.btnEnBuyuk.Size = new System.Drawing.Size(100, 23);
            this.btnEnBuyuk.TabIndex = 11;
            this.btnEnBuyuk.Text = "E n Büyük";
            this.btnEnBuyuk.UseVisualStyleBackColor = true;
            this.btnEnBuyuk.Click += new System.EventHandler(this.btnEnBuyuk_Click);
            // 
            // btnEnKucuk
            // 
            this.btnEnKucuk.Location = new System.Drawing.Point(37, 128);
            this.btnEnKucuk.Name = "btnEnKucuk";
            this.btnEnKucuk.Size = new System.Drawing.Size(100, 23);
            this.btnEnKucuk.TabIndex = 10;
            this.btnEnKucuk.Text = "En Küçük";
            this.btnEnKucuk.UseVisualStyleBackColor = true;
            this.btnEnKucuk.Click += new System.EventHandler(this.btnEnKucuk_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(153, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(117, 147);
            this.listBox1.TabIndex = 8;
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(67, 34);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(70, 20);
            this.txtSayi.TabIndex = 7;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(37, 67);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.Location = new System.Drawing.Point(37, 97);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(100, 23);
            this.btnGoruntule.TabIndex = 9;
            this.btnGoruntule.Text = "Görüntüle";
            this.btnGoruntule.UseVisualStyleBackColor = true;
            this.btnGoruntule.Click += new System.EventHandler(this.btnGoruntule_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sayı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 218);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnBuyuk);
            this.Controls.Add(this.btnEnKucuk);
            this.Controls.Add(this.btnGoruntule);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnBuyuk;
        private System.Windows.Forms.Button btnEnKucuk;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGoruntule;
        private System.Windows.Forms.Label label1;
    }
}

