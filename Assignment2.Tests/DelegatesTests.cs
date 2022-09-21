namespace Assignment2.Tests;

public delegate void PrintReverse(string input);
public delegate decimal Multiply(decimal d1, decimal d2);
public delegate bool WholeNumberAndString(int i, string input);
public class DelegatesTests
{
    [Fact]
    public void Delegate_Prints_In_Reverse_Order()
    {
        PrintReverse printReverse = delegate(string input) {
            var charArray = input.ToCharArray();
            Array.Reverse(charArray);
            var reversedString = new string(charArray);
        };
    }

    [Fact]
    public void Delegate_takes_two_dec_returns_product() 
    {
        Multiply multiply = delegate(decimal d1, decimal d2) {
            return d1*d2;
        };
        //Arrange
        decimal expected = 12;
        //Act
        decimal actual = multiply(3, 4);
        //Assert
        actual.Should().Be(expected);
    }

    [Fact]
    public void Delegate_takes_string_and_number_ouputs_true() 
    {
        WholeNumberAndString wholeNumberAndString = delegate(int number, string input) {
            input.Trim();
            int parsedString = int.Parse(input);
            return number == parsedString;
        };
        //Arrange
        bool expected = true;
        //Act
        bool actual = wholeNumberAndString(42, "   0042   ");
        //Assert
        actual.Should().Be(expected);
    }
}
