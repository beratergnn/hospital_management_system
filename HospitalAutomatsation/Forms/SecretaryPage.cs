using EntitiyLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace HospitalAutomatsation.Forms
{
    public partial class SecretaryPage : Form
    {
        public SecretaryPage()
        {
            InitializeComponent();
        }
        // Datagridview a tıklandığında veri getirirken textboxlara yanlış veri gelmemesi için
        int carrier = 0;
        private void btnDoctorProcedures_Click(object sender, EventArgs e)
        {
            lblDoctorID.Visible = true;
            lblDoctorName.Visible = true;
            lblDoctorSurname.Visible = true;
            lblDoctorPhoneNo.Visible = true;
            lblDoctorPassword.Visible = true;
            lblDoctorPoliclinic.Visible = true;

            lblSecretaryID.Visible = false;
            lblSecretaryName.Visible = false;
            lblSecretarySurname.Visible = false;
            lblSecretaryPhoneNo.Visible = false;
            lblSecretaryPassword.Visible = false;

            lblPatientID.Visible = false;
            lblPatientName.Visible = false;
            lblPatinetSurname.Visible = false;
            lblPatientPoliclinic.Visible = false;

            lblChoiseDoctor.Visible = false;
            comboboxCHOISEDOCTOR.Visible = false;

            lblHourlbl.Visible = false;
            lblHour.Visible = false;
            btnMakeAppointment.Visible = false;

            textboxID.Visible = true;
            textboxNAME.Visible = true;
            textboxSURNAME.Visible = true;
            textboxPHONENO.Visible = true;
            textboxPASSWORD.Visible = true;
            comboboxPOLICLINIC.Visible = true;

            btnAddDoctor.Visible = true;
            btnDeleteDoctor.Visible = true;
            btnUpdateDoctor.Visible = true;
            btnListDoctor.Visible = true;

            btnAddSecretary.Visible = false;
            btnDeleteSecretary.Visible = false;
            btnUpdateSecretary.Visible = false;
            btnListSecretary.Visible = false;

            btnAddPatient.Visible = false;
            btnDeletePatient.Visible = false;
            btnUpdatePatient.Visible = false;
            btnListPatient.Visible = false;

            btnBringPatient.Visible = false;

            dataGridView1.DataSource = null;
            dataGridView1.Visible = true;

            textboxID.Texts = "";
            textboxNAME.Texts = "";
            textboxSURNAME.Texts = "";
            textboxPASSWORD.Texts = "";
            textboxPHONENO.Texts = "";
            comboboxPOLICLINIC.Texts = "";

            textboxNAME.Enabled = true;
            textboxSURNAME.Enabled = true;
            comboboxPOLICLINIC.Enabled = true;

            panelTime.Visible = false;

            carrier = 1;
        }




        private void btnSecretaryProcedures_Click(object sender, EventArgs e)
        {
            lblDoctorID.Visible = false;
            lblDoctorName.Visible = false;
            lblDoctorSurname.Visible = false;
            lblDoctorPhoneNo.Visible = false;
            lblDoctorPassword.Visible = false;
            lblDoctorPoliclinic.Visible = false;

            lblSecretaryID.Visible = true;
            lblSecretaryName.Visible = true;
            lblSecretarySurname.Visible = true;
            lblSecretaryPhoneNo.Visible = true;
            lblSecretaryPassword.Visible = true;

            lblPatientID.Visible = false;
            lblPatientName.Visible = false;
            lblPatinetSurname.Visible = false;
            lblPatientPoliclinic.Visible = false;

            lblChoiseDoctor.Visible = false;
            comboboxCHOISEDOCTOR.Visible = false;

            textboxID.Visible = true;
            textboxNAME.Visible = true;
            textboxSURNAME.Visible = true;
            textboxPHONENO.Visible = true;
            textboxPASSWORD.Visible = true;
            comboboxPOLICLINIC.Visible = false;

            lblHourlbl.Visible = false;
            lblHour.Visible = false;
            btnMakeAppointment.Visible = false;

            btnAddDoctor.Visible = false;
            btnDeleteDoctor.Visible = false;
            btnUpdateDoctor.Visible = false;
            btnListDoctor.Visible = false;

            btnAddSecretary.Visible = true;
            btnDeleteSecretary.Visible = true;
            btnListSecretary.Visible = true;
            btnUpdateSecretary.Visible = true;

            btnAddPatient.Visible = false;
            btnDeletePatient.Visible = false;
            btnUpdatePatient.Visible = false;
            btnListPatient.Visible = false;

            btnBringPatient.Visible = false;

            panelTime.Visible = false;

            textboxID.Texts = "";
            textboxNAME.Texts = "";
            textboxSURNAME.Texts = "";
            textboxPASSWORD.Texts = "";
            textboxPHONENO.Texts = "";
            comboboxPOLICLINIC.Texts = "";

            dataGridView1.DataSource = null;
            dataGridView1.Visible = true;

            textboxNAME.Enabled = true;
            textboxSURNAME.Enabled = true;
            comboboxPOLICLINIC.Enabled = true;

            carrier = 2;
        }

        private void btnPatientProcedures_Click(object sender, EventArgs e)
        {
            lblDoctorID.Visible = false;
            lblDoctorName.Visible = false;
            lblDoctorSurname.Visible = false;
            lblDoctorPhoneNo.Visible = false;
            lblDoctorPassword.Visible = false;
            lblDoctorPoliclinic.Visible = false;

            lblSecretaryID.Visible = false;
            lblSecretaryName.Visible = false;
            lblSecretarySurname.Visible = false;
            lblSecretaryPhoneNo.Visible = false;
            lblSecretaryPassword.Visible = false;


            lblPatientID.Visible = true;
            lblPatientName.Visible = true;
            lblPatinetSurname.Visible = true;
            lblPatientPoliclinic.Visible = true;

            lblChoiseDoctor.Visible = false;
            comboboxCHOISEDOCTOR.Visible = false;

            textboxID.Visible = true;
            textboxNAME.Visible = true;
            textboxSURNAME.Visible = true;
            textboxPHONENO.Visible = false;
            textboxPASSWORD.Visible = false;
            comboboxPOLICLINIC.Visible = true;

            btnAddDoctor.Visible = false;
            btnDeleteDoctor.Visible = false;
            btnUpdateDoctor.Visible = false;
            btnListDoctor.Visible = false;

            btnAddSecretary.Visible = false;
            btnDeleteSecretary.Visible = false;
            btnListSecretary.Visible = false;
            btnUpdateSecretary.Visible = false;

            btnAddPatient.Visible = true;
            btnDeletePatient.Visible = true;
            btnUpdatePatient.Visible = true;
            btnListPatient.Visible = true;

            btnBringPatient.Visible = false;
            panelTime.Visible = false;

            lblHourlbl.Visible = false;
            lblHour.Visible = false;
            btnMakeAppointment.Visible = false;

            textboxID.Texts = "";
            textboxNAME.Texts = "";
            textboxSURNAME.Texts = "";
            textboxPASSWORD.Texts = "";
            textboxPHONENO.Texts = "";
            comboboxPOLICLINIC.Texts = "";

            dataGridView1.DataSource = null;
            dataGridView1.Visible = true;

            textboxNAME.Enabled = true;
            textboxSURNAME.Enabled = true;
            comboboxPOLICLINIC.Enabled = true;

            carrier = 3;
        }

        private void btnAppointmentSet_Click(object sender, EventArgs e)
        {
            lblDoctorID.Visible = false;
            lblDoctorName.Visible = false;
            lblDoctorSurname.Visible = false;
            lblDoctorPhoneNo.Visible = false;
            lblDoctorPassword.Visible = false;
            lblDoctorPoliclinic.Visible = false;

            lblSecretaryID.Visible = false;
            lblSecretaryName.Visible = false;
            lblSecretarySurname.Visible = false;
            lblSecretaryPhoneNo.Visible = false;
            lblSecretaryPassword.Visible = false;

            lblPatientID.Visible = true;
            lblPatientName.Visible = false;
            lblPatinetSurname.Visible = false;
            lblPatientPoliclinic.Visible = false;

            textboxID.Visible = true;
            textboxNAME.Visible = false;
            textboxSURNAME.Visible = false;
            textboxPHONENO.Visible = false;
            textboxPASSWORD.Visible = false;
            comboboxPOLICLINIC.Visible = false;

            btnAddDoctor.Visible = false;
            btnDeleteDoctor.Visible = false;
            btnUpdateDoctor.Visible = false;
            btnListDoctor.Visible = false;

            btnAddSecretary.Visible = false;
            btnDeleteSecretary.Visible = false;
            btnListSecretary.Visible = false;
            btnUpdateSecretary.Visible = false;

            btnAddPatient.Visible = false;
            btnDeletePatient.Visible = false;
            btnUpdatePatient.Visible = false;
            btnListPatient.Visible = false;

            btnBringPatient.Visible = true;

            dataGridView1.DataSource = null;
            dataGridView1.Visible = false;

            panelTime.Visible = false;

            lblHourlbl.Visible = false;
            lblHour.Visible = false;
            btnMakeAppointment.Visible = false;

        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
        }

        private void SecretaryPage_Load(object sender, EventArgs e)
        {
            // form açıldığı anda combobox içinde oluşacak verilein önceden eklenmesi
            string[] list = { "Cardiology", "Family Physician", "General Surgery", "Gynecology", "Internal Medicine", "Obstetrics", "Otolaryngology", "Pediatrics", "Psychiatry", "Urology" };
            comboboxPOLICLINIC.Items.AddRange(list);

            panelTime.Visible = false;
            dataGridView1.Visible = false;

            lblHourlbl.Visible = false;
            lblHour.Visible = false;
            btnMakeAppointment.Visible = false;

        }



        // İsim ve soyisim kısmına bir text girildiği anda paralonın otomatikmen oluşturulması için ilgili iki alanın textChanged kontrolü
        string autoPassword = null;
        private void textboxNAMEandSURNAME_textChanged(object sender, EventArgs e)
        {


            if (textboxNAME.Texts.Length > 0 && textboxSURNAME.Texts.Length > 0)
            {
                autoPassword = textboxSURNAME.Texts.ToLower() + textboxNAME.Texts.ToLower();
                textboxPASSWORD.Texts = autoPassword;

            }
        }

        // textboxID ye 11 den büyük bir tc kimlik no girilmemesi için kontrol
        string metin = null;
        private void textboxID_textChanged(object sender, EventArgs e)
        {
            if (textboxID.Texts.Length <= 11)
            {
                metin = textboxID.Texts;
            }
            if (textboxID.Texts.Length > 11)
            {
                textboxID.Texts = metin;
            }
        }

        // textboxPhone için 11 haneden büyük bir telefon numarası kabul edilmemesi kontrolü
        string phoneNo = null;
        private void textboxPHONENO_textChanged(Object sender, EventArgs e)
        {
            if (textboxPHONENO.Texts.Length <= 11)
            {
                phoneNo = textboxPHONENO.Texts;
            }
            if (textboxPHONENO.Texts.Length > 11)
            {
                textboxPHONENO.Texts = phoneNo;
            }
        }

        // ID ve phone number alanaları için sadece number almak için keyPressEvent kodu
        private void onlyNumber(Object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        // name ve surname alanaları için sadece text almak için keyPressEvent kodu
        private void onlyText(Object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (carrier == 1)
            {
                textboxID.Texts = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textboxNAME.Texts = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textboxSURNAME.Texts = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textboxPHONENO.Texts = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textboxPASSWORD.Texts = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                comboboxPOLICLINIC.Texts = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            }
            else if (carrier == 2)
            {
                textboxID.Texts = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textboxNAME.Texts = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textboxSURNAME.Texts = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textboxPHONENO.Texts = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textboxPASSWORD.Texts = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            }
            else if (carrier == 3)
            {
                textboxID.Texts = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textboxNAME.Texts = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textboxSURNAME.Texts = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                comboboxPOLICLINIC.Texts = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }

        }

        // @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ DOCTOR  ADD - UPDATE - LIST - DELETE
        private void btnListDoctor_Click(object sender, EventArgs e)
        {
            List<EntityDoctor> doclist = LogicDoctor.LLDoctorList();
            dataGridView1.DataSource = doclist;

            // İlgili işlem yapıldıktan sonra textboxları temizleme
            textboxID.Texts = "";
            textboxNAME.Texts = "";
            textboxSURNAME.Texts = "";
            textboxPASSWORD.Texts = "";
            textboxPHONENO.Texts = "";
            comboboxPOLICLINIC.Texts = "";
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            EntityDoctor entityDoctor = new EntityDoctor();
            entityDoctor.C_doctor_id_no = textboxID.Texts;
            entityDoctor.C_doctor_name = textboxNAME.Texts.ToUpper();
            entityDoctor.C_doctor_surname = textboxSURNAME.Texts.ToUpper();
            entityDoctor.C_doctor_policlinic_name = comboboxPOLICLINIC.Texts;
            entityDoctor.C_doctor_phone_number = textboxPHONENO.Texts;
            entityDoctor.C_doctor_password = textboxPASSWORD.Texts;

            int result = LogicDoctor.LLDoctorAdd(entityDoctor);
            if (result == 1)
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

            // İlgili işlem yapıldıktan sonra textboxları temizleme
            textboxID.Texts = "";
            textboxNAME.Texts = "";
            textboxSURNAME.Texts = "";
            textboxPASSWORD.Texts = "";
            textboxPHONENO.Texts = "";
            comboboxPOLICLINIC.Texts = "";
        }

        private void btnDeleteDoctor_Click(object sender, EventArgs e)
        {
            EntityDoctor entityDoctor = new EntityDoctor();
            entityDoctor.C_doctor_id_no = textboxID.Texts;
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
            // İlgili işlem yapıldıktan sonra textboxları temizleme
            textboxID.Texts = "";
            textboxNAME.Texts = "";
            textboxSURNAME.Texts = "";
            textboxPASSWORD.Texts = "";
            textboxPHONENO.Texts = "";
            comboboxPOLICLINIC.Texts = "";
        }

        private void btnUpdateDoctor_Click(object sender, EventArgs e)
        {
            EntityDoctor entityDoctor = new EntityDoctor();
            entityDoctor.C_doctor_id_no = textboxID.Texts;
            entityDoctor.C_doctor_name = textboxNAME.Texts.ToUpper();
            entityDoctor.C_doctor_surname = textboxSURNAME.Texts.ToUpper();
            entityDoctor.C_doctor_policlinic_name = comboboxPOLICLINIC.Texts;
            entityDoctor.C_doctor_phone_number = textboxPHONENO.Texts;
            entityDoctor.C_doctor_password = textboxPASSWORD.Texts;
            bool result = LogicDoctor.LLDoctorUpdate(entityDoctor);
            if (result)
            {
                MessageBox.Show("Kayıt başarılı bir şekilde güncellendi..");
                //Ekledikten sonra görüntülenmesi için tekrardan listeliyoruz
                List<EntityDoctor> doclist = LogicDoctor.LLDoctorList();
                dataGridView1.DataSource = doclist;
            }
            else
            {
                MessageBox.Show("Kayıt güncellenemedi..");
            }

            // İlgili işlem yapıldıktan sonra textboxları temizleme
            textboxID.Texts = "";
            textboxNAME.Texts = "";
            textboxSURNAME.Texts = "";
            textboxPASSWORD.Texts = "";
            textboxPHONENO.Texts = "";
            comboboxPOLICLINIC.Texts = "";
        }

        // @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ PATIENT  ADD - UPDATE - LIST - DELETE
        // Hasta listeleme butonu click olayı
        private void btnListPatient_Click(object sender, EventArgs e)
        {
            List<EntityPatient> patList = LogicPatient.LLPatientList();
            dataGridView1.DataSource = patList;

            // İlgili işlem yapıldıktan sonra textboxları temizleme
            textboxID.Texts = "";
            textboxNAME.Texts = "";
            textboxSURNAME.Texts = "";
            textboxPASSWORD.Texts = "";
            textboxPHONENO.Texts = "";
            comboboxPOLICLINIC.Texts = "";
        }

        // Hasta ekleme butonu click olayı
        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            EntityPatient entityPatient = new EntityPatient();
            entityPatient.C_patient_id_no = textboxID.Texts;
            entityPatient.C_patient_name = textboxNAME.Texts.ToUpper();
            entityPatient.C_patient_surname = textboxSURNAME.Texts.ToUpper();
            entityPatient.C_patient_policlinic_name = comboboxPOLICLINIC.Texts;



            int result = LogicPatient.LLPatientAdd(entityPatient);
            if (result == 1)
            {
                MessageBox.Show("Başarılı bir şekilde eklendi");
                //Ekledikten sonra görüntülenmesi için tekrardan listeliyoruz
                List<EntityPatient> patList = LogicPatient.LLPatientList();
                dataGridView1.DataSource = patList;
            }
            else
            {
                MessageBox.Show("Eklenemedi");

            }

            // İlgili işlem yapıldıktan sonra textboxları temizleme
            textboxID.Texts = "";
            textboxNAME.Texts = "";
            textboxSURNAME.Texts = "";
            textboxPASSWORD.Texts = "";
            textboxPHONENO.Texts = "";
            comboboxPOLICLINIC.Texts = "";
        }

        private void btnBringPatient_Click(object sender, EventArgs e)
        {

            EntityPatient entityPatient = new EntityPatient();
            entityPatient.C_patient_id_no = textboxID.Texts;

            EntityPatient errorControler = LogicPatient.LLPatientBring(entityPatient);

            if (errorControler != null)
            {
                MessageBox.Show("Hasta bilgileri getirildi");
                lblPatientName.Visible = true;
                lblPatinetSurname.Visible = true;
                lblPatientPoliclinic.Visible = true;

                textboxNAME.Visible = true;
                textboxSURNAME.Visible = true;
                comboboxPOLICLINIC.Visible = true;

                textboxNAME.Texts = errorControler.C_patient_name;
                textboxSURNAME.Texts = errorControler.C_patient_surname;
                comboboxPOLICLINIC.Texts = errorControler.C_patient_policlinic_name;

                textboxNAME.Enabled = false;
                textboxSURNAME.Enabled = false;
                comboboxPOLICLINIC.Enabled = false;

                lblChoiseDoctor.Visible = true;
                comboboxCHOISEDOCTOR.Visible = true;

                panelTime.Visible = true;

                lblHourlbl.Visible = true;
                lblHour.Visible = true;
                btnMakeAppointment.Visible = true;



                comboboxCHOISEDOCTOR.Items.Clear();
                comboboxCHOISEDOCTOR.Texts = "";
                doctorList(comboboxPOLICLINIC.Texts);

                datePickerDate.MinDate = DateTime.Now.AddDays(1);
                datePickerDate.MaxDate = DateTime.Now.AddDays(8);


            }
            else if (errorControler == null)
            {
                MessageBox.Show("Bu ID ye sahip bir hasta bulunamadı");
                lblPatientName.Visible = false;
                lblPatinetSurname.Visible = false;
                lblPatientPoliclinic.Visible = false;

                textboxNAME.Visible = false;
                textboxSURNAME.Visible = false;
                comboboxPOLICLINIC.Visible = false;

                textboxNAME.Enabled = true;
                textboxSURNAME.Enabled = true;
                comboboxPOLICLINIC.Enabled = true;
            }


        }

        private void doctorList(string policlinicName)
        {
            string doctorFullName;
            List<EntityDoctor> list = LogicDoctor.LLGetDoctorforAppointment(policlinicName);
            EntityDoctor entityDoctor = new EntityDoctor();
            for (int i = 0; i < list.Count; i++)
            {
                entityDoctor = list[i];

                doctorFullName = entityDoctor.C_doctor_name + " " + entityDoctor.C_doctor_surname;
                comboboxCHOISEDOCTOR.Items.Add(doctorFullName);
            }


        }

        // Hasta silme buton click olayı
        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            EntityPatient entityPatient = new EntityPatient();
            entityPatient.C_patient_id_no = textboxID.Texts;
            bool result = LogicPatient.LLPatientDelete(Convert.ToInt64(entityPatient.C_patient_id_no));
            if (result)
            {
                MessageBox.Show("Kayıt başarıı bir şekilde silindi..");
                //Ekledikten sonra görüntülenmesi için tekrardan listeliyoruz
                List<EntityPatient> patList = LogicPatient.LLPatientList();
                dataGridView1.DataSource = patList;
            }
            else
            {
                MessageBox.Show("Kayıt silinemedi..");
            }

            // İlgili işlem yapıldıktan sonra textboxları temizleme
            textboxID.Texts = "";
            textboxNAME.Texts = "";
            textboxSURNAME.Texts = "";
            textboxPASSWORD.Texts = "";
            textboxPHONENO.Texts = "";
            comboboxPOLICLINIC.Texts = "";
        }


        // Hasta güncelleme buton click olayı
        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            EntityPatient entityPatient = new EntityPatient();
            entityPatient.C_patient_id_no = textboxID.Texts;
            entityPatient.C_patient_name = textboxNAME.Texts.ToUpper();
            entityPatient.C_patient_surname = textboxSURNAME.Texts.ToUpper();
            entityPatient.C_patient_policlinic_name = comboboxPOLICLINIC.Texts;


            bool result = LogicPatient.LLPatientUpdate(entityPatient);
            if (result)
            {
                MessageBox.Show("Kayıt başarılı bir şekilde güncellendi..");
                //Ekledikten sonra görüntülenmesi için tekrardan listeliyoruz
                List<EntityPatient> patList = LogicPatient.LLPatientList();
                dataGridView1.DataSource = patList;
            }
            else
            {
                MessageBox.Show("Kayıt güncellenemedi..");
            }

            // İlgili işlem yapıldıktan sonra textboxları temizleme
            textboxID.Texts = "";
            textboxNAME.Texts = "";
            textboxSURNAME.Texts = "";
            textboxPASSWORD.Texts = "";
            textboxPHONENO.Texts = "";
            comboboxPOLICLINIC.Texts = "";
        }

        // @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ SECRETARY  ADD - UPDATE - LIST - DELETE
        // Sekreter listeleme buton click olayı
        private void btnListSecretary_Click(object sender, EventArgs e)
        {
            List<EntitySecretary> seclist = LogicSecretary.LLSecretaryList();
            dataGridView1.DataSource = seclist;

            // İlgili işlem yapıldıktan sonra textboxları temizleme
            textboxID.Texts = "";
            textboxNAME.Texts = "";
            textboxSURNAME.Texts = "";
            textboxPASSWORD.Texts = "";
            textboxPHONENO.Texts = "";
            comboboxPOLICLINIC.Texts = "";
        }

        // Sekreter silme buton click olayı
        private void btnDeleteSecretary_Click(object sender, EventArgs e)
        {
            EntitySecretary entitySecretary = new EntitySecretary();
            entitySecretary.C_secretary_id_no = textboxID.Texts;
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

            // İlgili işlem yapıldıktan sonra textboxları temizleme
            textboxID.Texts = "";
            textboxNAME.Texts = "";
            textboxSURNAME.Texts = "";
            textboxPASSWORD.Texts = "";
            textboxPHONENO.Texts = "";
            comboboxPOLICLINIC.Texts = "";
        }

        // Sekreter güncelleme buton click olayı
        private void btnUpdateSecretary_Click(object sender, EventArgs e)
        {
            EntitySecretary entitySecretary = new EntitySecretary();
            entitySecretary.C_secretary_id_no = textboxID.Texts;
            entitySecretary.C_secretary_name = textboxNAME.Texts.ToUpper();
            entitySecretary.C_secretary_surname = textboxSURNAME.Texts.ToUpper();
            entitySecretary.C_secretary_phone_number = textboxPHONENO.Texts;
            entitySecretary.C_secretary_password = textboxPASSWORD.Texts;
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


            // İlgili işlem yapıldıktan sonra textboxları temizleme
            textboxID.Texts = "";
            textboxNAME.Texts = "";
            textboxSURNAME.Texts = "";
            textboxPASSWORD.Texts = "";
            textboxPHONENO.Texts = "";
            comboboxPOLICLINIC.Texts = "";
        }

        // Sekreter ekleme buton click olayı
        private void btnAddSecretary_Click(object sender, EventArgs e)
        {
            EntitySecretary entitySecretary = new EntitySecretary();
            entitySecretary.C_secretary_id_no = textboxID.Texts;
            entitySecretary.C_secretary_name = textboxNAME.Texts.ToUpper();
            entitySecretary.C_secretary_surname = textboxSURNAME.Texts.ToUpper();
            entitySecretary.C_secretary_phone_number = textboxPHONENO.Texts;
            entitySecretary.C_secretary_password = textboxPASSWORD.Texts;

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

            // İlgili işlem yapıldıktan sonra textboxları temizleme
            textboxID.Texts = "";
            textboxNAME.Texts = "";
            textboxSURNAME.Texts = "";
            textboxPASSWORD.Texts = "";
            textboxPHONENO.Texts = "";
            comboboxPOLICLINIC.Texts = "";
        }

        private void btnHour9_Click(object sender, EventArgs e)
        {
            lblHour.Text = btnHour9.Text;
        }

        private void btnHour10_Click(object sender, EventArgs e)
        {
            lblHour.Text = btnHour10.Text;
        }

        private void btnHour11_Click(object sender, EventArgs e)
        {
            lblHour.Text = btnHour11.Text;
        }

        private void btnHour12_Click(object sender, EventArgs e)
        {
            lblHour.Text = btnHour12.Text;
        }

        private void btnHour13_Click(object sender, EventArgs e)
        {
            lblHour.Text = btnHour13.Text;
        }

        private void btnHour14_Click(object sender, EventArgs e)
        {
            lblHour.Text = btnHour14.Text;
        }

        private void btnHour15_Click(object sender, EventArgs e)
        {
            lblHour.Text = btnHour15.Text;
        }

        private void btnHour16_Click(object sender, EventArgs e)
        {
            lblHour.Text = btnHour16.Text;

        }

        private void btnHour17_Click(object sender, EventArgs e)
        {
            lblHour.Text = btnHour17.Text;
        }

        private void btnMakeAppointment_Click(object sender, EventArgs e)
        {
            EntityDoctor entityDoctor = new EntityDoctor();
            EntityPatient entityPatient = new EntityPatient();
            string entityDate ="";

            string name = comboboxCHOISEDOCTOR.Texts;
            List<EntityDoctor> list = LogicDoctor.LLGetDoctorforAppointment(comboboxPOLICLINIC.Texts);




            if (comboboxCHOISEDOCTOR.Texts == "")
            {
    
                MessageBox.Show("Please choise doctor.");
            }

            else
            {
                entityDoctor.C_doctor_name = name.Split(' ')[0];
                entityDoctor.C_doctor_surname = name.Split(' ')[1];
                entityPatient.C_patient_id_no = textboxID.Texts;
                entityDate = datePickerDate.Text + " " + lblHour.Text;


                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].C_doctor_name == comboboxCHOISEDOCTOR.Texts.Split(' ')[0] && list[i].C_doctor_surname == comboboxCHOISEDOCTOR.Texts.Split(' ')[1])
                    {
                        entityDoctor.C_doctor_id_no = list[i].C_doctor_id_no;
                    }
                }
                int deger = LogicSecretary.LLAppointmetCheck(entityDoctor, entityPatient, entityDate);
                if (deger==-1)
                {
                    MessageBox.Show("RANDEVU DOLU");
                }
                else if (deger == -11)
                {
                    MessageBox.Show("tc boş geçme pim");
                }
                else
                {

                    // entityDoctor.C_doctor_id_no = list[0].C_doctor_id_no;
                    entityDoctor.C_doctor_policlinic_name = comboboxPOLICLINIC.Texts;
                    
            

                    entityPatient.C_patient_id_no = textboxID.Texts;



                    MessageBox.Show(entityDate);

                    int result = LogicSecretary.LLAppointmetAdd(entityDoctor, entityPatient, entityDate);
                    if (result == 1)
                    {
                        MessageBox.Show("Başarılı bir şekilde eklendi");
                        //Ekledikten sonra görüntülenmesi için tekrardan listeliyoruz   
                    }
                    else
                    {
                        MessageBox.Show("Eklenemedi");

                    }
                }

            }

        }

        private void btnDoctorProcedures_MouseHover(object sender, EventArgs e)
        {
            btnDoctorProcedures.BackColor = Color.FromArgb(0, 150, 136);
        }

        private void btnDoctorProcedures_MouseLeave(object sender, EventArgs e)
        {
            btnDoctorProcedures.BackColor = panelMenu.BackColor;
        }

        private void btnSecretaryProcedures_MouseHover(object sender, EventArgs e)
        {
            btnSecretaryProcedures.BackColor = Color.FromArgb(0, 150, 136);
        }

        private void btnSecretaryProcedures_MouseLeave(object sender, EventArgs e)
        {
            btnSecretaryProcedures.BackColor = panelMenu.BackColor;
        }

        private void btnPatientProcedures_MouseHover(object sender, EventArgs e)
        {
            btnPatientProcedures.BackColor = Color.FromArgb(0, 150, 136);
        }

        private void btnPatientProcedures_MouseLeave(object sender, EventArgs e)
        {
            btnPatientProcedures.BackColor = panelMenu.BackColor;
        }

        private void btnAppointmentSet_MouseHover(object sender, EventArgs e)
        {
            btnAppointmentSet.BackColor = Color.FromArgb(0, 150, 136);
        }

        private void btnAppointmentSet_MouseLeave(object sender, EventArgs e)
        {
            btnAppointmentSet.BackColor = panelMenu.BackColor;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            btnBackToMain.BackColor = Color.FromArgb(224, 79, 95);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btnBackToMain.BackColor = panelMenu.BackColor;
        }

        private void SecretaryPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnBackToMain.PerformClick();
            }
        }
    }
}
