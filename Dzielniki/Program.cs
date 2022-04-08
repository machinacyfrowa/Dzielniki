void dzielniki()
{
    int liczba = 0; //liczba początkowa
    Console.WriteLine("Podaj początkową liczbę: "); //zapytaj użytkownika o liczbę

    liczba = int.Parse(Console.ReadLine() ?? "0"); //przeczytaj liczbę od użytkownika
                                                   // jeśli readline zwróci null to przekaż "0"
    Console.WriteLine("Jaką liczbę wykorzystać jako dzielnik:");
    int dzielnik = int.Parse(Console.ReadLine() ?? "1");//pobierz dzielnik od użytkownika

    Console.WriteLine("Ile kolejnych liczb chcesz otrzymać?");
    int ileLiczb = int.Parse(Console.ReadLine() ?? "1"); //domyśnie 1

    int iloscLiczb = 0; //licznik znalezionych liczb

    //przygotuj tablice
    int[] tablicaLiczb = new int[ileLiczb];
    while (iloscLiczb < ileLiczb) //wykonuj dopóki ilość liczb nie osiągnie 10
    {
        liczba++; //przejdz do następnej liczby
        if (liczba % dzielnik == 0) //liczba jest parzysta
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
}
void pierwsze()
{
    Console.WriteLine("Podaj liczbę początkową");
    int liczba = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("Podaj ilość liczb pierwszych do znalezienia:");
    int ilosc = int.Parse(Console.ReadLine() ?? "1");
    int iloscLiczb = 0;
    int[] tablicaLiczb = new int[ilosc];
    while(iloscLiczb < ilosc)
    {
        bool czyPierwsza = true; // zakładamy, że jest pierwsza
        //sprawdzamy czy faktycznie jest pierwsza
        for(int i = 2; i < liczba; i++)
        {
            if(liczba % i == 0) //znaleziono dzielnik
            {
                czyPierwsza = false; //nie jest pierwsza
                break; //dalej nie szukaj
            }
        }
        //jeśli doszliśmy tu i czypierwsza jest dalej true to znaczy ze faktycznie jest pierwsza
        if(czyPierwsza)
        {
            tablicaLiczb[iloscLiczb] = liczba;
            iloscLiczb++;
        }
        //lecimy do przodu od liczby początkowej
        liczba++;
    }
    string znalezioneLiczby = string.Join(", ", tablicaLiczb); // połącz elementy tablicy jako string,
                                                               // rozdzielając przecinkami 
    Console.WriteLine("Liczby: " + znalezioneLiczby);
}

Console.WriteLine("Co chcesz zrobić:");
Console.WriteLine("1. Pokaż kolejne liczby podzielne przez");
Console.WriteLine("2. Pokaż kolejne liczby pierwsze");
Console.WriteLine("0. Wyjście");
int wybor = int.Parse(Console.ReadLine() ?? "0");
switch(wybor)
{
    case 1:
        dzielniki();
        break;
    case 2:
        pierwsze();
        break;
    case 0:
        Console.WriteLine("Zamykam program...");
        break;
    default: 
        Console.WriteLine("Podano nieprawidłowy wybór!");
        break;
}

