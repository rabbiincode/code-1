string code;

Console.WriteLine("Welcome to Bezao library");
Console.Write("Input a character from 'c' - 'o' - 'd' - 'e' : ");
code = Console.ReadLine();

if (code == "c")
    Console.WriteLine("C# books__download");
else if (code == "o")
    Console.WriteLine(".NET core books__download");
else if (code == "d")
    Console.WriteLine("clean coding books__download");
else if (code == "e")
    Console.WriteLine("EFCore books__download");
else
    Console.WriteLine("try again");

Console.ReadKey();