# Część II. Aplikacja desktopowa
### Za pomocą dostępnego na stanowisku egzaminacyjnym środowiska programistycznego wykonaj aplikację desktopową do wprowadzania danych pracownika z możliwością generowania hasła.

### Opis wyglądu aplikacji
 - Okno o nazwie „Dodaj pracownika”. W nazwie okna należy wstawić także numer zdającego
 - Kontrolki rozmieszczone zgodnie z obrazem 1
 - Kontrolki w grupie „Dane Pracownika”:
 - pole edycyjne poprzedzone etykietą o treści „Imię”
 - pole edycyjne poprzedzone etykietą o treści „Nazwisko”
 - lista rozwijalna podpisana „Stanowisko” z elementami: Kierownik, Starszy programista, Młodszy programista, Tester
 - Kontrolki w grupie „Generowanie hasła”:
 - pole edycyjne poprzedzone etykietą o treści „Ile znaków?”
 - trzy pola wyboru podpisane: „Małe i wielkie litery”, „Cyfry”, „Znaki specjalne”. Pierwsze pole jest domyślnie zaznaczone
 - przycisk o treści „Generuj hasło”
 - Na dole okna znajduje się przycisk „Zatwierdź”, jest on wyraźnie dłuższy niż przycisk do generowania hasła
 - Okno ma tło koloru LightSteelBlue (#B0C4DE)
 - Przyciski mają tło koloru SteelBlue (#4682B4) i biały kolor czcionki
### Działanie aplikacji po wybraniu przycisku „Generuj hasło”:
 - Generowane jest hasło o liczbie znaków określonej w polu edycyjnym
 - Poszczególne znaki hasła są wybierane losowo z zestawu małych liter
 - Jeżeli zaznaczono checkbox „Małe i wielkie litery”, jeden ze znaków jest losowany z zestawu wielkich liter
 - Jeżeli zaznaczono checkbox „Cyfry”, jeden ze znaków hasła jest losowany z zestawu cyfr
 - Jeżeli zaznaczono checkbox „Znaki specjalne”, jeden ze znaków hasła jest losowany z zestawu znaków specjalnych
 - Dla uproszczenia zadania można przyjąć zawsze określony znak (np. pierwszy), który jest losowany z cyfr. Podobnie należy postąpić ze znakami specjalnymi (np. drugi znak)
 - Hasło jest wypisywane jako komunikat zgodnie z obrazem 2 po wybraniu przycisku „Generuj hasło”
 - Za zestaw liter przyjmuje się wszystkie litery z klawiatury małe i wielkie alfabetu łacińskiego
 - Za zestaw cyfr przyjmuje się kolejne cyfry od 0 do 9
 - Za zestaw znaków specjalnych przyjmuje się znaki !@#$%^&*()_+-=
 - Hasło oraz zestawy znaków są przechowywane w zmiennych typu napisowego
### Działanie aplikacji po wybraniu przycisku „Zatwierdź”
 - Wyświetlany jest komunikat z wypełnionymi danymi pracownika oraz wygenerowanym wcześniej hasłem
