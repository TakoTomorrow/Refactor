namespace CodeSmells.ChangePreventers.ParallelInheritanceHierarchies;

public class LanguageTeacher : Teacher
{
    public override string ShowCurriculum()
    {
        return new LanguageCurriculum().GetPlannedEducationalOutcomes();
    }
}

public class LanguageCurriculum : Curriculum
{
    public override string GetPlannedEducationalOutcomes()
    {
        return "Educational outcomes for language learning";
    }
}