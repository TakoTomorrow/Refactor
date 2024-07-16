namespace CodeSmells.ChangePreventers.ParallelInheritanceHierarchies;

public class PhysicalEducationTeacher : Teacher
{
    public override string ShowCurriculum()
    {
        return new Curriculum("physical").GetPlannedEducationalOutcomes();
    }
}
