namespace LogiLang
{
    class Functions
    {
        public static void show(List<int> mem, int start_addr, int end_addr,bool ascii = false)
        {
            if (start_addr < 0 || start_addr >= mem.Count || end_addr < 0 || end_addr >= mem.Count)
            {
                Console.WriteLine("Error: Invalid memory address");
                return;
            }
            
            int byte_counter = i-start_addr;
            for (int i = start_addr; i < end_addr; i++)
            {
                if (ascii)
                {
                    
                    Console.WriteLine(i + ": " +mem[i]);
                }
                else{
                    Console.Write(mem[i]);
                }
                
            }
            Console.Write("\n");
        }
    }
}