class Lab2
{
    static void Main(string[] args)
    {
        //Zadanie1();
        //Zadanie2();
        //Zadanie3();
        //Zadanie4();
        //Zadanie5();
        //Zadanie6();
        //Zadanie7();
        Zadanie8();
    }

    static void Zadanie1()
    {
        int suma = 0;
        int ocena;
        int liczbaOcen = 0;
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Podaj ocenę: ");
            ocena = Convert.ToInt32(Console.ReadLine());
            if (ocena >= 3)
            {
                suma += ocena;
                liczbaOcen++;
            }
            
        }
        double srednia = suma / (double)liczbaOcen;
        Console.WriteLine("Śrenia z ocen wynosi: {0:N}", srednia);
    }

    static void Zadanie2()
    {
        Console.WriteLine("Podaj kwotę: ");
        decimal kwota = Decimal.Parse(Console.ReadLine());
        Console.WriteLine("Podaj długość trwania inwestycji (w latach): ");
        int lata = Int32.Parse(Console.ReadLine());
        decimal rocznaStopaProcentowa = 0.06m; // 6% jako wartość procentowa
        decimal wartosc = kwota;
        for (int i = 0; i < lata; i++)
        {
            wartosc *= (1 + rocznaStopaProcentowa); // Kapitalizacja odsetek na koniec roku
        }
        Console.WriteLine("Wartość tej inwestycji wyniesie {0:C} złotych po {1} latach", wartosc, lata);
    }

    static void Zadanie3()
    {
        int[] liczby = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Podaj liczbę numer {0}: ", i + 1);
            liczby[i] = Int32.Parse(Console.ReadLine());
        }
        int max = liczby[0];
        for(int i = 0; i < 5; i++)
        {
            if (liczby[i] > max)
            {
                max = liczby[i];
            }
        }
        Console.WriteLine("Największa liczba to {0}", max);
    }

    static void Zadanie4()
    {
        int K = 120;
        decimal S = 1.8M;
        Console.WriteLine("Podaj długość skoku: ");
        decimal d = Decimal.Parse(Console.ReadLine());
        decimal pd = 60 + (d - K) * S;
        int ps = 0;
        int[] oceny = new int[5];
        for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Podaj ocene stylu (od 0 do 20): ");
            oceny[i] = Int32.Parse(Console.ReadLine());
        ps += oceny[i];
    }
        int max = oceny[0];
        for (int i = 0; i < 5; i++)
        {
            if (oceny[i] > max)
            {
                max = oceny[i];
            }
        }
        int min = oceny[0];
        for (int i = 0; i < 5; i++)
        {
            if (oceny[i] < min)
            {
                min = oceny[i];
            }
        }
        ps = ps - min - max;
        decimal p = pd + ps;
        Console.WriteLine("Skoczek uzyskał {0:0.##} punktów.", p);
    }

    static void Zadanie5()
    {
        Console.WriteLine("Podaj liczbę do obliczenia silni: ");
        int liczba = Int32.Parse(Console.ReadLine());
        if (liczba < 0)
        {
            Console.WriteLine("Silnia tylko dla liczb dodatnich!");
        }
        else
        {
            long silnia = 1;
            for(int i = 2; i<=liczba; i++)
            {
                silnia *= i;
            }
            Console.WriteLine("Silnia z liczby {0} wynosi {1}.", liczba, silnia);
        }
    }

    static void Zadanie6()
    {
        Console.WriteLine("Podaj liczbę: ");
        int liczba = Int32.Parse(Console.ReadLine());
        if (liczba <= 1)
        {
            Console.WriteLine("To nie jest liczba pierwsza.");
        }
        if(liczba <= 3)
        {
            Console.WriteLine("To jest liczba pierwsza.");
        }
        if(liczba % 2 == 0 || liczba % 3 == 0)
        {
            Console.WriteLine("To nie jest liczba pierwsza.");
        }
        for (int i = 5; i * i <= liczba; i += 6)
        {
            if (liczba % i == 0 || liczba % (i+2) == 0)
            {
                Console.WriteLine("To nie jest liczba pierwsza.");
            }
        }
    }

    static void Zadanie7()
    {
        Console.WriteLine("Podaj pierwszą liczbę: ");
        int a = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Podaj drugą liczbę: ");
        int b = Int32.Parse(Console.ReadLine());
        if (a >= b)
        {
            Console.WriteLine("b musi być większe od a.");
            return;
        }
        Console.WriteLine($"LIczby pierwsze w przedziale [{a}, {b}]:");
        for (int i = a; i<= b; i++)
        {
            if(Czypierwsza(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    static bool Czypierwsza(int n)
    {
        if (n <= 1)
        {
            return false;
        }
        if (n <= 3)
        {
            return true;
        }
        if (n % 2 == 0 || n % 3 == 0)
        {
            return false;
        }

        for (int i = 5; i * i <= n; i += 6)
        {
            if (n % i == 0 || n % (i + 2) == 0)
            {
                return false;
            }
        }
        return true;
    }

    static long Silnia(int n)
    {
        long wynik = 1;
        for (int i = 2; i <= n; i++)
        {
            wynik *= i;
        }
        return wynik;
    }

    static void Zadanie8()
    {
        Console.WriteLine("Podaj wartość n do symbolu Newtona ('n po k'): ");
        int n = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Podaj wartość k do symbolu Newtona ('n po k'): ");
        int k = Int32.Parse(Console.ReadLine());
        long Newton = Silnia(n) / (Silnia(k) * Silnia(n - k));
        Console.WriteLine("Symbol Newtona wynosi: {0:0.##} ", Newton);
    }
}
