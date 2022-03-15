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



        }
    }
}
