using System.Collections.Generic;
using System.Collections;

namespace Dictionaries_Stone_Evan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program: 21");

            Dictionary<int, string> topGames = new Dictionary<int, string>();
            topGames.Add(1, "MonsterHunter: World");
            topGames.Add(2, "MonsterHunter: Wilds");
            topGames.Add(3, "No Man's Sky");
            topGames.Add(4, "Minecraft");
            topGames.Add(5, "Sea of Thieves");
            topGames.Add(6, "Halo: Master Chief Collection");
            topGames.Add(7, "DOOM: The Dark Ages");
            topGames.Add(8, "Helldivers 2");
            topGames.Add(9, "Halo: Infinite");
            topGames.Add(10, "Warhammer 40k: Space Marine II");

            foreach(KeyValuePair<int, string> kvp in topGames)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value; {kvp.Value}");
            }

            if (topGames.ContainsKey(1)) 
            {
                Console.WriteLine($"My favorite game is {topGames[1]}!");
            }

            string result = "";

            topGames.TryGetValue(11, out result);

            if (result != "")
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("There is no game in the eleventh position.");
            }

            if (topGames.ContainsKey(5))
            {
                topGames[5] = "Skylanders: Superchargers";
            }

            Console.WriteLine(topGames[5]);

            Hashtable hashtable = new Hashtable(topGames);

            string favGame = (string)hashtable[1];

            Console.WriteLine($"Favorite Game: {favGame}");

            Hashtable capitals = new Hashtable()
            {
                { "Oklahoma", "Oklahoma City" },
                {"New York", "Albany" },
                {"California", "Sacramento" },
                {"Florida", "Tallahassee" }
            };

            foreach (DictionaryEntry kvp in capitals)
            { 
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            capitals.Clear();
        }
    }
}