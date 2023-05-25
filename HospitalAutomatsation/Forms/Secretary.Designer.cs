namespace HospitalAutomatsation
{
    partial class Secretary
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtSurnagme = new System.Windows.Forms.TextBox();
            this.txt_Nagme = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(500, 182);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(349, 182);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(219, 182);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(89, 182);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 30;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(518, 123);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 29;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(518, 65);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 22);
            this.txtPhoneNumber.TabIndex = 28;
            // 
            // txtSurnagme
            // 
            this.txtSurnagme.Location = new System.Drawing.Point(212, 117);
            this.txtSurnagme.Name = "txtSurnagme";
            this.txtSurnagme.Size = new System.Drawing.Size(100, 22);
            this.txtSurnagme.TabIndex = 26;
            // 
            // txt_Nagme
            // 
            this.txt_Nagme.Location = new System.Drawing.Point(212, 68);
            this.txt_Nagme.Name = "txt_Nagme";
            this.txt_Nagme.Size = new System.Drawing.Size(100, 22);
            this.txt_Nagme.TabIndex = 25;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(212, 22);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "SecretaryPassword";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "SecretaryPhoneNumber";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "SecretarySurname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "SecretaryName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "SecretaryID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(914, 216);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Secretary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 481);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Secretary";
            this.Text = "Secretary";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtSurnagme;
        private System.Windows.Forms.TextBox txt_Nagme;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}