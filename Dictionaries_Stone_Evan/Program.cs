using System.Collections.Generic;

namespace Dictionaries_Stone_Evan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program: 21");

            Dictionary<int, string> topGames = new Dictionary<int, string>();
            topGames.Add(1, "MonsterHunter:World");
            topGames.Add(2, "MonsterHunter:Wilds");
            topGames.Add(3, "No Man's Sky");
            topGames.Add(4, "Minecraft");
            topGames.Add(5, "Sea of Thieves");
            topGames.Add(6, "Halo: Master Chief Collection");
            topGames.Add(7, "DOOM: The Dark Ages");
            topGames.Add(8, "Helldivers 2");
            topGames.Add(9, "Halo: Infinite");
            topGames.Add(10, "Warhammer 40k: Space Marine II");
        }
    }
}