using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2450_Library
{
    public class Library
    {
        private List<Item> Items = new List<Item>();
        private List<Patron> Patrons = new List<Patron>();

        public Library()
        {            
        }

        public void LoadFile(string filePath)
        {
            throw new NotImplementedException();
        }

        public void SaveFile(string filePath)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetCatalog()
        {
            return Items.AsEnumerable();
        }

        public IEnumerable<Patron> GetPatrons()
        {
            return Patrons.AsEnumerable();
        }

        public IEnumerable<Item> GetOverdue(DateTime currentDate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetAvailableItems(int patronId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetCheckedItems(int patronId)
        {
            throw new NotImplementedException();
        }

        public void SetCheckOut(int patronId, IEnumerable<string> itemNames, DateTime currentDate)
        {
            List<string> coItems = itemNames.ToList();
            foreach (var item in Items)
            {
                if (item.BorrowedBy == patronId)
                {
                    bool stillCheckedOut = false;
                    foreach (string name in coItems)
                    {
                        if (item.Name == name)
                        {
                            stillCheckedOut = true;
                        }
                    }

                    if (!stillCheckedOut)
                        item.BorrowedBy = 0;
                }
                else
                {
                    foreach (string name in coItems)
                    {
                        if (item.Name == name)
                        {
                            item.BorrowedBy = patronId;
                            item.BorrowDate = currentDate;
                        }
                    }
                }
            }
        }

        public int GetPatronBorrowLimit(int patronId)
        {
            return Patrons.Find(x => x.Id == patronId).GetBorrowLimit();
        }
    }
}
