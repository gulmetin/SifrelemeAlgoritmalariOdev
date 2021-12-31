using Microsoft.VisualStudio.TestTools.UnitTesting;
using SifrelemeAlgoritmalariOdev;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()//sifreleme sayfasýnýn açýlmasýnýn kontrolü
        {
            Sifreleme sifreleme = new Sifreleme();
            sifreleme.ShowDialog();
        }
        [TestMethod]
        public void TestMethod2()//dosya sayfasýnýn açýlmasýnýn kontrolü
        {
            DosyaGonder dosya = new DosyaGonder();
            dosya.ShowDialog();
        }
        [TestMethod]
        public void TestMethod3()//listede_yok un 0 olmasýnýn kontrolü
        {
            Sifreleme sifreleme = new Sifreleme();
            int a = sifreleme.listede_yok;
            Assert.AreEqual(0, a);
            
        }
        [TestMethod]
        public void TestMethod4()//attemptsin 0 olmasýnýn kontrolü
        {
            Sifreleme sifreleme = new Sifreleme();
            int a = sifreleme.attempts;
            Assert.AreEqual(0, a);

        }
        [TestMethod]
        public void TestMethod5()//tmpStr 0 olmasýnýn kontrolü
        {
            Sifreleme sifreleme = new Sifreleme();
            string a = sifreleme.tmpStr;
            Assert.AreEqual("", a);

        }




    }
}