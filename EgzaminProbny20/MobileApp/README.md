# Część 2: Aplikacja Mobilna
### Za pomocą środowiska programistycznego dostępnego na stnaowisku egzaminacyjnym wykonaj aplikację mobilną quizu dotyczącego gór. 
### Do zbudowania aplikacji zastosuj obrazy i treść pytań z archiwum zad2.7z zabezpieczonego hasłem ?Quiz5

### Podczas programowania aplikacji zmiany kodu rejestruj za pomocą repozytorium wersji Git. PO przygotowaniu projektu utwórz lokalne repozytorium wersji Git, podczas pracy utwórz co najmniej 2 zapisy wersji: po utworzeniu widok aplikacji oraz po zapisaniu działania aplikacji. Komentarze migawek (commit) powinny być znaczące. SKofiguruj repozytorium Git: jako nazwę użytkownika użyj numer zdającego  , jako email użytkownik egzamin@poczta.pl

### Elementy aplikacji z wartościami początkowymi:
- Obraz z wartością początkową zad1.jpg
- Pole tekstowe z treścią pytania: "Które to schornisko?"
- Trzy pola radio z odpowiedziami: "Na Rysiance.", "Na Wielkiej Raczy", "Na Wielkiej Rycerzowej"
- Przycisk Dalej

### Założenia dotyczące widoku:
- Interfejs użytkownika zapisany za pomocą języka znaczników wspieranego w danym srodowisku
- Zastosoawny dowolny rozkład pozwalający na rozpieszczenie elementów zgodnie z obrazami 1 lub 2
- Tło okna lub rozkładu #2E7CB8
- Biały kolor czcionki dla elementów
- Jednocześnie można wybrać tylko jedno pole radio
- Wyśrodkowane w poziomie obraz, treść pytania i przycisk
- Wyrówanne do lewej strony pola typu radio

### Działanie aplikacji(można wykorzystać klasy Pytanie, PytanieZamkniete z aplikacji konsolowej):
- Treść pytań i odpowiedzi możńa skopiować z pliku pytania.txt wypakowanego z archiwum ZIP
- Wszystkie pytania należy zapisać w tablicy, liście lub innej kolekcji. Aplickacja jest uniwersalna - zawsze działa na wszystkich elementach kolekcji
- PO wybraniu przycisku DALEJ:
	- Ikrementowana jest liczba punktów, jeśli wybrano prawidłową odpowiedź
	- Jeżeli istnieją  nastepne pytania w quizie, wyświetlane jest kolejne pytanie
	- W przeciwnym wypadku wyświetlane jest ponownie pytanie pierwsze
	- Wszyskie pola radio nie są zaznaczone
- Aplikacja powinna być zapisana czytelnie, z zachowaniem zasad czystego formatowania kodu, należy stosowaćznaczące nazwy zmiennych i funkcji
