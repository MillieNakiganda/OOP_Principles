using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.Common
{
    public static class StringHandler
    {
        //putting the this keyword before the this paramater makes it an extension method
        //now the parameter nolonger represents an argument, but showing that we are extending a string type
        //so callig it will be as: stringname.InsertSpaces() or still as a static class
        public static string InsertSpaces(this string source)
        {
            string result = string.Empty;
            if (!string.IsNullOrWhiteSpace(source))
            {
                foreach(char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
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
