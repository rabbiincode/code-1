string date;

Console.WriteLine("Input a date:");
date = Console.ReadLine();

static void Main(string date)
{
  DateTime result = DateTime.Parse(date);
  result = result.AddDays(7);

  Console.WriteLine($"The date 7 days from now is : {result.ToString("MM/dd/yyyy")}");
};

Main(date);