namespace CodeSmells.ChangePreventers.ParallelInheritanceHierarchies;

public class PhysicalEducationTeacher : Teacher
{
    public override string ShowCurriculum()
    {
        return new PhysicalEducationCurriculum().GetPlannedEducationalOutcomes();
    }
}

public class PhysicalEducationCurriculum: Curriculum
{
    public override string GetPlannedEducationalOutcomes()
    {
        return "Educational outcomes for physical learning";
    }
}
