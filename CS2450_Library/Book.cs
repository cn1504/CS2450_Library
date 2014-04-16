using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2450_Library
{
    [Serializable]
    class Book : Item
    {
        public string Author;
        public bool IsChild;
    }
}
