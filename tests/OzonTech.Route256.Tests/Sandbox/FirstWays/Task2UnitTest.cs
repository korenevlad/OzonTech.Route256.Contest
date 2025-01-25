using task2 = OzonTech.Route256.Sandbox.FirstWays.Task2;

namespace OzonTech.Route256.Tests.FirstWays;
public class Task2UnitTest
{
    [Fact]
    public void CheckAnswersMatch()
    {
        // Arrange
        //Находим папку
        var currentDir = Directory.GetCurrentDirectory();
        var path = Path.Combine(Directory.GetParent(currentDir).Parent.Parent.FullName, "Sandbox/SandboxTasks/2/tests2");
        Assert.True(Directory.Exists(path), $"Не найдена папка с тестами для задачи: {path}");
        //Тянем файлы с входными данными
        var inputFiles = Directory.GetFiles(path, "*")
            .Where(f => !f.EndsWith(".a"))
            .OrderBy(f => int.Parse(Path.GetFileName(f)))
            .ToArray();
        //Забираем данные для каждого файла
        foreach (var inputFile in inputFiles)
        {
            var outputFile = inputFile + ".a";
            var inputData = File.ReadAllText(inputFile).Split('\n');
            var outputData = File.ReadAllText(outputFile).Split('\n');
            if (!int.TryParse(inputData[0], out int testCount))
                throw new InvalidOperationException($"First line of {outputData} is not a valid number.");
            //Работаем с каждой строкой файла
            for (int i = 1; i <= testCount; i++)
            {
                var inputLine = inputData[i];
                //Act
                var actualOutput = task2.SolveTask2(inputLine);
                //Assert
                Assert.Equal(outputData[i - 1], actualOutput);
            }
        }
    }
}