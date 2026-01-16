using System.Text;

namespace EgzaminProbny10ConsoleApp
{
    internal class Program
    {
        class Egzamin
        {
            public string szyfruj(string tekstJawny, int klucz)
            {
                klucz = klucz % 26;
                string tekstZaszyfrowany = tekstJawny;
                if (klucz != 0)
                {
                    char[] tekstZaszyfrowany2 = new char[tekstJawny.Length];
                    for (int i = 0; i<tekstJawny.Length; i++)
                    {
                        if (tekstJawny[i] == ' ') { tekstZaszyfrowany2[i] = ' '; continue; }
                        tekstZaszyfrowany2[i] = Convert.ToChar(Convert.ToInt32(tekstJawny[i]) + klucz);
                        if ( (Convert.ToInt32(tekstJawny[i]) + klucz) > 122)
                        {
                            tekstZaszyfrowany2[i] = Convert.ToChar((Convert.ToInt32(tekstJawny[i]) + klucz ) % 122 + 96);
                        }
                        if ((Convert.ToInt32(tekstJawny[i]) + klucz) < 97)
                        {
                            tekstZaszyfrowany2[i] = Convert.ToChar(
                                122 + Convert.ToInt32(tekstJawny[i]) % 96 + klucz//122 - Convert.ToInt32(tekstJawny[i] + klucz) % 97//97 +  Convert.ToInt32(tekstJawny[i] + klucz) % 25  //122 - Convert.ToInt32(tekstJawny[i]) % 97  //Convert.ToInt32(tekstJawny[i]) % 26   //96 + Convert.ToInt32(tekstJawny[i]) % 25 + klucz //122 - (Convert.ToInt32(tekstJawny[i]) % 94 + klucz)  //122 - (Convert.ToInt32(tekstJawny[i]) % 97 + klucz)
                                );
                            Console.WriteLine(Convert.ToInt32(tekstJawny[i]) % 96 + klucz);
                        }



                        //if ((Convert.ToInt32(tekstJawny[i]) + klucz) > 122)
                        //    tekstZaszyfrowany2[i] = Convert.ToChar(97 + (klucz - 1) );
                        //else if ((Convert.ToInt32(tekstJawny[i]) + klucz) < 97)
                        //    tekstZaszyfrowany2[i] = Convert.ToChar(122 + (klucz + 1));




                    }
                    tekstZaszyfrowany = new string(tekstZaszyfrowany2);
                }
                return tekstZaszyfrowany;
            }
        }
        static void Main(string[] args)
        {
            Egzamin E = new Egzamin();
            Console.WriteLine( E.szyfruj("abc xyz", -3) );
        }
    }
}
