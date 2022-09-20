var i = 1;
public class Student {
    public int Id { get; init; }
    public string GivenName { get; set; }
    public string Surname { get; set; }
    public Status Status { get; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime GraduationDate { get; set; }


}

public enum Status{New, Active, Dropout, Graduated}