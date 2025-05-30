﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses.Entities.Helpers
{
    public static class TextHelper
    {
        public static string CapitalizeFirstLetter(string word)
        {
            if(word.Length == 1)
            {
                return word.ToUpper();
            }
            return char.ToUpper(word[0]) + word.Substring(1).ToLower();
        }
    }
}
