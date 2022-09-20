var i = 1;
public class Student {
    public int Id { get; init; }
    public string GivenName { get; set; }
    public string Surname { get; set; }
    public Status Status { get; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime GraduationDate { get; set; }

    public Student(int id, string givenName, string surname, DateTime startDate, DateTime endDate, DateTime graduationDate)
    {
        Id = id;
        GivenName = givenName;
        Surname = surname;
        StartDate = startDate;
        EndDate = endDate;
        GraduationDate = graduationDate;
    }
}

public enum Status{New, Active, Dropout, Graduated}