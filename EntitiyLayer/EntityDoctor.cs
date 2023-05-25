using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer
{
    // Classımız diğer katmanlardan erişime açık olması için public

    public class EntityDoctor
    {
        // Alanlar sadece kontroller dahilinle değiştirilebilmesi için private
        // sadece metodlar üzerinden değişiklikleri yapılacak

        private string c_doctor_id_no;
        private string c_doctor_name;
        private string c_doctor_surname;
        private string c_doctor_policlinic_name;
        private string c_doctor_phone_number;
        private string c_doctor_password;

        //Doctor getter-setter Methods

        public string C_doctor_id_no { get => c_doctor_id_no; set => c_doctor_id_no = value; }
        public string C_doctor_name { get => c_doctor_name; set => c_doctor_name = value; }
        public string C_doctor_surname { get => c_doctor_surname; set => c_doctor_surname = value; }
        public string C_doctor_policlinic_name { get => c_doctor_policlinic_name; set => c_doctor_policlinic_name = value; }
        public string C_doctor_phone_number { get => c_doctor_phone_number; set => c_doctor_phone_number = value; }
        public string C_doctor_password { get => c_doctor_password; set => c_doctor_password = value; }
    }
}
