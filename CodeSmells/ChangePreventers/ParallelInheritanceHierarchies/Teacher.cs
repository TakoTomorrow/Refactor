namespace CodeSmells.ChangePreventers.ParallelInheritanceHierarchies;

public abstract class Teacher
{
    public abstract string ShowCurriculum();
}

public class Curriculum
{
    private readonly string CurriculumName;

    public Curriculum(string name){
        CurriculumName = name;
    }

    public string GetPlannedEducationalOutcomes()
    {
        return $"Educational outcomes for {@CurriculumName} learning";
    }
}