using System;
using System.Reflection.Metadata.Ecma335;

namespace Acme.Common
{
    public static class StringHandler
    {
        public static string InsertSpaces(string source)
        {
            string result = string.Empty;

            if (!String.IsNullOrWhiteSpace(source))
            {
                foreach (var letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result = result.Trim();
                        result += " ";
                    }

                    result += letter;
                }
            }

            result = result.Trim();
            return result;
        }
        
        
    }
}
