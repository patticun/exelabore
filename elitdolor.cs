using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Input plaintext string
        string plainTextinput = "Hello, World!";

        // Convert plaintext to UTF-8 encoded bytes
        byte[] plaintextBytes = Encoding.UTF8.GetBytes(plainTextinput);

        // Display the UTF-8 encoded bytes
        foreach (byte b in plaintextBytes)
        {
            Console.Write($"{b} ");
        }
    }
}
