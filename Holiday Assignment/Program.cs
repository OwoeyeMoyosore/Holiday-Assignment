using System;
using System.Linq;
using System.Collections.Generic;
namespace Question3
{
    public class Program 
    {
        public static string[] words = { "plane", "ferry", "car", "bike"};
        
        static void Main()
        {
            var word = words.OrderBy(x => x)
                            .Where(x => x.Contains("e"));
            foreach(var item in word)
            {
                Console.WriteLine(item);
            }
            
            

        }
    }

}

//1.Given a non-empty list of words above, sort it alphabetically and return a word that contains letter 'e'