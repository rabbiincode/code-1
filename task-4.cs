int input;

Console.WriteLine("Jump Statements");

Console.Write("Input a number from 1 - 5 : ");
input = Convert.ToInt32(Console.ReadLine());

for (int i = input; i <= 20; i++)
{
    Console.WriteLine(i);
    if (i == 17)      
      break;

    if (i == 9)
      continue;
    Console.WriteLine("I will not print if i == 9");
};

Console.ReadKey();