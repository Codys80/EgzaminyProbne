# Część II. Aplikacja mobilna
### Za pomocą środowiska programistycznego dostępnego na stanowisku egzaminacyjnym wykonaj aplikację mobilną do obsługi urządzeń domowych.
### Elementy aplikacji:
 - Napis (etykieta) o treści: „Urządzenia Domowe”
 - Napis o treści: „Autor: ”, dalej wstawiony numer zdającego
 - Rozkład dotyczący pralki:
   - Obraz pralka.jpg
   - Napis o treści: „Pralka”
   - Pole edycyjne z podpowiedzią o treści: „Podaj nr prania 1..12” umożliwiające wpisywanie jedynie liczb
   - Przycisk o treści: „Zatwierdź”
   - Napis o treści: „Numer prania: nie podano”
 - Rozkład dotyczący odkurzacza:
   - Obraz odkurzacz.jpg
   - Napis o treści: „Odkurzacz”
   - Przycisk o treści: „Włącz”
   - Napis o treści: „Odkurzacz wyłączony”
   - Napis o treści: „Status: naładowany”
### Działanie aplikacji:
 - Po wciśnięciu przycisku „Zatwierdź” pobierana jest liczba z pola edycyjnego, jeśli jest ona z przedziału od 1 do 12 to zmieniany jest napis poniżej na: „Numer prania: <numer>”, gdzie <numer> oznacza wartość podaną w polu edycyjnym 
 - Po wciśnięciu przycisku „Włącz”, zmienia się podpis przycisku na „Wyłącz” oraz treść napisu poniżej na: „Odkurzacz włączony”. Jeżeli kolejny raz zostanie wciśnięty przycisk, napisy wracają do stanu początkowego („Włącz” oraz „Odkurzacz wyłączony")
### Założenia aplikacji:
 - Interfejs użytkownika zapisany za pomocą języka znaczników wspieranego w danym środowisku (np. XAML, XML)
 - Zastosowane rozkłady liniowe (Linear / Stack lub inny o tej idei), aby można było uzyskać widok taki
jak na obrazach 3 i 4.
 - Kolory tła:
   - Dla głównego rozkładu lub strony: LightBlue (#ADD8E6)
   - Dla pola edycyjnego: SkyBlue (#87CEEB)
   - Dla przycisków: RoyalBlue (#4169E1)
 - Kolor czcionki wpisanego tekstu oraz czcionki podpowiedzi dla pola edycyjnego: Navy (#000080)
 - Marginesy zewnętrzne:
   - Dla pierwszych dwóch napisów 5
   - Dla przycisków 10
    - Dla obrazów marginesy lewy, prawy i dolny 20, górny 0
 - Tekst zapisany powiększoną czcionką dla napisów „Urządzenia Domowe”, „Pralka”, „Odkurzacz”
 - Pierwsze dwa napisy na stronie są wyśrodkowane
 - Obrazy mają wysokość 150
 - Aplikacja powinna być zapisana czytelnie, z zachowaniem zasad czystego formatowania kodu, należy stosować znaczące nazwy zmiennych i funkcji.