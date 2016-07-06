Poprawione:
* "powielony kod na każdej karcie" - teraz zamiast trzech oddzielnych kart dla każdego z samochodów
jest jedna wspólna karta CarsConfigs. Dlatego w kodzie tej karty są trzy funkcje ładujące komponenty 
samochodów - pierwsza funkcja ładuje konfigurację pierwszego, druga drugiego, trzecia trzeciego 
oraz trzy funkcje zapisujące odpowiednie obiekty tych trzech klas.
* "odświeżanie koszyka" - pewnie masz na myśli, że nie jest automatyczne. Już zrobione. 
* "brak cen i opcji kupna" - dadane
* dodatkowa obsługa błędów wczytywania pliku w ShoppingCart. Obsługa polega na tworzeniu nowego pliku
jeżeli wczytywany plik nie istnieje. Jest to w funkcji refresh_invoke().
* dadane czyszczenie koszyka po złożeniu zamówienia 
** ogólna zmiana działania: pierwsza karta dla wyboru samochodu, wybór zostaje odczytany w drugiej karcie
przez CarsConfigs i dalej mamy wybór funkcji do załadowania komponentów na kartę(cen, obrazków, kolorów, itp.). Reszta podobnie jak ostatnio.

