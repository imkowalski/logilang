using Tomlyn;
namespace LogiLang
{

    class FileLoader
    {
        public static Config LoadConfig(string path)
        {
            string config_file = System.IO.File.ReadAllText(path + "\\example_project\\logilang.toml");
            var config = Toml.ToModel<Config>(config_file);
            return config;
        }

        public static string LoadFile(string path)
        {
            string file = System.IO.File.ReadAllText(path);
            return file;
        }
    }
}