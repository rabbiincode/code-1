string words;
List<int> letters = new List<int>();

Console.Write("Enter a word containing upper and lower case: ");
words = Console.ReadLine();

for(int i = 0; i < words.Length; i++)
{
  if (words[i] >= 'A' & words[i] <= 'Z') {
    letters.Add(i);
  }
}

foreach(int i in letters)
{
    Console.WriteLine($"{words[i]} : {i}");
}

Console.ReadKey();