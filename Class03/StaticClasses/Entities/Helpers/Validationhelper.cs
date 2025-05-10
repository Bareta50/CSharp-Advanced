using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses.Entities.Helpers
{
    public static class Validationhelper
    {
        public static int ValidateNumberInput(string input)
        {
            bool isValidInput = int.TryParse(input, out int parsedInput);
            if (!isValidInput)
            {
                return -1;
            }
            return parsedInput;
        }
    }
}
