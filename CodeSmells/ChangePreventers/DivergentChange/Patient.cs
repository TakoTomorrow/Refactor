namespace CodeSmells.ChangePreventers.DivergentChange;

public class Patient(string patientName, IEnumerable<string> treatmentHistory)
{
    public string PatientName { get; private set; } = patientName;

    public List<string> TreatmentHistory { get; private set; } = treatmentHistory.ToList();

    public void ExportTreatmentHistory(string fileName)
    {
        using var writer = new StreamWriter(fileName);
        foreach (var treat in TreatmentHistory)
        {
            writer.WriteLine(json);
        }
    }
}