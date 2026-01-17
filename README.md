# Część I. Aplikacja konsolowa
### Napisz program implementujący klasę do obsługi notatek.
### Założenia do programu:
 - Program wykonywany w konsoli
 - Obiektowy język programowania zgodny z zainstalowanym na stanowisku egzaminacyjnym: C++ lub C#, lub Java, lub Python
 - Klasa notatka zawiera pola:
 - statyczne numeryczne licznika notatek do zliczania utworzonych notatek
 - numeryczne do zapisu unikalnego identyfikatora
 - dwa tekstowe do zapisu tytułu notatki i treści notatki
 - Dostęp do wszystkich pól jest ograniczony do wnętrza klasy notatka, przy czym pola identyfikatora i licznika nie są dostępne dla klas potomnych, a pola tekstowe są dostępne dla klas potomnych
 - Klasa notatka zawiera jeden konstruktor o parametrach wejściowych dla tytułu i treści. Ma on za zadanie kolejno:
 - inkrementować licznik notatek
 - ustawić pole identyfikatora równe licznikowi notatek, czyli pierwsza utworzona notatka ma id równe 1, druga – 2, itd.
 - ustawić pola tytułu i treści równe parametrom
 - Klasa notatka zawiera dwie metody bezparametrowe i niezwracające wartości, które mogą być wołane w programie głównym:
 - metodę wyświetlenia tytułu i treści notatki
 - metodę diagnostyczną wypisującą zawartości wszystkich pól oddzielone od siebie średnikami
 - Program powinien podejmować jasną komunikację z użytkownikiem, wyświetlane informacje powinny być zrozumiałe
 - Program powinien być zapisany czytelnie, z zachowaniem zasad czystego formatowania kodu, należy stosować znaczące nazwy zmiennych i funkcji. Wielkość liter np. dla nazwy klasy może być realizowana zgodnie z przyjętą konwencją nazewnictwa w danym języku programowania
 - Program główny powinien zawierać test działania aplikacji polegający na utworzeniu dwóch notatek z dowolnymi (znaczącymi) danymi (źródło danych jest dowolne: stała napisowa, literał lub pobrane z klawiatury) oraz uruchomieniu dla każdej z nich obu metod
 - Dokumentację aplikacji należy utworzyć zgodnie z opisem w części III treści zadania.
