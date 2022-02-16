// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

// string[] args;
// Display the number of command line arguments.
var path = @"C:\Users\gbs4e\OneDrive\Documents\testdoc.txt";
Console.WriteLine(args.Length);
if (args.Length > 0)
{
    path = args[0];

}
if (File.Exists(path) == false)
{
    Console.WriteLine("file not found. Hit any key......");
    Console.ReadLine();
    return;
}
var zpl = File.ReadAllText(path);
Console.WriteLine(zpl);
Console.ReadLine();