ImmutableStudent immutableStudent = new ImmutableStudent(1, "bob", "thebuilder", DateTime.Parse("01/08/2020"), DateTime.Parse("30/07/2023"), DateTime.Parse("30/07/2023"));

System.Console.WriteLine(immutableStudent.ToString());

public record ImmutableStudent 
{
    public int Id { get; init; }
    public string GivenName { get; init; }
    public string Surname { get; init; }
    public Status Status { get; }
    public DateTime StartDate { get; init; }
    public DateTime EndDate { get; init; }
    public DateTime GraduationDate { get; init; }

    public ImmutableStudent(int id, string givenName, string surname, DateTime _startDate, DateTime _endDate, DateTime _graduationDate)
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
}