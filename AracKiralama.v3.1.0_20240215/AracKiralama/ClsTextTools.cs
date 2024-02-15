using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama
{
    public class ClsTextTools
    {
        // Get Before Space -- Boşluktan Öncesini Al
        public string GetBeforeSpace(string input)
        {
            var index = input.IndexOf(' ');
            return index == -1 ? input : input.Substring(0, index);
        }

        // Get After Space -- Boşluktan Sonrasını Al
        public string GetAfterSpace(string input)
        {
            var index = input.IndexOf(' ');
            return index == -1 ? input : input.Substring(index + 1);
        }
    }
}
