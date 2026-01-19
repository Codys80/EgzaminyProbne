namespace ConsoleApp
{
    internal class Program
    {   
        //*********************************************
        // klasa: Egzamin
        // opis: klasa reprezentuje narzędzia dla typu łańcuchowego
        // metody: samogłoski - int
        //         powtorzenia - string
        // autor: CodyS80
        //************************************************
        class Egzamin()
        {
            public static int samogłoski(string tekst)
            {
                int licznik = 0;
                string samogłoski = "aąeęiouóyAĄEĘIOUÓY";
                for (int i = 0; i< samogłoski.Length; i++)
                {
                    if (tekst.Contains(samogłoski[i]) ) licznik++;
                }
                return licznik;
            }
            public static string powtorzenia(string tekst)
            {
                if(tekst == null && tekst == "" && tekst == string.Empty) return "";
                char[] bezPowtorzeń = new char[tekst.Length];
                int j = 0;
                for(int i = 0; i<tekst.Length; i++)
                {
                    if(i == tekst.Length - 1) bezPowtorzeń[j] = tekst[i];
                    else if (tekst[i] != tekst[i + 1]) 
                    {
                        bezPowtorzeń[j] = tekst[i];
                        j++;
                    }
                }
                return new string(bezPowtorzeń);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Egzamin.samogłoski("aąeęiouóyAĄEĘIOUÓY").ToString());
            Console.WriteLine(Egzamin.powtorzenia("Abba;;;to zespół").ToString());
            Console.WriteLine(Egzamin.powtorzenia("").ToString());
        }
    }
}
