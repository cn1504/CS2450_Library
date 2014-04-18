﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            this.Items = (List<Item>)bf.Deserialize(fs);
            this.Patrons = (List<Patron>)bf.Deserialize(fs);
            //done. close filestream
            fs.Close();
        }

        public void SaveFile(string filePath)
        {
            //create a filestream to create (or open) and write to the specified file
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            //starting from the beginning for the file, serialize and write the data structures
            fs.Seek(0, SeekOrigin.Begin);
            BinaryFormatter bf = new BinaryFormatter(); //used to serialize things
            bf.Serialize(fs, Items);
            bf.Serialize(fs, Patrons);
            //done. close filestream
            fs.Flush();
            fs.Close();
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
