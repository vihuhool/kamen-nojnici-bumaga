using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using ConsoleTables;


namespace ConsoleApp3
{

    public class Table
    {
        ConsoleTable table = new ConsoleTable();
        int length;
        public string[,] matrix;
        public Table(string[] args)
        {
            table = new ConsoleTable();
            length = args.Length;
            matrix = new string[length + 1, length + 1];

        }
        public void CreateTable(string[] args)
        {
            matrix[0, 0] = ".";
            for (int i = 1; i <= length; i++) { matrix[0, i] = args[i-1]; matrix[i, 0] = args[i-1]; }
            for (int j = 1; j <= length; j++)
            {
                for (int i = 1; i <= length; i++)
                {
                    if ((i - j + length) % length > (int)(length / 2)) matrix[i, j] = "lose";
                    else if (i == j) matrix[i, j] = "draw";
                    else matrix[i , j] = "win";

                }
            }
        }
        public void PrintTable(string[,] matrix)
        {
            var interval =5 ;
            for (int i=1; i<=length; i++)
            {
                if (interval < matrix[0, i].Length) interval = matrix[0, i].Length;
            }
            string format = String.Format("{{0,{0}}}", interval);
            for (int j = 0; j <= length; j++)
            {
                for (int i = 0; i <= length; i++)
                {
                    Console.Write(format, matrix[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine("\n");
            }
        }

            
    }
    
}
