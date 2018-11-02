using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Morgengry;





namespace UnitTest2
{
    [TestClass]
    public class UnitTest2
    {
        Book b1, b2, b3;
        Amulet a11, a12, a13;
        Course c111, c112;
        MerchandiseRepository merchandises = new MerchandiseRepository();
        CourseRepository courses = new CourseRepository();
        //AmuletRepository amulets = new AmuletRepository



        [TestInitialize]
        public void Init()
        {
            b1 = new Book("1");
            b2 = new Book("2", "Falling in Love with Yourself");
            b3 = new Book("3", "Spirits in the Night", 123.55);
            merchandises.AddBook(b1);
            merchandises.AddBook(b2);
            merchandises.AddBook(b3);


            a11 = new Amulet("11");
            a12 = new Amulet("12", Level.high);
            a13 = new Amulet("13", Level.low, "Capricorn");
            merchandises.AddAmulet(a11);
            merchandises.AddAmulet(a12);
            merchandises.AddAmulet(a13);


            c111 = new Course("Eufori med røg");
            c112 = new Course("Nuru Massage using Chia Oil", 157);
            courses.AddCourse(c111);
            courses.AddCourse(c112);

        }

        [TestMethod]
        public void TestGetValueForBook()
        {
            Assert.AreEqual(0.0, Utility.GetValueOfMerchandise(b1));
            Assert.AreEqual(0.0, Utility.GetValueOfMerchandise(b2));
            Assert.AreEqual(123.55, Utility.GetValueOfMerchandise(b3));
            Assert.AreEqual(183.55, merchandises.GetTotalValue());
        }

        [TestMethod]
        public void TestGetValueForMerchandise()
        {
            Assert.AreEqual(20.0, Utility.GetValueOfMerchandise(a11));
            Assert.AreEqual(27.5, Utility.GetValueOfMerchandise(a12));
            Assert.AreEqual(12.5, Utility.GetValueOfMerchandise(a13));
            Assert.AreEqual(183,55, merchandises.GetTotalValue());
        }

        [TestMethod]
        public void TestGetValueForCourse()
        {
            Assert.AreEqual(0.0, Utility.GetValueOfCourse(c111));
            Assert.AreEqual(2625.00, Utility.GetValueOfCourse(c112));
            Assert.AreEqual(2625.00, courses.GetTotalValue());
        }
    }
}
