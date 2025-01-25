using System.Text;
using task1_1 = OzonTech.Route256.Sandbox.FirstWays.Task1;
using task2_1 = OzonTech.Route256.Sandbox.FirstWays.Task2;
using task3_1 = OzonTech.Route256.Sandbox.FirstWays.Task3;
using task4_1 = OzonTech.Route256.Sandbox.FirstWays.Task4;
using task7_1 = OzonTech.Route256.Sandbox.FirstWays.Task7;

using task1_2 = OzonTech.Route256.Sandbox.SecondWays.Task1;

namespace OzonTech.Route256.Sandbox;
public class Starter
{
    public static void Main(string [] args)
    {
        // Для всех тестов первого пути
        // using var input = new StreamReader(Console.OpenStandardInput());
        // using var output = new StreamWriter(Console.OpenStandardOutput());
        // var count = int.Parse(input.ReadLine());
        // Для всех тестов первого пути
        
        // Задача 1_1 - Удалить цифру из числа
        // for (var i = 0; i < count; i++)
        // {
        //     var str = input.ReadLine();
        //     var result = task1_1.SolveTask1(str);
        //     output.WriteLine(result);
        // }
        // Задача 1_1 - Удалить цифру из числа
        
        // Задача 2_1 - Система высокой нагрузки
        // for (var i = 0; i < count; i++)
        // {
        //     var str = input.ReadLine();
        //     var result = task2_1.SolveTask2(str);
        //     output.WriteLine(result);
        // }
        // Задача 2_1 - Система высокой нагрузки
        
        // Задача 3_1 - Валидация ответа
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
        //         resultList.Add((task3_1.SolveTask3(nSet, inputSet, outputSet)));
        //         current++;
        //     }
        //     currentSet++;
        // }
        // foreach (var item in resultList) { Console.WriteLine(item);}
        // Задача 3_1 - Валидация ответа
        
        // Задача 4_1 - Ваня и вирусный файл (C#)
        // var current = 0;
        // var resultList = new List<int>();
        // while (current < count)
        // {
        //     var countOfSet = int.Parse(input.ReadLine());
        //     var currentOfSet = 0;
        //     var strJsonBuilder = new StringBuilder();
        //     while (currentOfSet < countOfSet)
        //     {
        //         strJsonBuilder.Append(input.ReadLine());
        //         currentOfSet ++;
        //     }
        //     var strJson = strJsonBuilder.ToString();
        //     resultList.Add(task4_1.SolveTask4(strJson));
        //     current++;
        // }
        // foreach (var item in resultList) { Console.WriteLine(item);}
        // Задача 4_1 - Ваня и вирусный файл (C#)
        
        // Задача 7_1 - ASCII-роботы
        // var countOfSets = 0;
        // while (countOfSets < count)
        // {
        //     var nAndM = input.ReadLine().ToCharArray();
        //     var n = int.Parse(nAndM[0].ToString());
        //     var m = int.Parse(nAndM[2].ToString());
        //     char[ , ] stock = new char[n , m];
        //     var countOfN = 0;
        //     while (countOfN < n)
        //     {
        //         var str = input.ReadLine().ToCharArray();
        //         for (var i = 0; i < m; i++)
        //         {
        //             stock[countOfN, i] = str[i];
        //         }
        //         countOfN ++;
        //     }
        //     var result = task7_1.SolveTask7(stock);
        // }
        // Задача 7_1 - ASCII-роботы
        
        // Задача 1_2 - Удалить цифру из числа
        task1_2.SolveTask1();
        // Задача 1_2 - Удалить цифру из числа
    }
}