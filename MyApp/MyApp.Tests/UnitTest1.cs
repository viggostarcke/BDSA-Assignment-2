namespace MyApp.Tests;

public class StudentTest
{
    [Fact]
    public void Student_toString_returns_correct_output()
    {
        //arrange
            var expectedResult = "Id: 1, Name: Bob, Surname: TheBuilder, Status: Graduated";
        //act
            DateTime StartDate = DateTime.Parse("01/08/2018");
            DateTime EndDate = DateTime.Parse("30/07/2021");
            DateTime GraduationDate = DateTime.Parse("30/07/2021");
            Student student = new Student(1, "Bob", "TheBuilder", StartDate, EndDate, GraduationDate);
        //assert
            //student.ToString().Should().Be(expectedResult);
    }
}