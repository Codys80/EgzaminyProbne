# Część I. Implementacja klasy

### Za pomocą narzędzi do tworzenia aplikacji konsolowych, zaprojektuj część logiki systemu automatów paczkowych. Zaimplementuj klasę o nazwie Skrytka oraz typ wyliczeniowy RozmiarSkrytki.
### Założenia dotyczące klasy Skrytka i typu RozmiarSkrytki:
 - Typ RozmiarSkrytki posiada trzy możliwe wartości Maly = 10, Sredni = 20, Duzy = 30
 - Klasa Skrytka zawiera:
 - Trzy pola: rozmiar typu RozmiarSkrytki, zawartość skrytki typu tekstowego lub pustego oraz kod dostępu typu tekstowego lub pustego. Dostęp do tych pól ma jedynie klasa. W przypadku późniejszego rozszerzania klasy, klasy potomne nie mają dostępu do tych pól
 - Konstruktor z jednym parametrem, który przekazuje rozmiar skrytki, reszta pól ma ustawioną wartość pustą
 - Ogólnie dostępne pole statyczne zliczające liczbę instancji klasy, początkowo ma wartość 0
 - Metodę statyczną, która generuje losowy kod składający się z 5 cyfr
 - Metodę, która zwraca informację o tym czy skrytka jest pusta (pole z zawartością skrytki ma wartość pustą)
 - Metodę, która umieszcza paczkę w skrytce: ustawia zawartość na przekazaną jako parametr metody i ustawia kod na losowo wygenerowany przez odpowiedzialną za to metodę tej klasy. W przypadku, gdy w skrytce już się coś znajduje (pole z zawartością skrytki nie jest puste) lub zawartość jest za duża (długość zawartości jest większa niż ustalony rozmiar skrytki), należy zwrócić wartość fałsz i nie ustawiać nowej zawartości i kodu. Jeśli udało się umieścić paczkę w skrytce, należy zwrócić ustawiony kod
 - Metodę, do otwierania skrytki: sprawdza czy podany kod (przekazany jako parametr metody) jest poprawny. Jeśli tak zwraca zawartość skrytki, ustawia kod i zawartość skrytki na pustą. Jeśli jednak kod jest nieprawidłowy należy zwrócić wartość fałsz
### Ogólne założenia:
 - Zastosowany wybrany obiektowy język programowania spośród: C++, C#, Java, Python
 - Kod powinien być zapisany czytelnie, z zachowaniem zasad czystego formatowania kodu
 - Do klasy dołączono testy jednostkowe, ich opis znajduje się w części III zadania
 - Należy stosować znaczące, angielskie lub polskie nazwenictwo zmiennych i funkcji

###
## Zadanie praktyczne II zostało stworzone przez [Marioneq](https://github.com/Marioneq4958)
