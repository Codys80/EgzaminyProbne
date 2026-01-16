# Część II. Aplikacja webowa
### Z zastosowaniem frameworka Angular lub biblioteki React.js (do wyboru) wykonaj aplikację internetową typu front-end będącą fragmentem aplikacji portalu społecznościowego pozwalającej na oglądanie filmów przesłanych przez użytkowników i dzielenia się swoimi wrażeniami na temat umieszczonych filmów.
### Założenia aplikacji:
 - Aplikacja składa się z dokładnie jednego komponentu, którego widok początkowy przedstawiono
 - Do utworzenia aplikacji należy wykorzystać materiały wideo i plik tekstowy o nazwie dane, które znajdują się w archiwum dołączonym do zadania
 - Z pliku dane.txt, który zawiera listę filmów z ich danymi, należy skopiować treść jako tablicę. Dane z tej tablicy należy wykorzystać w aplikacji 
 - Kod aplikacji powinien być zapisany czytelnie, z zachowaniem zasad czystego formatowania kodu, należy stosować znaczące, angielskie lub polskie nazwenictwo zmiennych i funkcji Zawartość interfejsu aplikacji:
 - Blok główny
 - Kolumna lewa
 - Blok wideo z włączonymi kontrolkami przeglądarki (wyświetlany jest aktualnie wybrany film), należy użyć materiałów wideo z archiwum
 - Nagłówek 2 stopnia, którego treścią jest tytuł aktualnie wybranego filmu
 - Akapit o treści „Dodany przez: <autor>, polubień: <polubienia>, wyświetleń: <wyswietlenia>”, gdzie fragmenty otoczone nawiasami < i > oznaczają wartości dotyczące aktualne wybranego filmu
 - Akapit zawierający przycisk o treści „Lubię to!”
 - Kolumna prawa
 - Nagłówek 2 stopnia o treści „Zobacz też inne filmy”
 - Lista zawierająca wszystkie filmy, treścią kolejnych elementów listy są tytuły filmów
### Działanie aplikacji:
 - Domyślnie aktualnie wybranym filmem jest pierwszy znajdujący się w tablicy, zostaje dla niego zwiększona liczba wyświetleń o 1
 - Kliknięcie przycisku „Lubię to!” powoduje zwiększenie liczby polubień aktualnie wybranego filmu o 1 (dozwolone jest kilkukrotne zwiększanie liczby polubień przez kilkukrotne wciskanie tego przycisku)
 - Kliknięcie jednego z elementów listy znajdującej się w prawej kolumnie powoduje zmienienie aktualnie wybranego filmu na ten, który został kliknięty. Zostaje zwiększona liczba wyświetleń o 1 (dla tego filmu)
### Wygląd aplikacji:
 - Przycisk i lista są stylowane z użyciem Bootstrap zgodnie 
 - Podział na dwie kolumny jest zrealizowany również z użyciem Bootstrap 
 - Blok wideo ma szerokość równą 100% szerokości kolumny
 - Blok główny ma ustawione margiesy wewnętrzne 48px (z każdej strony)