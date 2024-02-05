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

    internal static bool IsIdValid(string drink)
    {
        if (String.IsNullOrEmpty(drink))
        {
            return false;
        }

        foreach (char c in drink)
        {
            if (!Char.IsDigit(c))
                return false;
        }

        return true;
    }
}