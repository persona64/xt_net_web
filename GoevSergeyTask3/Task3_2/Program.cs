using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_2
{
    class Program
    {
        static void WordFrequency(string word)
        {
            char[] stringSeparator = { ' ', '.', '!', ',' };
            string changeString = word.ToLower();
            string[] wordsArray = changeString.Split(stringSeparator);
            Dictionary<string, int> words = new Dictionary<string, int>();

            foreach (var item in wordsArray)
            {
                if (words.ContainsKey(item))
                    words[item]++;
                else
                    words.Add(item, 1);
            }

            Console.WriteLine();

            foreach (KeyValuePair<string, int> keyValuePair in words)
            {
                Console.WriteLine("Слово: {0}, частота повторений: {1}", keyValuePair.Key, keyValuePair.Value);
            }
        }

        static void Main(string[] args)
        {
            string text = "In the summer it is hot. In the winter it is not. In the spring " +
                "there are flowers. In the autumn there are showers.";
            string text2 = "Rain on the green grass, Rain on the tree, " +
                "Rain on the house - tops, But not on me";
            string text3 = "Whether the weather be fine, Or whether the weather be not, " +
                "Whether the weather be cold, Or whether the weather be hot, " +
                "We’ll whether the weather Whatever the weather Whether we like it or not.";

            WordFrequency(text);
            WordFrequency(text2);
            WordFrequency(text3);

            Console.ReadKey();
        }
    }
}
