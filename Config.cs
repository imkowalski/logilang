namespace LogiLang
{
    class Config
    {
        public string? Name { get; set; }
        public string? CompilerVersion { get; set; }
        public string? OutputMode { get; set; }
        public int? Memory { get; set; }
        public string[]? Modules { get; set; }
    }
}