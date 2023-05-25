using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiyLayer;
using DataAccessLayer;
using LogicLayer;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace HospitalAutomatsation
{
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<EntityDoctor> doclist = LogicDoctor.LLDoctorList();
            dataGridView1.DataSource= doclist;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EntityDoctor entityDoctor = new EntityDoctor();
            entityDoctor.C_doctor_id_no = txtID.Text;
            entityDoctor.C_doctor_name = txt_Nagme.Text;
            entityDoctor.C_doctor_surname = txtSurnagme.Text;
            entityDoctor.C_doctor_policlinic_name = comboboxPoliclinic.Text;
            entityDoctor.C_doctor_phone_number = txtPhoneNumber.Text;
            entityDoctor.C_doctor_password = txtPassword.Text;

            int result = LogicDoctor.LLDoctorAdd(entityDoctor);
            if(result == 1)
            {
                MessageBox.Show("Başarılı bir şekilde eklendi");
                //Ekledikten sonra görüntülenmesi için tekrardan listeliyoruz
                List<EntityDoctor> doclist = LogicDoctor.LLDoctorList();
                dataGridView1.DataSource = doclist;
            }
            else 
            {
                MessageBox.Show("Eklenemedi");

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EntityDoctor entityDoctor = new EntityDoctor();
            entityDoctor.C_doctor_id_no = txtID.Text;
            bool result = LogicDoctor.LLDoctorDelete(Convert.ToInt64(entityDoctor.C_doctor_id_no));
            if (result)
            {
                MessageBox.Show("Kayıt başarıı bir şekilde silindi..");
                //Ekledikten sonra görüntülenmesi için tekrardan listeliyoruz
                List<EntityDoctor> doclist = LogicDoctor.LLDoctorList();
                dataGridView1.DataSource = doclist;
            }
            else
            {
                MessageBox.Show("Kayıt silinemedi..");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EntityDoctor entityDoctor = new EntityDoctor();
            entityDoctor.C_doctor_id_no = txtID.Text;
            entityDoctor.C_doctor_name = txt_Nagme.Text;
            entityDoctor.C_doctor_surname = txtSurnagme.Text;
            entityDoctor.C_doctor_policlinic_name = comboboxPoliclinic.Text;
            entityDoctor.C_doctor_phone_number = txtPhoneNumber.Text;
            entityDoctor.C_doctor_password= txtPassword.Text;
            bool result = LogicDoctor.LLDoctorUpdate(entityDoctor);
            if (result)
            {
                MessageBox.Show("Kayır başarılı bir şekilde güncellendi..");
                //Ekledikten sonra görüntülenmesi için tekrardan listeliyoruz
                List<EntityDoctor> doclist = LogicDoctor.LLDoctorList();
                dataGridView1.DataSource = doclist;
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
            comboboxPoliclinic.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtPhoneNumber.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtPassword.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void btnFormSecretary_Click(object sender, EventArgs e)
        {
            Secretary secretary = new Secretary();
            secretary.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.ShowDialog();
        }
    }
}
