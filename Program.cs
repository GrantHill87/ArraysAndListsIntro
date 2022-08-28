using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here are we are with the arrays and lists exercise.");
            Console.WriteLine("");
            Console.WriteLine("We'll create some variables that can help express defined inputs of list-like spectrums.");
            var sodaDispenser = new string[] {"coca-cola", "sprite", "7up", "Dr.Pepper", "pepsi", "root beer", "diet coke"};
            Console.WriteLine("");
            Console.WriteLine($"A soda dispenser collection (of soda varieties) has been created. It has the following options;");
            Console.WriteLine("");
            foreach (var soda in sodaDispenser)
            {
                Console.WriteLine(soda);
            }
            Console.WriteLine("");
            Console.WriteLine("The above array was printed using the 'for each' function. Let's try the same action with a different function.");
            Console.WriteLine("");
            for (int i = 0; i < sodaDispenser.Length; i++)
            {
                Console.WriteLine(sodaDispenser[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("The same array as before has now been printed again, using the 'for' function.");
            Console.WriteLine("");
            Console.WriteLine("An array is oriented within a reference variable type spectrum, and cannot be altered once created. Utilizes the 'sodaDispenser.Length' function in its capacity.");
            Console.WriteLine("");
            Console.WriteLine("A list is oriented within a value variable type spectrum, and can be changed at any time. Utilizes the 'sodaDispenser.Count' function in its capacity.");
            Console.WriteLine("");
            Console.WriteLine("Keep in my mind that some methods are already pre-defined, such as 'list.add', or 'list.remove', where 'list' represents the actual list, and 'add', or 'remove' represent pre-defined methods.");
            var gramsOfSugar = new List<int>();
            gramsOfSugar.Add(1);
            gramsOfSugar.Add(2);
            gramsOfSugar.Add(100);
            gramsOfSugar.Add(200);
            Console.WriteLine("");
            Console.WriteLine("We'll go ahead and attempt to print aspects of our newly defined variable, utilizing the list format.");
            Console.WriteLine("");
            foreach (var gram in gramsOfSugar)
            {
                Console.WriteLine(gram);
            }
            Console.WriteLine("");
            Console.WriteLine("Looks like it worked! Cool, now let's change up our newly defined list, and then print it with a different function.");
            Console.WriteLine("");
            gramsOfSugar.Remove(1);
            gramsOfSugar.Remove(2);
            gramsOfSugar.Add(300);
            gramsOfSugar.Add(400);
            for (int v = 0; v < gramsOfSugar.Count; v++)
            {
                Console.WriteLine(gramsOfSugar[v]);
            }
            Console.WriteLine("");
            Console.WriteLine("Nice. Be sure to check the libraries being utilized in your prgramming, by checking the very top of your script. Up above, we needed to employ the library titled, 'system.collections.generic', in order to safely use lists functionally within our code.");
        }
    }
}
