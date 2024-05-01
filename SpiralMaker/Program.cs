using SpiralMaker;
using System.Diagnostics;

var keepGoing = true;
do
{
    Console.WriteLine("Enter an integer to get your spiral");

    var input = Console.ReadLine();
    if (input == null) keepGoing = false;
    if(int.TryParse(input, out var integer))
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        var spiral = Spiral.CreateSpiral(integer);
        stopwatch.Stop();
        Console.WriteLine($"V1 Elapsed milliseconds: {stopwatch.ElapsedMilliseconds}");
        stopwatch.Reset();
        stopwatch.Start();
        spiral = Spiral.CreateSpiralV2(integer);
        stopwatch.Stop();
        Console.WriteLine($"V2 Elapsed milliseconds: {stopwatch.ElapsedMilliseconds}");

        //for(var row = 0; row < spiral.GetLength(0); row++)
        //{
        //    for(var col = 0; col < spiral.GetLength(1); col++)
        //    {
        //        Console.Write(spiral[row, col]);
        //        Console.Write(' ');
        //    }
        //    Console.WriteLine();
        //}
    }

} while (keepGoing);