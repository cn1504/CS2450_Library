using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2450_Library
{
    [Serializable]
    public class Patron
    {
        public int Id;
        public string Name;
        public string Address;
        public DateTime DateOfBirth;

        public int GetBorrowLimit(DateTime currentDate)
        {
            const int BORROW_LIMIT_ADULT = 6;
            const int BORROW_LIMIT_CHILD = 3;

            return (IsChild(currentDate)) ? BORROW_LIMIT_CHILD : BORROW_LIMIT_ADULT;
        }

        public bool IsChild(DateTime currentDate)
        {
            const int ADULT_AGE = 18;

            int age = currentDate.Year - DateOfBirth.Year;
            if (currentDate.Month < DateOfBirth.Month || 
                (currentDate.Month == DateOfBirth.Month && currentDate.Day < DateOfBirth.Day)) 
                age--;
            return (age < ADULT_AGE);
        }
    }
}
