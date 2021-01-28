using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testing2018;

namespace ArmourTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetLevel()
        {
            // testataan getLevel -metodia
            Armour ar = new Armour("Jorma", "Kokkeli", 20, 2, 2);
            int lvl = ar.getLevel();

            if (lvl != 2)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestGetSlot()
        {
            // testataan getSlot -metodia
            Armour ar = new Armour("Jorma", "Kokkeli", 20, 2, 2);
            int slot = ar.getSlot();

            if (slot != 2)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestMaxProt()
        {
            // testataan getMaxProt -metodia
            Armour ar = new Armour("Jorma", "Kokkeli", 20, 2, 2);
            int maxProt = ar.getMaxProt();

            if (maxProt != 20)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestCurProt()
        {
            // testataan getCurProt -metodia
            Armour ar = new Armour("Jorma", "Kokkeli", 20, 2, 2);
            int curProt = ar.getCurProt();

            if (curProt != 20)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestTakeDam()
        {
            // testataan että damagen otto toimii ja samalla testataan että ei voida mennä alle nollan
            Armour ar = new Armour("Jorma", "Kokkeli", 20, 2, 2);
            ar.takeDam(21);
            int curProt = ar.getCurProt();

            if (curProt != 0)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestRepair()
        {
            // testataan että repair toimii ja samalla testataan että ei voida ylittää maxProt
            Armour ar = new Armour("Jorma", "Kokkeli", 20, 2, 2);
            ar.takeDam(5);
            ar.repair(6);
            int curProt = ar.getCurProt();

            if (curProt != 20)
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestCondition()
        {
            // testataan että condition metodi toimii, käydään läpi jokainen mahdolinen kuntotaso
            // jos yksi kohta failaa, koko testi failaa
            Armour ar = new Armour("Jorma", "Kokkeli", 10, 2, 2);
            string condition = ar.getCondition();

            if (condition != "Mint")
            {
                Assert.Fail();
            }

            ar.takeDam(2);
            condition = ar.getCondition();

            if (condition != "Excellent")
            {
                Assert.Fail();
            }

            ar.takeDam(2);
            condition = ar.getCondition();

            if (condition != "Good")
            {
                Assert.Fail();
            }

            ar.takeDam(2);
            condition = ar.getCondition();

            if (condition != "Average")
            {
                Assert.Fail();
            }

            ar.takeDam(2);
            condition = ar.getCondition();

            if (condition != "Weak")
            {
                Assert.Fail();
            }

            ar.takeDam(1);
            condition = ar.getCondition();

            if (condition != "Poor")
            {
                Assert.Fail();
            }

            ar.takeDam(1);
            condition = ar.getCondition();

            if (condition != "Destroyed")
            {
                Assert.Fail();
            }
        }
    }
}
