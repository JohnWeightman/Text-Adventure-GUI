﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure_GUI
{
    static class DrawGUI
    {

        #region Program Start

        public static void DrawGUIConsole()     //Main start function to set up interface
        {
            Console.SetWindowSize(171, 50);     
            Console.SetBufferSize(172, 51);
            Console.Clear();
            DrawBorders();                      
            DrawPlayersFirstStatsBox();        
            DrawPlayersSecondStatsBox();
            DrawPlayersThirdStatsBox();
            DrawPlayersFourthStatsBox();
            DrawPlayersFifthStatsBox();
            DrawFightOrderBox();                
            DrawEnemiesBox();
            UpdateStoryBox(StartDisplay.StartStory);
            List<string> StartDisplayOptions = StartDisplay.StartOptions;
            UpdatePlayerOptions(StartDisplayOptions);
            List<string> StartDisplayEvents = StartDisplay.StartEvents;
            UpdateEventBox(StartDisplayEvents);
        }

        static void DrawBorders() //Draws the main borders for the interface
        {
            Draw.RectangleFromTop(170, 48, 0, 0, ConsoleColor.Blue);
            Draw.RectangleFromTop(170, 3, 0, 0, ConsoleColor.Blue);
            Draw.RectangleFromTop(146, 44, 24, 4, ConsoleColor.Blue);
            Draw.RectangleFromTop(24, 44, 146, 4, ConsoleColor.Blue);
            Draw.RectangleFromTop(122, 34, 24, 4, ConsoleColor.Blue);
            Draw.RectangleFromTop(61, 9, 85, 39, ConsoleColor.Blue);
            Console.SetCursorPosition(74, 2);
            Console.Write("Text Adventure GUI"); 
        }

        #endregion

        #region Players First Stats Box

        static void DrawPlayersFirstStatsBox() //Draws the Players first stats box
        {
            Draw.Rectangle(20, 4, 2, 3, Draw.DrawKind.BelowCursorButKeepCursorLocation, color: ConsoleColor.Green);
            UpdatePlayersFirstStatsBox(); 
        }

        public static void UpdatePlayersFirstStatsBox() //Updates the information in the Players first stats box
        {
            ClearPlayersFirstStatsBox(); 
            Console.SetCursorPosition(4, 6); 
            Console.Write("Name: " + Player.Name);
            Console.SetCursorPosition(4, 7);
            Console.Write("Lvl: " + Player.Level);
            Console.SetCursorPosition(4, 8);
            Console.Write("HP: " + Player.HP + "/" + Player.MaxHP);
            Console.SetCursorPosition(4, 9);
            Console.Write("AC: " + Player.AC);
        }

        public static void ClearPlayersFirstStatsBox() //Clears the Players first stats box
        {
            for (int YPos = 6; YPos < 10; YPos++)
            {
                Console.SetCursorPosition(4, YPos);
                for (int x = 0; x < 18; x++)
                {
                    Console.Write(" ");
                }
            }
        }

        #endregion

        #region Players Second Stats Box

        static void DrawPlayersSecondStatsBox() //Draws the Players second stats box
        {
            Draw.Rectangle(20, 3, 2, 1, Draw.DrawKind.BelowCursorButKeepCursorLocation, color: ConsoleColor.Green);
            UpdatePlayersSecondStatsBox();
        }

        public static void UpdatePlayersSecondStatsBox() //Updates the Players second stats box
        {
            ClearPlayersSecondStatsBox();
            Console.SetCursorPosition(4, 11);
            Console.Write("STR: " + Player.Str);
            Console.SetCursorPosition(4, 12);
            Console.Write("DEX: " + Player.Dex);
            Console.SetCursorPosition(4, 13);
            Console.Write("CON: " + Player.Con);
        }

        public static void ClearPlayersSecondStatsBox() //Clears the Players third stats box
        {
            for (int YPos = 11; YPos < 14; YPos++)
            {
                Console.SetCursorPosition(4, YPos);
                for (int x = 0; x < 18; x++)
                {
                    Console.Write(" ");
                }
            }
        }

        #endregion

        #region Players Third Stats Box

        static void DrawPlayersThirdStatsBox() //Draws the Players third stats box
        {
            Draw.Rectangle(20, 2, 2, 1, Draw.DrawKind.BelowCursorButKeepCursorLocation, color: ConsoleColor.Green);
            UpdatePlayersThirdStatsBox();
        }

        public static void UpdatePlayersThirdStatsBox() //Updates the Players third stat box
        {
            ClearPlayersThirdStatsBox();
            Console.SetCursorPosition(4, 15);
            Console.Write("XP: " + Player.XP);
            Console.SetCursorPosition(4, 16);
            Console.Write("LU: " + Player.LU);
        }

        public static void ClearPlayersThirdStatsBox() //Clears the Players third stat box
        {
            for (int YPos = 15; YPos < 17; YPos++)
            {
                Console.SetCursorPosition(4, YPos);
                for (int x = 0; x < 18; x++)
                {
                    Console.Write(" ");
                }
            }
        }

        #endregion

        #region Players Fourth Stats Box

        static void DrawPlayersFourthStatsBox() //Draws the Players fourth stats box
        {
            Draw.Rectangle(20, 3, 2, 1, Draw.DrawKind.BelowCursorButKeepCursorLocation, color: ConsoleColor.Green);
            UpdatePlayersFourthStatsBox();
        }

        public static void UpdatePlayersFourthStatsBox() //Update the Players fourth stat box
        {
            ClearPlayersFourthStatsBox();
            Console.SetCursorPosition(4, 18);
            Console.Write("Weapon: " + Player.Weapon);
            Console.SetCursorPosition(4, 19);
            Console.Write("OfHand: " + Player.OffHand);
            Console.SetCursorPosition(4, 20);
            Console.Write("Armour: " + Player.Armour);
        }

        public static void ClearPlayersFourthStatsBox() //Clear the Players fourth stat box
        {
            for (int YPos = 18; YPos < 21; YPos++)
            {
                Console.SetCursorPosition(4, YPos);
                for (int x = 0; x < 18; x++)
                {
                    Console.Write(" ");
                }
            }
        }

        #endregion

        #region Players Inventory Box

        static void DrawPlayersFifthStatsBox() //Draws the Players fifth stats box
        {
            Draw.Rectangle(20, 26, 2, 1, Draw.DrawKind.BelowCursorButKeepCursorLocation, color: ConsoleColor.Green);
            UpdateInventory();
        }

        public static void UpdateInventory() //Updates the Players Inventory box
        {
            ClearInventory();
            Console.SetCursorPosition(4, 22);
            Console.Write("Inventory");
            int YPos = 24;
            foreach (string Item in Player.Inventory)
            {
                Console.SetCursorPosition(4, YPos);
                Console.Write(Item);
                YPos += 1;
            }
        }

        public static void ClearInventory() //Clears the Players Inventory box
        {
            for (int YPos = 22; YPos < 48; YPos++)
            {
                Console.SetCursorPosition(4, YPos);
                for (int x = 0; x < 18; x++)
                {
                    Console.Write(" ");
                }
            }
        }

        #endregion

        #region Fight Order Box

        static void DrawFightOrderBox() //Draws the Fight Order box
        {
            Draw.Rectangle(20, 10, 148, -23, Draw.DrawKind.BelowCursorButKeepCursorLocation, color: ConsoleColor.Red);
            List<string> StartDisplayList = StartDisplay.StartFightOrder;
            UpdateFightOrderBox(StartDisplayList);
        }

        public static void UpdateFightOrderBox(List<string> FightOrder) //Updates the Fight Order box
        {
            ClearFightOrderBox();
            Console.SetCursorPosition(150, 6);
            Console.Write("Fight Order");
            int YPos = 8;
            foreach(string Character in FightOrder)
            {
                Console.SetCursorPosition(150, YPos);
                Console.Write(Character);
                YPos += 1;
            }
        }

        public static void ClearFightOrderBox() //Clears the Fight Order box
        {
            for (int YPos = 6; YPos < 16; YPos++)
            {
                Console.SetCursorPosition(150, YPos);
                for (int x = 0; x < 18; x++)
                {
                    Console.Write(" ");
                }
            }
        }

        #endregion

        #region Enemies Box

        static void DrawEnemiesBox() //Draws the Enemies box
        {
            Draw.Rectangle(20, 10, 148, 1, Draw.DrawKind.BelowCursorButKeepCursorLocation, color: ConsoleColor.Red);
            List<string> StartDisplayList = StartDisplay.StartEnemies;
            UpdateEnemiesBox(StartDisplayList);
        }

        public static void UpdateEnemiesBox(List<string> Enemies) //Updates the Enmies Box
        {
            ClearEnemiesBox();
            Console.SetCursorPosition(150, 17);
            Console.Write("Enemies");
            int YPos = 19;
            foreach(string Enemy in Enemies)
            {
                Console.SetCursorPosition(150, YPos);
                Console.Write(Enemy);
                YPos += 1;
            }
        }

        public static void ClearEnemiesBox() //Clears the Enemies box
        {
            for (int YPos = 17; YPos < 26; YPos++)
            {
                Console.SetCursorPosition(150, YPos);
                for (int x = 0; x < 18; x++)
                {
                    Console.Write(" ");
                }
            }
        }

        #endregion

        #region Story Box

        public static void UpdateStoryBox(List<string> StoryStrings) //Updates the Story box
        {
            ClearStoryBox();
            int YPos = 6;
            foreach (string StoryString in StoryStrings)
            {
                List<string> Story = CheckStringLength(StoryString);
                foreach (string Line in Story)
                {
                    Console.SetCursorPosition(28, YPos);
                    Console.Write(Line);
                    YPos += 1;
                }
            }
        }

        static List<string> CheckStringLength(string Text)   //limites each written line is no longer than 97 characters
        {
            List<string> Story = new List<string>();
            bool TextTooLong = true;
            int CharNum = 110;
            while (TextTooLong)
            {
                if (Text.Length > CharNum)
                {
                    char[] CharString = Text.ToCharArray();
                    bool Found = false;
                    while (!Found)
                    {
                        if (CharString[CharNum] == ' ' || CharString[CharNum] == '.')
                        {
                            char[] chars = Text.ToCharArray(0, CharNum);
                            string Temp = new string(chars);
                            Story.Add(Temp);
                            if (CharString[CharNum] == ' ')
                            {
                                Text = Text.Substring(CharNum + 1);
                            }
                            else
                            {
                                Text = Text.Substring(CharNum);
                            }
                            CharNum = 110;
                            Found = !Found;
                        }
                        else
                        {
                            CharNum -= 1;
                        }
                    }
                }
                else
                {
                    TextTooLong = !TextTooLong;
                    Story.Add(Text);
                }
            }
            return Story;
        }

        public static void ClearStoryBox() //Clears the story box
        {
            for (int YPos = 6; YPos < 39; YPos++)
            {
                Console.SetCursorPosition(28, YPos);
                for (int x = 0; x < 115; x++)
                {
                    Console.Write(" ");
                }
            }
        }

        #endregion

        #region Player Options Box

        public static void UpdatePlayerOptions(List<string> Options) //Updates the Players Options box
        {
            ClearPlayerOptions();
            int YPos = 41;
            int OptionNum = 1;
            bool Left = true;
            foreach(string Option in Options)
            {
                if (Left)
                {
                    Console.SetCursorPosition(28, YPos);
                    Console.Write(OptionNum + ". " + Option);
                    OptionNum += 1;
                    YPos += 1;
                    if(YPos > 47)
                    {
                        YPos = 41;
                        Left = !Left;
                    }
                }
                else
                {
                    Console.SetCursorPosition(50, YPos);
                    Console.Write(OptionNum + ". " + Option);
                    OptionNum += 1;
                    YPos += 1;
                }
            }
        }

        public static void ClearPlayerOptions() //Clears the Players Option box
        {
            for (int YPos = 41; YPos < 49; YPos++)
            {
                Console.SetCursorPosition(28, YPos);
                for (int x = 0; x < 55; x++)
                {
                    Console.Write(" ");
                }
            }
        }

        #endregion

        #region Events Box

        public static void UpdateEventBox(List<string> Events) //Updates the Event box
        {
            ClearEventsBox();
            int YPos = 40;
            foreach (string Event in Events)
            {
                Console.SetCursorPosition(86, YPos);
                Console.Write(Event);
                YPos += 1;
            }
        }

        public static void ClearEventsBox() //Updates the Event box
        {
            for (int YPos = 40; YPos < 49; YPos++)
            {
                Console.SetCursorPosition(86, YPos);
                for (int x = 0; x < 60; x++)
                {
                    Console.Write(" ");
                }
            }
        }

        #endregion

    }
}
