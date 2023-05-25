using EntitiyLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAutomatsation
{
    public partial class Secretary : Form
    {
        public Secretary()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<EntitySecretary> seclist = LogicSecretary.LLSecretaryList();
            dataGridView1.DataSource = seclist;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EntitySecretary entitySecretary = new EntitySecretary();
            entitySecretary.C_secretary_id_no = txtID.Text;
            entitySecretary.C_secretary_name = txt_Nagme.Text;
            entitySecretary.C_secretary_surname = txtSurnagme.Text; 
            entitySecretary.C_secretary_phone_number = txtPhoneNumber.Text;
            entitySecretary.C_secretary_password = txtPassword.Text;

            int result = LogicSecretary.LLSecretaryAdd(entitySecretary);
            if (result == 1)
            {
                MessageBox.Show("Başarılı bir şekilde eklendi");
                //Ekledikten sonra görüntülenmesi için tekrardan listeliyoruz
                List<EntitySecretary> seclist = LogicSecretary.LLSecretaryList();
                dataGridView1.DataSource = seclist;
            }
            else
            {
                MessageBox.Show("Eklenemedi");

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EntitySecretary entitySecretary = new EntitySecretary();
            entitySecretary.C_secretary_id_no = txtID.Text;
            bool result = LogicSecretary.LLSecretaryDelete(Convert.ToInt64(entitySecretary.C_secretary_id_no));
            if (result)
            {
                MessageBox.Show("Kayıt başarıı bir şekilde silindi..");
                //Ekledikten sonra görüntülenmesi için tekrardan listeliyoruz
                List<EntitySecretary> seclist = LogicSecretary.LLSecretaryList();
                dataGridView1.DataSource = seclist;
            }
            else
            {
                MessageBox.Show("Kayıt silinemedi..");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EntitySecretary entitySecretary = new EntitySecretary();
            entitySecretary.C_secretary_id_no = txtID.Text;
            entitySecretary.C_secretary_name = txt_Nagme.Text;
            entitySecretary.C_secretary_surname = txtSurnagme.Text;
            entitySecretary.C_secretary_phone_number = txtPhoneNumber.Text;
            entitySecretary.C_secretary_password = txtPassword.Text;
            bool result = LogicSecretary.LLSecretaryUpdate(entitySecretary);
            if (result)
            {
                MessageBox.Show("Kayır başarılı bir şekilde güncellendi..");
                //Ekledikten sonra görüntülenmesi için tekrardan listeliyoruz
                List<EntitySecretary> seclist = LogicSecretary.LLSecretaryList();
                dataGridView1.DataSource = seclist;
            }
            else
            {
                MessageBox.Show("Kayıt güncellenemedi..");
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_Nagme.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSurnagme.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPhoneNumber.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtPassword.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
