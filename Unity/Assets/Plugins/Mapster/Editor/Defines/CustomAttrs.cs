using System;

namespace Mapster.Editor
{
    [AttributeUsage(AttributeTargets.Field)]
    internal class CommandAttribute : Attribute
    {
        public readonly string option;
        public readonly bool new_line;

        public CommandAttribute(string option, bool new_line = true)
        {
            this.option = option;
            this.new_line = new_line;
        }
    }
}