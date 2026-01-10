# Część II. Aplikacja mobilna
### Wykonaj aplikację mobilną za pomocą środowiska programistycznego dostępnego na stanowisku egzaminacyjnym oraz uruchom ją w dostępnym emulatorze systemu mobilnego. Aplikacja jest fragmentem programu do przeglądania ofert turystycznych.

### Elementy aplikacji:
 - Tytuł o treści: „Domek w górach”.
 - Obraz o nazwie obraz.jpg wypakowany z archiwum.
 - Trzy przyciski o treści: „POLUB”, „USUŃ”, „ZAPISZ” umiejscowione obok siebie.
 - Napis o treści „0 polubień”.
 - Linia horyzontalna.
 - Napis o treści „Opis”.
 - Napis o treści „Odwiedź komfortowy domek w Sudetach, blisko do szlaków turystycznych”.
### Działanie aplikacji:
 - Aplikacja implementuje licznik polubień, który w stanie początkowym aplikacji jest równy 0, następnie jego stan jest:
 - inkrementowany po wciśnięciu przycisku „POLUB”,
 - dekrementowany po wciśnięciu przycisku „USUŃ”. Licznik nie może być niższy niż 0.
 - Stan licznika jest wyświetlany pod przyciskami, w formie napisu „<x> polubień”, gdzie <x> oznacza aktualną wartość licznika.
### Założenia aplikacji:
 - Interfejs użytkownika zapisany za pomocą języka znaczników wspieranego w danym środowisku (np. XAML, XML).
 - Zastosowany typ rozkładu liniowy wertykalny (Linear / Stack lub inny o tej idei) z zagłębionym rozkładem liniowym horyzontalnym dla przycisków.
 - Margines wewnętrzny górny dla całej strony lub rozkładu wertykalnego: 20 px (lub dp)
 - Kolor tła przycisków i rozkładu, w którym się znajdują: Teal (#008080), zgodnie z Obrazem 1a.
 - Kolory czcionki: biały dla przycisków oraz Gray (#808080) dla napisu „Odwiedź...”
 - Czcionka tytułu ma rozmiar największy spośród użytych w aplikacji.
 - Czcionka napisu „Opis” jest pogrubiona.
 - Napis o liczbie polubień jest wyrównany do prawej.
 - Obraz wypełnia całą szerokość strony (zależnie od zastosowanego aspektu może być automatycznie obcięty przez emulator – zobacz obraz 1b).
 - Linia horyzontalna jest koloru Gray (#808080), dopuszcza się również prostokąt o wysokości 1.
 - Aplikacja powinna być zapisana czytelnie, z zachowaniem zasad czystego formatowania kodu, należy stosować znaczące nazwy zmiennych i funkcji. 
