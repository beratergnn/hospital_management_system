using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataAccessLayer;
using EntitiyLayer;
using LogicLayer;
using HospitalAutomatsation.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalAutomatsation
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        
        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDoctorLogin_MouseHover(object sender, EventArgs e)
        {
            btnDoctorLoginScreen.BackColor  = Color.FromArgb(0, 150, 136);

        }

        private void btnDoctorLogin_MouseLeave(object sender, EventArgs e)
        {
            btnDoctorLoginScreen.BackColor = panelMenu.BackColor;
        }

        private void btnSecretaryLogin_MouseHover(object sender, EventArgs e)
        {
            btnSecretaryLoginScreen.BackColor = Color.FromArgb(0, 150, 136);
        }

        private void btnSecretaryLogin_MouseLeave(object sender, EventArgs e)
        {
            btnSecretaryLoginScreen.BackColor = panelMenu.BackColor;
        }

        private void btnAbout_MouseHover(object sender, EventArgs e)
        {
            btnAboutScreen.BackColor = Color.FromArgb(98, 137, 204);
        }

        private void btnAbout_MouseLeave(object sender, EventArgs e)
        {
            btnAboutScreen.BackColor = panelMenu.BackColor;
        }

        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.FromArgb(224, 79, 95);
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.BackColor = panelMenu.BackColor;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            DialogResult = MessageBox.Show("Are you sure to exit?", "Logout", MessageBoxButtons.YesNo);

            if(DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDoctorLoginScreen_Click(object sender, EventArgs e)
        {
            lblIdentityNo.Visible = true;
            lblPassword.Visible = true;
            txtId.Visible = true;
            txtPassword.Visible = true;
            newBtnLoginDoctor.Visible= true;
            newBtnLoginSecretary.Visible = false;
            pictureBox.Visible = true;
            pictureBoxPassword.Visible= true;
            pictureBox.Image = Properties.Resources.doctor128green;

            panelDesktopPanel.Visible = true;

        }

      
        private void btnSecretaryLoginScreen_Click(object sender, EventArgs e)
        {
            lblIdentityNo.Visible = true;
            lblPassword.Visible = true;
            txtId.Visible = true;
            txtPassword.Visible = true;
            newBtnLoginSecretary.Visible = true;
            newBtnLoginDoctor.Visible = false;
            pictureBox.Visible= true;
            pictureBoxPassword.Visible = true;
            pictureBox.Image = Properties.Resources.secretary128green;

            panelDesktopPanel.Visible = true;



        }

        private void newBtnLoginDoctor_Click(object sender, EventArgs e)
        {
            EntityDoctor entityDoctor = new EntityDoctor();
            entityDoctor.C_doctor_id_no = txtId.Texts;
            entityDoctor.C_doctor_password = txtPassword.Texts;

            int errorControler = LogicDoctor.LLDoctorLogin(entityDoctor);

            if (errorControler == 1)
            {
                MessageBox.Show("Login is successful, you can proceed to the panel by clicking OK.");
                DoctorPage doctorPage = new DoctorPage();
                doctorPage.DoktorTC = txtId.Texts;
                doctorPage.ShowDialog();
                this.Hide();    
            }
            else if (errorControler == 0)
            {
                MessageBox.Show("You entered your password incorrectly, please try again with the correct password.");
            }
            else if (errorControler == -1)
            {
                MessageBox.Show("A doctor with this ID number could not be found.");
            }
            else if (errorControler == -2)
            {
                MessageBox.Show("You have entered incompletely, please check and try again.");
            }
        }

        // txtBox kontrolününde id alanı için 11 karakterden fazla girilmemesi için kontrol
        string metin = null;
        private void txtId__TextChanged(object sender, EventArgs e)
        {
            
            if (txtId.Texts.Length<=11)
            {
                metin = txtId.Texts;
            }
            if (txtId.Texts.Length > 11)
            {
                txtId.Texts = metin;
            }
        }

        private void newBtnLoginSecretary_Click(object sender, EventArgs e)
        {
            EntitySecretary entitySecretary = new EntitySecretary();
            entitySecretary.C_secretary_id_no = txtId.Texts;
            entitySecretary.C_secretary_password = txtPassword.Texts;

            int errorControler = LogicSecretary.LLSecretaryLogin(entitySecretary);

            if (errorControler == 1)
            {
                MessageBox.Show("Login is successful, you can proceed to the panel by clicking OK.");
                SecretaryPage secretaryPage = new SecretaryPage();
                secretaryPage.ShowDialog();
                this.Hide();    
            }
            else if (errorControler == 0)
            {
                MessageBox.Show("You entered your password incorrectly, please try again with the correct password.");
            }
            else if (errorControler == -1)
            {
                MessageBox.Show("A secretary with this ID number could not be found.");
            }
            else if (errorControler == -2)
            {
                MessageBox.Show("You have entered incompletely, please check and try again.");
            }
        }

        private void btnAboutScreen_Click(object sender, EventArgs e)
        {


            panelDesktopPanel.Visible = false; 
            ChartsPage chartsPage = new ChartsPage();
            chartsPage.ShowDialog();

        }
        bool isClicked = false;
        private void pictureBoxPassword_Click(object sender, EventArgs e)
        {
            if(isClicked == false)
            {
                pictureBoxPassword.Image = Properties.Resources.eye0_24;
                isClicked= true;
                txtPassword.PasswordChar = true;
            }
            else
            {
                pictureBoxPassword.Image = Properties.Resources.eye1_24;
                isClicked = false;
                txtPassword.PasswordChar = false;
            }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void HomePage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                newBtnLoginSecretary.PerformClick();
                newBtnLoginDoctor.PerformClick();

            }
            if (e.KeyCode == Keys.Escape)
            {
                btnLogout.PerformClick();
            }
        }
    }
}
