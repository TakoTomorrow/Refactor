namespace CodeSmells.ChangePreventers.ParallelInheritanceHierarchies;

public abstract class Teacher
{
    public abstract string ShowCurriculum();
}

public abstract class Curriculum
{
    public abstract string GetPlannedEducationalOutcomes();
}