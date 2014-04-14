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
            var i = new Book();
            i.Name = "Dune";
            i.Author = "Frank Herbert";
            i.BorrowedBy = 0;
            Items.Add(i);

            var d = new Media();
            d.Name = "The Hobbit";
            d.BorrowedBy = 0;
            d.IsDvd = true;
            Items.Add(d);

            var p = new Patron();
            p.Name = "Frank Weber";
            p.Address = "418 South 5th Street, Gadsden, AL(Alabama) 35901";
            p.DateOfBirth = new DateTime(1988, 4, 12);
            p.Id = 1;
            Patrons.Add(p);
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
            // Check in and check out the items
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

        public int GetPatronBorrowLimit(int patronId, DateTime currentDate)
        {
            return Patrons.Find(x => x.Id == patronId).GetBorrowLimit(currentDate);
        }
        
        public bool AddItem(Item item)
        {
            if (Items.Exists(x => x.Name == item.Name))
            {
                return false;
            }

            Items.Add(item);
            return true;
        }

        public void DeleteItem(string name)
        {
            Items.RemoveAll(x => x.Name == name);
        }

        public void AddPatron(Patron patron)
        {
            patron.Id = 1;
            while (Patrons.Exists(x => x.Id == patron.Id))
            {
                patron.Id++;
            }

            Patrons.Add(patron);
        }

        public void DeletePatron(int id)
        {
            Patrons.RemoveAll(x => x.Id == id);
        }
    }
}
