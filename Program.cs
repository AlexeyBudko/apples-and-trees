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

        public int Shake()
        {
            Random rand = new Random();
            int shakenApples = rand.Next(100500);
            while (shakenApples > this.numOfApples)
                shakenApples = rand.Next(100500);
            numOfApples -= shakenApples;
            return shakenApples;
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
            Tree appleTree = new Tree();
            char operation;

            do
            {
                Console.WriteLine("Enter 'g' for growing apples, 'f' - for finish and 's' - for shake");
                operation = Convert.ToChar(Console.ReadLine());
                switch (operation)
                {
                    case 'g':
                        int numOfGrownApples = appleTree.Grow();
                        Console.WriteLine("Was grown " + numOfGrownApples + " apples.");
                        break;
                    case 's':
                        int numOfShakenApples = appleTree.Shake();
                        Console.WriteLine("Was shaken " + numOfShakenApples + " apples.");
                        break;
                    case 'f':
                        break;
                    default:
                        Console.WriteLine("Wrong key!");
                        break;

                }
            } while (operation != 'f');
        }
    }
}
