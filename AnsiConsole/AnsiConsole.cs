using System;

namespace AnsiConsole
{
    public static class AnsiConsole
    {
        public static AnsiWriter Out {get;}
        public static AnsiWriter Error {get;}


        static AnsiConsole()
        {
            Out = new AnsiWriter(Console.Out);
            Error = new AnsiWriter(Console.Error);
        }
    }
}
