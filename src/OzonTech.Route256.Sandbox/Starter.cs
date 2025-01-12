using task1 = OzonTech.Route256.Sandbox.Task1;

namespace OzonTech.Route256.Sandbox;
public class Starter
{
    public static void Main(string [] args)
    {
        // Задача 1 - Удалить цифру из числа
        using var input = new StreamReader(Console.OpenStandardInput());
        using var output = new StreamWriter(Console.OpenStandardOutput());
        var count = int.Parse(input.ReadLine());
        for (var i = 0; i < count; i++)
        {
            var str = input.ReadLine();
            var result = task1.SolveTask1(str);
            output.WriteLine(result);
        }
    }
}