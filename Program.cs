using System;

public class MainClass
{
  public static void Main()
  {
    string a = Console.ReadLine();
    string b = Console.ReadLine();

    if ( a == "True" & b == "True")
    {
      Console.WriteLine("False");
    }

    else if ( a == "False" & b == "True")
    {
      Console.WriteLine("False");
    }

    else if ( a == "False" & b == "False")
    {
      Console.WriteLine("False");
    }

    else if ( a == "True" & b == "False")
    {
      Console.WriteLine("True");
    }
  }
}


