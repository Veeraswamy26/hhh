using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Class1
    {
        /* public static void add(int a, int b)
         {
             var c = a + b;
             Console.WriteLine(c);
         }
         public static void add()
         {
             int a = Convert.ToInt32(Console.ReadLine());
             int b = Convert.ToInt32(Console.ReadLine());
             int c = a + b;
             Console.WriteLine(c);
             if (c <= 0)
             {
                 Console.WriteLine("TC FAILED");
             }
             else if (c > 0)
             {
                 Console.WriteLine("tC PASSED");
             }
             else
             {
                 Console.WriteLine("AE");
             }
         }
         */
        public static void Main(string[] args)
        {
            generic();
            nongenric();
            Console.Read();
        }
        public static void nongenric()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("sno", "1");
            hashtable.Add("Name", "veera");
            hashtable.Add("company", "iray");
            hashtable.Add("experience", "1");

            foreach (string key in hashtable.Keys)
            {
                Console.WriteLine("key  : " + key + "      value : " + hashtable[key]);
            }
        }
        public static void generic()
        {
            string[] student1 = new string[] { "veera", "mvgr", "2024" };
            string[] student2 = new string[] { "sai", "giet", "2019" };
            string[] student3 = new string[] { "naresh", "Arora", "2022" };
            string[] student4 = new string[] { "vamsi", "bvc", "2023" };

            Dictionary<int, string[]> dict = new Dictionary<int, string[]>();

            dict.Add(1, student1);
            dict.Add(2, student2);  
            dict.Add(3, student3);  
            dict.Add(4, student4);

            foreach (var data in dict) 
            {
                string[] studentdata = data.Value;
                foreach (var key in studentdata) 
                {
                    Console.WriteLine(key);
                }
            }
        }
    }
}