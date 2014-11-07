using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDHelpers
{
    class StringHelper
    {
        public string RemoveSpaces(String test)
        {
            return test.Replace(" ", string.Empty);
        }

        public Boolean ContainsNumber(String test)
        {
            return test.Any(number => Char.IsDigit(number));
        }

        public int NumberOfUpperCases(String test)
        {
            int amount = 0;
            if (test == null) return amount;
            foreach (char ch in test)
            {
                if (Char.IsUpper(ch))
                {
                    amount++;
                }
            }
            return amount;
        }
    }
}
