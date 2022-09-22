namespace Assignment2.Tests;

public class QueriesTests
{
    [Fact]
    public void Query_Returns_4_wizards_By_Rowling()
    {
        //Arrange
        int expectedCount = 4;

        //Act
        var actualWizards = Queries.Get_All_Wizards_Name_By_Rowling_With_Linq();
        var actualWizards2 = Queries.Get_All_Wizards_By_Rowling_With_Extensions();
        
        //Assert
        actualWizards.Count().Should().Be(expectedCount);
        actualWizards2.Count().Should().Be(expectedCount);
    }

    [Fact]
    public void Query_Returns_1977_As_First_Year_Of_Sith() 
    {
        //Arrange
        int expectedYear = 1977;
        //Act
        int? actualLinq = Queries.Get_First_Year_Of_Sith_Linq();
        int? actualExtensions = Queries.Get_First_Year_Of_Sith_Extensions();
        //Assert
        actualLinq.Should().Be(expectedYear);
        actualExtensions.Should().Be(expectedYear);
    }

    [Fact]
    public void Query_Returns_Harry_Potter_Tuples() 
    {
        //Arrange
        int expectedCount = 4;
        HashSet<(string, int)> expectedWizards = new HashSet<(string, int)>();
        expectedWizards.Add(("Harry Potter", 1997));
        expectedWizards.Add(("Voldemort", 1997));
        expectedWizards.Add(("Sirius Black", 1999));
        expectedWizards.Add(("Severus Snape", 1997));
        
        //Act
        var actualLinq = Queries.Get_Harry_Potter_Tuples_Linq();
        var actualExtensions = Queries.Get_Harry_Potter_Tuples_Extensions();

        //Assert
        actualLinq.Count().Should().Be(expectedCount);
        actualExtensions.Count().Should().Be(expectedCount);
        actualLinq.Should().BeEquivalentTo(expectedWizards);
        actualExtensions.Should().BeEquivalentTo(expectedWizards);
    }

    [Fact]
    public void Query_Returns_Wizard_Grouped_By_Creator() 
    {
        //Arrange
        List<string> expectedList = new List<string> {"Gargamel", "Gandalf", "Sauron", "Harry Potter", "Severus Snape", "Sirius Black", "Voldemort", "Melisandre", "Darth Sidious", "Darth Vader", "Kylo Ren", "Rey Palpatine"};

        //Act
        var actualLinq = Queries.Get_Wizards_Grouped_By_Creator_Reverse_Order_Linq();
        var actualExtensions = Queries.Get_Wizards_Grouped_By_Creator_Reverse_Order_Extensions();

        //Assert
        actualLinq.Should().Equal(expectedList);
        actualExtensions.Should().Equal(expectedList);
    }
}
