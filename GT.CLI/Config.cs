using GT.CLI.Common;
using System.Text;
using System.Text.Json;

namespace GT.CLI
{
    public static class Config
    {
        readonly static string ConfigPath = "~/.gtcli-config.json";

        public static string ENTITY_NAMESPACE = "Core.Entity";
        public static string SERVICE_NAMESPACE = "Core.Services";
        public static string WEB_NAMESPACE = "App.Api";
        public static string SHARE_NAMESPACE = "Share";

        public static string CLIENT_PATH = "../clients/webapp";
        public static string DTO_PATH = "./Share/Models";


        /// <summary>
        /// 初始化配置文件
        /// </summary>
        static async Task InitConfigFileAsync()
        {
            if (File.Exists(ConfigPath))
            {
                Console.WriteLine("config file already exist!");
                return;
            }
            var options = new ConfigOptions
            {
                ApiNamespace = WEB_NAMESPACE,
                EntityNamespace = ENTITY_NAMESPACE,
                ServiceNamespace = SERVICE_NAMESPACE,
                ShareNamespace = SHARE_NAMESPACE,

                ApiPath = "./" + WEB_NAMESPACE,
                EntityPath = "./" + ENTITY_NAMESPACE,
                ServicePath = "./" + SERVICE_NAMESPACE,
                SharePath = "./" + SHARE_NAMESPACE,

                ClientPath = CLIENT_PATH,
                DtoPath = DTO_PATH
            };

            var content = JsonSerializer.Serialize(options);
            await File.WriteAllTextAsync(ConfigPath, content, Encoding.UTF8);
        }

        /// <summary>
        /// 读取配置文件
        /// </summary>
        static ConfigOptions ReadConfigFile()
        {
            if (!File.Exists(ConfigPath))
            {
                Console.WriteLine("config file not exist! You can use `gt config init` init config file!");
                return default;
            }
            var config = File.ReadAllText(ConfigPath);
            var options = JsonSerializer.Deserialize<ConfigOptions>(config);

            return options;
        }
    }
}
