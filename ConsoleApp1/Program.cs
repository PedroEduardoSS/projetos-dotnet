using System;

namespace MyApp
{
  class Program
  {
    static void Main(string[] args)
    {
        
     Messages msg = new Messages("Abuu");
     Console.WriteLine(msg.defaultMessage);
     msg.sendMessage();
    }
  }
}