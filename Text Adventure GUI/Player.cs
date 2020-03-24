using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure_GUI
{
    static class Player
    {
        public static string Name = "Player";
        public static int Level = 1;
        public static int HP = 90;
        public static int MaxHP = 90;
        public static int AC = 18;
        public static int Pro = 2;
        public static int Str = 18;
        public static int Dex = 16;
        public static int Con = 14;
        public static int XP = 1000;
        public static int LU = 2000;
        public static string Weapon = "Longsword";
        public static string OffHand = "Shield";
        public static string Armour = "Chainmail";
        public static List<string> Inventory = new List<string>() {
            "Health Potion",
            "Health Potion",
            "Health Potion",
            "Key",
            "Key"
        };
    }
}