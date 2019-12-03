 
using System;

namespace Reading
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Reading NFC Readers");
            var nfc = new NFCReader();
            var readers = nfc.GetReadersList();
            Console.WriteLine("Found " + readers.Count);
            foreach (var reader in readers)
            {
                Console.WriteLine(reader);
            }

            Console.ReadLine();
        }
    }
}