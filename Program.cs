using System;
class program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbe od 1 do 20");
        int liczbazadan;
        if (int.TryParse(Console.ReadLine(), out liczbazadan))
        {
            if (liczbazadan >= 1 && liczbazadan <= 20)
            {
                Console.WriteLine("wygenerowane zadania: ");

                for (int i = 1; i <= liczbazadan; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine($"zadanie {i} Priorytet wysoki");
                    }
                    else
                    {
                        Console.WriteLine($"zadanie {i} Priorytet normalny");
                    }
                }
            }
            else
            {
                Console.WriteLine("Bład podaj liczbe z przedziału od 1 do 20");
            }
        }
        else
        {
            Console.WriteLine("Bład wprowadz poprawna liczbe całkowita");
        }

    }
}