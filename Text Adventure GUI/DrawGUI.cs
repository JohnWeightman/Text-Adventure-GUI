using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure_GUI
{
    static class DrawGUI
    {

        #region Program Start

        public static void DrawGUIConsole()
        {
            Console.Clear();
            DrawBorders();
            DrawPlayersFirstStatsBox();
            DrawPlayersSecondStatsBox();
            DrawPlayersThirdStatsBox();
            DrawPlayersFourthStatsBox();
            DrawPlayersFifthStatsBox();
            DrawFightOrderBox();
            DrawEnemiesBox();
            WriteStory();
            PrintPlayerOptions();
        }

        static void DrawBorders()
        {
            Draw.RectangleFromTop(170, 48, 0, 0, ConsoleColor.Blue);
            Draw.RectangleFromTop(170, 3, 0, 0, ConsoleColor.Blue);
            Draw.RectangleFromTop(146, 44, 24, 4, ConsoleColor.Blue);
            Draw.RectangleFromTop(24, 44, 146, 4, ConsoleColor.Blue);
            Draw.RectangleFromTop(122, 34, 24, 4, ConsoleColor.Blue);
            Draw.RectangleFromTop(61, 9, 85, 39, ConsoleColor.Blue);
            Console.SetCursorPosition(80, 2);
            Console.Write("Title");
            //Draw.Rectangle(22, 17, 1, 5, color: ConsoleColor.Green);
        }

        #endregion

        #region Players First Stats Box

        static void DrawPlayersFirstStatsBox()
        {
            Draw.Rectangle(20, 4, 2, 3, Draw.DrawKind.BelowCursorButKeepCursorLocation, color: ConsoleColor.Green);
            UpdatePlayersFirstStatsBox();
        }

        public static void UpdatePlayersFirstStatsBox()
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

        static void ClearPlayersFirstStatsBox()
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

        static void DrawPlayersSecondStatsBox()
        {
            Draw.Rectangle(20, 3, 2, 1, Draw.DrawKind.BelowCursorButKeepCursorLocation, color: ConsoleColor.Green);
            UpdatePlayersSecondStatsBox();
        }

        public static void UpdatePlayersSecondStatsBox()
        {
            ClearPlayersSecondStatsBox();
            Console.SetCursorPosition(4, 11);
            Console.Write("STR: " + Player.Str);
            Console.SetCursorPosition(4, 12);
            Console.Write("DEX: " + Player.Dex);
            Console.SetCursorPosition(4, 13);
            Console.Write("CON: " + Player.Con);
        }

        static void ClearPlayersSecondStatsBox()
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

        static void DrawPlayersThirdStatsBox()
        {
            Draw.Rectangle(20, 2, 2, 1, Draw.DrawKind.BelowCursorButKeepCursorLocation, color: ConsoleColor.Green);
            UpdatePlayersThirdStatsBox();
        }

        public static void UpdatePlayersThirdStatsBox()
        {
            ClearPlayersThirdStatsBox();
            Console.SetCursorPosition(4, 15);
            Console.Write("XP: " + Player.XP);
            Console.SetCursorPosition(4, 16);
            Console.Write("LU: " + Player.LU);
        }

        static void ClearPlayersThirdStatsBox()
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

        static void DrawPlayersFourthStatsBox()
        {
            Draw.Rectangle(20, 3, 2, 1, Draw.DrawKind.BelowCursorButKeepCursorLocation, color: ConsoleColor.Green);
            UpdatePlayersFourthStatsBox();
        }

        public static void UpdatePlayersFourthStatsBox()
        {
            ClearPlayersFourthStatsBox();
            Console.SetCursorPosition(4, 18);
            Console.Write("Weapon: " + Player.Weapon);
            Console.SetCursorPosition(4, 19);
            Console.Write("OfHand: " + Player.OffHand);
            Console.SetCursorPosition(4, 20);
            Console.Write("Armour: " + Player.Armour);
        }

        static void ClearPlayersFourthStatsBox()
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

        #region Players Fifth Stats Box

        static void DrawPlayersFifthStatsBox()
        {
            Draw.Rectangle(20, 26, 2, 1, Draw.DrawKind.BelowCursorButKeepCursorLocation, color: ConsoleColor.Green);
            UpdateInventory();
        }

        public static void UpdateInventory()
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

        static void ClearInventory()
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

        static void DrawFightOrderBox()
        {
            Draw.Rectangle(20, 10, 148, -23, Draw.DrawKind.BelowCursorButKeepCursorLocation, color: ConsoleColor.Red);
            UpdateFightOrderBox();
        }

        public static void UpdateFightOrderBox()
        {
            ClearFightOrderBox();
            Console.SetCursorPosition(153, 6);
            Console.Write("Fight Order");
            Console.SetCursorPosition(153, 8);
            Console.Write("Murtagh");
            Console.SetCursorPosition(153, 9);
            Console.Write("Bandit 1");
            Console.SetCursorPosition(153, 10);
            Console.Write("Bandit 2");
            Console.SetCursorPosition(153, 11);
            Console.Write("Bandit 3");
            Console.SetCursorPosition(153, 12);
            Console.Write("Bandit 4");
            Console.SetCursorPosition(153, 13);
            Console.Write("Bandit 5");
            Console.SetCursorPosition(153, 14);
            Console.Write("Bandit 6");
            Console.SetCursorPosition(153, 15);
            Console.Write("Bandit 7");
        }

        static void ClearFightOrderBox()
        {
            for (int YPos = 6; YPos < 16; YPos++)
            {
                Console.SetCursorPosition(153, YPos);
                for (int x = 0; x < 15; x++)
                {
                    Console.Write(" ");
                }
            }
        }

        #endregion

        #region Enemies Box

        static void DrawEnemiesBox()
        {
            Draw.Rectangle(20, 10, 148, 10, Draw.DrawKind.BelowCursorButKeepCursorLocation, color: ConsoleColor.Red);
            Console.SetCursorPosition(155, 17);
            Console.Write("Enemies");
            Console.SetCursorPosition(155, 19);
            Console.Write("Bandit 1");
            Console.SetCursorPosition(155, 20);
            Console.Write("Bandit 2");
            Console.SetCursorPosition(155, 21);
            Console.Write("Bandit 3");
            Console.SetCursorPosition(155, 22);
            Console.Write("Bandit 4");
            Console.SetCursorPosition(155, 23);
            Console.Write("Bandit 5");
            Console.SetCursorPosition(155, 24);
            Console.Write("Bandit 6");
            Console.SetCursorPosition(155, 25);
            Console.Write("Bandit 7");
        }

        public static void UpdateEnemiesBox()
        {

        }

        static void ClearEnemiesBox()
        {

        }

        #endregion

        #region Story Box

        public static void WriteStory()
        {
            ClearStory();
            string Text = "123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789";
            List<string> Story = CheckStringLength(Text);
            int XPos = 28;
            int YPos = 6;
            foreach (string Line in Story)
            {
                Console.SetCursorPosition(XPos, YPos);
                Console.Write(Line);
                YPos += 1;
            }
        }

        static List<string> CheckStringLength(string Text)   //97 chars long
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
                }
            }
            return Story;
        }

        static void ClearStory()
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

        public static void PrintPlayerOptions()
        {
            Console.SetCursorPosition(28, 41);
            Console.Write("1. Option 1");
            Console.SetCursorPosition(28, 42);
            Console.Write("2. Option 2");
            Console.SetCursorPosition(28, 43);
            Console.Write("3. Option 3");
            Console.SetCursorPosition(28, 44);
            Console.Write("4. Option 4");
            Console.SetCursorPosition(28, 45);
            Console.Write("5. Option 5");
            Console.SetCursorPosition(28, 46);
            Console.Write("6. Option 6");
            Console.SetCursorPosition(28, 47);
            Console.Write("7. Option 7");
            Console.SetCursorPosition(50, 41);
            Console.Write("1. Option 8");
            Console.SetCursorPosition(50, 42);
            Console.Write("2. Option 9");
            Console.SetCursorPosition(50, 43);
            Console.Write("3. Option 10");
            Console.SetCursorPosition(50, 44);
            Console.Write("4. Option 11");
            Console.SetCursorPosition(50, 45);
            Console.Write("5. Option 12");
            Console.SetCursorPosition(50, 46);
            Console.Write("6. Option 13");
            Console.SetCursorPosition(50, 47);
            Console.Write("7. Option 14");
            Console.ReadLine();
            ClearPlayerOptions();
        }

        static void ClearPlayerOptions()
        {
            for (int YPos = 41; YPos < 49; YPos++)
            {
                Console.SetCursorPosition(28, YPos);
                for (int x = 0; x < 50; x++)
                {
                    Console.Write(" ");
                }
            }
        }

        #endregion

    }
}
