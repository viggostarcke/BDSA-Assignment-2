public class Student {
    public int Id { get; init; }
    public string GivenName { get; set; }
    public string Surname { get; set; }
    public Status Status { get; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime GraduationDate { get; set; }

    public Student(int id, string givenName, string surname, DateTime _startDate, DateTime _endDate, DateTime _graduationDate)
    {
        Id = id;
        GivenName = givenName;
        Surname = surname;
        Status = DetermineStatus(_startDate, _endDate, _graduationDate);
        StartDate = _startDate;
        EndDate = _endDate;
        GraduationDate = _graduationDate;
    }

    Status DetermineStatus(DateTime SD, DateTime ED, DateTime GD) 
    {
        if (DateTime.Now > ED.Date)
        {
            if (ED.Date == GD.Date) return Status.Graduated; 
            return Status.Dropout;
        }
        if (DateTime.Now < SD.Date)
        {
            return Status.New;
        }
        return Status.Active;
    }

    public string ToString() 
    {
        return "Id: " + Id + ", Name: " + GivenName + ", Surname: " + Surname + ", Status: " + Status;
    }
}

public enum Status{New, Active, Dropout, Graduated}