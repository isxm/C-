﻿namespace MyExtensions
{
    using System.Text;

    // Task 1 StringBuilder.SubString
    public static class SubstringExtensions
    {
        public static StringBuilder Substring(this StringBuilder stringbuilder, int index, int length)
        {
            var output = new StringBuilder(stringbuilder.ToString().Substring(index, length));
            return output;
        }
        public static StringBuilder Substring(this StringBuilder stringbuilder, int index)
        {
            var output = new StringBuilder(stringbuilder.ToString().Substring(index));
            return output;
        }

    }
}