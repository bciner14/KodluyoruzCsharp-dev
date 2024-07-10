using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Pozitif iki sayı giriniz (n ve m):");
        string[] input = Console.ReadLine().Split();

        if (input.Length < 2)
        {
            Console.WriteLine("Lütfen iki pozitif sayı giriniz.");
            return;
        }

        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);

        // Kullanıcıdan n adet pozitif sayı girmesini iste
        int[] numbers = new int[n];
        Console.WriteLine($"{n} adet pozitif sayı giriniz:");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Kullanıcının girmiş olduğu sayılardan m'ye tam bölünen veya m'ye eşit olanları yazdır
        Console.WriteLine($"Girilen sayılardan {m}'e tam bölünen veya eşit olanlar:");
        foreach (int number in numbers)
        {
            if (number % m == 0)
            {
                Console.WriteLine(number);
            }
        }
    }
}