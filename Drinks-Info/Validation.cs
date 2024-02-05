namespace Drinks_Info;

public class Validation
{
    internal static bool IsStringValid(string category)
    {
        if (String.IsNullOrEmpty(category))
        {
            return false;
        }

        foreach (char c in category)
        {
            if (!Char.IsLetter(c) && c != '/' && c != ' ')
                return false;
        }

        return true;
    }
}