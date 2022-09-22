using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example of Queue In Collection

            
            
                Queue qu = new Queue();

                qu.Enqueue(100);
                qu.Enqueue(200);
                qu.Enqueue(300);
                qu.Enqueue(500);

                qu.Dequeue();

                foreach (var item in qu)
                {
                    Console.WriteLine(item);
                }


            
        }

    }
}
    

