# Część 1: Aplikacja konsolowa:

### Wykorzystująć zasady programowania obiektowego zaprogamuj klasy do realizacji quizi o nazwach: Pytanie oraz PytanieZamkniete.

### Założenia do programu:
- program wykonywany w konsoli,
- Zastosowany obiektowy jezyk programowania zgodny z zainstalowanym na stanowisku egzaminacyjnym: C++ lub C#, lub Java, lub Python
- Program powinien podejmować zrozmiałą komunikacje z użytkownikiem
- W programie może być zastosowane angielskie lub polskie nazewnictwo zmiennych i funkcji
- Program powinien być zapisany czytelnie, z zachowaniem zasad czystego formatowania kodu, należy stosować znaczące nazwy pól i metod
- Uruchomienie programu i sprawdzenie działania klas zgodnie z pooleceniami w części 3 arkusza


### Klasa Pytanie, której obiekt nie może być powołany, zawiera:
- Pola dostępne jedynie w klasie oraz w klasach potomych, przechowujące:
	- Wartość tekstową z treścią pytania
	- Nazwę pliku zawierającego zdjęcie do pytania
	- Informację czy odpowiedź na pytanie jest poprawna, typu logicznego
- Konstruktor dwuargumentowy, którego argumentami są treść pytania i nazwa pliku dla pytania
	-NA podstawie argumentów ustawia wartość pól
	-UStawia pole logiczne: odpowiedź na pytanie nie jest poprawna
- Metodę abstrakcyjną typu logicznego, sprawdzającą odpowiedź. Metoda ma jeden argument o typie znakowym, który przyjmuje wartości 'A' lub 'B' lucz 'C'(odpowiedzi użytkownika na pytanie quizu).
- Metoda nie zawiera domyślnej implementacji

### Klasa PytanieZamkniete dziedzicząca po klasie Pytanie. Klasa zawiera:
- Pola dostępne jedynie w klasie, niedostępne w klasach potomnych, przechowujące:
	- Treść odpowiedzi A
	- Treść odpowiedzi B
	- Treść odpowiedzi C
	- Informację o porawnej odpowiedzi(znak 'A' lub 'B' lub 'C')
- Konstruktor sześcioargumentowy, o argumentach: treść pytania, nazwa pliku graficznego dla pytania, treść odpowiedzi A, treść odpowiedzi B, treść odpowiedzi C, odpowiedź poprawna
	- Konstruktor wywołuje konstruktor klasy, po które dziedzicy
	- Przypisuje treści odpowiedzi oraz poprawną odpowiedź do pól klasy
- Implementację metody abstrakcyjnej sprawdzającej odpowiedź, która:
	- Sprawdza czy odpowiedź jest poprawna i w zależności od wyniku przypisuje odpowiednią wartość do pola logicznego
	- Zwraca warotść pola logicznego
