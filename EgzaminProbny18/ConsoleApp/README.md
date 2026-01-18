# Część I. Aplikacja konsolowa
### Napisz program implementujący klasę i dwie klasy potomne, który obsługuje działanie urządzeń domowych.

### Założenia do programu:
 - Program wykonywany w konsoli
 - Zastosowany obiektowy język programowania zgodny z zainstalowanym na stanowisku egzaminacyjnym: C++ lub C#, lub Java, lub Python
 - Program zawiera klasę bazową reprezentującą urządzenie oraz dwie klasy potomne reprezentujące pralkę oraz odkurzacz
 - Wymaganie do klasy bazowej:
   - Implementuje jedną ogólnodostępną metodę, która wyświetla treść komunikatu. Komunikat jest argumentem metody. Metoda nie zwraca wartości.
 - Wymagania do klasy reprezentującej pralkę:
   - Definiuje pole przechowujące numer programu prania, który jest liczbą całkowitą. Pole inicjowane jest wartością 0. Instancje klasy nie mają dostępu do pola, pole nie jest widoczne w klasach dziedziczących po klasie pralki
   - Implementuje ogólnodostępną metodę do ustawienia numeru programu prania. Argumentem metody jest numer programu. Gdy jest on liczbą z przedziału od 1 do 12 metoda ustawia pole określające numer programu na tą wartość. W przeciwnym wypadku pole jest ustawione na wartość 0. Metoda zwraca wartość pola numeru programu
 - Wymagania do klasy reprezentującej odkurzacz:
   - Definiuje pole reprezentujące stan odkurzacza, które jest typu logicznego, inicjowane wartością false. Wartość false oznacza, że odkurzacz jest wyłączony, true - włączony. Pole dostępne tylko w tej klasie, niedostępne w klasach potomnych
   - Implementuje ogólnodostępną bezargumentową metodę on(), która włącza odkurzacz. Metoda nie zwraca wartości. Włączenie polega na ustawieniu pola stanu na wartość true oraz wywołaniu metody klasy bazowej z komunikatem „Odkurzacz włączono”. Zmiana stanu i komunikat mogą być wykonane tylko i wyłącznie, gdy odkurzacz jest wyłączony
   - Implementuje ogólnodostępną bezargumentową metodę off(), która wyłącza odkurzacz. Metoda nie zwraca wartości. Wyłączenie polega na ustawieniu pola stanu na wartość false oraz wywołaniu metody klasy bazowej z komunikatem „Odkurzacz wyłączono”. Zmiana stanu i komunikat mogą być wykonane tylko i wyłącznie, gdy odkurzacz jest włączony
 - Wymagania do programu głównego:
   - Należy zainicjować dwa obiekty typu pralka i odkurzacz
   - Na obiekcie typu pralka należy przetestować ustawienie programu prania z wartościami poprawnymi i niepoprawnymi. Powinny być wyświetlone odpowiednie komunikaty
 - Na obiekcie typu odkurzacz należy:
   - Wywołać metodę on()trzykrotnie; mimo trzykrotnego wywołania tylko raz wyświetla się komunikat 
   - Wywołać metodę klasy bazowej z treścią: „Odkurzacz wyładował się”
   - Wywołać metodę off()
 - Program powinien podejmować zrozumiałą komunikację z użytkownikiem. 
 - W programie może być zastosowane angielskie lub polskie nazewnictwo klas, pól, metod, instancji klas, zmiennych
 - Program powinien być zapisany czytelnie, z zachowaniem zasad czystego formatowania kodu, należy stosować znaczące nazwy zmiennych, metod