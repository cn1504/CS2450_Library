using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CS2450_Library;

namespace UnitTestProject1
{
    [TestClass]
    public class Library_Tests
    {
        [TestMethod]
        public void MakeEmptyLibrary()
        {
            //new library
            Library lib = new Library();
            //assure that it's empty
            foreach (Item i in lib.GetCatalog())
            {
                Assert.Fail("Item in new Library");
            }
            foreach (Patron i in lib.GetPatrons())
            {
                Assert.Fail("Patron in new Library");
            }
            foreach (Item i in lib.GetOverdue(DateTime.Now))
            {
                Assert.Fail("Overdue Item in empty Library");
            }
        }
    }
}
