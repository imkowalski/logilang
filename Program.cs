using System;


namespace LogiLang
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory();
            Config config = FileLoader.LoadConfig(path);
            string text = FileLoader.LoadFile(path + "\\example_project\\main.ll");
            Interpreter.Run(text);
            Functions.show([1, 2, 3, 4, 5], 3, 5,true);
        }
    }

}
