class WritingAssignments:Assignments
{
    string _title;

    public WritingAssignments(string studentName, string subject, string tile)
    :base(studentName, subject)
    {
        _title = tile;
    }
    public string GetWritingInformation(){
        return $"{GetSummary()}\n{_title}";
    }
}