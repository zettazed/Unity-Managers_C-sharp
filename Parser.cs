using System.Linq;
public static class Parser
{
    public static int IntParsing(string text)
    {
        int parsingInt = 0;
        int.TryParse(string.Join("", text.Where(c => char.IsDigit(c))), out parsingInt);
        return parsingInt;
    }
}