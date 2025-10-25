# BedrockInfo.cs
Web-API for [bedrockinfo.com](https://bedrockinfo.com) an website to check the online status, players, gamemode of your Minecraft: Bedrock Edtion Server

## Example
```cs
using System;
using BedrockInfoApi;
using System.Threading.Tasks;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new BedrockInfo();
            string serverStatus = await api.GetServerStatus("mc.hypixel.net");
            Console.WriteLine(serverStatus);
        }
    }
}
```
