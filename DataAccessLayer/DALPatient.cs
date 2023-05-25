using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiyLayer;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class DALPatient
    {
        public static List<EntityPatient> PatientList()
        {
            List<EntityPatient> values = new List<EntityPatient>();
            SqlCommand command = new SqlCommand("SELECT * FROM TBLPATIENT", Connection.conn);

            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                EntityPatient entPat = new EntityPatient();
                entPat.C_patient_id_no = dataReader["patient_id_no"].ToString();
                entPat.C_patient_name = dataReader["patient_name"].ToString();
                entPat.C_patient_surname = dataReader["patient_surname"].ToString();
                entPat.C_patient_policlinic_name = dataReader["policlinic_name"].ToString();

                values.Add(entPat);
            }
            dataReader.Close();
            return values;
        }
        public static List<EntityPatient> PatientListForDoctor(string entityDoctor)
        {
            List<EntityPatient> values = new List<EntityPatient>();
            SqlCommand command = new SqlCommand("Select p.patient_id_no,patient_name,patient_surname, p.policlinic_name From TBLAPPOINTMENT a INNER JOIN TBLPATIENT p ON a.patient_id_no = p.patient_id_no WHERE doctor_id_no = @P1", Connection.conn);

            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            command.Parameters.AddWithValue("@P1", entityDoctor);

            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                EntityPatient entPat = new EntityPatient();
                entPat.C_patient_name = dataReader["patient_name"].ToString();
                entPat.C_patient_surname = dataReader["patient_surname"].ToString();
                entPat.C_patient_id_no = dataReader["patient_id_no"].ToString();
                entPat.C_patient_policlinic_name = dataReader["policlinic_name"].ToString();

                values.Add(entPat);
            }
            dataReader.Close();
            return values;
        }


        public static int PatientAdd(EntityPatient entityPatient)
        {
            SqlCommand command = new SqlCommand("INSERT INTO TBLPATIENT (patient_id_no,patient_name,patient_surname,policlinic_name) VALUES (@P1,@P2,@P3,@P4)", Connection.conn);

            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }

            command.Parameters.AddWithValue("@P1", entityPatient.C_patient_id_no);
            command.Parameters.AddWithValue("@P2", entityPatient.C_patient_name);
            command.Parameters.AddWithValue("@P3", entityPatient.C_patient_surname);
            command.Parameters.AddWithValue("@P4", entityPatient.C_patient_policlinic_name);


            return command.ExecuteNonQuery();
        }
        public static bool PatientDelete(long pat)
        {
            SqlCommand command = new SqlCommand("DELETE FROM TBLPATIENT WHERE patient_id_no = @P1", Connection.conn);

            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            command.Parameters.AddWithValue("@P1", pat);
            return command.ExecuteNonQuery() > 0;

        }
        public static bool PatientUpdate(EntityPatient entityPatient)
        {
            SqlCommand command = new SqlCommand("UPDATE TBLPATIENT SET patient_name=@P1,patient_surname=@P2, policlinic_name=@P3 WHERE patient_id_no=@P4", Connection.conn);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            command.Parameters.AddWithValue("@P1", entityPatient.C_patient_name);
            command.Parameters.AddWithValue("@P2", entityPatient.C_patient_surname);
            command.Parameters.AddWithValue("@P3", entityPatient.C_patient_policlinic_name);
            command.Parameters.AddWithValue("@P4", entityPatient.C_patient_id_no);
            

            return command.ExecuteNonQuery() > 0;

        }

        public static EntityPatient PatientBring(EntityPatient entityPatient)
        {
            EntityPatient values = new EntityPatient();
            SqlCommand command = new SqlCommand("SELECT * FROM TBLPATIENT WHERE patient_id_no = @P1", Connection.conn);


            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            command.Parameters.AddWithValue("@P1", entityPatient.C_patient_id_no);

            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                values.C_patient_id_no = dataReader["patient_id_no"].ToString();
                values.C_patient_name = dataReader["patient_name"].ToString();
                values.C_patient_surname = dataReader["patient_surname"].ToString();
                values.C_patient_policlinic_name = dataReader["policlinic_name"].ToString();

            }
            dataReader.Close();
            return values;
        }

    }
}
