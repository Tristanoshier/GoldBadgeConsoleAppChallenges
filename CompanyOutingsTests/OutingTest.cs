using System;
using System.Collections.Generic;
using CompanyOutingsRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CompanyOutingsTests
{
    [TestClass]
    public class OutingTest
    {
        [TestMethod]
        public void GetAllOutings_ShouldReturnCorrectList()
        {
            Outing outing = new Outing();
            OutingRepository outingRepo = new OutingRepository();
            outingRepo.AddOuting(outing);

            List<Outing> outings = outingRepo.GetAllOutings();
            bool directoryContainsOuting = outings.Contains(outing);

            Assert.IsTrue(directoryContainsOuting);
        }

        [TestMethod]
        public void AddOuting_ShouldReturnCorrectBool()
        {
            Outing outing = new Outing();
            OutingRepository outingRepo = new OutingRepository();

            bool outingAdded = outingRepo.AddOuting(outing);

            Assert.IsTrue(outingAdded);
        }
    }
}
