using System;
using System.Linq;

namespace karakter_degistirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Verilen string ifade içerisindeki ilk ve son karakterin yerini değiştirip tekrar ekrana yazdıran console uygulamasını yazınız.
            // Örnek: Input: Merhaba Hello Algoritma x
            // Output: aerhabM oellH algoritmA x

            Console.WriteLine("Bir ifade giriniz: ");
            string input = Console.ReadLine();
            CharReplacement(input);
            Console.ReadKey();
        }

        static void CharReplacement(string input)
        {
            string[] inputArray = input.Split(' ');
                        
            for (int i = 0; i < inputArray.Length; i++)
            {
                char[] letters = inputArray[i].ToCharArray();
                char letter = letters[0];
                letters[0] = letters[letters.Length - 1];
                letters[letters.Length - 1] = letter;
                string newInput = string.Concat(letters);
                Console.Write(newInput + ' ');
            }
        }
    }
}
