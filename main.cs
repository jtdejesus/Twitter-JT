using System;

class Program {
  public static void Main (string[] args) {
    string message = "Platea dictumst quisque sagittis purus sit amet volutpat consequat mauris.";
    if (message.Length <=140)
    Console.WriteLine("Posted");
    else
    Console.WriteLine("Rejected");
  }
}