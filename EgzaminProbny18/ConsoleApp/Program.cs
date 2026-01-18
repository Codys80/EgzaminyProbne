using System.Runtime.ConstrainedExecution;

namespace ConsoleApp
{
    internal class Program
    {
        class Urządzenie
        {
            public void wyświetl(string komunikat)
            {
                Console.WriteLine(komunikat);
            }
        }
        class Pralka : Urządzenie
        {
            private int program = 0;
            public void ustawProgram(int program)
            {
                this.program = program;
                
                if (program > 12) { this.program = 0; wyświetl("Niepoprawny numer programu"); }
                else wyświetl("Program został utworzony");
            }
        }
        class Odkurzacz : Urządzenie
        {
            private bool stan = false;
            public void on()
            {
                this.stan = true;
                wyświetl("Odkurzacz włączono");
            }
            //**********************************************
            //nazwa metody: off
            //opis funkcji: funkcja wyłącza odkurzacz poprzez zmianę wartości bool stan na false
            //parametry: brak
            //zwracany typ i opis: brak
            //autor: CodyS80
            //***********************************************
            public void off()
            {
                this.stan = false;
                wyświetl("Odkurzacz wyłączono");
            }
        }
        static void Main(string[] args)
        {
            Pralka pralka = new Pralka();
            Odkurzacz odkurzacz = new Odkurzacz();

            pralka.ustawProgram(1);
            pralka.ustawProgram(14);

            odkurzacz.on();
            odkurzacz.off();
        }
    }
}
