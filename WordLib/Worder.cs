namespace WordLib;
public class Worder
{
    public string IsPalindromeWordChecker(string inputWord)
    {

        
        if (string.IsNullOrEmpty(inputWord))
        {
            throw new ArgumentException("Input string cannot be empty. Please try again");
        }

        string inputString, reverseString = string.Empty;
        inputString = inputWord;


      
        for (int i = inputWord.Length - 1; i >= 0; i--)
        {
            reverseString += inputWord[i];
        }

        return reverseString;



    }

    public int CheckingStringLength(string inputWord)
    {

        if (string.IsNullOrEmpty(inputWord))
        {
            throw new ArgumentException("Input string cannot be empty. Please try again");
        }

        int numbersInLetter = inputWord.Length;

        return numbersInLetter;
    }
}