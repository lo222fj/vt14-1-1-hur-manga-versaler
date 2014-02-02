using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1_1_hur_manga_versaler.Model
{
    public static class TextAnalyzer
    {
        public static int GetNumberOfCapitals(string text) 
        {
            var nrOfCapitals = 0;

            foreach(char character in text)
            {
                if (Char.IsUpper(character))
                {
                    nrOfCapitals += 1;
                }
            }

            return nrOfCapitals;
        }
    }
}