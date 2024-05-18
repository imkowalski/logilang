namespace Interpreter_Func
{
    public class Interpreter
    {
        public static void Run(string text)
        {
            Parse(text);
            Evaluate(text);
        }
        private static void Parse(string text)
        {
            string[] lines = text.Split("\n");
            List<string> parsed = new List<string>();
            foreach (string line in lines)
            {
                string[] tokens = line.Split(" ");
                foreach (string token in tokens)
                {
                    parsed.Add(token);
                }
                parsed.Add("EOL");
            }
            parsed.RemoveAt(parsed.Count - 1);
            parsed.Add("EOF");
            foreach (string token in parsed)
            {
                Console.WriteLine(token);
            }
        }
        private static void Evaluate(string text)
        {

        }
        
    }
}