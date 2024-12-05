using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patient_s_medical_record
{
    public abstract class MedicalRecord
    {
        public string PatientID { get; set; } // Идентификатор пациента
        public string PatientName { get; set; } // Имя пациента
        public DateTime RecordDate { get; private set; } // Дата записи (только для чтения)

        // Конструктор базового класса
        protected MedicalRecord(string patientID, string patientName)
        {
            PatientID = patientID;
            PatientName = patientName;
            RecordDate = DateTime.Now; // Устанавливаем текущую дату при создании карты
        }

        // Абстрактный метод
        public abstract string GetSummary();  // Возвращает краткое описание карты

        // Виртуальный метод 
        public virtual void AddNote(string note) { Console.WriteLine($"Заметка добавлена для {PatientName}: {note}"); } // Добавляет заметку к карте

        public virtual void PrintRecord() { Console.WriteLine($"ID пациента: {PatientID}, Имя: {PatientName}, Дата: {RecordDate}"); } // Выводит основную информацию о пациенте

        public virtual string GetDiagnosis() { return "Диагноз недоступен"; } // Виртуальный метод, возвращающий диагноз. 
        public void SetPatientName(string newName) { PatientName = newName; } 
    }
}
