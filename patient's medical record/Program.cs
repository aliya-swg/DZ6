using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patient_s_medical_record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Пример использования
        PatientVitals vitals = new PatientVitals("12345", "Алия Тутов", 73, 97.4, 110, 90);
        PatientDiagnosis diagnosis = new PatientDiagnosis("12345", "Алия Тутова", "Первомативный аппендиция", "Постельный режим, диета");

        vitals.PrintRecord();
        Console.WriteLine(vitals.GetSummary());
        vitals.AddNote("Пациент чувствует себя немного лучше.");

        diagnosis.PrintRecord();
        Console.WriteLine(diagnosis.GetSummary());
        diagnosis.AddMedication("Каламин");
        Console.WriteLine(diagnosis.GetSummary());

        Console.WriteLine($"Диагноз из записи диагноза: {diagnosis.GetDiagnosis()}");
        Console.WriteLine($"Диагноз из записи витальных показателей: {vitals.GetDiagnosis()}");
        }
    }
}
