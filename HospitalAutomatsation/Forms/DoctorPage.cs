using EntitiyLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalAutomatsation.Forms
{
    public partial class DoctorPage : Form
    {
        public DoctorPage()
        {
            InitializeComponent();
        }
        public string DoktorTC;

        int hangisi = 0;
        private void DoctorPage_Load_1(object sender, EventArgs e)
        {
            
            dataGridView1.Visible = false;
            generatingResultsPanel.Visible = false;
            listResultsPanel.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (hangisi == 1)
            {
                txtBoxPIDNo.Texts = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtPName.Texts = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtPSurname.Texts = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtPoliclinicName.Texts = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }else if(hangisi == 2)
            {
                textboxPID.Texts = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textboxDID.Texts = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textboxPN.Texts = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textboxRT.Texts = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textboxRDT.Texts = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void btnSendResult_Click(object sender, EventArgs e)
        {
            EntityDoctor entityDoctor = new EntityDoctor();
            EntityPatient entityPatient = new EntityPatient();
            string sonuc;
            DateTime dateTime = DateTime.Now;

            entityPatient.C_patient_id_no = txtBoxPIDNo.Texts;
            entityPatient.C_patient_name = txtPName.Texts;
            entityPatient.C_patient_surname = txtPSurname.Texts;
            entityPatient.C_patient_policlinic_name = txtPoliclinicName.Texts;
            sonuc = txtDoctorOpinion.Texts;

            entityDoctor.C_doctor_id_no = DoktorTC;


            int result = LogicDoctor.LLResultAdd(entityDoctor,entityPatient,sonuc,dateTime);
            if (result == 1)
            {
                MessageBox.Show("Başarılı bir şekilde eklendi");
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurmadan sonuç yazmaya çalışmayın.");

            }
        }

        private void btnResultGeneration_Click(object sender, EventArgs e)
        {
            hangisi = 1;

            dataGridView1.Visible = true;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            List<EntityPatient> doclist = LogicPatient.LLPatientListForDoctor(DoktorTC);
            dataGridView1.DataSource = doclist;


            generatingResultsPanel.Visible = true;
            listResultsPanel.Visible = false;
        }


        private void btnListResults_Click(object sender, EventArgs e)
        {
            hangisi = 2;
            dataGridView1.Visible = true;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            List<String> resultList = LogicDoctor.LLResultList(DoktorTC);

            dataGridView1.Columns.Add("doctor_id", "doctor_id");
            dataGridView1.Columns.Add("patient_id", "patient_id");
            dataGridView1.Columns.Add("policlinic_name", "policlinic_name");
            dataGridView1.Columns.Add("result_text", "result_text");
            dataGridView1.Columns.Add("result_d_time", "result_d_time");
            for (int i = 0; i < resultList.Count; i++)
            {
                string rows = resultList[i].ToString();

                string[] rowsColumn = rows.Split(' ');
                string fullTime = rowsColumn[4]+" "+ rowsColumn[5];
                dataGridView1.Rows.Add(rowsColumn[0], rowsColumn[1], rowsColumn[2], rowsColumn[3], fullTime);
            }

           

            listResultsPanel.Visible = true;
            generatingResultsPanel.Visible = true;



        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            if (textboxPID.Texts=="")
            {
                MessageBox.Show("Lütfen önce alanları datagridviewden çekerek doldurunuz.");
            }
            else
            {
                // Geçici olarak textbox verilerini.txt dosyasına kaydedin
                File.WriteAllText("temp.txt", "Patient ID : " + textboxPID.Texts + "\n" + "Doctor ID : " + textboxDID.Texts + "\n" + "Policlinic Name : " + textboxPN.Texts + "\n" + "Result Time : " + textboxRDT.Texts + "\n"+"Result Text : " + textboxRT.Texts + "\n");

                // Geçici .txt dosyasını Notepad'te açın
                ProcessStartInfo startInfo = new ProcessStartInfo("temp.txt");  
                startInfo.UseShellExecute = true;
                startInfo.Verb = "print";
                Process.Start(startInfo);

                // "Microsoft Print to PDF" yazıcısını seçin ve dosyayı yazdırın
                PrintDialog printDialog = new PrintDialog();
                printDialog.PrinterSettings.PrintFileName = "TextboxData.pdf";
                printDialog.PrinterSettings.PrintToFile = true;
                printDialog.ShowDialog();

                // Geçici .txt dosyasını silin
                File.Delete("temp.txt");
            }
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            string email = "barisbalcikoca@outlook.com";
            Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");

            if (textboxPID.Texts == "")
            {
                MessageBox.Show("Lütfen DataGridden verileri çekin.");
            }
            else
            {
                if (regex.IsMatch(textboxMailTo.Texts))
                {
                    try
                    {
                        string recipient = textboxMailTo.Texts;
                        string subject = textboxSubject.Texts;
                        string body = "Patient ID : " + textboxPID.Texts + "\n" + "Doctor ID : " + textboxDID.Texts + "\n" + "Policlinic Name : " + textboxPN.Texts + "\n" + "Result Time : " + textboxRDT.Texts + "\n" + "Result Text : " + textboxRT.Texts + "\n\n" + textboxDescription.Texts;
                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress(email);
                        mail.To.Add(recipient);
                        mail.Subject = subject;
                        mail.Body = body;
                        SmtpClient smtp = new SmtpClient();
                        smtp.Host = "smtp-mail.outlook.com";
                        smtp.Credentials = new NetworkCredential("barisbalcikoca@outlook.com", "balcikocabaris.");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);

                        MessageBox.Show("Başarılı bir şekilde mail gönderilmiştir");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir e posta formatı giriniz.");
                }
            }
        }

        private void btnResultGeneration_MouseHover(object sender, EventArgs e)
        {
            btnResultGeneration.BackColor = Color.FromArgb(0, 150, 136);
        }

        private void btnResultGeneration_MouseLeave(object sender, EventArgs e)
        {
            btnResultGeneration.BackColor = panelMenu.BackColor;
        }

        private void btnListResults_MouseHover(object sender, EventArgs e)
        {
            btnListResults.BackColor = Color.FromArgb(0, 150, 136);
        }

        private void btnListResults_MouseLeave(object sender, EventArgs e)
        {
            btnListResults.BackColor = panelMenu.BackColor;
        }

        private void btnBackToMain_MouseHover(object sender, EventArgs e)
        {
            btnBackToMain.BackColor = Color.FromArgb(224, 79, 95);
        }

        private void btnBackToMain_MouseLeave(object sender, EventArgs e)
        {
            btnBackToMain.BackColor = panelMenu.BackColor;
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
        }

        private void DoctorPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnBackToMain.PerformClick();
            }
        }
    }
}


