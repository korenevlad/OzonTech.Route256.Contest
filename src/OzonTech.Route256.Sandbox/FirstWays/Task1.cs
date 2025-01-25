namespace OzonTech.Route256.Sandbox.FirstWays;
public class Task1
{
    public static string SolveTask1(string str)
    {
        var charMas = str.ToCharArray();
        if (charMas.Length == 1) { return "0"; }
        var resultMas = new List<char>();
        var pointer = 0;
        while (pointer < charMas.Length - 1 
               && int.Parse(charMas[pointer].ToString()) >= int.Parse(charMas[pointer + 1].ToString()))
        {
            resultMas.Add(charMas[pointer]);
            pointer++;
        }
        if (pointer == charMas.Length - 1)
        {
            return string.Concat(resultMas);
        }
        else
        {
            pointer++;
            while (pointer < charMas.Length)
            {
                resultMas.Add(charMas[pointer]);
                pointer++;
            } 
        }
        return string.Concat(resultMas);
    }
}