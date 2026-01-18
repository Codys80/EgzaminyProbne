# Część I. Aplikacja konsolowa
### Za pomocą narzędzi do tworzenia aplikacji konsolowych utwórz program implementujący algorytm szyfru Cezara.Założenia aplikacji:
### Założenia aplikacji:
 - Zastosowany obiektowy język programowania zgodny z zainstalowanym na stanowisku egzaminacyjnym: C++ lub C#, lub Java, lub Python
 - Podejście obiektowe lub strukturalne
 - Szyfrowanie odbywa się w osobnej metodzie lub funkcji, która zawiera:
 - Dwa argumenty: tekst jawny oraz klucz (przy podejściu obiektowym dopuszcza się bez parametrów)
 - Wartość zwracaną: tekst zaszyfrowany
 - Implementację algorytmu szyfrowania kodem Cezara
 - W programie należy stosować znaczące, angielskie lub polskie nazewnictwo
 - Program powinien być zapisany czytelnie, z zachowaniem zasad czystego formatowania kodu
 - Do kodu należy dołączyć testy jednostkowe opisane w części III zadania egzaminacyjnego
### Opis algorytmu:
```
Szyfr Cezara polega na zamianie każdej litery tekstu jawnego na literę tekstu szyfrowanego przesuniętego
w alfabecie o stałą liczbę znaków zwaną kluczem.
Przykładowo dla klucza k = 3, każdą literę alfabetu z tabeli 1 należy zamienić odpowiednią literą z tabeli 2.
Natomiast dla klucza k = -3, każdą literę alfabetu z tabeli 1 należy zamienić odpowiednią literą z tabeli 3.
```
### Założenia dotyczące algorytmu:
 - Szyfr działa jedynie dla małych liter podstawowego alfabetu łacińskiego, przedstawionego w tabeli 1 (kody ASCII od 97 do 122)
 - Znak spacji pozostaje w zaszyfrowanym tekście bez zmian
 - Tekst jawny i zaszyfrowany są dowolnego typu napisowego, ich długość zależy od wczytanego tekstu
 - Klucz szyfrowania jest liczbą całkowitą (wartości dodatnie i ujemne, może być większy od 26). Dla klucza k = 0 tekst jawny jest równy tekstowi zaszyfrowanemu
 - Tekst oraz klucz są wczytywane z klawiatury w programie głównym
 - W podejściu obiektowym szyfrowany tekst i klucz mogą być polami klasy
 - Nie jest wymagana walidacja tekstu jawnego – zakłada się, że wprowadzono go bez błędów (tylko małe litery i spacje)
