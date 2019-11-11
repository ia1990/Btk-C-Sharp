namespace Queues
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
            this.rbPriority3 = new System.Windows.Forms.RadioButton();
            this.rbPriority2 = new System.Windows.Forms.RadioButton();
            this.listPriority3 = new System.Windows.Forms.ListBox();
            this.listPriority2 = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rbPriority1 = new System.Windows.Forms.RadioButton();
            this.numMaxSize = new System.Windows.Forms.NumericUpDown();
            this.btnDequeue = new System.Windows.Forms.Button();
            this.btnEnqueue = new System.Windows.Forms.Button();
            this.numProcessTime = new System.Windows.Forms.NumericUpDown();
            this.txtDequeue = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.listPriority1 = new System.Windows.Forms.ListBox();
            this.labe_maxsize = new System.Windows.Forms.Label();
            this.lblQueue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProcessTime)).BeginInit();
            this.SuspendLayout();
            // 
            // rbPriority3
            // 
            this.rbPriority3.AutoSize = true;
            this.rbPriority3.Location = new System.Drawing.Point(651, 146);
            this.rbPriority3.Margin = new System.Windows.Forms.Padding(2);
            this.rbPriority3.Name = "rbPriority3";
            this.rbPriority3.Size = new System.Drawing.Size(31, 17);
            this.rbPriority3.TabIndex = 48;
            this.rbPriority3.Text = "3";
            this.rbPriority3.UseVisualStyleBackColor = true;
            // 
            // rbPriority2
            // 
            this.rbPriority2.AutoSize = true;
            this.rbPriority2.Location = new System.Drawing.Point(617, 147);
            this.rbPriority2.Margin = new System.Windows.Forms.Padding(2);
            this.rbPriority2.Name = "rbPriority2";
            this.rbPriority2.Size = new System.Drawing.Size(31, 17);
            this.rbPriority2.TabIndex = 47;
            this.rbPriority2.Text = "2";
            this.rbPriority2.UseVisualStyleBackColor = true;
            // 
            // listPriority3
            // 
            this.listPriority3.FormattingEnabled = true;
            this.listPriority3.Location = new System.Drawing.Point(402, 98);
            this.listPriority3.Margin = new System.Windows.Forms.Padding(2);
            this.listPriority3.Name = "listPriority3";
            this.listPriority3.Size = new System.Drawing.Size(163, 277);
            this.listPriority3.TabIndex = 46;
            // 
            // listPriority2
            // 
            this.listPriority2.FormattingEnabled = true;
            this.listPriority2.Location = new System.Drawing.Point(223, 98);
            this.listPriority2.Margin = new System.Windows.Forms.Padding(2);
            this.listPriority2.Name = "listPriority2";
            this.listPriority2.Size = new System.Drawing.Size(163, 277);
            this.listPriority2.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(423, 61);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 17);
            this.label11.TabIndex = 44;
            this.label11.Text = "3.İşlem - 3.Öncelik";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(256, 61);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 17);
            this.label10.TabIndex = 43;
            this.label10.Text = "2.İşlem - 2.Öncelik";
            // 
            // rbPriority1
            // 
            this.rbPriority1.AutoSize = true;
            this.rbPriority1.Checked = true;
            this.rbPriority1.Location = new System.Drawing.Point(585, 147);
            this.rbPriority1.Margin = new System.Windows.Forms.Padding(2);
            this.rbPriority1.Name = "rbPriority1";
            this.rbPriority1.Size = new System.Drawing.Size(31, 17);
            this.rbPriority1.TabIndex = 42;
            this.rbPriority1.TabStop = true;
            this.rbPriority1.Text = "1";
            this.rbPriority1.UseVisualStyleBackColor = true;
            // 
            // numMaxSize
            // 
            this.numMaxSize.Location = new System.Drawing.Point(627, 325);
            this.numMaxSize.Margin = new System.Windows.Forms.Padding(2);
            this.numMaxSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxSize.Name = "numMaxSize";
            this.numMaxSize.Size = new System.Drawing.Size(34, 20);
            this.numMaxSize.TabIndex = 41;
            this.numMaxSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnDequeue
            // 
            this.btnDequeue.Location = new System.Drawing.Point(575, 263);
            this.btnDequeue.Margin = new System.Windows.Forms.Padding(2);
            this.btnDequeue.Name = "btnDequeue";
            this.btnDequeue.Size = new System.Drawing.Size(105, 20);
            this.btnDequeue.TabIndex = 40;
            this.btnDequeue.Text = "Dequeue";
            this.btnDequeue.UseVisualStyleBackColor = true;
            this.btnDequeue.Click += new System.EventHandler(this.btnDequeue_Click);
            // 
            // btnEnqueue
            // 
            this.btnEnqueue.Location = new System.Drawing.Point(576, 169);
            this.btnEnqueue.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnqueue.Name = "btnEnqueue";
            this.btnEnqueue.Size = new System.Drawing.Size(104, 21);
            this.btnEnqueue.TabIndex = 39;
            this.btnEnqueue.Text = "Enqueue";
            this.btnEnqueue.UseVisualStyleBackColor = true;
            this.btnEnqueue.Click += new System.EventHandler(this.btnEnqueue_Click);
            // 
            // numProcessTime
            // 
            this.numProcessTime.Location = new System.Drawing.Point(647, 118);
            this.numProcessTime.Margin = new System.Windows.Forms.Padding(2);
            this.numProcessTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numProcessTime.Name = "numProcessTime";
            this.numProcessTime.Size = new System.Drawing.Size(34, 20);
            this.numProcessTime.TabIndex = 38;
            this.numProcessTime.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // txtDequeue
            // 
            this.txtDequeue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDequeue.Enabled = false;
            this.txtDequeue.Location = new System.Drawing.Point(575, 239);
            this.txtDequeue.Margin = new System.Windows.Forms.Padding(2);
            this.txtDequeue.Name = "txtDequeue";
            this.txtDequeue.Size = new System.Drawing.Size(106, 20);
            this.txtDequeue.TabIndex = 37;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(575, 98);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(106, 20);
            this.txtName.TabIndex = 36;
            // 
            // listPriority1
            // 
            this.listPriority1.FormattingEnabled = true;
            this.listPriority1.Location = new System.Drawing.Point(47, 98);
            this.listPriority1.Margin = new System.Windows.Forms.Padding(2);
            this.listPriority1.Name = "listPriority1";
            this.listPriority1.Size = new System.Drawing.Size(163, 277);
            this.listPriority1.TabIndex = 35;
            // 
            // labe_maxsize
            // 
            this.labe_maxsize.AutoSize = true;
            this.labe_maxsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labe_maxsize.ForeColor = System.Drawing.Color.Red;
            this.labe_maxsize.Location = new System.Drawing.Point(651, 356);
            this.labe_maxsize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labe_maxsize.Name = "labe_maxsize";
            this.labe_maxsize.Size = new System.Drawing.Size(15, 15);
            this.labe_maxsize.TabIndex = 34;
            this.labe_maxsize.Text = "0";
            // 
            // lblQueue
            // 
            this.lblQueue.AutoSize = true;
            this.lblQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQueue.ForeColor = System.Drawing.Color.Red;
            this.lblQueue.Location = new System.Drawing.Point(571, 356);
            this.lblQueue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(93, 15);
            this.lblQueue.TabIndex = 33;
            this.lblQueue.Text = "Queue Size =";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(574, 327);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Max Size";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(574, 223);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Kişi Adı (Baştaki)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(574, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "İş Süresi (dk)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(579, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Kişi Adı (Enqueue)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 355);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Son";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Baş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(72, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "1.İşlem - 1.Öncelik";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(273, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Queue (Banka Kuyruğu)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(51, 83);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "İsim - işlem Sür. - Bekleme Sür.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(229, 83);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 13);
            this.label12.TabIndex = 50;
            this.label12.Text = "İsim - işlem Sür. - Bekleme Sür.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(407, 84);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 13);
            this.label13.TabIndex = 51;
            this.label13.Text = "İsim - işlem Sür. - Bekleme Sür.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 402);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rbPriority3);
            this.Controls.Add(this.rbPriority2);
            this.Controls.Add(this.listPriority3);
            this.Controls.Add(this.listPriority2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rbPriority1);
            this.Controls.Add(this.numMaxSize);
            this.Controls.Add(this.btnDequeue);
            this.Controls.Add(this.btnEnqueue);
            this.Controls.Add(this.numProcessTime);
            this.Controls.Add(this.txtDequeue);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.listPriority1);
            this.Controls.Add(this.labe_maxsize);
            this.Controls.Add(this.lblQueue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Queue";
            ((System.ComponentModel.ISupportInitialize)(this.numMaxSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProcessTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbPriority3;
        private System.Windows.Forms.RadioButton rbPriority2;
        private System.Windows.Forms.ListBox listPriority3;
        private System.Windows.Forms.ListBox listPriority2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbPriority1;
        private System.Windows.Forms.NumericUpDown numMaxSize;
        private System.Windows.Forms.Button btnDequeue;
        private System.Windows.Forms.Button btnEnqueue;
        private System.Windows.Forms.NumericUpDown numProcessTime;
        private System.Windows.Forms.TextBox txtDequeue;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox listPriority1;
        private System.Windows.Forms.Label labe_maxsize;
        private System.Windows.Forms.Label lblQueue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

