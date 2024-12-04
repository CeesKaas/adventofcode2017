﻿using AoC2022.Days;
using System.Diagnostics;

Console.WriteLine("Starting");
var sw = Stopwatch.StartNew();
await new Day11().Start();
sw.Stop();
Console.WriteLine($"Finished executions took: {sw.Elapsed}");