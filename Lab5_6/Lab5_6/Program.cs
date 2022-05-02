using System;

namespace Lab5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Usage: [algorithm: -s or -b] [Input file path] [Destination path]");
                return;
            }

            if (args[0] == "-be" || args[0] == "-bd")
            {
                //Block
                    Console.Write("Enter key: ");
                    string ?key = Console.ReadLine();
                    RC2 rc2 = new(key);
                    if (args[0] == "-be"){
                        // encryption
                        Console.WriteLine("Encryption of " + args[1] + " to: " + args[2] + " ...");
                        string encryptedData = rc2.encrypte(File.ReadAllBytes(args[1]));                        
                        //Console.WriteLine("Encrypted data: " + encryptedData[0] + " | " +encryptedData[1]);
                        string filename = Path.GetFileNameWithoutExtension(args[1]);
                        string destinationFile = args[2] + "\\" + filename + ".bin";
                        File.WriteAllText(destinationFile, encryptedData);
                        return;
                    }
                    if (args[0] == "-bd")
                    {
                        // decryption
                        string encFile = File.ReadAllText(args[1]);
                        //Console.WriteLine(BinFile[0] + " | " + BinFile[1]);
                        
                        byte[] data = rc2.decrypt(encFile);
                        //foreach (byte b in data)
                        //{
                        //    Console.WriteLine("byte: " + b + " Char: " + (char)b);
                        // }
                        File.WriteAllBytes(args[2], data);
                        return;
                    }
            }
            else if (args[0] == "-s")
            {
                //Stream
            }
        }
    }
}