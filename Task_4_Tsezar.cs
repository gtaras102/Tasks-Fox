/* Цезар - реалізувати шифрування тексту за 
допомогою алгоритма Цезарь.
Зашифравати та розшифрувати текстове повідомлення
*/

using System;
class Program
{
    static void Main(string[] args)
    {
        string text = "";
        int key;
        //string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        Console.WriteLine("Введіть текст:");
        text = Console.ReadLine();

        Console.WriteLine("\nВведіть ключ для шифрування (від 1 до 5):)");
        key = Convert.ToInt32(Console.ReadLine());
            while (key < 0 || key > 5)
            {
                Console.WriteLine("Неприпустимий діапазон ключа. Введіть значення від 1 до 5.");
                key = Convert.ToInt32(Console.ReadLine());   
            }

        string encryptedText = CaesarCipher(text, key);
        Console.WriteLine("Encrypted Text: " + encryptedText);

        string decryptedText = CaesarCipher(encryptedText, -key);
        Console.WriteLine("Decrypted Text: " + decryptedText);
    }
    static string CaesarCipher(string message, int shift)
    {
        char[] buffer = message.ToCharArray();

        for (int i = 0; i < buffer.Length; i++)
        {
            char letter = buffer[i];

            if (char.IsLetter(letter))
            {
                char letterOffset = char.IsUpper(letter) ? 'A' : 'a';
                letter = (char)((((letter + shift) - letterOffset + 26) % 26) + letterOffset);
            }

            buffer[i] = letter;
        }
        return new string(buffer);
    }
}




