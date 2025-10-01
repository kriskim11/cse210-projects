using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

public class WritingAssignment : Assignment
{
    private string _title;
    public WritingAssignment(string studentName, string assignmentTitle, string title)
        : base(studentName, assignmentTitle)
    {
        _title = title;
    }

    public string GetWritingInfo()
    {
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}  