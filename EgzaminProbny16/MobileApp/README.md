# Część II. Aplikacja desktopowa
### Za pomocą dostępnego na stanowisku egzaminacyjnym środowiska programistycznego wykonaj aplikację desktopową wybierania kolorów z palety RGB. Obrazy przedstawiają stany aplikacji. W zależności od użytego środowiska programistycznego wygląd może nieznacznie się różnić.

# Opis wyglądu aplikacji:
 - Tytuł okna „Wzornik kolorów RGB. Wykonał” dalej wstawiony numer zdającego
 - Tło okna: Cornsilk (#FFF8DC)
 - Duży prostokąt o białym kolorze tła
 - Napis: „Dobierz kolor suwakami i zapisz przyciskiem:”
 - Trzy suwaki, każdy o wartości początkowej 255 oraz zakresie wartości od 0 do 255
 - Z lewej strony suwaków kolejno etykiety: R, G, B
 - Z prawej strony suwaków etykiety z aktualną wartością suwaka, początkowo ustawione na 255
 - Przycisk „Pobierz” koloru Peru ( #CD853F)
 - Etykieta z pobraną wartością suwaków, domyślnie „255, 255, 255” o kolorze tła białym (mały prostokąt)

 ### Działanie aplikacji:
 - Zmiany położenia suwaków powodują zmianę wartości RGB po prawej stronie suwaka oraz powodują ustawienie koloru dużego prostokąta na wartość RGB odpowiadającą suwakom (obraz 3)
 - Po wciśnięciu przycisku „Pobierz” mały prostokąt na dole okna ma ustawiony kolor oraz tekst odpowiadający aktualnemu RGB (obraz 4)
 - Dalsze ruchy suwakami zmieniają kolor dużego prostokąta oraz wartości RGB przy suwakach (obraz 5). Mały prostokąt nie zmienia się, jego zmianę może wywołać dopiero przyciśnięcie przycisku „Pobierz”