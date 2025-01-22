using System.Text.Json;

namespace OzonTech.Route256.Sandbox;
public class Directory
{
    public string Dir { get; set; }
    public List<string> Files { get; set; }
    public List<Directory> Folders { get; set; }
    public Directory()
    {
        Files = new List<string>();
        Folders = new List<Directory>();
    }
}
public class Task4
{
    public static int SolveTask4(string str)
    {
        str.Replace(" ", "");
        var mainDirectory = JsonSerializer.Deserialize<Directory>(str, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            MaxDepth = 500
        });
        return FindCountInfectedFiles(mainDirectory);
    }
    private static int FindCountInfectedFiles(Directory dir)
    {
        if (dir.Files.Any(f => f.EndsWith(".hack")))
        {
            return FindAllFiles(dir);
        }
        var countInfectedFiles = 0;
        foreach (var folder in dir.Folders)
        {
            countInfectedFiles += FindCountInfectedFiles(folder);
        }
        return countInfectedFiles;
    }
    private static int FindAllFiles(Directory dir)
    {
        var countAllFiles = dir.Files.Count;
        foreach (var folder in dir.Folders)
        {
            countAllFiles += FindAllFiles(folder);
        }
        return countAllFiles;
    }
}

