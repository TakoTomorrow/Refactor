namespace Refactor.ChangePrevents;

public class Patient
{
    public string PatientName { get; private set; }
    public List<string> TreatmentHistory { get; private set; }

    public Patient(string patientName, Array<string> treatmentHistory)
    {
        PatientName = patientName;
        TreatmentHistory = treatmentHistory.ToList();
    }

    public void ExportTreatmentHistory(string fileName)
    {
        using var writer = new StreamWriter(fileName);
        foreach (var treatment in TreatmentHistory)
        {
            writer.WriteLine(treatment);
        }
    }
}