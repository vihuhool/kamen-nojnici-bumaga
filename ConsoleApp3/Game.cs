using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Game
    {
        int humanchoise;
        int compchoise;
        int length;
        public string result;
        public Game(int humanchoise, int compchoise, int length)
        {
            this.compchoise = compchoise;
            this.humanchoise = humanchoise;
            this.length = length;
        }
        public void PlayGame()
        {
            if ((humanchoise - compchoise+length) % length > (int)(length / 2)) result = "win";
            else if (humanchoise == compchoise) result = "draw";
            else result = "lose";
        }
    }
}
