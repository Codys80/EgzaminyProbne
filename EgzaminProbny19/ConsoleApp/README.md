# Część I. Aplikacja konsolowa
### Napisz program implementujący klasę z narzędziami dla typu łańcuchowego (string).
### Założenia do programu:
 - Program wykonywany w konsoli
 - Zastosowany obiektowy język programowania zgodny z zainstalowanym na stanowisku egzaminacyjnym: C++ lub C#, lub Java, lub Python
 - Klasa ma charakter biblioteki narzędziowej, nie jest przewidziane powoływanie obiektów tej klasy, wszystkie jej metody są statyczne i są widzialne poza klasą
 - Klasa zawiera dwie metody:
   - Metoda licząca wszystkie samogłoski:
     - Jako parametr przyjmuje zmienną typu tekstowego
     - Zwraca liczbę samogłosek znajdujących się w parametrze
     - Przez samogłoski rozumie się znaki: „aąeęiouóyAĄEĘIOUÓY”
     - W przypadku, gdy parametrem jest pusty łańcuch znaków lub null, metoda zwraca 0
   - Metoda usuwająca powtórzenia znaków występujące obok siebie:
     - Jako parametr przyjmuje łańcuch, w którym będą szukane powtórzenia
     - Zwraca łańcuch bez powtórzeń
     - W przypadku, gdy parametrem jest pusty łańcuch lub null, metoda zwraca pusty łańcuch
     - Wszystkie znaki łańcucha są sprawdzane, czy znak następny jest tym samym znakiem. Jeśli tak, jest on pomijany w wyjściowym łańcuchu znaków.
 - W programie głównym należy przetestować obie metody, wczytując łańcuch z klawiatury i wyświetlając liczbę samogłosek oraz łańcuch po eliminacji duplikatów
 - Program powinien podejmować zrozumiałą komunikację z użytkownikiem
 - W programie może być zastosowane angielskie lub polskie nazewnictwo
 - Program powinien być zapisany czytelnie, z zachowaniem zasad czystego formatowania kodu, należy stosować znaczące nazwy zmiennych, klasy i metod
 - Dokumentację aplikacji należy utworzyć zgodnie z opisem w części III treści zadania.