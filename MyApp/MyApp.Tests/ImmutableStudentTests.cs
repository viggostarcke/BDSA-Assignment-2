namespace MyApp.Tests;

public class ImmutableStudentTests {
    [Fact]
    public void ImmutableStudent_recordToString_returns_graduated_output()
    {
        //arrange
        var ExpectedResult = "ImmutableStudent { Id = 1, GivenName = Bob, Surname = TheBuilder, Status = Graduated, StartDate = 01/08/2018 00:00:00, EndDate = 30/07/2021 00:00:00, GraduationDate = 30/07/2021 00:00:00 }";
        DateTime StartDate = DateTime.Parse("01/08/2018");
        DateTime EndDate = DateTime.Parse("30/07/2021");
        DateTime GraduationDate = DateTime.Parse("30/07/2021");
        ImmutableStudent immutableStudent = new (1, "Bob", "TheBuilder", StartDate, EndDate, GraduationDate);

        //act
        var result = $"{ immutableStudent }";

        //assert
        result.Should().Be(ExpectedResult);
    }

    [Fact]
    public void ImmutableStudent_recordCompare_returns_true() 
    {
        //arrange
        DateTime StartDate = DateTime.Parse("01/08/2018");
        DateTime EndDate = DateTime.Parse("30/07/2021");
        DateTime GraduationDate = DateTime.Parse("30/07/2021");
        ImmutableStudent immutableStudent1 = new (1, "Bob", "TheBuilder", StartDate, EndDate, GraduationDate);
        ImmutableStudent immutableStudent2 = new (1, "Bob", "TheBuilder", StartDate, EndDate, GraduationDate);

        //act
        var result = Equals(immutableStudent1, immutableStudent2);

        //assert
        result.Should().Be(true);
    }

    [Fact]
    public void ImmutableStudent_recordCompare_returns_false() 
    {
        //arrange
        DateTime StartDate = DateTime.Parse("01/08/2018");
        DateTime EndDate = DateTime.Parse("30/07/2021");
        DateTime GraduationDate = DateTime.Parse("30/07/2021");
        ImmutableStudent immutableStudent1 = new (2, "Patrick", "Bateman", StartDate, EndDate, GraduationDate);
        ImmutableStudent immutableStudent2 = new (1, "Bob", "TheBuilder", StartDate, EndDate, GraduationDate);

        //act
        var result = Equals(immutableStudent1, immutableStudent2);

        //assert
        result.Should().Be(false);
    }
}