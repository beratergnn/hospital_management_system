using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiyLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicDoctor
    {
        public static List<EntityDoctor> LLDoctorList()
        {
            return DALDoctor.DoctorList();
        }

        public static  int LLDoctorAdd(EntityDoctor entityDoctor)
        {
            if(entityDoctor.C_doctor_id_no !="" && entityDoctor.C_doctor_name != "" && entityDoctor.C_doctor_surname != "")
            {

                return DALDoctor.DoctorAdd(entityDoctor);
            }
            else
            {
                return -1;
            }
        }

        public static int LLResultAdd(EntityDoctor entityDoctor,EntityPatient entityPatient, string sonuc, DateTime dateTime)
        {
            if (entityDoctor.C_doctor_id_no != "" && entityPatient.C_patient_surname != "" && sonuc != "")
            {

                return DALDoctor.ResultAdd(entityDoctor,entityPatient,sonuc,dateTime);
            }
            else
            {
                return -1;
            }
        }

        public static bool LLDoctorDelete (long doc)
        {
            if(doc >= 1)
            {
                return DALDoctor.DoctorDelete(doc);
            }
            else
            {
                return false;
            }
        }
        public static bool LLDoctorUpdate(EntityDoctor entityDoctor)
        {
            if(entityDoctor.C_doctor_name!="" && entityDoctor.C_doctor_surname!="" && entityDoctor.C_doctor_policlinic_name!="" && entityDoctor.C_doctor_policlinic_name != "")
            {
                return DALDoctor.DoctorUpdate(entityDoctor);
            }
            else
            {
                return false;
            }
        }

        public static int LLDoctorLogin(EntityDoctor loginDoctor)
        {
            if(loginDoctor.C_doctor_id_no.Length==11 && loginDoctor.C_doctor_password.Length>0)
            {
                EntityDoctor entityDoctors = new EntityDoctor();
                entityDoctors = DALDoctor.DoctorIDLogin(loginDoctor);
                if (entityDoctors.C_doctor_id_no ==loginDoctor.C_doctor_id_no )
                {
                    entityDoctors = DALDoctor.DoctorLogin(loginDoctor);
                    if (loginDoctor.C_doctor_password == entityDoctors.C_doctor_password)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                    
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -2;
            }
        }
        public static List<EntityDoctor> LLGetDoctorforAppointment(string getDoctor)
        {
            return DALDoctor.GetDoctorforAppointment(getDoctor);
        }

        public static List<String> LLResultList(string getDoctor)
        {
            return DALDoctor.ResultList(getDoctor);
        }

        public static int LogicToplamRandevuHasta(string polikinidAd)
        {
            return DALDoctor.toplamRandevuHasta(polikinidAd);
        }
        public static string LogicDoktorGetir(string doktorAdSoyad)
        {
            List<EntityDoctor> doktorKontrol = LLDoctorList();
            string doktorTC;
            doktorTC = doktorKontrol[doktorKontrol.FindIndex(x => x.C_doctor_name == doktorAdSoyad.Split(' ')[0] && x.C_doctor_surname == doktorAdSoyad.Split(' ')[1])].C_doctor_id_no;
            return doktorTC;
        }
        public static int LogicToplamHastaDoktor(string doktorTC)
        {
            return DALDoctor.toplamHastaDoktor(doktorTC);
        }
    }
}
