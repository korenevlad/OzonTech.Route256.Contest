using System.Text;
using task4 = OzonTech.Route256.Sandbox.FirstWays.Task4;

namespace OzonTech.Route256.Tests.FirstWays;
public class Task4UnitTest
{
    [Fact]
    public void CheckAnswersMatch()
    {
        // Arrange
        //Находим папку
        var currentDir = Directory.GetCurrentDirectory();
        var path = Path.Combine(Directory.GetParent(currentDir).Parent.Parent.FullName, "Sandbox/SandboxTasks/4/tests4");
        Assert.True(Directory.Exists(path), $"Не найдена папка с тестами для задачи: {path}");
        //Тянем файлы с входными данными
        var inputFiles = Directory.GetFiles(path, "*")
            .Where(f => !f.EndsWith(".a"))
            .OrderBy(f => int.Parse(Path.GetFileName(f)))
            .ToArray();
        //Забираем данные для каждого файла (набора тестов)
        foreach (var inputFile in inputFiles)
        {
            var outputFile = inputFile + ".a";
            var inputData = File.ReadAllText(inputFile).Split('\n');
            var outputData = File.ReadAllText(outputFile).Split('\n');
            if (!int.TryParse(inputData[0].ToString(), out int testCount))
                throw new InvalidOperationException($"First line of {outputData} is not a valid number.");
            //Работаем с каждым тестом
            var count = 0;
            var currentIndexSetN = 1;
            while (count < testCount)
            {
                var currentSetN = int.Parse((inputData[currentIndexSetN]));
                var countOfSet = 1;
                var strJsonBuilder = new StringBuilder();
                while (countOfSet < currentSetN + 1)
                {
                    strJsonBuilder.Append(inputData[currentIndexSetN + countOfSet]);
                    countOfSet ++;
                }
                //Act
                var strJson = strJsonBuilder.ToString();
                var result = task4.SolveTask4(strJson);
                //Assert
                Assert.Equal(int.Parse(outputData[count]), result);
                currentIndexSetN += countOfSet; 
                count++;
            }
        }
    }
}