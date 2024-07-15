namespace CodeSmells.DivergentChange.ChangePreventers;

public class Patient
{
    public string PatientName { get; private set; }
    public List<string> TreatmentHistory { get; private set; }

    public Patient(string patientName, Array<string> treatmentHistory)
    {
        PatientName = patientName;
        TreatmentHistory = treatmentHistory.ToList();
    }
}