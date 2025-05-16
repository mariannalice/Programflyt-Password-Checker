class Program 
{
  static void Main ()
  {
    string? Password = null;
    while (string.IsNullOrWhiteSpace(Password))
    {  
      Console.WriteLine("Please enter your password:");
      Password = Console.ReadLine();

      if (string.IsNullOrWhiteSpace(Password))
      {
        Console.WriteLine("You need to enter a valid password. Not empty or whith space between characters.\n");
      }
    }

    Console.WriteLine("\nLets check the strength of your password!");
      
    if (Password.Length >=1 && Password.Length <=6)
    {
        Console.WriteLine($"Your password is: {Password.Length} characters. 6 og less characters is a weak password.");
    }
    else if (Password.Length >= 6 && Password.Length <= 10)
    {
      Console.WriteLine($"Your password is: {Password.Length} characters. Between 6 and 10 characters is a medium-strong password");
    }
    else if (Password.Length > 10)
    {
      Console.WriteLine($"10 characters or more is a strong password. You password contains: {Password.Length} characters.");
    }
    else
    {
      Console.WriteLine("");
    }
  }
}
