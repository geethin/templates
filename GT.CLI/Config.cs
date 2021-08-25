using GT.CLI.Common;
using System.Diagnostics;
using System.Text;
using System.Text.Json;

namespace GT.CLI
{
    public static class Config
    {
        readonly static string ConfigPath = "./.gtcli-config.json";

        public static string ENTITY_NAMESPACE = "Core.Entity";
        public static string SERVICE_NAMESPACE = "Core.Services";
        public static string WEB_NAMESPACE = "App.Api";
        public static string SHARE_NAMESPACE = "Share";

        public static string CLIENT_PATH = "../clients/webapp";
        public static string DTO_PATH = "./Share/Models";

        /// <summary>
        /// 初始化配置文件
        /// </summary>
        public static async Task InitConfigFileAsync()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            path = Path.Combine(path, ConfigPath);

            if (File.Exists(path))
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

            var content = JsonSerializer.Serialize(options, new JsonSerializerOptions { WriteIndented = true });
            await File.WriteAllTextAsync(path, content, Encoding.UTF8);
        }

        /// <summary>
        /// 读取配置文件
        /// </summary>
        public static ConfigOptions ReadConfigFile()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            path = Path.Combine(path, ConfigPath);

            if (!File.Exists(path))
            {
                return default;
            }
            var config = File.ReadAllText(path);
            var options = JsonSerializer.Deserialize<ConfigOptions>(config);

            WEB_NAMESPACE = options.ApiNamespace;
            ENTITY_NAMESPACE = options.EntityNamespace;
            SERVICE_NAMESPACE = options.ServiceNamespace;
            SHARE_NAMESPACE = options.ShareNamespace;
            CLIENT_PATH = options.ClientPath;
            DTO_PATH = options.DtoPath;

            return options;
        }

        public static void EditConfigFile()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            path = Path.Combine(path, ConfigPath);
            if (!File.Exists(path))
            {
                Console.WriteLine("config file not exist!");
                return;
            }
            var process = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "powershell",
                    Arguments = $"-c {path}",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };
            process.Start();
            string result = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
        }
    }
}
