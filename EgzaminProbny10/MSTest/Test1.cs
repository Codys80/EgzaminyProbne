namespace EgzaminProbny10MSTest
{
    [TestClass]
    public sealed class Test1
    {
        public string szyfruj(string tekstJawny, int klucz)
        {
            klucz = klucz % 26;
            string tekstZaszyfrowany = tekstJawny;
            if (klucz != 0)
            {
                char[] tekstZaszyfrowany2 = new char[tekstJawny.Length];
                for (int i = 0; i < tekstJawny.Length; i++)
                {
                    if (tekstJawny[i] == ' ') { tekstZaszyfrowany2[i] = ' '; continue; }
                    tekstZaszyfrowany2[i] = Convert.ToChar(Convert.ToInt32(tekstJawny[i]) + klucz);
                    if ((Convert.ToInt32(tekstJawny[i]) + klucz) > 122)
                    {
                        tekstZaszyfrowany2[i] = Convert.ToChar((Convert.ToInt32(tekstJawny[i]) + klucz) % 122 + 96);
                    }
                    if ((Convert.ToInt32(tekstJawny[i]) + klucz) < 97)
                    {
                        tekstZaszyfrowany2[i] = Convert.ToChar(122 + Convert.ToInt32(tekstJawny[i]) % 96 + klucz);
                        Console.WriteLine(Convert.ToInt32(tekstJawny[i]) % 96 + klucz);
                    }
                }
                tekstZaszyfrowany = new string(tekstZaszyfrowany2);
            }
            return tekstZaszyfrowany;
        }


        [TestMethod]
        public void DanePodstawowe()
        {
            Assert.AreEqual("def", szyfruj("abc", 3));
        }
        [TestMethod]
        public void Zawijanie()
        {
            Assert.AreEqual("abc", szyfruj("xyz", 3));
        }
        [TestMethod]
        public void Odszyfrowanie()
        {
            Assert.AreEqual("abc", szyfruj("def", -3));
        }
        [TestMethod]
        public void KluczWiększyNiżDługośćAlfabetu()
        {
            Assert.AreEqual("def", szyfruj("abc", 29));
        }
        [TestMethod]
        public void SpacjaWTekście()
        {
            Assert.AreEqual("cd ef", szyfruj("ab cd", 2));
        }
    }
}
