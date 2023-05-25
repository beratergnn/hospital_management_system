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
    public class DALDoctor
    {
        public static List<EntityDoctor> DoctorList()
        {
            List<EntityDoctor> values = new List<EntityDoctor>();
            SqlCommand command = new SqlCommand("SELECT * FROM TBLDOCTOR", Connection.conn);

            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                EntityDoctor entDoc = new EntityDoctor();
                entDoc.C_doctor_id_no = dataReader["doctor_id_no"].ToString();
                entDoc.C_doctor_name = dataReader["doctor_name"].ToString();
                entDoc.C_doctor_surname = dataReader["doctor_surname"].ToString();
                entDoc.C_doctor_policlinic_name = dataReader["policlinic_name"].ToString();
                entDoc.C_doctor_phone_number = dataReader["doctor_phone_number"].ToString();
                entDoc.C_doctor_password = dataReader["doctor_password"].ToString();

                values.Add(entDoc);
            }
            dataReader.Close();
            return values;
        }
        public static int DoctorAdd(EntityDoctor entityDoctor)
        {
            SqlCommand command = new SqlCommand("INSERT INTO TBLDOCTOR (doctor_id_no,doctor_name,doctor_surname,policlinic_name,doctor_phone_number,doctor_password) VALUES (@P1,@P2,@P3,@P4,@P5,@P6)", Connection.conn);

            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }

            command.Parameters.AddWithValue("@P1", entityDoctor.C_doctor_id_no);
            command.Parameters.AddWithValue("@P2", entityDoctor.C_doctor_name);
            command.Parameters.AddWithValue("@P3", entityDoctor.C_doctor_surname);
            command.Parameters.AddWithValue("@P4", entityDoctor.C_doctor_policlinic_name);
            command.Parameters.AddWithValue("@P5", entityDoctor.C_doctor_phone_number);
            command.Parameters.AddWithValue("@P6", entityDoctor.C_doctor_password);

            return command.ExecuteNonQuery();
        }

        public static int ResultAdd(EntityDoctor entityDoctor,EntityPatient entityPatient,string sonuc,DateTime dateTime)
        {
            SqlCommand command = new SqlCommand("INSERT INTO TBLRESULTS (result_text,patient_id,doctor_id,policlinic_name,result_d_time) VALUES (@P1,@P2,@P3,@P4,@P5)", Connection.conn);

            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }

            command.Parameters.AddWithValue("@P1", sonuc);
            command.Parameters.AddWithValue("@P2", entityPatient.C_patient_id_no);
            command.Parameters.AddWithValue("@P3", entityDoctor.C_doctor_id_no);
            command.Parameters.AddWithValue("@P4", entityPatient.C_patient_policlinic_name);
            command.Parameters.AddWithValue("@P5", dateTime);


            return command.ExecuteNonQuery();
        }

        public static bool DoctorDelete(long doc)
        {
            SqlCommand command = new SqlCommand("DELETE FROM TBLDOCTOR WHERE doctor_id_no = @P1", Connection.conn);

            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            command.Parameters.AddWithValue("@P1", doc);
            return command.ExecuteNonQuery() > 0;

        }
        public static bool DoctorUpdate(EntityDoctor entityDoctor)
        {
            SqlCommand command = new SqlCommand("UPDATE TBLDOCTOR SET doctor_name=@P1,doctor_surname=@P2,policlinic_name=@P3,doctor_phone_number=@P4,doctor_password=@P5 WHERE doctor_id_no=@P6", Connection.conn);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            command.Parameters.AddWithValue("@P1", entityDoctor.C_doctor_name);
            command.Parameters.AddWithValue("@P2", entityDoctor.C_doctor_surname);
            command.Parameters.AddWithValue("@P3", entityDoctor.C_doctor_policlinic_name);
            command.Parameters.AddWithValue("@P4", entityDoctor.C_doctor_phone_number);
            command.Parameters.AddWithValue("@P5", entityDoctor.C_doctor_password);
            command.Parameters.AddWithValue("@P6", entityDoctor.C_doctor_id_no);

            return command.ExecuteNonQuery() > 0;

        }

        public static EntityDoctor DoctorLogin(EntityDoctor loginDoctor)
        {
            EntityDoctor values = new EntityDoctor();
            SqlCommand command = new SqlCommand("SELECT doctor_id_no, doctor_password FROM TBLDOCTOR WHERE doctor_id_no =@P1 and doctor_password = @P2", Connection.conn);

            command.Parameters.AddWithValue("@P1", loginDoctor.C_doctor_id_no);
            command.Parameters.AddWithValue("@P2", loginDoctor.C_doctor_password);

            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
               
                values.C_doctor_id_no = dataReader["doctor_id_no"].ToString();
                values.C_doctor_password = dataReader["doctor_password"].ToString();
            }
            dataReader.Close();
            return values;
            
        }
        public static EntityDoctor DoctorIDLogin(EntityDoctor loginDoctor)
        {
            EntityDoctor values = new EntityDoctor();
            SqlCommand command = new SqlCommand("SELECT doctor_id_no, doctor_password FROM TBLDOCTOR WHERE doctor_id_no =@P1", Connection.conn);

            command.Parameters.AddWithValue("@P1", loginDoctor.C_doctor_id_no);

            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {

                values.C_doctor_id_no = dataReader["doctor_id_no"].ToString(); 
            }
            dataReader.Close();
            return values;

        }
        public static List<EntityDoctor> GetDoctorforAppointment(string getDoctor)
        {
            List<EntityDoctor> valuesList = new List<EntityDoctor>();
            SqlCommand command = new SqlCommand("Select doctor_id_no, doctor_name, doctor_surname From TBLDOCTOR WHERE  policlinic_name =@P1", Connection.conn);

            command.Parameters.AddWithValue("@P1", getDoctor);

            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                EntityDoctor values = new EntityDoctor();
                values.C_doctor_id_no = dataReader["doctor_id_no"].ToString() ;
                values.C_doctor_name = dataReader["doctor_name"].ToString();
                values.C_doctor_surname = dataReader["doctor_surname"].ToString();
                valuesList.Add(values);
            }
            dataReader.Close();
            return valuesList;

        }


        public static List<String> ResultList(string getDoctor)
        {
            List<String> values = new List<String>();
            SqlCommand command = new SqlCommand("SELECT * FROM TBLRESULTS WHERE doctor_id=@P1", Connection.conn);

            command.Parameters.AddWithValue("@P1", getDoctor);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }

            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                EntityDoctor entDoc = new EntityDoctor();
                EntityPatient entPat = new EntityPatient();

                entDoc.C_doctor_id_no = dataReader["doctor_id"].ToString();
                entPat.C_patient_id_no = dataReader["patient_id"].ToString();
                entPat.C_patient_policlinic_name = dataReader["policlinic_name"].ToString();
                string text = dataReader["result_text"].ToString();
                string date = dataReader["result_d_time"].ToString();

                string son = entDoc.C_doctor_id_no+" "+ entPat.C_patient_id_no+" "+ entPat.C_patient_policlinic_name+" "+ text+" "+date;
                values.Add(son);
            }
            dataReader.Close();
            return values;
        }

        public static int toplamRandevuHasta(string polikinikAd)//PoliclinicPatientCount
        {
            int toplamRandevu = 0;

            SqlCommand toplamRandevuHasta = new SqlCommand(" SELECT COUNT(appointment_id) as appointmentCount FROM TBLAPPOINTMENT WHERE policlinic_name = @P1", Connection.conn);
            toplamRandevuHasta.Parameters.AddWithValue("@P1", polikinikAd);

            if (toplamRandevuHasta.Connection.State != ConnectionState.Open)
            {
                //Bağlantımızı komutumuz ile açıyoruz.
                toplamRandevuHasta.Connection.Open();
            }

            //Veritabanından okuma işlemi
            SqlDataReader dataOku = toplamRandevuHasta.ExecuteReader();


            //Data okuma devam ettiği sürece devam et
            while (dataOku.Read())
            {
                toplamRandevu = Convert.ToInt32(dataOku["appointmentCount"].ToString());
            }
            dataOku.Close();
            return toplamRandevu;
        }

        public static int toplamHastaDoktor(string doktorTC)
        {
            int toplamRandevu = 0;

            SqlCommand toplamRandevuHasta = new SqlCommand("SELECT COUNT(appointment_id) as appointmentCount FROM TBLAPPOINTMENT WHERE doctor_id_no = @P1", Connection.conn);
            toplamRandevuHasta.Parameters.AddWithValue("@P1", doktorTC);

            if (toplamRandevuHasta.Connection.State != ConnectionState.Open)
            {
                //Bağlantımızı komutumuz ile açıyoruz.
                toplamRandevuHasta.Connection.Open();
            }

            //Veritabanından okuma işlemi
            SqlDataReader dataOku = toplamRandevuHasta.ExecuteReader();


            //Data okuma devam ettiği sürece devam et
            while (dataOku.Read())
            {
                toplamRandevu = Convert.ToInt32(dataOku["appointmentCount"].ToString());
            }
            dataOku.Close();
            return toplamRandevu;
        }


    }
}
