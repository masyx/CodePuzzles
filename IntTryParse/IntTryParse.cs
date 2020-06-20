using System;
using System.Collections.Generic;

namespace IntTryParse
{
    class IntTryParse
    {
        static void Main(string[] args)
        {
            var values = new List<string>{ null, "160519", "9432.0", "16,667",
                          "   -322   ", "+4302", "(100);", "01FA" };

            GetIntValue(values);
        }

        /// <summary>
        /// Parsing the list of string values
        /// </summary>
        /// <param name="values"></param>
        public static void GetIntValue(List<string> values)
        {
            foreach (var value in values)
            {
                bool success = int.TryParse(value, out int result);
                if (success)
                {
                    Console.WriteLine($"Converted {value} to {result}");

                }
                else
                {
                    Console.WriteLine("Attempted conversion of '{0}' failed.", value ?? "<null>");
                }
            }
            
        }
    }
}
