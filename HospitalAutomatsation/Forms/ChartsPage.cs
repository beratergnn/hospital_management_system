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

namespace HospitalAutomatsation.Forms
{
    public partial class ChartsPage : Form
    {
        public ChartsPage()
        {
            InitializeComponent();
        }


        List<string> list = new List<string>();
        List<EntityDoctor> doktorListe = new List<EntityDoctor>();
        int kisiSayisi;
        string doktorTC;

        private void DoktorGrafik_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.Minimum = 1;
            chart1.ChartAreas[0].AxisX.Maximum = 60;
            doktorListe.AddRange(LogicDoctor.LLDoctorList());
            for (int i = 0; i < doktorListe.Count; i++)
            {

                list.Add(doktorListe[i].C_doctor_name + " " + doktorListe[i].C_doctor_surname);
                doktorTC = LogicDoctor.LogicDoktorGetir(list[i]);
                kisiSayisi = LogicDoctor.LogicToplamHastaDoktor(doktorTC);
                chart1.Series["Person Count"].Points.AddXY(list[i] + " :" + kisiSayisi, kisiSayisi);

            }

            string[] dizi = {"Cardiology" ,"Family" ,"Physician" ,"General Surgery", "Gynecology" ,"Internal Medicine" ,"Obstetrics", "Otolaryngology" ,"Pediatrics" ,"Psychiatry" ,"Urology"};



            chart2.ChartAreas[0].AxisX.Interval = 1;
            chart2.ChartAreas[0].AxisX.Minimum = 1;
            chart2.ChartAreas[0].AxisX.Maximum = 10;
          

            for (int i = 0; i < dizi.Length; i++)
            {
                int personCount = LogicDoctor.LogicToplamRandevuHasta(dizi[i]);

                chart2.Series["Person Count"].Points.Add(personCount);
                chart2.Series["Person Count"].Points[i].AxisLabel = dizi[i]+" :"+personCount.ToString();

            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
        }

        private void ChartsPage_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                btnLogout.PerformClick();
            }
        }
    }
}
