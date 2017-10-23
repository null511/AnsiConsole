using System;
using System.IO;

namespace AnsiConsole
{
    public class AnsiWriter
    {
        public TextWriter Writer {get;}


        public AnsiWriter(TextWriter writer)
        {
            this.Writer = writer;
        }

        public AnsiWriter Write(string text)
        {
            Writer.Write(text);
            return this;
        }

        public AnsiWriter WriteLine()
        {
            Writer.WriteLine();
            return this;
        }

        public AnsiWriter Write(string text, ConsoleColor color)
        {
            SetColor(color);
            Writer.Write(text);
            return this;
        }

        public AnsiWriter WriteLine(string text, ConsoleColor color)
        {
            SetColor(color);
            Writer.WriteLine(text);
            return this;
        }

        public AnsiWriter SetColor(ConsoleColor color)
        {
            //
            return this;
        }
    }
}
