namespace StudentWebsite.Models;

public class Student
{
    public string Name { get; set; } = string.Empty;
    public string Program { get; set; } = string.Empty;
    public string Year { get; set; } = string.Empty;
    public string Introduction { get; set; } = string.Empty;
    public string Background { get; set; } = string.Empty;
    public List<string> Interests { get; set; } = new();
    public string CareerGoal { get; set; } = string.Empty;
}
