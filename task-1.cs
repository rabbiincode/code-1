string word;
string letters;
string lastFour;
string replace;
string output;
char hash = '#';

Console.Write("Enter a Word: ");
word = Console.ReadLine();

while ( word.Length < 5)
{
   Console.Write("input a word with a minimum of 5 letters: ");
   word = Console.ReadLine();
}
letters = word.Substring(0, word.Length - 4);
lastFour = word.Substring(word.Length - 4);
Console.WriteLine(letters);
Console.WriteLine(lastFour);
string empty = "";

foreach (char letter in letters)
{
    empty += letter;
};
Console.WriteLine(empty);


Console.ReadKey();