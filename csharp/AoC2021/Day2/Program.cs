// Solves AoC day 2 in C# 10.
//
// Usage:
// put your sample in sample.txt and input in input.txt in the working
// directory.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Day2;

void Run(string file)
{
    var aim = 0L;
    var depth = 0L;
    var pos = 0L;

    foreach (var (opcode, amount) in ReadCommands(file))
        switch (opcode)
        {
            case Opcode.Forward:
                pos += amount;
                depth += aim * amount;
                break;
            case Opcode.Down:
                aim += amount;
                break;
            case Opcode.Up:
                aim -= amount;
                break;
        }

    Console.Out.WriteLine($"part 1: {aim * pos}");
    Console.Out.WriteLine($"part 2: {depth * pos}");
}

IEnumerable<Command> ReadCommands(string s)
{
    return from line in File.ReadAllLines(s) select ParseCommand(line);
}

Command ParseCommand(string line)
{
    var fragments = line.Split();
    if (fragments.Length != 2) throw new ArgumentException($"ill-formed line: {line}");
    var code = ParseOpcode(fragments[0]);
    var amount = int.Parse(fragments[1]);
    return new Command(code, amount);
}

Opcode ParseOpcode(string code)
{
    return code.ToLower() switch
    {
        "forward" => Opcode.Forward,
        "down" => Opcode.Down,
        "up" => Opcode.Up,
        _ => throw new ArgumentException($"unknown opcode: {code}")
    };
}

Run("sample.txt");
Run("input.txt");