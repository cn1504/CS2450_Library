using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2450_Library
{
    [Serializable]
    public class Item
    {
        public string Name;
        public int BorrowedBy;
        public DateTime BorrowDate;
    }
}
