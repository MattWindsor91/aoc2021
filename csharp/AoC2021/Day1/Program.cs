// Solves AoC day 1 in C# 10.
//
// Usage:
// put your sample in sample.txt and input in input.txt in the working
// directory.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;

void Run(string file)
{
    var readings = ReadReadings(file).ToImmutableList();
    Console.WriteLine($"{file} part 1: {Count(readings)}");
    Console.WriteLine($"{file} part 2: {Count(Window3(readings))}");
}

IEnumerable<int> ReadReadings(string s)
{
    return from line in File.ReadAllLines(s) select int.Parse(line);
}

IEnumerable<int> Window3(ImmutableList<int> input)
{
    var raw = input.Zip(input.Take(Range.StartAt(1))).Zip(input.Take(Range.StartAt(2)));
    return from r in raw select r.First.First + r.First.Second + r.Second;
}

int Count(IEnumerable<int> readings)
{
    var last = -1;
    var i = -1;

    foreach (var r in readings)
    {
        if (last < r) i++;

        last = r;
    }

    return i;
}

Run("sample.txt");
Run("input.txt");