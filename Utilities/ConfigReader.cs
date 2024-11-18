using System.IO;
using Newtonsoft.Json;

public static class ConfigReader
{
    public static dynamic Config { get; private set; }

    static ConfigReader()
    {
        var configContent = File.ReadAllText("config.json");
        Config = JsonConvert.DeserializeObject<dynamic>(configContent);
    }

    public static string TestUser => Config.TestUser;
    public static string TestPassword => Config.TestPassword;
}