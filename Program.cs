using System;

namespace AVLTree
{
    class Program
    {
        static void Main(string[] args)
        {
            AVLTree<int> oak = new AVLTree<int>();

            oak.Add(7);
            oak.Add(1);
            oak.Add(9);
            oak.Add(3);
            oak.Add(10);
            oak.Add(14);
            oak.Add(16);
            oak.Add(5);
            oak.Add(2);
            oak.Add(12);
            oak.Add(17);

            foreach (var item in oak)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(oak.Contains(4));
            
            Console.WriteLine(oak.Contains(5));

            oak.Remove(2);

            foreach (var item in oak)
            {
                Console.WriteLine(item);
            }

            oak.Clear();

            foreach (var item in oak)
            {
                Console.WriteLine(item);
            }
        }
    }
}