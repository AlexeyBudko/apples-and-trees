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
        private int numOfBlossomedApples;

        public Tree()
        {
            this.apples=new List<Apple>();
        }

        public int getNumOfBlossomedApples()
        {
            return this.numOfBlossomedApples;
        }

        public int getNumOfApples()
        {
            return this.apples.Count;
        }

        public int Grow()
        {
            int grownApples = this.numOfBlossomedApples;
            for (int i = 0; i < grownApples; i++)
                this.apples.Add(new Apple());
            return grownApples;
        }

        public int Shake()
        {
            Random rand = new Random();
            int shakenApples = rand.Next(this.getNumOfApples() + 1);
            this.apples.RemoveRange(0, shakenApples);
            return shakenApples;
        }

        public int CountAllPips()
        {
            int numOfPips = 0;
            foreach (Apple apple in this.apples)
                numOfPips += apple.getNumOfPips();
            return numOfPips;
        }

        public int Blossom()
        {
            Random rand = new Random();
            this.numOfBlossomedApples = rand.Next(25);
            return this.numOfBlossomedApples;
        }

        public void Reset()
        {
            this.numOfBlossomedApples = 0;
            this.apples.Clear();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Tree appleTree = new Tree();

            appleTree.Blossom();

            char operation;

            do
            {
                Console.WriteLine("Enter 'g' for growing apples, 'f' - for finish and 's' - for shake, 'b' - for blossom, 'r' - for reset");
                operation = Convert.ToChar(Console.ReadLine());
                switch (operation)
                {
                    case 'g':
                        if (appleTree.getNumOfApples() == 0 && appleTree.getNumOfBlossomedApples() > 0)
                        {
                            int numOfGrownApples = appleTree.Grow();
                            Console.WriteLine("Was grown " + numOfGrownApples + " apples.");
                        }
                        else
                            Console.WriteLine("Apples can't grow on the tree!");
                        break;
                    case 's':
                        if (appleTree.getNumOfApples() == 0)
                            Console.WriteLine("There are no apples on the tree!");
                        else
                        {
                            int numOfShakenApples = appleTree.Shake();
                            Console.WriteLine("Was shaken " + numOfShakenApples + " apples.");
                        }
                        break;
                    case 'b':
                        if (appleTree.getNumOfBlossomedApples() == 0)
                        {
                            int numOfBlossomedApples = appleTree.Blossom();
                            Console.WriteLine("Was blossomed " + numOfBlossomedApples + " apples.");
                        }
                        else
                            Console.WriteLine("The tree can't blossom!");
                        break;
                    case 'r':
                        appleTree.Reset();
                        Console.WriteLine("The tree has no flowers and no apples");
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
