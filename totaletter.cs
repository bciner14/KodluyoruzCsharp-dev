using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bir cümle yazınız:");
        string sentence = Console.ReadLine();

        // Cümledeki kelime ve harf sayısını yazdır
        int wordCount = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
        int charCount = sentence.Replace(" ", "").Length;

        Console.WriteLine($"Cümledeki toplam kelime sayısı: {wordCount}");
        Console.WriteLine($"Cümledeki toplam harf sayısı: {charCount}");
    }
}