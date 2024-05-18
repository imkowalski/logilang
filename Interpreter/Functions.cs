using System.Text;
namespace Interpreter_Func
{
    class Functions
    {
        public static void show(List<int> mem, int start_addr, int end_addr,string decorator = "raw")
        {
            if (decorator == "raw")
            {
                // Print raw memory
                for (int i = start_addr; i < end_addr; i++)
                {
                    Console.Write(mem[i] + " ");
                }
                Console.Write("\n");
                return;
            }
            
            var bytes = new List<byte>();
            for (int i = start_addr; i < end_addr; i += 8)
            {
                if (i + 7 < end_addr) // Ensure there are enough bits left to form a byte
                {
                    string binary = string.Join("", mem.GetRange(i, 8)); // Get 8 bits
                    byte b = Convert.ToByte(binary, 2); // Convert to byte
                    bytes.Add(b);
                }
            }

            if (decorator == "ascii")
            {
                // Convert bytes to ASCII and print
                
                string asciiString = new string(Encoding.ASCII.GetString(bytes.ToArray()).ToCharArray());
                Console.Write(asciiString);
            }
            else if (decorator == "bytes")
            {
                // Print bytes
                foreach (byte b in bytes)
                {
                    Console.Write(b + " ");
                }
            }
            else if (decorator == "hex")
            {
                // Print bytes in hex
                foreach (byte b in bytes)
                {
                    Console.Write(b.ToString("X2")+" ");
                }
            }
            else if (decorator == "binary")
            {
                // Print bytes in binary
                foreach (byte b in bytes)
                {
                    Console.Write(Convert.ToString(b, 2).PadLeft(8, '0')+ " ");
                }
            }

            Console.Write("\n");
            Console.Write("\n");
        }
        public static List<int> get(List<int> mem, int addr, string value, string decorator = "raw")
        {
            if (decorator == "raw"){
                mem[addr] = int.Parse(value);
            }
            
            return mem;
        }
    }
}