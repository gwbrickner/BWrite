using System;
using System.IO;
using System.Linq;

class Program {
  public static void Main (string[] args) {
    
    int x = 1;
      
    Console.WriteLine("Welcome to BWrite! A simple C# based text editor! \n");

    Console.WriteLine("Please enter a file name.");
    string fileName = Console.ReadLine();

    if (!File.Exists(fileName))
    {
      File.Create(fileName);
    }

    Console.Clear();
    Console.WriteLine(File.ReadAllText(fileName));
    
    string textToAppend = "\n" + Console.ReadLine();
    
    while (x == x)
    {
      String[] splitString = textToAppend.Split(':');

      if (splitString.Last() == "exit")
      {
        textToAppend = splitString[0];
        File.AppendAllText(fileName, textToAppend);
        break;
      }
      
      else
      {
        textToAppend = textToAppend + "\n" + Console.ReadLine();
      }
    }
    
  }
}