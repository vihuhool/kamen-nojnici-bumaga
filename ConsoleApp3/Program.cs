using System;
using System.Security.Cryptography;
using System.IO;
using System.Linq;



namespace ConsoleApp3
{


    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length % 2 != 1 || args.Length<3) { Console.WriteLine("INPUT ERROR: wrong number of values"); return; }
            if (args.Distinct().Count()!=args.Count()) { Console.WriteLine("INPUT ERROR: identical arguments"); return; }
            var rand = new Random();
            int humanchoise; string input;
            int compchoise = rand.Next(1, args.Length);
            KeyGenerator compmove = new KeyGenerator(args[compchoise - 1]);
            compmove.DoHMAC();

            
            Menu b = new Menu(args);


            while (true)
            {
                Console.Write("HMAC:");
                compmove.PrintHex(compmove.hashValue);
                b.PrintMenu(args);
            
                    input = Console.ReadLine();
                if (input == "?")
                {
                    humanchoise = -1;
                }
                else
                {
                    try { humanchoise = Convert.ToInt32(input); }
                    catch { Console.WriteLine("INPUT ERROR, Click on any button"); Console.ReadKey(); Console.Clear(); continue; }
                }
                
                if (humanchoise > 0 && humanchoise <= args.Length)
                {
                    Console.WriteLine("Your move:" + args[humanchoise - 1]);
                    Console.WriteLine("Computer move:" + args[compchoise - 1]);
                    Game j = new Game(humanchoise, compchoise, args.Length);
                    j.PlayGame();
                    Console.WriteLine(j.result);
                    Console.Write("HMAC key:"); compmove.PrintHex(compmove.secretkey);
                    break;
                }
                else if (humanchoise == 0) { break; }
                else if (humanchoise == -1) {
                    Console.Clear();
                    Table t = new Table(args);
                    t.CreateTable(args);
                    t.PrintTable(t.matrix);
                    Console.ReadKey();
                    Console.Clear();
                }
                else { Console.WriteLine("INPUT ERROR, Click on any button"); Console.ReadKey(); Console.Clear(); }
            }
        }
    }
}
