using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter;

namespace UnitTestOOD1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddOwnerWithExistedEmail()
        {
            Shelter theShelter = new Shelter("Fontys", "NL", 0123456, "Fontys@gmail.com");
            Owner o = new Owner("le", "a");
            theShelter.AddOwner(o);
            Assert.AreEqual(theShelter.AddOwner(new Owner("An", "a")), false);
        }

        [TestMethod]
        public void TestAddAnimalWithExistedRFID()
        {
            Shelter theShelter = new Shelter("Fontys", "NL", 0123456, "Fontys@gmail.com");
            Cat a = new Cat("ha2910", "pretty", "Fontys", "4 years", DateTime.Now);
            theShelter.AddAnimal(a);
            Assert.AreEqual(theShelter.AddAnimal(new Dog("ha2910", "beautiful", "Fontys", DateTime.Now)), false);
        }

        [TestMethod]
        public void TestAdoptionBefore20days()
        {
            Shelter theShelter = new Shelter("Fontys", "NL", 0123456, "Fontys@gmail.com");
            Cat a = new Cat("ha2910", "pretty", "Fontys", "4 years", DateTime.Now);
            Owner o = new Owner("le", "a");
            decimal fee = 0;
            theShelter.AddAnimal(a);
            theShelter.AddOwner(o);
            Assert.AreEqual(a.Adopt(o, ref fee), false);

        }

        [TestMethod]
        public void TestAdoptionAfter20daysWithPreviousOwner()
        {
            Shelter theShelter = new Shelter("Fontys", "NL", 0123456, "Fontys@gmail.com");
            Cat a = new Cat("ha2910", "pretty", "Fontys", "4 years", DateTime.Now);
            Owner o = new Owner("le", "a");
            a.UpdateOwner(o);
            decimal fee = 0;
            theShelter.AddAnimal(a);
            theShelter.AddOwner(o);
            Assert.AreEqual(a.Adopt(o, ref fee), false);
        }

        [TestMethod]
        public void TestAdoptionAfter20daysWithNewOwner()
        {
            Shelter theShelter = new Shelter("Fontys", "NL", 0123456, "Fontys@gmail.com");
            DateTime value = new DateTime(2018, 1, 18);
            Cat a = new Cat("ha2910", "pretty", "Fontys", "4 years", value);
            Owner o = new Owner("le", "a");
            decimal fee = 0;
            theShelter.AddAnimal(a);
            theShelter.AddOwner(o);
            Assert.AreEqual(a.Adopt(o, ref fee), true);
        }

        [TestMethod]
        public void TestClaimingBefore20DaysWithNewOwner()
        {
            Shelter theShelter = new Shelter("Fontys", "NL", 0123456, "Fontys@gmail.com");
            Cat a = new Cat("ha2910", "pretty", "Fontys", "4 years", DateTime.Now);
            Owner o = new Owner("le", "a");
            decimal fee = 0;
            theShelter.AddAnimal(a);
            theShelter.AddOwner(o);
            Assert.AreEqual(a.Claim(o, ref fee), false);
        }

        [TestMethod]
        public void TestClaimingBefore20DaysWithPreviousOwner()
        {
            Shelter theShelter = new Shelter("Fontys", "NL", 0123456, "Fontys@gmail.com");
            DateTime value = new DateTime(2018,10,8);
            Cat a = new Cat("ha2910", "pretty", "Fontys", "4 years", value);
            Owner o = new Owner("le", "a"); 
            decimal fee = 0;
            theShelter.AddAnimal(a);
            theShelter.AddOwner(o);
            a.UpdateOwner(o);
            Assert.AreEqual(a.Claim(o, ref fee), true);
        }

        [TestMethod]
        public void TestClaimingAfterAdoptionfromNewOwner()
        {
            Shelter theShelter = new Shelter("Fontys", "NL", 0123456, "Fontys@gmail.com");
            DateTime value = new DateTime(2018, 9, 8);
            Cat a = new Cat("ha2910", "pretty", "Fontys", "4 years", value);
            Owner o = new Owner("le", "a");

            decimal fee = 0;
            theShelter.AddAnimal(a);
            theShelter.AddOwner(o);
            a.UpdateOwner(o);

            a.Adopt(new Owner("N","b"), ref fee);
            Assert.AreEqual(a.Claim(o, ref fee), false);
        }

        [TestMethod]
        public void TestCalculateFeeForAdoption()
        {
            Shelter theShelter = new Shelter("Fontys", "NL", 0123456, "Fontys@gmail.com");
            DateTime value = new DateTime(2018, 9, 8);
            Cat a = new Cat("ha2910", "pretty", "Fontys", "4 years", value);
            Owner o = new Owner("le", "a");

            theShelter.AddAnimal(a);
            theShelter.AddOwner(o);

            Assert.AreEqual(a.CalculateFee(o.ID),25);
        }

        [TestMethod]
        public void TestCalculateFeeForClaiming()
        {
            Shelter theShelter = new Shelter("Fontys", "NL", 0123456, "Fontys@gmail.com");
            DateTime value = new DateTime(2018,10,9);
            Dog d = new Dog("ha2910", "pretty", "Fontys", value);
            Owner o = new Owner("le", "a");

            theShelter.AddAnimal(d);
            theShelter.AddOwner(o);
            d.UpdateOwner(o);

            Assert.AreEqual(d.CalculateFee(o.ID),12);
        }


    }
}

