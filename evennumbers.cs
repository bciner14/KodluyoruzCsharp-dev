using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Pozitif bir sayı giriniz:");
        int n = int.Parse(Console.ReadLine());

        // Kullanıcıdan n adet pozitif sayı girmesini iste ve çift olanları yazdır
        int[] numbers = new int[n];
        Console.WriteLine($"{n} adet pozitif sayı giriniz:");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Girilen çift sayılar:");
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine(number);
            }
        }
    }
}
