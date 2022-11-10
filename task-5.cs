string name;
string password;
string question;
string loginUser;
string loginPassword;

Console.WriteLine("Welcome, Register");

Console.Write("Enter username : ");
name = Console.ReadLine();

Console.Write("Enter password : ");
password = Console.ReadLine();

Console.WriteLine("Registration Successful");

Console.Write("Do you want to Login? (yes/no) : ");
question = Console.ReadLine();

//while (question != "yes" || question != "no")
//{
  //  Console.WriteLine("invalid input");
   // Console.Write("Do you want to Login? (yes/no) : ");
    //question = Console.ReadLine();
//}

if (question == "yes")
{
    Console.WriteLine("Enter username : ");
    loginUser = Console.ReadLine();

    Console.WriteLine("Enter password : ");
    loginPassword = Console.ReadLine();

    if (loginUser != name || loginPassword != password)
    {
        Console.WriteLine("username or password incorrect");
        while(loginUser != name || loginPassword != password)
        {
            Console.WriteLine("Enter username : ");
            loginUser = Console.ReadLine();

            Console.WriteLine("Enter password : ");
            loginPassword = Console.ReadLine();
            Console.WriteLine("username or password incorrect");
        }
    }
    else
    {
       Console.WriteLine("Login Successful");
    }
} 
else
{
    Console.WriteLine("Have a nice day");
}

Console.ReadKey();g