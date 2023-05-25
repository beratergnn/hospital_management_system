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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<EntityPatient> patlist = LogicPatient.LLPatientList();
            dataGridView1.DataSource = patlist;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EntityPatient entityPatient = new EntityPatient();
            entityPatient.C_patient_id_no = txtID.Text;
            entityPatient.C_patient_name = txt_Nagme.Text;
            entityPatient.C_patient_surname = txtSurnagme.Text;
            

            int result = LogicPatient.LLPatientAdd(entityPatient);
            if (result == 1)
            {
                MessageBox.Show("Başarılı bir şekilde eklendi");
                //Ekledikten sonra görüntülenmesi için tekrardan listeliyoruz
                List<EntityPatient> patlist = LogicPatient.LLPatientList();
                dataGridView1.DataSource = patlist;
            }
            else
            {
                MessageBox.Show("Eklenemedi");

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EntityPatient entityPatient = new EntityPatient();
            entityPatient.C_patient_id_no = txtID.Text;
            bool result = LogicPatient.LLPatientDelete(Convert.ToInt64(entityPatient.C_patient_id_no));
            if (result)
            {
                MessageBox.Show("Kayıt başarıı bir şekilde silindi..");
                //Ekledikten sonra görüntülenmesi için tekrardan listeliyoruz
                List<EntityPatient> patlist = LogicPatient.LLPatientList();
                dataGridView1.DataSource = patlist;
            }
            else
            {
                MessageBox.Show("Kayıt silinemedi..");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            EntityPatient entityPatient = new EntityPatient();
            entityPatient.C_patient_id_no = txtID.Text;
            entityPatient.C_patient_name = txt_Nagme.Text;
            entityPatient.C_patient_surname = txtSurnagme.Text;
         
            bool result = LogicPatient.LLPatientUpdate(entityPatient);
            if (result)
            {
                MessageBox.Show("Kayır başarılı bir şekilde güncellendi..");
                //Ekledikten sonra görüntülenmesi için tekrardan listeliyoruz
                List<EntityPatient> patlist = LogicPatient.LLPatientList();
                dataGridView1.DataSource = patlist;
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
            
        }
    }
}
