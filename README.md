# Część I. Aplikacja konsolowa
### Za pomocą narzędzi do tworzenia aplikacji konsolowych zaimplementuj program sprawdzający poprawność numeru PESEL. Program powinien sprawdzać płeć i sumę kontrolną według opisu:
```
Numer PESEL jest to 11-cyfrowy identyfikator numeryczny.
Płeć
Informacja o płci osoby zawarta jest na 10. (przedostatniej) pozycji numeru PESEL.
• cyfry 0, 2, 4, 6, 8 (parzyste) – oznaczają płeć żeńską
• cyfry 1, 3, 5, 7, 9 (nieparzyste) – oznaczają płeć męską
Cyfra kontrolna i sprawdzanie poprawności numeru
Jedenastą cyfrą numeru PESEL jest cyfra kontrolna umożliwiająca kontrolę poprawności identyfikatora.
Jest ona wynikiem działania na pierwszych dziesięciu cyfrach.
Algorytm obliczania cyfry kontrolnej na podstawie kolejnych cyfr numeru:
1. Dla kolejnych 10 cyfr numeru PESEL oblicz iloczyn każdej cyfry i jej wagi na podstawie tabeli:
Pozycja cyfry od lewej 1 2 3 4 5 6 7 8 9 10
Waga cyfry 1 3 7 9 1 3 7 9 1 3
Oznacza to, że pierwszą cyfrę numeru PESEL należy pomnożyć przez 1, drugą cyfrę przez 3, trzecią przez
7 itd.
2. Wszystkie iloczyny zsumuj ze sobą i zapisz w zmiennej S
3. Wykonaj operację modulo 10 na sumie S i zapisz w zmiennej M
4. Gdy wartość zmiennej M jest równa 0, to zmiennej R przypisz wartość 0. W przeciwnym przypadku
zmiennej R przypisz wartość różnicy 10 i M (R=10-M)
5. Zmienna R stanowi sumę kontrolną numeru PESEL i musi być równa jedenastej cyfrze numeru
PESEL

```

### Założenia aplikacji:
 - Zastosowany obiektowy język programowania zgodny z zainstalowanym na stanowisku egzaminacyjnym: C++ lub C#, lub Java, lub Python
 - Numer PESEL może być przechowywany jako zmienna tekstowa albo tablica 11 liczb całkowitych lub znaków
 - Zmienna ta jest zainicjowana numerem PESEL zdającego lub w przypadku jego braku numerem 55030101193
 - Sprawdzanie płci należy zaimplementować w osobnej funkcji zwracającej typ znakowy o wartości 'K' dla kobiety oraz 'M' dla mężczyzny
 - Sprawdzanie sumy kontrolnej należy zaimplementować w osobnej funkcji zwracającej wartość logiczną true w przypadku zgodności sumy lub false w przeciwnym przypadku
 - Parametrem wejściowym obu funkcji jest zmienna przechowująca numer PESEL
 - Program główny testuje działanie funkcji i zawiera następujące operacje wejścia – wyjścia
 - Wczytanie z klawiatury numeru PESEL
 - Wypisanie płci (ustalonej przez funkcję) w postaci napisu: „Kobieta” lub „Mężczyzna” w oparciu o wczytany numer PESEL
 - Wypisanie informacji o zgodności lub niezgodności sumy kontrolnej w oparciu o wczytany numer PESEL
 - Program powinien podejmować zrozumiałą komunikację z użytkownikiem
 - W programie może być zastosowane angielskie lub polskie nazewnictwo zmiennych i funkcji
 - Program powinien być zapisany czytelnie, z zachowaniem zasad czystego formatowania kodu, należy stosować nazwy zmiennych znaczące oraz zgodne z przedstawionym algorytmem
