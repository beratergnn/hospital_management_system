namespace HospitalAutomatsation
{
    partial class Doctor
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txt_Nagme = new System.Windows.Forms.TextBox();
            this.txtSurnagme = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnFormSecretary = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboboxPoliclinic = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(914, 216);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "DoctorID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "DoctorName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "DoctorSurname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "DoctorPoliclinic";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "DoctorPhoneNumber";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "DoctorPassword";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(194, 21);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 7;
            // 
            // txt_Nagme
            // 
            this.txt_Nagme.Location = new System.Drawing.Point(194, 61);
            this.txt_Nagme.Name = "txt_Nagme";
            this.txt_Nagme.Size = new System.Drawing.Size(100, 22);
            this.txt_Nagme.TabIndex = 8;
            // 
            // txtSurnagme
            // 
            this.txtSurnagme.Location = new System.Drawing.Point(194, 113);
            this.txtSurnagme.Name = "txtSurnagme";
            this.txtSurnagme.Size = new System.Drawing.Size(100, 22);
            this.txtSurnagme.TabIndex = 9;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(500, 61);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 22);
            this.txtPhoneNumber.TabIndex = 11;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(500, 119);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 12;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(89, 178);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 13;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(219, 178);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(349, 178);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdate.Location = new System.Drawing.Point(500, 178);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnFormSecretary
            // 
            this.btnFormSecretary.Location = new System.Drawing.Point(683, 85);
            this.btnFormSecretary.Name = "btnFormSecretary";
            this.btnFormSecretary.Size = new System.Drawing.Size(140, 23);
            this.btnFormSecretary.TabIndex = 17;
            this.btnFormSecretary.Text = "Form Secretary";
            this.btnFormSecretary.UseVisualStyleBackColor = true;
            this.btnFormSecretary.Click += new System.EventHandler(this.btnFormSecretary_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(683, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Form Patient";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboboxPoliclinic
            // 
            this.comboboxPoliclinic.FormattingEnabled = true;
            this.comboboxPoliclinic.Items.AddRange(new object[] {
            "Cardiology",
            "Family Physician",
            "General Surgery",
            "Gynecology",
            "Internal Medicine",
            "Obstetrics",
            "Otolaryngology",
            "Pediatrics",
            "Psychiatry",
            "Urology"});
            this.comboboxPoliclinic.Location = new System.Drawing.Point(500, 13);
            this.comboboxPoliclinic.Name = "comboboxPoliclinic";
            this.comboboxPoliclinic.Size = new System.Drawing.Size(121, 24);
            this.comboboxPoliclinic.TabIndex = 19;
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 450);
            this.Controls.Add(this.comboboxPoliclinic);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFormSecretary);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtSurnagme);
            this.Controls.Add(this.txt_Nagme);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Doctor";
            this.Text = "Doctor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txt_Nagme;
        private System.Windows.Forms.TextBox txtSurnagme;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnFormSecretary;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboboxPoliclinic;
    }
}

