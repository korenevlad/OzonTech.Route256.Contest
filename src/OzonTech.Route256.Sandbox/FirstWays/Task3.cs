namespace OzonTech.Route256.Sandbox.FirstWays;

public class Task3
{
    public static string SolveTask3(string n, string input, string output)
    {
        var nInt = int.Parse(n);
        
        var inputResult = ReturnMassiveInt(input);
        if (inputResult.Item1 == "no") { return "no"; }
        var inputMasInt = inputResult.Item2;
        
        var outputResult = ReturnMassiveInt(output);
        if (outputResult.Item1 == "no") { return "no"; }
        var outputMasInt = outputResult.Item2;
        
        if (inputMasInt.Length != outputMasInt.Length) { return "no"; }
        Array.Sort(inputMasInt);
        var pointer = 0;
        while (pointer < inputMasInt.Length)
        {
            if (inputMasInt[pointer] != outputMasInt[pointer]) { return "no"; }
            pointer++;
        }
        return "yes";
    }

    private static (string, int[]) ReturnMassiveInt(string str)
    {
        var masStr = str.Split(' ');
        var masListTemp = new List<int>();
        foreach (var item in masStr)
        {
            if (int.TryParse(item, out int itemSeccessParsed))
            {
                if (item.ToCharArray()[0] == '0' || (item.ToCharArray()[0] == '-' && item.ToCharArray()[1] == '0'))
                {
                    return ("no", masListTemp.ToArray());
                }
                masListTemp.Add(itemSeccessParsed);
            }
            else { return ("no", masListTemp.ToArray()); }
        }
        return ("yes" , masListTemp.ToArray());
    } 
}