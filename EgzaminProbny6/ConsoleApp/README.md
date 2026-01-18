# Część I. Aplikacja konsolowa
### Napisz program implementujący algorytm przeszukiwania tablicy z wartownikiem. Opis algorytmu:
By odnaleźć element x podejmiemy następujące kroki:
 1. na końcu tablicy (pod indeksem n+1) wstawimy szukany element x - będzie to nasz wartownik, w przypadku, gdy nie znajdziemy go nigdzie indziej w tablicy, zabezpieczy nas on przed wyjściem poza tablicę,
 2. przejdziemy po kolejnych elementach tablicy, tak długo aż nie znajdziemy szukanego elementu,
 3. w momencie znalezienia szukanego elementu x sprawdzamy, który jest to element tablicy? Jeżeli jest to ostatni element tablicy (n+1) to trafiliśmy na naszego wartownika i oznacza to, że w tablicy nie było szukanego elementu x, w przeciwnym razie element x został odnaleziony.
### Założenia do programu:
 - Program wykonywany w konsoli.
 - Zastosowany obiektowy język programowania zgodny z zainstalowanym na stanowisku egzaminacyjnym: C++ lub C#, lub Java, lub Python.
 - Przeszukiwana jest minimum 50 elementowa tablica liczb całkowitych wypełniona wartościami pseudolosowymi z zakresu od 1 do 100.
 - Wyszukiwane jest pierwsze wystąpienie elementu w tablicy.
 - Wypełnianie tablicy i przeszukiwanie jest realizowane w oddzielnych funkcjach / metodach. Funkcja przeszukująca zwraca indeks odnalezionego elementu.
 - Wartość do wyszukania jest pobierana z klawiatury.
 -  Po przeszukaniu tablicy na ekranie wyświetlana jest zawartość tablicy (liczby oddzielone przecinkami) oraz indeks, pod którym odszukano wartość lub w przypadku jej braku – stosowny komunikat.
 - Program powinien podejmować zrozumiałą komunikację z użytkownikiem, dane wprowadzane i wyprowadzane powinny być opatrzone zrozumiałym opisem.
 - Program powinien być zapisany czytelnie, z zachowaniem zasad czystego formatowania kodu, należy stosować znaczące nazwy zmiennych i funkcji.
 - Program główny powinien zawierać test działania aplikacji.
