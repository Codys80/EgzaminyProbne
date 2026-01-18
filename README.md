# Część I. Aplikacja konsolowa
### Korzystając z mechanizmów programowania obiektowego zaprojektuj część logiki systemu wirtualnej wypożyczalni filmów. Zaimplementuj aplikację zawierającą klasę o nazwie film z metodami get, set oraz inkrementuj. 
### Założenia klasy:
 - Obiektowy język programowania zgodny z zainstalowanym na stanowisku egzaminacyjnym, jeden z: C++, C#, Java, Python.
 - Klasa film zawiera dwa pola zawierające tytuł oraz liczbę wypożyczeń. Dla uproszczenia można przyjąć, że tytuł może mieć maksymalnie 20 znaków. Dostęp do obu pól ma jedynie klasa. W przypadku późniejszego rozszerzenia klasy, klasy potomne powinny również mieć dostęp do tych pól.
 - Klasa film zawiera funkcjonalność:
 - inicjalizację pól wartością pustą lub 0 w zależności od typu
 - metodę ustawiającą tytuł (ang. setter)
 - metodę pobierającą tytuł (ang. getter)
 - metodę pobierającą liczbę wypożyczeń (ang. getter)
 - bezargumentową metodę realizującą inkrementację pola przechowującego liczbę wypożyczeń. Metoda nie zwraca żadnej wartości
### Założenia aplikacji:
 - Inicjalizacja obiektu i wyświetlenie zawartości jego pól
 - Test działania metody set, poprzez ustawienie dowolnej wartości dla pola obiektu,
 - Test działania metody get, poprzez pobranie wartości z pola obiektu i wyświetlenie jej na ekranie
 - Test metody inkrementacji pola przechowującego liczbę wypożyczeń zrealizowany w ten sposób, że wyświetlona jest wartość pola przed i po zastosowaniu metody
 - Aplikacja powinna być zapisana czytelnie, z zachowaniem zasad czystego formatowania kodu, należy stosować znaczące nazwy pól i metod
