using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Queue
{
    public class Program
    {
        
        static void Main(string[] args)
        
        {
              Hashtable hs = new Hashtable();

              hs.Add(91, "IND");
              hs.Add(92, "PAK");
              hs.Add(33, " FR");
              hs.Add(35, "AUS");

             hs.Remove(33);

         foreach (DictionaryEntry d in hs)
        {
         Console.WriteLine($"{d.Key}  {d.Value}");
         }
      }

        

}
        

}



       

    

