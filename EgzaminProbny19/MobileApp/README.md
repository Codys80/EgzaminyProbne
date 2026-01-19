# Część II. Aplikacja mobilna
### Za pomocą środowiska programistycznego dostępnego na stanowisku egzaminacyjnym wykonaj aplikację mobilną obsługującą zapisy na wizytę u weterynarza.

### Elementy aplikacji:
 - Pole tekstowe z tytułem „Wizyta u weterynarza”
 - Pole edycyjne z podpowiedzią „Imię i nazwisko właściciela...”
 - Pole tekstowe „Gatunek”
 - Lista z elementami tekstowymi: „Pies”, „Kot”, „Świnka morska”
 - Jedno lub dwa pola tekstowe o treści „Ile ma lat?” oraz „0” (wartość reprezentująca wiek zwierzęcia)
 - Suwak, w postaci kontrolki Slider lub SeekBar o wartości początkowej 0 i wartości maksymalnej 20
 - Pole edycyjne z podpowiedzią „Cel wizyty”
 - Pole dedykowane do zapisu czasu z wartością początkową 4:00PM lub 16:00
 - Przycisk o treści: „OK”

### Działanie aplikacji:
 - Po kliknięciu gatunku z listy, wartość maksymalna suwaka zmienia się na:
   - 18 dla psa
   - 20 dla kota
 - 9 dla świnki morskiej
 - W momencie przesuwania suwaka zmienia się odpowiednio wartość wieku w polu tekstowym obok suwaka. Wartość wieku jest zawsze liczbą całkowitą
 - Po kliknięciu przycisku, wartości z formularza: imię i nazwisko właściciela, gatunek, wiek, cel wizyty, czas są wyświetlane w postaci napisu pod przyciskiem albo w postaci okna z komunikatem. Poszczególne wartości są rozdzielone przecinkiem 
 - Formularz nie musi być walidowany

### Założenia aplikacji:
 - Interfejs użytkownika zapisany za pomocą języka znaczników wspieranego w danym środowisku (np. XAML, XML).
 - Zastosowany rozkład liniowy wertykalny (Linear / Stack lub inny o tej idei), z zagnieżdżonym rozkładem liniowym horyzontalnym dla kontrolek dotyczących wieku (napisy i suwak)
 - Kolor głównego rozkładu: LightGreen (#90EE90)
 - Cechy tytułu: zapisany czcionką większą niż pozostałe kontrolki, kolor tła: SeaGreen (#2E8B57), marginesy wewnętrzne 10
 - Cechy listy: wysokość dopasowana do liczby elementów
 - Aplikacja powinna być zapisana czytelnie, z zachowaniem zasad czystego formatowania kodu, należy stosować znaczące nazwy zmiennych i funkcji.