using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // 1. Kalkulator BMI
        /*
        Console.WriteLine("Podaj swoją wagę (w kilogramach): ");
        double waga = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj swój wzrost (w metrach): ");
        double wzrost = double.Parse(Console.ReadLine());

        double bmi = waga / (wzrost * wzrost);
        Console.WriteLine($"Twoje BMI wynosi: {bmi:F2}");
        */

        // 2. Słownik angielsko-polski
        
        Dictionary<string, string> slownik = new Dictionary<string, string>();

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Dodaj słowo angielskie: ");
            string ang = Console.ReadLine();

            Console.WriteLine("Dodaj tłumaczenie: ");
            string pol = Console.ReadLine();

            slownik[ang] = pol;
        }

        Console.WriteLine("Podaj słowo po angielsku: ");
        string szukane = Console.ReadLine();

        if (slownik.ContainsKey(szukane))
        {
            Console.WriteLine("Tłumaczenie: " + slownik[szukane]);
        }
        else
        {
            Console.WriteLine("Brak tłumaczenia dla tego słowa.");
        }
        

        // 3. Średnia z ocen
        /*
        List<int> oceny = new List<int>();

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Podaj ocenę {i}: ");
            int ocena = int.Parse(Console.ReadLine());
            oceny.Add(ocena);
        }

        double srednia = (double)oceny.Sum() / oceny.Count;
        Console.WriteLine($"Średnia ocen wynosi: {srednia:F2}");
        */

        // 4. Sortowanie nazwisk
        /*
        string[] nazwiska = new string[5];

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Podaj nazwisko {i + 1}: ");
            nazwiska[i] = Console.ReadLine();
        }

        Array.Sort(nazwiska);

        Console.WriteLine("Posortowane nazwiska:");
        foreach (string nazwisko in nazwiska)
        {
            Console.WriteLine(nazwisko);
        }
        */

        // 5. Licznik samogłosek
        /*
        Console.WriteLine("Podaj zdanie: ");
        string zdanie = Console.ReadLine().ToLower();

        int licznik = 0;
        char[] samogloski = { 'a', 'e', 'i', 'o', 'u', 'y' };

        foreach (char znak in zdanie)
        {
            if (Array.Exists(samogloski, s => s == znak))
            {
                licznik++;
            }
        }

        Console.WriteLine($"Liczba samogłosek: {licznik}");
        */

        // 6. Gra w zgadywanie liczby
        /*
        Random random = new Random();
        int wylosowana = random.Next(1, 101);
        int proba;

        Console.WriteLine("Zgadnij liczbę od 1 do 100:");

        while (true)
        {
            proba = int.Parse(Console.ReadLine());

            if (proba < wylosowana)
            {
                Console.WriteLine("Za mało!");
            }
            else if (proba > wylosowana)
            {
                Console.WriteLine("Za dużo!");
            }
            else
            {
                Console.WriteLine("Brawo! Zgadłeś.");
                break;
            }
        }
        */
    }
}

        