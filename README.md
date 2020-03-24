ISTALRI SKOLIR PRODUCTIONS

# Text-Adventure-GUI
* Working Progress* Draws boxes to a console with different player stats, fight orders, story text, etc. Has public functions to update display

This code utilizes a 'Draw'class made by Ryan S White, link to the original page: https://www.codeproject.com/Tips/1091249/Drawing-a-Rectangle-in-the-Csharp-Console

The code uses 3 different classes each in their own .cs file. The first is the 'Draw' class which I sourced from the above link, this is a
static class that has functions that can be called to draw boxes of different shapes, sizes and colours to the console. Check out the link
above more more detail.

The second class is a static 'Player' Class, this houses the stats of the player that the 'DrawGUI' classes uses to print to the console.
Feel free to change anything within this class, though bear in mind that alterations to the 'DrawGUI' class may be needed if done so.

The Final class is the main bulk of the project, when the program is first ran, it calls the 'DrawGUIConsole' function from the static 'DrawGUI'
class. This function draws all the initial borders and stats boxes before calling their update functions. To update the information in
these use the following public functions:

1) DrawGUIConsole()               - Needs to be called at the start of the program, draws everything to the console. Can be called again
                                    again to completely redraw everything if need be.
2) UpdatePlayersFirstStatsBox()   - Will update the box containing the Player's Name, Level, Hit Points and Armour Class using the
                                    'Name', 'Level', 'HP', 'MaxHP' and 'AC' variables in the static 'Player' class.
3) UpdatePlayersSecondStatsBox()  - Will update the box containing the Player's Strength, Dexterity and Constition using the 'Str',
                                    'Dex' and 'Con' variables in the static 'Player'class.
4) UpdatePlayersThirdStatsBox()   - Will update the box containing the Player's XP and XP needed for Next Level using the 'XP' and 'LU'
                                    variables in the static 'Player' class.
5) UpdatePlayersFourthStatsBox()  - Will update the box containing the Player's Weapon, Off-Hand and Armour using the 'Weapon',
                                    'OffHand' and 'Armour' variables in the static 'Player' class.
6) UpdateInventory()              - Will update the box containing the Player's Inventory using the 'Inventory' list in the static
                                    'Player' class.
7) UpdateFightOrderBox()          - Will update the box containing the fight order of PC and NPCs turns in a fight.
8) UpdateEnemiesBox()             - Will update the box containing the NPCs that the Player is currently fighting.
9) UpdateStoryBox()               - Will update the box containing the Story informing the Player of current events.
10) UpdatePlayerOptions()         - Will update the box containing the Players options for the current event.
