
using System.Text.RegularExpressions;

public class RegexSamples{
    public void FindAndReplace(){

        var input = "";
        var styleRegEx = new Regex("(style\\s*=\\s*\"(?<inner>.*?)\")", RegexOptions.IgnoreCase);
        var styleMatch = styleRegEx.Match(input);
        if (styleMatch.Success)
        {
            //TODO
        }
    }
}