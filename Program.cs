using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Apples_and_trees
{
    class Tree
    {
        public Tree()
        {
            numOfApples = 0;
        }

        public Tree(int amountOaApples)
        {
            numOfApples = amountOaApples;
        }

        private int numOfApples
        {
            set;
            get;
        }

        public int Grow()
        {
            Random rand = new Random();
            int grownApples = rand.Next(100500);
            numOfApples += grownApples;
            return grownApples;
        }
    }

    class Apple
    {
        int numOfPips
        {
            set;
            get;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
