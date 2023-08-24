using Microsoft.VisualStudio.TestPlatform.Utilities;
using WordLib;
namespace WordLibTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void IsPalindrome()
    {
        // Create an instance to test:
        Worder worder = new Worder();

        // expected output
        string expectedResult = "radar";
        string inputWord = "radar";
        // Run the method under test:
        string actualResult = worder.IsPalindromeWordChecker(inputWord);

        // Assert / Verify the result:
        Assert.AreEqual(expectedResult, actualResult);


    }

    [TestMethod]

    public void IsPalindromeThrowsException()
    {
        
        Worder worder = new Worder();

        // expected output
        string inputWord = null;

        // Assert / Verify the result:
        Assert.ThrowsException<ArgumentException>(() => worder.IsPalindromeWordChecker(inputWord));


    }

    [TestMethod]

    public void StringLenghtCheck()
    {
        // Create an instance to test:
        Worder worder = new Worder();

        // expected output
        int expectedOutput = 6;
        string inputWord = "London";

        // Run the method under test:
        int actualResult = worder.CheckingStringLength(inputWord);
        // Assert / Verify the result:
        Assert.AreEqual(expectedOutput, actualResult);


    }

    [TestMethod]

    public void StringLenghtCheckThrowsException()
    {
        // Create an instance to test:
        Worder worder = new Worder();

        // expected output
        string inputWord = null;

        // Assert / Verify the result:
        Assert.ThrowsException<ArgumentException>(() => worder.CheckingStringLength(inputWord));


    }





}


