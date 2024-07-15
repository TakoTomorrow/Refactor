namespace CodeSmells.DivergentChange.ChangePreventers;

public class PatientFileService : IPatientFileService
{
    public static void ExportTreatmentHistory(string fileName, List<string> treatments)
    {
        var json = JsonSerializer.Serialize(treatments);
        using var writer = new StreamWriter(fileName);
        writer.Write(json);
    }
}