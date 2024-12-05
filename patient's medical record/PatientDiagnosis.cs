using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patient_s_medical_record
{
    public class PatientDiagnosis : MedicalRecord
    {
        public string Diagnosis { get; set; } // Диагноз
        public string Treatment { get; set; } // Лечение
        public List<string> Medications { get; set; } = new List<string>(); // Список лекарств

        // Конструктор
        public PatientDiagnosis(string patientID, string patientName, string diagnosis, string treatment) : base(patientID, patientName)
        {
            Diagnosis = diagnosis;
            Treatment = treatment;
        }

        // Второй конструктор
        public PatientDiagnosis(string patientID, string patientName) : base(patientID, patientName) { }

        // Mетод для получения краткого описания
        public override string GetSummary()
        {
            string medicationList = string.Join(", ", Medications); // Объединяем лекарства в строку
            return $"Диагноз для {PatientName}: {Diagnosis}, Лечение: {Treatment}, Лекарства: {medicationList}";
        }
        public override string GetDiagnosis() { return Diagnosis; } //Возвращает диагноз

        public void AddMedication(string medication) { Medications.Add(medication); } // Добавление лекарства
        public void RemoveMedication(string medication) { Medications.Remove(medication); } // Удаление лекарства

        public string GetTreatmentPlan() { return Treatment; } // Получение плана лечения

        public void UpdateTreatment(string newTreatment) { Treatment = newTreatment; } //Изменение плана лечения


    }
}
