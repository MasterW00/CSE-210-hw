class Assignments
{
    private string _studentName;
    private string _subject;
    public Assignments(string studentName, string subject){
        _studentName = studentName;
        _subject = subject;
    }
    public string GetSummary(){
        return $"{_studentName} - {_subject}";
    }
}