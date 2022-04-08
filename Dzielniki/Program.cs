int liczba = 0; //liczba początkowa
int iloscLiczb = 0; //licznik znalezionych liczb
while (iloscLiczb < 10) //wykonuj dopóki ilość liczb nie osiągnie 10
{
    liczba++; //przejdz do następnej liczby
    if (liczba % 2 == 0) //liczba jest parzysta
    {
        Console.WriteLine(liczba.ToString()); //wypisz na ekranie
        iloscLiczb++; //zwiększ licznik
    }
}
