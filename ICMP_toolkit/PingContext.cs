public class PingContext
{
  private IPingStrategy _pingStrategy;

  public void SetPingStrategy(IPingStrategy pingStrategy)
  {
    _pingStrategy = pingStrategy;
  }

  public void ExecutePing(string ipAddress)
  {
    _pingStrategy.Ping(ipAddress);
  }
}