using System;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World of collections in C#");

            int[] arr = new int[10];
            Array.Resize(ref arr, 15); // parameter: 1: ref is output param, 15: the size
                                       // just create the 5 values into the array, is better create a new one to have the 15
                                       // never possible in a static array:
                                       // incresing the size 
                                       // if want insert into the middle of an array
                                       // delete or removing values from the middle

            // Non-Generic Collections:
            // System.Collections: Stack, Queue, LinkedList, SortedeList, HashTable

            //Array and Array List:
            //Fixed Lenght    Variable Lenght
            //Not possible to insert items    We can insert items into the middle
            //Not possible to delete items    We can delete items from the middle

            ArrayList al = new ArrayList();
            Console.WriteLine(al.Capacity);
            al.Add(100);
            Console.WriteLine(al.Capacity);
            al.Add(200); al.Add(300); al.Add(400);
            Console.WriteLine(al.Capacity);
            al.Add(500); // auto resize give 4 more
            Console.WriteLine(al.Capacity);

            foreach (object obj in al)
                Console.Write(obj + " ");
            Console.WriteLine();

            // insert an itme
            al.Insert(3, 350);
            foreach (object obj in al)
                Console.Write(obj + " ");
            Console.WriteLine();

            // remove an item
            al.Remove(200); // by value
            al.RemoveAt(2); // by index
            foreach (object obj in al)
                Console.Write(obj + " ");

            Console.ReadLine();

            
            

        }
    }
}
