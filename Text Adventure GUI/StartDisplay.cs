﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure_GUI
{
    static class StartDisplay
    {
        public static List<string> StartStory = new List<string>() { "Welcome to a text adventure!" };
        public static List<string> StartFightOrder = new List<string>() {"Player", "Bandit 1", "Bandit 2", "Bandit 3", "Bandit 4", "Bandit 5", "Bandit 6",
            "Bandit 7"};
        public static List<string> StartEnemies = new List<string>() { "Bandit 1", "Bandit 2", "Bandit 3", "Bandit 4", "Bandit 5", "Bandit 6", "Bandit 7" };
        public static List<string> StartOptions = new List<string>() {"Option 1", "Option 2", "Option 3", "Option 4", "Option 5", "Option 6", "Option 7",
            "Option 8", "Option 9", "Option 10", "Option 11", "Option 12", "Option 13", "Option 14"};
        public static List<string> StartEvents = new List<string>() {"Event 1", "Event 2", "Event 3", "Event 4", "Event 5", "Event 6", "Event 7", "Event 8",
            "Event 9"};
    }
}
