# ISTALRI SKOLIR PRODUCTIONS

# Text-Adventure-GUI
The code from this project is from the Text-Adventure-Environment project.

Draws boxes to a console with different player stats, fight orders, story text, etc. Has public functions to update the display

This code utilizes a 'Draw'class made by Ryan S White, link to the original page: https://www.codeproject.com/Tips/1091249/Drawing-a
Rectangle-in-the-Csharp-Console

The code uses 4 different classes each in their own .cs file. The first is the 'Draw' class which I sourced from the above link, this is
a static class that has functions that can be called to draw boxes of different shapes, sizes and colours to the console. Check out the
link above more more detail.

The second class is the static 'Player' Class, this houses the stats of the player that the 'DrawGUI' classes uses to print to the
console. Feel free to change anything within this class, though bear in mind that alterations to the 'DrawGUI' class may be needed if
done so.

The third class is the static 'StartDisplay' class, this stores the variables that are printed to the boxes on program start up that
aren't Player related. This is the data for the Story Box, Fight Order Box, Enemies Box, Player Options Box and the Events Box.

The Final class is the main bulk of the project, when the program is first ran, it calls the 'DrawGUIConsole' function from the static
'DrawGUI' class. This function draws all the initial borders and stats boxes before calling their update functions. To update the
information in these boxes, use the following public functions:

1) DrawGUIConsole() - Needs to be called at the start of the program, draws everything to the console. Can be called again to completely
redraw everything if need be, but this will display the start up info in the Story Box, Fight Order Box, Enemies Box, Player Options Box
and the Events Box. If you call this after initial run time then make sure you also call the aproppriate update functions to display the
correct information.

2) UpdatePlayersFirstStatsBox() - Will update the box containing the Player's Name, Level, Hit Points and Armour Class using the'Name',
'Level', 'HP', 'MaxHP' and 'AC' variables in the static 'Player' class.
                                    
3) UpdatePlayersSecondStatsBox() - Will update the box containing the Player's Strength, Dexterity and Constition using the 'Str', 'Dex'
and 'Con' variables in the static 'Player'class.
                                    
4) UpdatePlayersThirdStatsBox() - Will update the box containing the Player's XP and XP needed for Next Level using the 'XP' and 'LU'
variables in the static 'Player' class.
                                    
5) UpdatePlayersFourthStatsBox() - Will update the box containing the Player's Weapon, Off-Hand and Armour using the 'Weapon', 'OffHand'
and 'Armour' variables in the static 'Player' class.
                                    
6) UpdateInventory() - Will update the box containing the Player's Inventory using the 'Inventory' list in the static 'Player' class.

7) UpdateFightOrderBox(List<string>) - Will update the box containing the fight order of PC and NPCs turns in a fight. Pass it a
  'List<string>' containing the PCs and NPCs in the fight order.
  
8) UpdateEnemiesBox(List<string>)- Will update the box containing the NPCs that the Player is currently fighting. Pass it a'List<string>
containing all the enemies for the encounter.
  
9) UpdateStoryBox(string) - Will update the box containing the Story informing the Player of current events. Pass it a 'string' to print
to the box.

10) UpdatePlayerOptions(List<string>) - Will update the box containing the Players options for the current event. Pass it a
'List<string>' containing all of the Player's options.

11) UpdateEventBox(List<string>) - Will update the box containing the games Events. Pass it a 'List<string>' containing the latest game
events.
