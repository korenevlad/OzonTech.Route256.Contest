using Xunit.Sdk;
using task3 = OzonTech.Route256.Sandbox.Task3;

namespace OzonTech.Route256.Tests;
public class Task3UnitTest
{
    [Fact]
    public void CheckAnswersMatch()
    {
        //Arrange
        var currentDir = Directory.GetCurrentDirectory();
        var path = Path.Combine(Directory.GetParent(currentDir).Parent.Parent.FullName, "SandboxTasks/3/tests3");
        Assert.True(Directory.Exists(path), $"Не найдена папка с тестами для задачи: {path}");
        //Тянем файлы с входными данными
        var inputFiles = Directory.GetFiles(path, "*")
            .Where(f => !f.EndsWith(".a"))
            .OrderBy(f => int.Parse(Path.GetFileName(f)))
            .ToArray();
        //Забираем данные для каждого файла (набора тестов)
        var numberTest = 1;
        foreach (var inputFile in inputFiles)
        {
            var outputFile = inputFile + ".a";
            var inputData = File.ReadAllText(inputFile).Split('\n');
            var outputData = File.ReadAllText(outputFile).Split('\n');
            if (!int.TryParse(inputData[0], out int testCount))
                throw new InvalidOperationException($"First line of {outputData} is not a valid number.");
            //Работаем с каждым тестом
            var current = 0;
            var currentSet = 1;
            var nSet = "";
            var inputSet = "";
            var outputSet = "";
            while (current < testCount)
            {
                if (currentSet % 3 == 1) { nSet = inputData[currentSet]; }
                if (currentSet % 3 == 2) { inputSet = inputData[currentSet]; }
                if (currentSet % 3 == 0)
                {
                    outputSet = inputData[currentSet];
                    //Act
                    var result = task3.SolveTask3(nSet, inputSet, outputSet);
                    //Assert
                    try
                    {
                        Assert.Equal(outputData[current], result);
                    }
                    catch (Xunit.Sdk.EqualException ex)
                    {
                        throw new Exception($"Завалился тест {current} в наборе {int.Parse(Path.GetFileName(inputFile))}-го файла");
                    }
                    current++;
                }
                currentSet++;
            }
            numberTest++;
        }
    }
}