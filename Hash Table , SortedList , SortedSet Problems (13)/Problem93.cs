using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace problem_solving_course_23
{

    class Problem93
    {
        //Problem 93: Copy Hashtable to Another Hashtable.


        static void Main1()
        {
            // Create a new Hashtable and add some key-value pairs
            Hashtable hashtable1 = new Hashtable();
            hashtable1.Add("Key1", "Value1");
            hashtable1.Add("Key2", "Value2");
            hashtable1.Add("Key3", "Value3");
            // Create a new Hashtable to copy the contents into
            Hashtable hashtable2 = new Hashtable(hashtable1);
            // Copy the contents of hashtable1 to hashtable2
            
            Console.WriteLine("Contents of hashtable1:");
            foreach (DictionaryEntry entry in hashtable1)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
            Console.WriteLine("\nContents of hashtable2:");
            foreach (DictionaryEntry entry in hashtable2)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }

        }

    }
}
