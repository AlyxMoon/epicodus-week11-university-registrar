using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace University
{
  public class Program
  {
    public static void Main()
    {
      IWebHost host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build();

      host.Run();
    }
  }
}