using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer
{
    // Classımız diğer katmanlardan erişime açık olması için public

    public class EntitySecretary
    {
        // Alanlar sadece kontroller dahilinle değiştirilebilmesi için private
        // sadece metodlar üzerinden değişiklikleri yapılacak
        private string c_secretary_id_no;
        private string c_secretary_name;
        private string c_secretary_surname;
        private string c_secretary_password;
        private string c_secretary_phone_number;


        // İlgili getter setter metodları

        public string C_secretary_id_no { get => c_secretary_id_no; set => c_secretary_id_no = value; }
        public string C_secretary_name { get => c_secretary_name; set => c_secretary_name = value; }
        public string C_secretary_surname { get => c_secretary_surname; set => c_secretary_surname = value; }
        public string C_secretary_password { get => c_secretary_password; set => c_secretary_password = value; }
        public string C_secretary_phone_number { get => c_secretary_phone_number; set => c_secretary_phone_number = value; }
    }
}
