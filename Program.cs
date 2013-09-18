using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Apples_and_trees
{
    class Apple
    {
        int numOfPips;

        public int getNumOfPips()
        {
            return this.numOfPips;
        }

        public Apple()
        {
            Random rand = new Random();
            this.numOfPips = rand.Next(20);
        }
    }

    class Tree
    {
        private List<Apple> apples;

        public Tree()
        {
            this.apples=new List<Apple>();
        }

        public int Grow()
        {
            Random rand = new Random();
            int grownApples = rand.Next(100);
            for (int i = 0; i < grownApples; i++)
                apples.Add(new Apple());
            return grownApples;
        }

        public int Shake()
        {
            Random rand = new Random();
            int shakenApples = rand.Next(this.apples.Capacity);
            apples.RemoveRange(0, shakenApples);
            return shakenApples;
        }

        public int CountAllPips()
        {
            int numOfPips = 0;
            foreach (Apple apple in this.apples)
                numOfPips += apple.getNumOfPips();
            return numOfPips;
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
