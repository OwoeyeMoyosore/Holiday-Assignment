using System;
using System.Linq;
using System.Collections.Generic;


namespace Question1
{
    public class Program
    {
        public static void Main()
        {
            var ewords = words.Where(x => x.Contains("e"))//Question 2
                              .OrderBy(x => x);//Question 3
            Console.WriteLine($"Words that contains lowercase 'e':");
            foreach (string word in ewords)
            {
                Console.WriteLine(word);
            }
            //Question 4
            var lastword = ewords.Last();
            Console.WriteLine($"\n Last Word is {lastword} \n");

            //Question 5
            Console.WriteLine($" Words that contains asterisk '*':");
            var asterisk  = words.Where(x => x.Contains("*"))
                                 .OrderBy(x => x);
            foreach (string word in asterisk) 
            {
                Console.WriteLine(word);
            }


            //var word = Keywords.Where(b => !b.Contains("a") || !b.Contains("o"));
            //                        //.Select(z => z);
            //foreach(var item in word)
            //{
            //    Console.WriteLine(item); 

        }




         static string[] words = {"abstract", "add*", "alias*", "as", "ascending*",
             "async*", "await*", "base","bool", "break",
             "by*", "byte", "case", "catch", "char", "checked",
             "class", "const", "continue", "decimal", "default",
             "delegate", "descending*", "do", "double",
             "dynamic*", "else", "enum", "event", "equals*",
             "explicit", "extern", "false", "finally", "fixed",
             "from*", "float", "for", "foreach", "get*", "global*",
             "group*", "goto", "if", "implicit", "in", "int",
             "into*", "interface", "internal", "is", "lock", "long",
             "join*", "let*", "nameof*", "namespace", "new", "null",
             "object", "on*", "operator", "orderby*", "out",
             "override", "params", "partial*", "private", "protected",
             "public", "readonly", "ref", "remove*", "return", "sbyte",
             "sealed", "select*", "set*", "short", "sizeof",
             "stackalloc", "static", "string", "struct", "switch",
             "this", "throw", "true", "try", "typeof", "uint", "ulong",
             "unsafe", "ushort", "using", "value*", "var*", "virtual",
             "unchecked", "void", "volatile", "where*", "while", "yield*" };
    }
}






