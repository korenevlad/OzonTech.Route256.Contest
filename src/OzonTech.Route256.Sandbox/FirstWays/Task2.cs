namespace OzonTech.Route256.Sandbox.FirstWays;

public class Task2
{
    public static string SolveTask2(string str)
    {
        var charMas = str.ToCharArray();
        if (charMas[0] != 'M')
        {
            return "NO";
        }
        var result = "YES";
        var pointer = 0;
        while (pointer < charMas.Length - 1)
        {
            if (!CheckValidNextSymbol(charMas[pointer], charMas[pointer + 1]))
            {
                return "NO";
            }
            pointer++;
        }
        if (charMas[charMas.Length - 1] != 'D')
        {
            result = "NO";
        }
        return result;
    }

    public static bool CheckValidNextSymbol(char first, char second)
    {
        return ((first == 'M' && second == 'C')
                || (first == 'M' && second == 'R')
                || (first == 'M' && second == 'D')
                || (first == 'R' && second == 'C')
                || (first == 'C' && second == 'M')
                || (first == 'D' && second == 'M'));
    }
}