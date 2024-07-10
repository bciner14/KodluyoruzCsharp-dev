using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Pozitif bir sayı giriniz:");
        int n = int.Parse(Console.ReadLine());

        // Kullanıcıdan n adet kelime girmesini iste ve sondan başa doğru yazdır
        string[] words = new string[n];
        Console.WriteLine($"{n} adet kelime giriniz:");
        for (int i = 0; i < n; i++)
        {
            words[i] = Console.ReadLine();
        }

        Console.WriteLine("Girilen kelimeler sondan başa doğru:");
        for (int i = n - 1; i >= 0; i--)
        {
            Console.WriteLine(words[i]);
        }
    }
}
