using Colotiline.GoLikeTests.Directory.Subdirectory;
using Newtonsoft.Json;

Console.WriteLine(Greeting.Create("Mark"));
Console.WriteLine(MathNet.Numerics.Constants.Pi);
Console.WriteLine(JsonConvert.SerializeObject(new { Answer = 42 }));