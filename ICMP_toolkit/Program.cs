using System;

class Program
{
  static void Main(string[] args)
  {
    PingContext pingContext = new PingContext();

    Console.WriteLine("Select ping type: 1 for Normal, 2 for Custom");
    string choice = Console.ReadLine();

    if (choice == "1")
    {
      pingContext.SetPingStrategy(new NormalPingStrategy());
    }
    else if (choice == "2")
    {
      pingContext.SetPingStrategy(new CustomPingStrategy());
    }
    else
    {
      Console.WriteLine("Invalid choice");
      return;
    }

    Console.WriteLine("Enter IP address to ping:");
    string ipAddress = Console.ReadLine();

    pingContext.ExecutePing(ipAddress);
  }
}
