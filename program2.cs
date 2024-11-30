using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj trzy liczby całkowite:");

        Console.Write("a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("c: ");
        int c = int.Parse(Console.ReadLine());

        if (IsPythagoreanTriple(a, b, c))
        {
            Console.WriteLine($"Liczby {a}, {b}, {c} tworzą trójkę pitagorejską.");
        }
        else
        {
            Console.WriteLine($"Liczby {a}, {b}, {c} nie tworzą trójki pitagorejskiej.");
        }
    }

    static bool IsPythagoreanTriple(int a, int b, int c)
    {
        // Posortuj liczby w kolejności rosnącej
        int[] numbers = { a, b, c };
        Array.Sort(numbers);

        // Sprawdź warunek trójki pitagorejskiej
        return (numbers[0] * numbers[0] + numbers[1] * numbers[1]) == (numbers[2] * numbers[2]);
    }
}
