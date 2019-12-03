 
using System;

namespace Reading
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Reading NFC Readers");
            var nfc = new NFCReader();
            try
            {
                nfc.Connect();
            }
            catch (Exception e)
            {
                Console.WriteLine("failed to connect");
                Console.WriteLine(e);
            }
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