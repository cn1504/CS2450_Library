using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CS2450_Library;

namespace UnitTestProject1
{
    [TestClass]
    public class Patron_IsChild_Tests
    {
        [TestMethod]
        public void IsChild_EarlierYear()
        {
            //arrange patron
            Patron person = new Patron();
            person.DateOfBirth = new DateTime(2000, 5, 15);
            //arrange date
            DateTime today = new DateTime(2014, 1, 1);

            //should still be a child
            Assert.IsTrue(person.IsChild(today), "expected to be a child");

        }
        [TestMethod]
        public void IsChild_LaterYear()
        {
            //arrange patron
            Patron person = new Patron();
            person.DateOfBirth = new DateTime(2000, 5, 15);
            //arrange date
            DateTime today = new DateTime(2024, 1, 1);

            //should still be a child
            Assert.IsFalse(person.IsChild(today), "expected to be an adult");

        }
        [TestMethod]
        public void IsChild_LastYear()
        {
            //arrange patron
            Patron child = new Patron();
            child.DateOfBirth = new DateTime(2000, 5, 15);
            //arrange date
            DateTime today = new DateTime(2017, 12, 31);

            //should still be a child
            Assert.IsTrue(child.IsChild(today), "expected to be a child");

        }
        [TestMethod]
        public void IsChild_NextYear()
        {
            //arrange patron
            Patron child = new Patron();
            child.DateOfBirth = new DateTime(2000, 5, 15);
            //arrange date
            DateTime today = new DateTime(2019, 1, 1);

            //should still be a child
            Assert.IsFalse(child.IsChild(today), "expected to be an adult");

        }
        [TestMethod]
        public void IsChild_LastMonth()
        {
            //arrange patron
            Patron child = new Patron();
            child.DateOfBirth = new DateTime(2000, 5, 15);
            //arrange date
            DateTime today = new DateTime(2018, 4, 30);

            //should still be a child
            Assert.IsTrue(child.IsChild(today), "expected to be a child");

        }
        [TestMethod]
        public void IsChild_NextMonth()
        {
            //arrange patron
            Patron child = new Patron();
            child.DateOfBirth = new DateTime(2000, 5, 15);
            //arrange date
            DateTime today = new DateTime(2018, 6, 1);

            //should still be a child
            Assert.IsFalse(child.IsChild(today), "expected to be an adult");

        }
        [TestMethod]
        public void IsChild_Yesterday()
        {
            //arrange patron
            Patron child = new Patron();
            child.DateOfBirth = new DateTime(2000, 5, 15);
            //arrange date
            DateTime today = new DateTime(2018, 5, 14);

            //should still be a child
            Assert.IsTrue(child.IsChild(today), "expected to be a child");

        }
        [TestMethod]
        public void IsChild_Tomorrow()
        {
            //arrange patron
            Patron child = new Patron();
            child.DateOfBirth = new DateTime(2000, 5, 15);
            //arrange date
            DateTime today = new DateTime(2018, 5, 16);

            //should still be a child
            Assert.IsFalse(child.IsChild(today), "expected to be an adult");

        }
        [TestMethod]
        public void IsChild_Birthday()
        {
            //arrange patron
            Patron child = new Patron();
            child.DateOfBirth = new DateTime(2000, 5, 15);
            //arrange date
            DateTime today = new DateTime(2018, 5, 15);

            //should still be a child
            Assert.IsFalse(child.IsChild(today), "expected to be an adult");

        }
    }
}
