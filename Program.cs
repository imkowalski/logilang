using System;
using Interpreter_Func;


namespace LogiLang
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory();
            Config config = FileLoader.LoadConfig(path);
            string text = FileLoader.LoadFile(path + "\\example_project\\main.ll");
            int[] test = new int[(int)config.Memory];
            test[10] = 10;
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(test[i]);
            }
            Interpreter.Run(text);
        }
    }

}
