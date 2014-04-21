using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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
            //create a filestream to open and read the file specified
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            //starting from the beginning for the file, read the following serialized data structures
            fs.Seek(0, SeekOrigin.Begin);
            BinaryFormatter bf = new BinaryFormatter(); //used to deserialize things
            try
            {
                //try to deserialize
                List<Item> tempItems = (List<Item>)bf.Deserialize(fs);
                List<Patron> tempPatrons = (List<Patron>)bf.Deserialize(fs);
                //if successful, set the library's data to be that
                this.Items = tempItems;
                this.Patrons = tempPatrons;
            }
            //is thrown when the file can't be deserialized
            catch (SerializationException ex)
            {
                throw new InvalidDataException("Not a valid file.");
            }
            finally
            {
                //done. close filestream
                fs.Close();
            }
        }

        public void SaveFile(string filePath)
        {
            //create a filestream to create (or open) and write to the specified file
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            //starting from the beginning for the file, serialize and write the data structures
            fs.Seek(0, SeekOrigin.Begin);
            BinaryFormatter bf = new BinaryFormatter(); //used to serialize things
            try
            {
                bf.Serialize(fs, Items);
                bf.Serialize(fs, Patrons);
                fs.Flush();
            }
            finally
            {
                //done. close filestream
                fs.Close();
            }
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
            TimeSpan BORROW_DURATION_ADULTS_BOOK = TimeSpan.FromDays(14);
            TimeSpan BORROW_DURATION_CHILDRENS_BOOK = TimeSpan.FromDays(7);
            TimeSpan BORROW_DURATION_DVD = TimeSpan.FromDays(2);
            TimeSpan BORROW_DURATION_VIDEO_TAPE = TimeSpan.FromDays(2);

            return from x in Items
                   where x.BorrowedBy != 0 && (
                   (x is Book && (x as Book).IsChild && (currentDate - x.BorrowDate > BORROW_DURATION_CHILDRENS_BOOK)) ||
                   (x is Book && !(x as Book).IsChild && (currentDate - x.BorrowDate > BORROW_DURATION_ADULTS_BOOK)) ||
                   (x is Media && (x as Media).IsDvd && (currentDate - x.BorrowDate > BORROW_DURATION_DVD)) ||
                   (x is Media && !(x as Media).IsDvd && (currentDate - x.BorrowDate > BORROW_DURATION_VIDEO_TAPE))
                   )
                   select x;
        }

        public IEnumerable<Item> GetAvailableItems(int patronId, DateTime currentDate)
        {
            Patron p = Patrons.Find(x => x.Id == patronId);
            return from x in Items
                   where x.BorrowedBy == 0 && (p.IsChild(currentDate) ? (x is Book) && (x as Book).IsChild : true)
                   select x;
        }

        public IEnumerable<Item> GetCheckedItems(int patronId)
        {
            return from x in Items
                   where x.BorrowedBy == patronId
                   select x;
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

        public Patron FindPatron(int id)
        {
            return Patrons.Find(x => x.Id == id);
        }
    }
}
