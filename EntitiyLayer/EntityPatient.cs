using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer

{  
    // Classımız diğer katmanlardan erişime açık olması için public

    public class EntityPatient
    {

        // Alanlar sadece kontroller dahilinle değiştirilebilmesi için private
        // sadece metodlar üzerinden değişiklikleri yapılacak
        private string c_patient_id_no;
        private string c_patient_name;
        private string c_patient_surname;
        private string c_patient_policlinic_name;

        // İlgili getter setter metodları
        public string C_patient_id_no { get => c_patient_id_no; set => c_patient_id_no = value; }
        public string C_patient_name { get => c_patient_name; set => c_patient_name = value; }
        public string C_patient_surname { get => c_patient_surname; set => c_patient_surname = value; }
        public string C_patient_policlinic_name { get => c_patient_policlinic_name; set => c_patient_policlinic_name = value; }
    }
}
