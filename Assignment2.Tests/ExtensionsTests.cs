namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Fact]
    public void IsSecure_Should_Return_True()
    {
        //Arrange
        bool expected = true;
        Uri uri = new Uri("https://github.com/itu-bdsa");
        //Act
        bool actual = uri.IsSecure();
        //Assert
        actual.Should().Be(expected);
    }

    [Fact]
    public void IsSecure_Should_Return_False()
    {
        //Arrange
        bool expected = false;
        Uri uri = new Uri("http://sport.tv2.dk/");
        //Act
        bool Actual = uri.IsSecure();
        //Assert
        Actual.Should().Be(expected);
    }

    [Fact]
    public void WordCount_Should_Return_4()
    {
        //Arrange
        int expected = 4;
        string sentence = "Hello there, i'm Bob!";
        //Act
        int wordCount = sentence.WordCount();
        //Assert
        wordCount.Should().Be(expected);
    }
}
