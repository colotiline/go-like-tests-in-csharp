using Colotiline.GoLikeTests.Directory.Subdirectory;
using Newtonsoft.Json;

namespace Colotiline.GoLikeTests;

public sealed class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Greeting.Create("Mark"));
        Console.WriteLine(MathNet.Numerics.Constants.Pi);
        Console.WriteLine(JsonConvert.SerializeObject(new { Answer = 42 }));
    }
}