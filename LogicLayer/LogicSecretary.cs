using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiyLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicSecretary
    {
        public static List<EntitySecretary> LLSecretaryList()
        {
            return DALSecretary.SecretaryList();
        }

        public static int LLSecretaryAdd(EntitySecretary entitSecretary)
        {
            if (entitSecretary.C_secretary_id_no != "" && entitSecretary.C_secretary_name != "" && entitSecretary.C_secretary_surname != "")
            {

                return DALSecretary.SecretaryAdd(entitSecretary);
            }
            else
            {
                return -1;
            }
        }
        public static int LLAppointmetAdd(EntityDoctor entityDoctor, EntityPatient entityPatient, string entityDate)
        {
            if (entityDoctor.C_doctor_name != "" && entityDoctor.C_doctor_surname != "" && entityPatient.C_patient_id_no != "")
            {

                return DALSecretary.AppointmentAdd(entityDoctor, entityPatient, entityDate);
            }
            else
            {
                return -1;
            }

        }

        public static int LLAppointmetCheck(EntityDoctor entityDoctor, EntityPatient entityPatient, string entityDate)
        {

            if (entityDoctor.C_doctor_id_no.ToString().Length != 11)
            {
                return -11;
            }
            else
            {
                return DALSecretary.AppointmentCheck(entityDoctor, entityPatient,entityDate); ;
            }

        }

        public static bool LLSecretaryDelete(long sec)
        {
            if (sec >= 1)
            {
                return DALSecretary.SecretaryDelete(sec);
            }
            else
            {
                return false;
            }
        }
        public static bool LLSecretaryUpdate(EntitySecretary entitySecretary)
        {
            if (entitySecretary.C_secretary_name != "" && entitySecretary.C_secretary_surname != "" )
            {
                return DALSecretary.SecretaryUpdate(entitySecretary);
            }
            else
            {
                return false;
            }
        }

        public static int LLSecretaryLogin(EntitySecretary loginSecretary)
        {
            if (loginSecretary.C_secretary_id_no.Length == 11 && loginSecretary.C_secretary_password.Length > 0)
            {
                EntitySecretary entitySecretarys = new EntitySecretary();
                entitySecretarys = DALSecretary.SecretaryIDLogin(loginSecretary);
                if (entitySecretarys.C_secretary_id_no == loginSecretary.C_secretary_id_no)
                {
                    entitySecretarys = DALSecretary.SecretaryLogin(loginSecretary);
                    if (loginSecretary.C_secretary_password == entitySecretarys.C_secretary_password)
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
    }
}
