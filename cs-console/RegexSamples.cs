
using System.Text.RegularExpressions;

public class RegexSamples
{
    public void FindAndReplace()
    {

        string input = "This is   text with   far  too   much   " +
                     "white space.";
        string pattern = "\\s+";
        string replacement = " ";
        string result = Regex.Replace(input, pattern, replacement);

        Console.WriteLine("Original String: {0}", input);
        Console.WriteLine("Replacement String: {0}", result);
    }
}