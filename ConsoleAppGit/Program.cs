



//Write a c# program demonstarte reverse of a string

public class ReverseString
{
    public static void Main(String[] args)
    {
        string str = "Enjoy code";
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        string reverseString = new string(charArray);
        Console.WriteLine("Reverse of string is: " + reverseString);
    }
}

