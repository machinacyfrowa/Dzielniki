int liczba = 0; //liczba początkowa
Console.WriteLine("Podaj początkową liczbę: "); //zapytaj użytkownika o liczbę

liczba = int.Parse(Console.ReadLine() ?? "0"); //przeczytaj liczbę od użytkownika
                                               // jeśli readline zwróci null to przekaż "0"
Console.WriteLine("Ile kolejnych liczb chcesz otrzymać?");
int ileLiczb = int.Parse(Console.ReadLine() ?? "1"); //domyśnie 1

int iloscLiczb = 0; //licznik znalezionych liczb

//przygotuj tablice
int[] tablicaLiczb = new int [ileLiczb];
while (iloscLiczb < ileLiczb) //wykonuj dopóki ilość liczb nie osiągnie 10
{
    liczba++; //przejdz do następnej liczby
    if (liczba % 2 == 0) //liczba jest parzysta
    {
        //Console.WriteLine(liczba.ToString()); //wypisz na ekranie
        tablicaLiczb[iloscLiczb] = liczba; //zapisz liczbę do tablicy na pozycji określonej przez
                                            //ilość liczb (0, 1, 2...)
        iloscLiczb++; //zwiększ licznik
    }
}
string znalezioneLiczby = string.Join(", ", tablicaLiczb); // połącz elementy tablicy jako string,
                                                           // rozdzielając przecinkami 
Console.WriteLine("Liczby: " + znalezioneLiczby);
