using System;

namespace EasyCon.Script
{
    public class ScriptException : Exception
    {
        public int Address { get; private set; }

        public ScriptException(string message, int address)
            : base(message)
        {
            Address = address;
        }
    }
}
