using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2450_Library
{
    public class Patron
    {
        public int Id;
        public string Name;
        public string Address;
        public DateTime DateOfBirth;

        public int GetBorrowLimit(DateTime currentDate)
        {
            throw new NotImplementedException();
        }
    }
}
