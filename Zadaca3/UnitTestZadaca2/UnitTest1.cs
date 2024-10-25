using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Zadaca2;

namespace UnitTestZadaca2
{
    [TestClass]
    public class UnitTest1
    {
        List<Osoba> nizOsoba = new List<Osoba>();
        List<Osoba> nizOsoba2 = new List<Osoba>();
        int[] nizInt = new int[5];
        string[] nizString = new string[5];

        [TestInitialize]
        public void Napuni()
        {
            nizInt[0] = 78;
            nizInt[1] = 11;
            nizInt[2] = 234;
            nizInt[3] = 81;
            nizInt[4] = 19;

            nizString[0] = "Mersad";
            nizString[1] = "Berin";
            nizString[2] = "Azra";
            nizString[3] = "Zijad";
            nizString[4] = "Rijad";

            nizOsoba.Add(new Osoba("Berin", "Masovic", "2001-05-12", 192, 80));
            nizOsoba.Add(new Osoba("Neko", "Nekic", "2012-02-02", 152, 60));
            nizOsoba.Add(new Osoba("Mahmut", "mahmutovic", "1998-11-01", 182, 89));
            nizOsoba.Add(new Osoba("Adis", "Kos", "2001-05-10", 188, 91));
            nizOsoba.Add(new Osoba("Mahir", "Korac", "1978-12-28", 179, 71));


            nizOsoba2.Add(new Osoba("Berin", "Masovic", "2001-05-12", 192, 80));
            nizOsoba2.Add(new Osoba("Neko", "Nekic", "2012-02-02", 152, 60));
            nizOsoba2.Add(new Osoba("Mahmut", "mahmutovic", "1998-11-01", 182, 89));
            nizOsoba2.Add(new Osoba("Adis", "Kos", "2001-05-10", 188, 91));
            nizOsoba2.Add(new Osoba("Mahir", "Korac", "1978-12-28", 179, 71));

        }

        [TestMethod]
        public void TestSelectionSort()
        {           

             AlgoritamSelectionSort.SelectionSort(ref nizInt);

            Assert.AreEqual(nizInt[0], 11);
            Assert.AreEqual(nizInt[1], 19);
            Assert.AreEqual(nizInt[2], 78);
            Assert.AreEqual(nizInt[3], 81);
            Assert.AreEqual(nizInt[4], 234);

            AlgoritamSelectionSort.SelectionSort(ref nizString);

            Assert.AreEqual(nizString[0], "Azra");
            Assert.AreEqual(nizString[1], "Berin");
            Assert.AreEqual(nizString[2], "Mersad");
            Assert.AreEqual(nizString[3], "Rijad");
            Assert.AreEqual(nizString[4], "Zijad");

            AlgoritamSelectionSort.SelectionSort(ref nizOsoba, 0);

            Assert.AreEqual(nizOsoba[0].ime, "Adis");
            Assert.AreEqual(nizOsoba[1].prezime, "Masovic");
            Assert.AreEqual(nizOsoba[2].datum_rodenja, "1978-12-28");
            Assert.AreEqual(nizOsoba[3].visina, 182);
            Assert.AreEqual(nizOsoba[4].tezina, 60);
            Assert.AreEqual(5, nizOsoba.Count);


            AlgoritamSelectionSort.SelectionSort(ref nizOsoba2, 4);

            Assert.AreEqual(nizOsoba2[0].ime, "Neko");
            Assert.AreEqual(nizOsoba2[1].prezime, "Korac");
            Assert.AreEqual(nizOsoba2[2].datum_rodenja, "2001-05-12");
            Assert.AreEqual(nizOsoba2[3].visina, 182);
            Assert.AreEqual(nizOsoba2[4].tezina, 91);

        }


        [TestMethod]
        public void TestShellSort()
        {

            AlgoritamShellSort.ShellSort(ref nizInt);

            Assert.AreEqual(nizInt[0], 11);
            Assert.AreEqual(nizInt[1], 19);
            Assert.AreEqual(nizInt[2], 78);
            Assert.AreEqual(nizInt[3], 81);
            Assert.AreEqual(nizInt[4], 234);

            AlgoritamShellSort.ShellSort(ref nizString);

            Assert.AreEqual(nizString[0], "Azra");
            Assert.AreEqual(nizString[1], "Berin");
            Assert.AreEqual(nizString[2], "Mersad");
            Assert.AreEqual(nizString[3], "Rijad");
            Assert.AreEqual(nizString[4], "Zijad");

            AlgoritamShellSort.ShellSort(ref nizOsoba, 0);

            Assert.AreEqual(nizOsoba[0].ime, "Adis");
            Assert.AreEqual(nizOsoba[1].prezime, "Masovic");
            Assert.AreEqual(nizOsoba[2].datum_rodenja, "1978-12-28");
            Assert.AreEqual(nizOsoba[3].visina, 182);
            Assert.AreEqual(nizOsoba[4].tezina, 60);

            AlgoritamShellSort.ShellSort(ref nizOsoba2, 4);

            Assert.AreEqual(nizOsoba2[0].ime, "Neko");
            Assert.AreEqual(nizOsoba2[1].prezime, "Korac");
            Assert.AreEqual(nizOsoba2[2].datum_rodenja, "2001-05-12");
            Assert.AreEqual(nizOsoba2[3].visina, 182);
            Assert.AreEqual(nizOsoba2[4].tezina, 91);

        }

        [TestMethod]
        public void TestBubbleSort()
        {

            int[] nizInt = new int[5];
            nizInt[0] = 78;
            nizInt[1] = 11;
            nizInt[2] = 234;
            nizInt[3] = 81;
            nizInt[4] = 19;

            AlgoritamBubbleSort.BubbleSort(ref nizInt);

            Assert.AreEqual(nizInt[0], 11);
            Assert.AreEqual(nizInt[1], 19);
            Assert.AreEqual(nizInt[2], 78);
            Assert.AreEqual(nizInt[3], 81);
            Assert.AreEqual(nizInt[4], 234);

            AlgoritamBubbleSort.BubbleSort(ref nizString);

            Assert.AreEqual(nizString[0], "Azra");
            Assert.AreEqual(nizString[1], "Berin");
            Assert.AreEqual(nizString[2], "Mersad");
            Assert.AreEqual(nizString[3], "Rijad");
            Assert.AreEqual(nizString[4], "Zijad");

            AlgoritamBubbleSort.BubbleSort(ref nizOsoba, 0);

            Assert.AreEqual(nizOsoba[0].ime, "Adis");
            Assert.AreEqual(nizOsoba[1].prezime, "Masovic");
            Assert.AreEqual(nizOsoba[2].datum_rodenja, "1978-12-28");
            Assert.AreEqual(nizOsoba[3].visina, 182);
            Assert.AreEqual(nizOsoba[4].tezina, 60);


            AlgoritamBubbleSort.BubbleSort(ref nizOsoba2, 4);

            Assert.AreEqual(nizOsoba2[0].ime, "Neko");
            Assert.AreEqual(nizOsoba2[1].prezime, "Korac");
            Assert.AreEqual(nizOsoba2[2].datum_rodenja, "2001-05-12");
            Assert.AreEqual(nizOsoba2[3].visina, 182);
            Assert.AreEqual(nizOsoba2[4].tezina, 91);

        }

        [TestMethod]
        public void TestInsertionSort()
        {

            int[] nizInt = new int[5];
            nizInt[0] = 78;
            nizInt[1] = 11;
            nizInt[2] = 234;
            nizInt[3] = 81;
            nizInt[4] = 19;

            AlgoritamInsertionSort.InsertionSort(ref nizInt);

            Assert.AreEqual(nizInt[0], 11);
            Assert.AreEqual(nizInt[1], 19);
            Assert.AreEqual(nizInt[2], 78);
            Assert.AreEqual(nizInt[3], 81);
            Assert.AreEqual(nizInt[4], 234);

            AlgoritamInsertionSort.InsertionSort(ref nizString);

            Assert.AreEqual(nizString[0], "Azra");
            Assert.AreEqual(nizString[1], "Berin");
            Assert.AreEqual(nizString[2], "Mersad");
            Assert.AreEqual(nizString[3], "Rijad");
            Assert.AreEqual(nizString[4], "Zijad");

            AlgoritamInsertionSort.InsertionSort(ref nizOsoba, 0);

            Assert.AreEqual(nizOsoba[0].ime, "Adis");
            Assert.AreEqual(nizOsoba[1].prezime, "Masovic");
            Assert.AreEqual(nizOsoba[2].datum_rodenja, "1978-12-28");
            Assert.AreEqual(nizOsoba[3].visina, 182);
            Assert.AreEqual(nizOsoba[4].tezina, 60);

            AlgoritamInsertionSort.InsertionSort(ref nizOsoba2, 4);

            Assert.AreEqual(nizOsoba2[0].ime, "Neko");
            Assert.AreEqual(nizOsoba2[1].prezime, "Korac");
            Assert.AreEqual(nizOsoba2[2].datum_rodenja, "2001-05-12");
            Assert.AreEqual(nizOsoba2[3].visina, 182);
            Assert.AreEqual(nizOsoba2[4].tezina, 91);

        }


        [TestMethod]
        public void TestCombSort()
        {

            int[] nizInt = new int[5];
            nizInt[0] = 78;
            nizInt[1] = 11;
            nizInt[2] = 234;
            nizInt[3] = 81;
            nizInt[4] = 19;

            AlgoritamCombSort.CombSort(ref nizInt);

            Assert.AreEqual(nizInt[0], 11);
            Assert.AreEqual(nizInt[1], 19);
            Assert.AreEqual(nizInt[2], 78);
            Assert.AreEqual(nizInt[3], 81);
            Assert.AreEqual(nizInt[4], 234);

            AlgoritamCombSort.CombSort(ref nizString);

            Assert.AreEqual(nizString[0], "Azra");
            Assert.AreEqual(nizString[1], "Berin");
            Assert.AreEqual(nizString[2], "Mersad");
            Assert.AreEqual(nizString[3], "Rijad");
            Assert.AreEqual(nizString[4], "Zijad");

            AlgoritamCombSort.CombSort(ref nizOsoba, 0);

            Assert.AreEqual(nizOsoba[0].ime, "Adis");
            Assert.AreEqual(nizOsoba[1].prezime, "Masovic");
            Assert.AreEqual(nizOsoba[2].datum_rodenja, "1978-12-28");
            Assert.AreEqual(nizOsoba[3].visina, 182);
            Assert.AreEqual(nizOsoba[4].tezina, 60);

            AlgoritamCombSort.CombSort(ref nizOsoba2, 4);

            Assert.AreEqual(nizOsoba2[0].ime, "Neko");
            Assert.AreEqual(nizOsoba2[1].prezime, "Korac");
            Assert.AreEqual(nizOsoba2[2].datum_rodenja, "2001-05-12");
            Assert.AreEqual(nizOsoba2[3].visina, 182);
            Assert.AreEqual(nizOsoba2[4].tezina, 91);

        }


        [TestMethod]
        public void TestCocktailSort()
        {

            int[] nizInt = new int[5];
            nizInt[0] = 78;
            nizInt[1] = 11;
            nizInt[2] = 234;
            nizInt[3] = 81;
            nizInt[4] = 19;

            AlgoritamCocktailSort.CocktailSort(ref nizInt);

            Assert.AreEqual(nizInt[0], 11);
            Assert.AreEqual(nizInt[1], 19);
            Assert.AreEqual(nizInt[2], 78);
            Assert.AreEqual(nizInt[3], 81);
            Assert.AreEqual(nizInt[4], 234);

            AlgoritamCocktailSort.CocktailSort(ref nizString);

            Assert.AreEqual(nizString[0], "Azra");
            Assert.AreEqual(nizString[1], "Berin");
            Assert.AreEqual(nizString[2], "Mersad");
            Assert.AreEqual(nizString[3], "Rijad");
            Assert.AreEqual(nizString[4], "Zijad");

            AlgoritamCocktailSort.CocktailSort(ref nizOsoba, 0);

            Assert.AreEqual(nizOsoba[0].ime, "Adis");
            Assert.AreEqual(nizOsoba[1].prezime, "Masovic");
            Assert.AreEqual(nizOsoba[2].datum_rodenja, "1978-12-28");
            Assert.AreEqual(nizOsoba[3].visina, 182);
            Assert.AreEqual(nizOsoba[4].tezina, 60);

            AlgoritamCocktailSort.CocktailSort(ref nizOsoba2, 4);

            Assert.AreEqual(nizOsoba2[0].ime, "Neko");
            Assert.AreEqual(nizOsoba2[1].prezime, "Korac");
            Assert.AreEqual(nizOsoba2[2].datum_rodenja, "2001-05-12");
            Assert.AreEqual(nizOsoba2[3].visina, 182);
            Assert.AreEqual(nizOsoba2[4].tezina, 91);

        }


        [TestMethod]
        public void TestHeapSort()
        {

            int[] nizInt = new int[5];
            nizInt[0] = 78;
            nizInt[1] = 11;
            nizInt[2] = 234;
            nizInt[3] = 81;
            nizInt[4] = 19;

            AlgoritamHeapSort.HeapSort(ref nizInt);

            Assert.AreEqual(nizInt[0], 11);
            Assert.AreEqual(nizInt[1], 19);
            Assert.AreEqual(nizInt[2], 78);
            Assert.AreEqual(nizInt[3], 81);
            Assert.AreEqual(nizInt[4], 234);

            AlgoritamHeapSort.HeapSort(ref nizString);

            Assert.AreEqual(nizString[0], "Azra");
            Assert.AreEqual(nizString[1], "Berin");
            Assert.AreEqual(nizString[2], "Mersad");
            Assert.AreEqual(nizString[3], "Rijad");
            Assert.AreEqual(nizString[4], "Zijad");

            AlgoritamHeapSort.HeapSort(ref nizOsoba, 0);

            Assert.AreEqual(nizOsoba[0].ime, "Adis");
            Assert.AreEqual(nizOsoba[1].prezime, "Masovic");
            Assert.AreEqual(nizOsoba[2].datum_rodenja, "1978-12-28");
            Assert.AreEqual(nizOsoba[3].visina, 182);
            Assert.AreEqual(nizOsoba[4].tezina, 60);

            AlgoritamHeapSort.HeapSort(ref nizOsoba2, 4);

            Assert.AreEqual(nizOsoba2[0].ime, "Neko");
            Assert.AreEqual(nizOsoba2[1].prezime, "Korac");
            Assert.AreEqual(nizOsoba2[2].datum_rodenja, "2001-05-12");
            Assert.AreEqual(nizOsoba2[3].visina, 182);
            Assert.AreEqual(nizOsoba2[4].tezina, 91);

        }

        [TestMethod]
        public void TestGnomeSort()
        {

            int[] nizInt = new int[5];
            nizInt[0] = 78;
            nizInt[1] = 11;
            nizInt[2] = 234;
            nizInt[3] = 81;
            nizInt[4] = 19;

            AlgoritamGnomeSort.GnomeSort(ref nizInt, nizInt.Length);

            Assert.AreEqual(nizInt[0], 11);
            Assert.AreEqual(nizInt[1], 19);
            Assert.AreEqual(nizInt[2], 78);
            Assert.AreEqual(nizInt[3], 81);
            Assert.AreEqual(nizInt[4], 234);

            AlgoritamGnomeSort.GnomeSort(ref nizString, nizString.Length);

            Assert.AreEqual(nizString[0], "Azra");
            Assert.AreEqual(nizString[1], "Berin");
            Assert.AreEqual(nizString[2], "Mersad");
            Assert.AreEqual(nizString[3], "Rijad");
            Assert.AreEqual(nizString[4], "Zijad");

            AlgoritamGnomeSort.GnomeSort(ref nizOsoba, nizOsoba.Count, 0);

            Assert.AreEqual(nizOsoba[0].ime, "Adis");
            Assert.AreEqual(nizOsoba[1].prezime, "Masovic");
            Assert.AreEqual(nizOsoba[2].datum_rodenja, "1978-12-28");
            Assert.AreEqual(nizOsoba[3].visina, 182);
            Assert.AreEqual(nizOsoba[4].tezina, 60);

            AlgoritamGnomeSort.GnomeSort(ref nizOsoba2, nizOsoba2.Count, 4);

            Assert.AreEqual(nizOsoba2[0].ime, "Neko");
            Assert.AreEqual(nizOsoba2[1].prezime, "Korac");
            Assert.AreEqual(nizOsoba2[2].datum_rodenja, "2001-05-12");
            Assert.AreEqual(nizOsoba2[3].visina, 182);
            Assert.AreEqual(nizOsoba2[4].tezina, 91);

        }

        [TestMethod]
        public void TestOddEvenSort()
        {

            int[] nizInt = new int[5];
            nizInt[0] = 78;
            nizInt[1] = 11;
            nizInt[2] = 234;
            nizInt[3] = 81;
            nizInt[4] = 19;

            AlgoritamOddEvenSort.OddEvenSort(ref nizInt, nizInt.Length);

            Assert.AreEqual(nizInt[0], 11);
            Assert.AreEqual(nizInt[1], 19);
            Assert.AreEqual(nizInt[2], 78);
            Assert.AreEqual(nizInt[3], 81);
            Assert.AreEqual(nizInt[4], 234);

            AlgoritamOddEvenSort.OddEvenSort(ref nizString, nizString.Length);

            Assert.AreEqual(nizString[0], "Azra");
            Assert.AreEqual(nizString[1], "Berin");
            Assert.AreEqual(nizString[2], "Mersad");
            Assert.AreEqual(nizString[3], "Rijad");
            Assert.AreEqual(nizString[4], "Zijad");

            AlgoritamOddEvenSort.OddEvenSort(ref nizOsoba, nizOsoba.Count, 0);

            Assert.AreEqual(nizOsoba[0].ime, "Adis");
            Assert.AreEqual(nizOsoba[1].prezime, "Masovic");
            Assert.AreEqual(nizOsoba[2].datum_rodenja, "1978-12-28");
            Assert.AreEqual(nizOsoba[3].visina, 182);
            Assert.AreEqual(nizOsoba[4].tezina, 60);


            AlgoritamOddEvenSort.OddEvenSort(ref nizOsoba2, nizOsoba2.Count, 4);

            Assert.AreEqual(nizOsoba2[0].ime, "Neko");
            Assert.AreEqual(nizOsoba2[1].prezime, "Korac");
            Assert.AreEqual(nizOsoba2[2].datum_rodenja, "2001-05-12");
            Assert.AreEqual(nizOsoba2[3].visina, 182);
            Assert.AreEqual(nizOsoba2[4].tezina, 91);

        }

        [TestMethod]
        public void ZamjenskiObjekat()
        {

            ZamjenskiObjekat z = new ZamjenskiObjekat();
            Assert.IsNotNull(z);

            string[] imena = z.ime();
            string[] prezimena = z.prezime();
            string[] datumi = z.datum_rodenja();
            int[] visine = z.visina();
            int[] tezine = z.tezina();

            List<Osoba> listaOsoba = new List<Osoba>();
            List<Osoba> listaOsoba2 = new List<Osoba>();

            for (int i = 0; i < imena.Length; i++)
            {

                Osoba osoba = new Osoba();
                osoba.ime = imena[i];
                osoba.prezime = prezimena[i]; 
                osoba.datum_rodenja = datumi[i];
                osoba.visina = visine[i];
                osoba.tezina = tezine[i];

                listaOsoba.Add(osoba);
                listaOsoba2.Add(osoba);

            }

            AlgoritamSelectionSort.SelectionSort(ref listaOsoba, 4);

            Assert.AreEqual(listaOsoba[0].ime, "Neko");
            Assert.AreEqual(listaOsoba[1].prezime, "Korac");
            Assert.AreEqual(listaOsoba[2].datum_rodenja, "2001-05-12");
            Assert.AreEqual(listaOsoba[3].visina, 182);
            Assert.AreEqual(listaOsoba[4].tezina, 91);

            AlgoritamHeapSort.HeapSort(ref listaOsoba2, 0);

            Assert.AreEqual(listaOsoba2[0].ime, "Adis");
            Assert.AreEqual(listaOsoba2[1].prezime, "Masovic");
            Assert.AreEqual(listaOsoba2[2].datum_rodenja, "1978-12-28");
            Assert.AreEqual(listaOsoba2[3].visina, 182);
            Assert.AreEqual(listaOsoba2[4].tezina, 60);


        }

        [TestMethod]
        public void TestOsoba()
        {

            Osoba o = new Osoba();

            o.ime = "Berin";
            o.prezime = "Masovic";
            o.datum_rodenja = "2001-05-12";
            o.visina = 192;
            o.tezina = 80;
           

            Assert.AreEqual(o.daj("0"), "Berin");
            Assert.AreEqual(o.daj("1"), "Masovic");
            Assert.AreEqual(o.daj("2"), "2001-05-12");
            Assert.AreEqual(o.daj(3), 192);
            Assert.AreEqual(o.daj(4), 80);
            Assert.AreEqual(o.daj(5), 0);
            Assert.AreEqual(o.daj(""), "");

            Assert.AreEqual(o.vrati(0), "imenu");
            Assert.AreEqual(o.vrati(1), "prezimenu");
            Assert.AreEqual(o.vrati(2), "datumu rodenja");
            Assert.AreEqual(o.vrati(3), "visini");
            Assert.AreEqual(o.vrati(4), "tezini");
            Assert.AreEqual(o.vrati(5), "");

        }

        [TestMethod]
        public void RandomDate() {

            string trenutniDatum = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();

            string date = RandomDateTime.RandomDate();
            Assert.IsTrue(date.CompareTo("1959-01-01") > 0);
            Assert.IsTrue(date.CompareTo(trenutniDatum) < 0);

            date = RandomDateTime.RandomDate();
            Assert.IsTrue(date.CompareTo("1959-01-1") > 0);
            Assert.IsTrue(date.CompareTo(trenutniDatum) < 0);

            date = RandomDateTime.RandomDate();
            Assert.IsTrue(date.CompareTo("1959-01-01") > 0);
            Assert.IsTrue(date.CompareTo(trenutniDatum) < 0);

            date = RandomDateTime.RandomDate();
            Assert.IsTrue(date.CompareTo("1959-01-01") > 0);
            Assert.IsTrue(date.CompareTo(trenutniDatum) < 0);

        }

        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", 
                    "|DataDirectory|\\Zadaca2CSV.csv", 
                    "Zadaca2CSV#csv", 
                    DataAccessMethod.Sequential),
         DeploymentItem("Zadaca2CSV.csv"),TestMethod]
        public void testZaCSV()
        {   
            string ime = testContextInstance.DataRow["ime"].ToString();
            string prezime = testContextInstance.DataRow["prezime"].ToString();
            string datum_rodenja = testContextInstance.DataRow["datum_rodenja"].ToString();
            int visina = Int32.Parse(testContextInstance.DataRow["visina"].ToString());
            int tezina = Int32.Parse(testContextInstance.DataRow["tezina"].ToString());

            Osoba o = new Osoba(ime, prezime, datum_rodenja, visina, tezina);

            Assert.AreEqual(o.ime, ime);
            Assert.AreEqual(o.prezime, prezime);
            Assert.AreEqual(o.datum_rodenja, datum_rodenja);
            Assert.AreEqual(o.visina, visina);
            Assert.AreEqual(o.tezina, tezina);

        }

        [TestCleanup]
        public void Obrisi()
        {

            nizOsoba.Clear();
            nizOsoba2.Clear();

        }

    }
}
