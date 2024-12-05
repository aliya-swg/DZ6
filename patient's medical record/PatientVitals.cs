using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patient_s_medical_record
{
    public class PatientVitals : MedicalRecord
    {
        public int HeartRate { get; set; } // Частота пульса
        public double Temperature { get; set; } // Температура
        public int BloodPressureSystolic { get; set; } // Систолическое давление
        public int BloodPressureDiastolic { get; set; } // Диастолическое давление

        // Конструктор с параметрами
        public PatientVitals(string patientID, string patientName, int heartRate, double temperature, int systolic, int diastolic) : base(patientID, patientName)
        {
            HeartRate = heartRate;
            Temperature = temperature;
            BloodPressureSystolic = systolic;
            BloodPressureDiastolic = diastolic;
        }

        // Второй конструктор 
        public PatientVitals(string patientID, string patientName) : base(patientID, patientName) { }

        // Метод для получения краткого описания
        public override string GetSummary()
        {
            return $"Витальные показатели для {PatientName}: Пульс - {HeartRate}, Температура - {Temperature}, Давление - {BloodPressureSystolic}/{BloodPressureDiastolic}";
        }

        public override void AddNote(string note)
        {
            base.AddNote(note);
            Console.WriteLine($"Добавлена в запись витальных показателей!");
        }

        public override string GetDiagnosis() { return "Диагноз недоступен в витальных показателях"; }

        public string GetBloodPressure() { return $"{BloodPressureSystolic}/{BloodPressureDiastolic}"; } // Получение артериального давления

        public void UpdateBloodPressure(int systolic, int diastolic) //Пример метода изменения данных
        {
            BloodPressureSystolic = systolic;
            BloodPressureDiastolic = diastolic;
        }
    }


}
