using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInspector.Core
{
    public class CharacterCounter
    {
        public IEnumerable<char> FindMostOccuringCharacter(string value)
        {
            Dictionary<char, int> characterCounter = new Dictionary<char, int>();

            int maxCount = 0;

            foreach (char c in value)
            {
                int i;
                characterCounter.TryGetValue(c, out i);
                i++;

                if (i > maxCount)
                {
                    maxCount = i;
                }

                characterCounter[c] = i;
            }

            List<char> mostOccuringCharacters = new List<char>();

            foreach (KeyValuePair<char, int> characterCount in characterCounter)
            {
                if (characterCount.Value == maxCount)
                {
                    mostOccuringCharacters.Add(characterCount.Key);
                }
            }

            return mostOccuringCharacters.AsEnumerable();
        }
    }
}
