class Program 
{
  static void Main ()
  {
    Console.WriteLine("Please enter you password. ");
    string? Password = Console.ReadLine();

   if (Password.Length <=6)
   {
      Console.WriteLine($"Your password is: {Password.Length} characters. 6 og less characters is a weak password.");
   }
   else if (Password.Length >= 6 && Password.Length <= 10)
   {
    Console.WriteLine($"Your pawwsord is: {Password.Length} characters. Between 6 and 10 characters is a medium-strong password");
   }
   else if (Password.Length >= 10)
   {
    Console.WriteLine($"10 characters or more is a strong password. You password contains: {Password.Length} characters.");
   }
   else
   {
    Console.WriteLine("");
   }
  }
}
