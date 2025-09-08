using System.Collections.Generic;
using System.Collections;

namespace Dictionaries_Stone_Evan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program: 21"); //writes program #

            //creates dictionary: topGames with my top 10 games
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

            //for each kv pair in topGames, write the key and value in console
            foreach(KeyValuePair<int, string> kvp in topGames)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value; {kvp.Value}");
            }

            //if topGame contains a 1 key, write what my favorite game is
            if (topGames.ContainsKey(1)) 
            {
                Console.WriteLine($"My favorite game is {topGames[1]}!");
            }

            string result = ""; //creates empty result string

            topGames.TryGetValue(11, out result); //trys to get the value of a kvp with the key "11"

            //if result does not = "", then write result, if else then state there is no game with key "11"
            if (result != "")
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("There is no game in the eleventh position.");
            }
             //if topGame contain a 5 key, replace its value with "Skylanders: SuperChargers"
            if (topGames.ContainsKey(5))
            {
                topGames[5] = "Skylanders: Superchargers";
            }

            //writes the new 5 value
            Console.WriteLine(topGames[5]);
            
            //creates a hashtable with topGames's values
            Hashtable hashtable = new Hashtable(topGames);

            //create the string favGame and give it the value of hashtable's 1
            string favGame = (string)hashtable[1];

            //writes the favorite game from hashtable
            Console.WriteLine($"Favorite Game: {favGame}");

            //creates a new hastable but for capitals, and assigns it kvp
            Hashtable capitals = new Hashtable()
            {
                { "Oklahoma", "Oklahoma City" },
                {"New York", "Albany" },
                {"California", "Sacramento" },
                {"Florida", "Tallahassee" }
            };

            //for each kvp in capitals, write its key and value
            foreach (DictionaryEntry kvp in capitals)
            { 
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            capitals.Clear();//clears the capital hashtable
        }
    }
}