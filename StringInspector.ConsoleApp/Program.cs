using StringInspector.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInspector.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CharacterCounter characterCounter = new CharacterCounter();

            Console.WriteLine("Type in a string, the characters that occur the most will be returned.");
            string value = Console.ReadLine();
            IEnumerable<char> mostOccuringCharacters = characterCounter.FindMostOccuringCharacter(value);
            Console.WriteLine("The most occuring characters are:");
            foreach (var character in mostOccuringCharacters)
            {
                Console.WriteLine(character);
            }
            Console.ReadLine();
        }
    }
}
