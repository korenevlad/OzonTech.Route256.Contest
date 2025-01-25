namespace OzonTech.Route256.Sandbox.SecondWays;
public class Task1
{
    public static void SolveTask1()
    {
        using var input = new StreamReader(Console.OpenStandardInput());
        using var output = new StreamWriter(Console.OpenStandardOutput())
        {
            AutoFlush = true
        };
        int k = int.Parse(input.ReadLine());
        for (; k > 0; --k)
        {
            var n = input.ReadLine();
            if (n.Length == 1)
            {
                output.WriteLine(0);
                continue;
            }
            bool flag = true;
            for (int i = 0; i < n.Length; ++i)
            {
                if (flag && (i == n.Length - 1 || n[i] - '0' < n[i + 1] - '0'))
                {
                    flag = false;
                    continue;
                }
                output.Write(n[i] - '0');
            }
            output.WriteLine();
        }
    }
}