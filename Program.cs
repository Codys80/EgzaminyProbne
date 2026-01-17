using System.Runtime.ConstrainedExecution;

namespace EgzaminProbny12ConsoleApp
{
    internal class Program
    {
        //************************************************
        //klasa: Notatka
        //opis: klasa obsługująca notatki
        //pola: liczbaNotatek - przechowuje liczbę instancji klasy
        //      id - przechowuje id danej instancji
        //      tytul - przechowuje tytuł notatki
        //      tresc - przechowuje tresc notatki
        //autor: CodyS80
        //************************************************
        class Notatka
        {
            private static int liczbaNotatek;
            private int id;
            protected string tytul, tresc;
            //**********************************************
            //nazwa funkcji: diagnozuj
            //opis funkcji: funkcja wyswietla wszystkie pola danej instancji klasy
            //parametry: brak
            //zwracany typ i opis: brak
            //autor: CodyS80
            //***********************************************

            public void diagnozuj()
            {
                Console.WriteLine(liczbaNotatek + ';' + this.id + ';' + this.tytul + ';' + this.tresc);
            }
            //**********************************************
            //nazwa funkcji: wyswietl
            //opis funkcji: funkcja wyswietla tytuł i treść danej notatki
            //parametry: brak
            //zwracany typ i opis: brak
            //autor: CodyS80
            //***********************************************
            public void wyswietl()
            {
                Console.WriteLine("\t"+this.tytul+"\n"+ this.tresc);
            }
            //**********************************************
            //nazwa funkcji: Notatka
            //opis funkcji: konstruktor klasy, przypisuje wartości dla pól tytul i tresc, inkrementuje liczbaNotatek i ustawia id
            //parametry: string tytul,
            //           reprezentuje dane wprowadzone przez użytkownika w celu przypisania ich do pola tytul
            //           string tresc
            //           reprezentuje dane wprowadzone przez użytkownika w celu przypisania ich do pola tresc
            //zwracany typ i opis: brak
            //autor: CodyS80
            //***********************************************
            public Notatka(string tytul, string tresc)
            {
                this.tytul = tytul;
                this.tresc = tresc;
                liczbaNotatek = liczbaNotatek + 1;
                id = liczbaNotatek;
            }
        }
        static void Main(string[] args)
        {
            Notatka A1 = new Notatka("O granicach dobra i zła [32]", "Sed ut perspiciatis, unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam eaque ipsa, quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt, explicabo. Nemo enim ipsam voluptatem, quia voluptas sit, aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos, qui ratione voluptatem sequi nesciunt, neque porro quisquam est, qui dolorem ipsum, quia dolor sit, amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt, ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit, qui in ea voluptate velit esse, quam nihil molestiae consequatur, vel illum, qui dolorem eum fugiat, quo voluptas nulla pariatur?");
            Notatka B2 = new Notatka("O granicach dobra i zła [33]", "At vero eos et accusamus et iusto odio dignissimos ducimus, qui blanditiis praesentium voluptatum deleniti atque corrupti, quos dolores et quas molestias excepturi sint, obcaecati cupiditate non provident, similique sunt in culpa, qui officia deserunt mollitia animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita distinctio. Nam libero tempore, cum soluta nobis est eligendi optio, cumque nihil impedit, quo minus id, quod maxime placeat, facere possimus, omnis voluptas assumenda est, omnis dolor repellendus. Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet, ut et voluptates repudiandae sint et molestiae non recusandae. Itaque earum rerum hic tenetur a sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores repellat.");
            A1.diagnozuj(); B2.diagnozuj();
            A1.wyswietl();
            B2.wyswietl();
        }
    }
}
