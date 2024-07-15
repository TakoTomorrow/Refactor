namespace CodeSmells.DivergentChange.ChangePreventers;

public interface IPatientFileService
{
    public static void ExportTreatmentHistory(string fileName, List<string> treatments);
}