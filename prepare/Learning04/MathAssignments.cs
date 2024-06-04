class MathAssignments:Assignments
{
    private string _problems;
    private string _textBookSection;
    public MathAssignments(string studentName, string subject, string textBookSection, string problems)
    :base(studentName, subject)
    {
        _problems = problems;
        _textBookSection = textBookSection;
    }
    public string GetHomeworkList(){
        return $"{GetSummary()}\nSection {_textBookSection} Problems {_problems}";
    }
}