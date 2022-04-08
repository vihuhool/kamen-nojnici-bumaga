using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Menu
    {
       public int size;
        public Menu(string[] args)
        {
            size = args.Length;
        }
        public void PrintMenu(string[] args)
        {
            for (int i=0;i<size;i++)
            {
                Console.WriteLine(i+1 + ". " + args[i]);
            }
            Console.WriteLine("0" + ". " + "Exit");
            Console.WriteLine("?" + ". " + "Help");
            Console.Write("Enter your move: ");

        }
    }
}
