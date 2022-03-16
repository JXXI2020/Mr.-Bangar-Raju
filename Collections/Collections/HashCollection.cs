using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class HashCollection
    {
        //Collections Part2
        //Array and collections
        //index is the key for access
        //HashTable: Key Value Combination

        static void Main()
        {

            Hashtable ht = new Hashtable();
            ht.Add("Eid", 1010);
            ht.Add("Ename", "Scott");
            ht.Add("Job", "Manager");
            ht.Add("Did", 30);
            ht.Add("Mgrid", 130);
            ht.Add("Email", "scott@fasd.com");

            Console.WriteLine(ht["Email"]);

            foreach (object key in ht.Keys)
            {
                Console.WriteLine(key + " : " +ht[key]);

                Console.WriteLine(key);
                Console.WriteLine(ht[key]);
                Console.WriteLine(key.GetHashCode());
            }
                

            Console.WriteLine("Hello".GetHashCode()); // give the hashcode, internal code

            Console.ReadLine();
        }

    }
}
