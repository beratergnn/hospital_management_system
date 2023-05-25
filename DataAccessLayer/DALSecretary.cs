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
    public class DALSecretary
    {
        public static List<EntitySecretary> SecretaryList()
        {
            List<EntitySecretary> values = new List<EntitySecretary>();
            SqlCommand command = new SqlCommand("SELECT * FROM TBLSECRETARY", Connection.conn);

            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                EntitySecretary entSec = new EntitySecretary();
                entSec.C_secretary_id_no = dataReader["secretary_id_no"].ToString();
                entSec.C_secretary_name = dataReader["secretary_name"].ToString();
                entSec.C_secretary_surname = dataReader["secretary_surname"].ToString();
                entSec.C_secretary_phone_number = dataReader["secretary_phone_number"].ToString();
                entSec.C_secretary_password = dataReader["secretary_password"].ToString();


                values.Add(entSec);
            }
            dataReader.Close();
            return values;
        }
        public static int SecretaryAdd(EntitySecretary entitySecretary)
        {
            SqlCommand command = new SqlCommand("INSERT INTO TBLSECRETARY (secretary_id_no,secretary_name,secretary_surname,secretary_phone_number,secretary_password) VALUES (@P1,@P2,@P3,@P4,@P5)", Connection.conn);


            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }

            command.Parameters.AddWithValue("@P1", entitySecretary.C_secretary_id_no);
            command.Parameters.AddWithValue("@P2", entitySecretary.C_secretary_name);
            command.Parameters.AddWithValue("@P3", entitySecretary.C_secretary_surname);
            command.Parameters.AddWithValue("@P4", entitySecretary.C_secretary_phone_number);
            command.Parameters.AddWithValue("@P5", entitySecretary.C_secretary_password);

            return command.ExecuteNonQuery();
        }
        public static int AppointmentAdd(EntityDoctor entityDoctor, EntityPatient entityPatient, string entityDate)
        {
            SqlCommand command = new SqlCommand("INSERT TBLAPPOINTMENT(doctor_id_no,patient_id_no,policlinic_name,appointment_d_time) VALUES (@P1,@P2,@P3,@P4)", Connection.conn);

            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }

            command.Parameters.AddWithValue("@P1", entityDoctor.C_doctor_id_no);
            command.Parameters.AddWithValue("@P2", entityPatient.C_patient_id_no);
            command.Parameters.AddWithValue("@P3", entityDoctor.C_doctor_policlinic_name);
            command.Parameters.AddWithValue("@P4", entityDate);

            return command.ExecuteNonQuery();
        }

        public static int AppointmentCheck(EntityDoctor entityDoctor, EntityPatient entityPatient, string entityDate)
        {
            SqlCommand command = new SqlCommand("Select doctor_id_no, appointment_d_time, patient_id_no FROM TBLAPPOINTMENT WHERE doctor_id_no =@P1 AND appointment_d_time = @P2 AND patient_id_no =@P3 ", Connection.conn);

            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }

            command.Parameters.AddWithValue("@P1", entityDoctor.C_doctor_id_no);
            command.Parameters.AddWithValue("@P2", entityDate);
            command.Parameters.AddWithValue("@P3", entityPatient.C_patient_id_no);
            
            return command.ExecuteNonQuery();


        }


        public static bool SecretaryDelete(long sec)
        {
            SqlCommand command = new SqlCommand("DELETE FROM TBLSECRETARY WHERE secretary_id_no = @P1", Connection.conn);

            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            command.Parameters.AddWithValue("@P1", sec);
            return command.ExecuteNonQuery() > 0;

        }
        public static bool SecretaryUpdate(EntitySecretary entitySecretary)
        {
            SqlCommand command = new SqlCommand("UPDATE TBLSECRETARY SET secretary_name=@P1,secretary_surname=@P2,secretary_phone_number=@P3,secretary_password=@P4  WHERE secretary_id_no=@P5", Connection.conn);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            command.Parameters.AddWithValue("@P1", entitySecretary.C_secretary_name);
            command.Parameters.AddWithValue("@P2", entitySecretary.C_secretary_surname);
            command.Parameters.AddWithValue("@P3", entitySecretary.C_secretary_phone_number);
            command.Parameters.AddWithValue("@P4", entitySecretary.C_secretary_password);
            command.Parameters.AddWithValue("@P5", entitySecretary.C_secretary_id_no);
         

            return command.ExecuteNonQuery() > 0;

        }

        public static EntitySecretary SecretaryLogin(EntitySecretary entitySecretary)
        {
            EntitySecretary values = new EntitySecretary();
            SqlCommand command = new SqlCommand("SELECT secretary_id_no, secretary_password FROM TBLSECRETARY WHERE secretary_id_no =@P1 and secretary_password = @P2", Connection.conn);

            command.Parameters.AddWithValue("@P1", entitySecretary.C_secretary_id_no);
            command.Parameters.AddWithValue("@P2", entitySecretary.C_secretary_password);

            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {

                values.C_secretary_id_no = dataReader["secretary_id_no"].ToString();
                values.C_secretary_password = dataReader["secretary_password"].ToString();
            }
            dataReader.Close();
            return values;

        }
        public static EntitySecretary SecretaryIDLogin(EntitySecretary entitySecretary)
        {
            EntitySecretary values = new EntitySecretary();
            SqlCommand command = new SqlCommand("SELECT secretary_id_no, secretary_password FROM TBLSECRETARY WHERE secretary_id_no =@P1", Connection.conn);

            command.Parameters.AddWithValue("@P1", entitySecretary.C_secretary_id_no);

            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {

                values.C_secretary_id_no = dataReader["secretary_id_no"].ToString();
            }
            dataReader.Close();
            return values;

        }
    }
}
