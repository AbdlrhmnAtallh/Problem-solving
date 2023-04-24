using System;
namespace Rot13_Cipher
{
    class Rot13Cipher
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your message: ");
            string message = Console.ReadLine();

            string encryptedMessage = Encrypt(message);
            string decryptedMessage = Decrypt(encryptedMessage);

            Console.WriteLine("Encrypted message: " + encryptedMessage);
            Console.WriteLine("Decrypted message: " + decryptedMessage);

            Console.ReadKey();
        }

        static string Encrypt(string message)
        {
            char[] charArray = message.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (char.IsLower(charArray[i]))
                {
                    charArray[i] = (char)(((charArray[i] - 'a') + 13) % 26 + 'a');
                }
                else if (char.IsUpper(charArray[i]))
                {
                    charArray[i] = (char)(((charArray[i] - 'A') + 13) % 26 + 'A');
                }
            }

            return new string(charArray);
        }

        static string Decrypt(string encryptedMessage)
        {
            char[] charArray = encryptedMessage.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (char.IsLower(charArray[i]))
                {
                    charArray[i] = (char)(((charArray[i] - 'a') + 13) % 26 + 'a');
                }
                else if (char.IsUpper(charArray[i]))
                {
                    charArray[i] = (char)(((charArray[i] - 'A') + 13) % 26 + 'A');
                }
            }

            return new string(charArray);
        }
    }
}