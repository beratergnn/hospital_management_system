using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiyLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicPatient
    {
        public static List<EntityPatient> LLPatientList()
        {
            return DALPatient.PatientList();
        }

        public static List<EntityPatient> LLPatientListForDoctor(string entityDoctor)
        {
            return DALPatient.PatientListForDoctor(entityDoctor);
        }


        public static int LLPatientAdd(EntityPatient entityPatient)
        {
            if (entityPatient.C_patient_id_no != "" && entityPatient.C_patient_surname != "" && entityPatient.C_patient_name != "" && entityPatient.C_patient_policlinic_name!="")
            {

                return DALPatient.PatientAdd(entityPatient);
            }
            else
            {
                return -1;
            }
        }
        public static bool LLPatientDelete(long pat)
        {
            if (pat >= 1)
            {
                return DALPatient.PatientDelete(pat);
            }
            else
            {
                return false;
            }
        }
        public static bool LLPatientUpdate(EntityPatient entityPatient)
        {
            if (entityPatient.C_patient_name != "" && entityPatient.C_patient_surname != "" && entityPatient.C_patient_policlinic_name != "")
            {
                return DALPatient.PatientUpdate(entityPatient);
            }
            else
            {
                return false;
            }
        }

        public static EntityPatient LLPatientBring(EntityPatient controlPatient)
        {
            if (controlPatient.C_patient_id_no.Length == 11)
            {
                EntityPatient  entityPatient = new EntityPatient();
                entityPatient = DALPatient.PatientBring(controlPatient);

                if (entityPatient.C_patient_id_no == controlPatient.C_patient_id_no)
                {
                    
                    return entityPatient;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
            

        }
    }
}
