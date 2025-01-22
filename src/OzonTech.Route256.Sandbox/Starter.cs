using System.Text;
using task1 = OzonTech.Route256.Sandbox.Task1;
using task2 = OzonTech.Route256.Sandbox.Task2;
using task3 = OzonTech.Route256.Sandbox.Task3;
using task4 = OzonTech.Route256.Sandbox.Task4;

namespace OzonTech.Route256.Sandbox;
public class Starter
{
    public static void Main(string [] args)
    {
        using var input = new StreamReader(Console.OpenStandardInput());
        using var output = new StreamWriter(Console.OpenStandardOutput());
        var count = int.Parse(input.ReadLine());
        
        // Задача 1 - Удалить цифру из числа
        // for (var i = 0; i < count; i++)
        // {
        //     var str = input.ReadLine();
        //     var result = task1.SolveTask1(str);
        //     output.WriteLine(result);
        // }
        // Задача 1 - Удалить цифру из числа
        
        // Задача 2 - Система высокой нагрузки
        // for (var i = 0; i < count; i++)
        // {
        //     var str = input.ReadLine();
        //     var result = task2.SolveTask2(str);
        //     output.WriteLine(result);
        // }
        // Задача 2 - Система высокой нагрузки
        
        // Задача 3 - Валидация ответа
        // var current = 0;
        // var currentSet = 1;
        // var nSet = "";
        // var inputSet = "";
        // var outputSet = "";
        // var resultList = new List<string>();
        // while (current < count)
        // {
        //     if (currentSet % 3 == 1) { nSet = input.ReadLine(); }
        //     if (currentSet % 3 == 2) { inputSet = input.ReadLine(); }
        //     if (currentSet % 3 == 0)
        //     {
        //         outputSet = input.ReadLine();
        //         resultList.Add((task3.SolveTask3(nSet, inputSet, outputSet)));
        //         current++;
        //     }
        //     currentSet++;
        // }
        // foreach (var item in resultList) { Console.WriteLine(item);}
        // Задача 3 - Валидация ответа
        
        // Задача 4 - Ваня и вирусный файл (C#)
        var current = 0;
        var resultList = new List<int>();
        while (current < count)
        {
            var countOfSet = int.Parse(input.ReadLine());
            var currentOfSet = 0;
            var strJsonBuilder = new StringBuilder();
            while (currentOfSet < countOfSet)
            {
                strJsonBuilder.Append(input.ReadLine());
                currentOfSet ++;
            }
            var strJson = strJsonBuilder.ToString();
            resultList.Add(task4.SolveTask4(strJson));
            current++;
        }
        foreach (var item in resultList) { Console.WriteLine(item);}
    }
}