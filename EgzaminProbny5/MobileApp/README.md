# Część II. Aplikacja mobilna
### Wykonaj aplikację mobilną za pomocą środowiska programistycznego dostępnego na stanowisku egzaminacyjnym oraz uruchom ją w dostępnym emulatorze systemu mobilnego.
### Opis wyglądu aplikacji
 - Napis „Rejestruj konto”.
 - Napis „Podaj e-mail:”, a pod nim pole edycyjne z podpowiedzią o treści „email”.
 - Napis „Podaj hasło:”, a pod nim pole edycyjne do wprowadzenia hasła, realizuje ukrywanie hasła jak na obrazach 1a i 1b.
 - Napis „Powtórz hasło:”, a pod nim pole edycyjne do wprowadzenia hasła, realizuje ukrywanie hasła jak na obrazach 1a i 1b.
 - Przycisk o treści „ZATWIERDŹ”, jest on wyśrodkowany.
 - Obszar do wyświetlania komunikatów, jest on wyśrodkowany.
### Działanie aplikacji
 - Po wybraniu przycisku ZATWIERDŹ jest sprawdzane:
 - Czy e-mail zawiera znak @.
 - Czy podane hasło jest równe powtórzonemu hasłu.
 - W obszarze do wyświetlania komunikatów pojawia się napis:
 - Na początku działania aplikacji: „Autor”, dalej wstawiony numer PESEL zdającego.
 - Po zatwierdzeniu, gdy e-mail jest niepoprawny: „Nieprawidłowy adres e-mail”.
 - Po zatwierdzeniu, gdy hasła się różnią: „Hasła się różnią”.
 - Po zatwierdzeniu, gdy nie wystąpiły błędy: „Witaj <e-mail>”, gdzie <e-mail> oznacza aktualnie wprowadzony adres e-mail.
### Założenia aplikacji
 - Interfejs użytkownika zapisany za pomocą języka znaczników wspieranego w danym środowisku (np. XAML, XML).
 - Zastosowany typ rozkładu liniowy (Linear / Stack lub inny o tej idei).
 - Zastosowany kolor tła dla napisu „Rejestruj konto”: Teal (#008080) ,zgodnie z Obrazem 1a.
 - Zastosowany kolory czcionki: czarny i biały, zgodnie z Obrazem 1a.
‒ Czcionka napisu „Rejestruj konto” jest wizualnie większa od pozostałych.
‒ Pola edycyjne są rozciągnięte na całą szerokość ekranu.
‒ Aplikacja powinna być zapisana czytel
