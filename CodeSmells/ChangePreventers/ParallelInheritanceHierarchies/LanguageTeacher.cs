namespace CodeSmells.ChangePreventers.ParallelInheritanceHierarchies;

public class LanguageTeacher : Teacher
{
    public override string ShowCurriculum()
    {
        return new Curriculum("language").GetPlannedEducationalOutcomes();
    }
}