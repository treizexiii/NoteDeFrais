using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceCommercial;
using System;

namespace TestCommercial
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddNoteTest()
        {
            Commercial c;
            c = new Commercial("Armand", "RAVE", 32, 290, 'A');
            NoteDeFrais f, f1;
            f = new NoteDeFrais(new DateTime(2020, 10, 19), c);
            f1 = new NoteDeFrais(new DateTime(2020, 10, 18), c);
            Assert.AreEqual(2, c.NotesDeFrais.Count);
        }

        [TestMethod]
        public void AmountUncheckTest()
        {
            Commercial c,c1;
            ServiceCom sc;
            sc = new ServiceCom();
            c = new Commercial("Armand", "RAVE", 32, 290, 'A');
            c1 = new Commercial("Jonathan", "ROUGIER", 34, 250, 'A');
            sc.AddNewCormmercial(c);
            sc.AddNewCormmercial(c1);
            NoteDeFrais f, f1, f2, f3, f4;
            f = new NoteDeFrais(new DateTime(2020, 10, 19), c);
            f1 = new NoteDeFrais(new DateTime(2020, 10, 18), c);
            f1.SetCheck();
            f2 = new NoteDeFrais(new DateTime(2020, 10, 19), c1);
            f3 = new NoteDeFrais(new DateTime(2020, 10, 18), c1);
            f3.SetCheck();
            f4 = new NoteDeFrais(new DateTime(2020, 10, 15), c);
            f4.SetCheck();
            Assert.AreEqual(2, sc.AmountUncheck());
        }

        [TestMethod]
        public void CalculAmountTravelTest()
        {
            Commercial c;
            c = new Commercial("Armand", "RAVE", 32, 8, 'A');
            NoteDeFrais f;
            f = new TravelBill(new DateTime(2020, 10, 19), c, 250);
            Assert.AreEqual(50,f.CalculAmount());
        }

        [TestMethod]
        public void CalculAmountLunchTest()
        {
            Commercial c;
            c = new Commercial("Armand", "RAVE", 32, 8, 'B');
            NoteDeFrais f;
            f = new LunchBill(new DateTime(2020, 10, 19), c, 15);
            Assert.AreEqual(15,f.CalculAmount());
        }

        [TestMethod]
        public void CalculAmountHotelTest()
        {
            Commercial c;
            c = new Commercial("Armand", "RAVE", 32, 8, 'A');
            NoteDeFrais f;
            f = new HotelBill(new DateTime(2020, 10, 19), c, 3, 80);
            Assert.AreEqual((decimal)74.75, f.CalculAmount());
        }
    }
}
