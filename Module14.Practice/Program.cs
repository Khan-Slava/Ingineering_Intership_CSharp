using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module14.Practice
{
    internal class Program
    {
        static void Main()
        {
            string text = "Вот дом, Который построил Джек. А это пшеница, Которая в темном чулане хранится В доме, Который построил Джек. А это веселая птица-синица, Которая часто ворует пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";

            string[] words = text.Split(new[] { ' ', ',', '.', '-', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            // Вывод статистики в виде таблицы
            Console.WriteLine("Слово\t\tЧастота");
            Console.WriteLine("-----------------------");
            foreach (var pair in wordCount.OrderByDescending(p => p.Value))
            {
                Console.WriteLine($"{pair.Key}\t\t{pair.Value}");
            }
        }
    }
}
