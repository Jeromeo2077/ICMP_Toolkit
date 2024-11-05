using System;
using System.Net;
using System.Net.Sockets;

public class NormalPingStrategy : IPingStrategy
{
  public void Ping(string ipAddress)
  {
    // Implementation for normal ICMP ping using Socket class
    Console.WriteLine($"Pinging {ipAddress} with normal ICMP packets...");
    // Add actual ping logic here
  }
}