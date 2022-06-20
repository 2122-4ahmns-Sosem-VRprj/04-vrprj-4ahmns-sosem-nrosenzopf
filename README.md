# VR-Project Nadine Rosenzopf
 ![Unbenannt-1](https://user-images.githubusercontent.com/72389468/173933636-c494aaf7-4740-4ebf-82b5-d4db2ef1211a.jpg)

Attention! Objects are not arranged correctly here. This is only for a rough overview!


### Information:
Unfortunately, the WackAMole commits have been neglected due to minor problems in the beginning (connection, internet,...). I ask for your understanding. After 2 weeks the commits started correctly.
The commits are unfortunately not in English.

### Inserted packages:

| Package Name | Package ID | Version |
|:---|:---|:---|
| JetBrains Rider Editor | com.unity.ide.rider | 2.0.7 |
| Oculus XR Plugin | com.unity.xr.oculus | 1.10.0 |
| Test Framework | com.unity.test-framework | 1.1.31 |
| TextMeshPro | com.unity.textmeshpro | 3.0.6 |
| Timeline | com.unity.timeline | 1.4.8 |
| Unity UI | com.unity.ugui | 1.0.0 |
| Version Control | com.unity.collab-proxy | 1.9.0 |
| Visual Studio Code Editor | com.unity.ide.vscode | 1.2.3 |
| Visual Studio Editor | com.unity.ide.visualstudio | 2.0.11 |
| XR Interaction Toolkit | com.unity.xr.interaction.toolkit | 2.0.1 |
| XR Plugin Management | com.unity.xr.management | 4.0.7 |

### Inserted assets:
1. gaming machine https://free3d.com/3d-model/asteroids-upright-arcade-machine-20174.html 
2. hammer from CG Trader
3. dog https://www.turbosquid.com/
4. dead rabbit
5. tin https://www.turbosquid.com/de/3d-models/free-obj-model-generic-metal-sheet/538417
6. barrel https://www.turbosquid.com/de/AssetManager/Index.cfm?stgAction=getFiles&subAction=Download&intID=1790727&intType=3&csrf=4CCA0D8322C5B519585621AD9DF017BC63ACD9B2&showDownload=1&s=1
7. Grafittiwall https://sketchfab.com/3d-models/abandoned-building-003d543d7a81edb4dcd8237dd3142231d78#download
8. RainMaker https://assetstore.unity.com/packages/vfx/particles/environment/rain-maker-2d-and-3d-rain-particle-system-for-unity-34938
9. Lamp https://www.turbosquid.com/de/AssetManager/Index.cfm?stgAction=getFiles&subAction=Download&intID=1681409&intType=3&csrf=D198EF018B6CD7FF2BA44B1667CAFE250C30384D&showDownload=1&s=1
10. WATER https://assetstore.unity.com/packages/tools/animation/water-float-164693

### Inserted sounds:
1. Introduction: Self recorded!
2. sourround sound https://www.youtube.com/watch?v=wrRNj9gJezA 
3. blood sound for WackAMole
5. End of the Game: Self recorded!
6. Undefined Sound Effects: Youtube




# Gameplay with puzzle
## Start: 
Entrance in front of the maze: high walls, no exit possible; Only way: into the maze.
Maze consists of two parts, which is connected with the help of an underground.
## In the first part:
### Puzzle 1:
Labyrinth with 4 eggs hidden, which have a certain color. When I pick up the egg, a number is said with the help of the audio (example red=5. The speaker says "5").
After each pick up, a 2D egg appears in the canvas in the picked up color with the just mentioned value.
The 3D egg disappears after being picked up.
In the middle of the game there is a small arithmetic puzzle game. For this you need these 4 eggs with the respective color. On the walls there are 3 small calculations like for example "Red-Blue=?". There is under each calculation 1 button, where the number is to be entered in each case. The number increases each time the button is pressed: 1 click and the number increases by 1 (for example, the current number is 4 and the button is pressed, it jumps to 5). To each calculation belongs a button. If all 3 calculations are correct, a trapdoor opens and the game falls into the underground. IMPORTANT: The numbers are NOT regenerated every round.

![Spiel1 1](https://user-images.githubusercontent.com/72389468/164445084-e431bc2e-37f3-4384-a692-1c218f73879d.JPG)
![Spiel1 2](https://user-images.githubusercontent.com/72389468/164445135-5c37fb3a-cf6b-4b99-ab7f-3fc9880b31cc.JPG)
![Spiel1 3](https://user-images.githubusercontent.com/72389468/164445160-70c48221-05a8-4129-a57b-dcef425cf59f.JPG)

## Die:
If you touch these objects you die!

![fdga](https://user-images.githubusercontent.com/72389468/173935146-facb256a-e0b2-4f93-86c7-cf7db9a6cbf2.jpg)



## Underground:
An earthy corridor with water (Unity Standard Assets) is in front of you. If you walk along the narrow passage, you will come to a glowing hammer, which must be taken for the next puzzle. If you continue along the corridor, you will come to an elevator, which will go up with the help of the button operation.

## Second part:

### Puzzle 2:
Here you will find the game "whack a mole". Using the hammer you found before, you have to hit a certain number of these little animals with the hammer within a certain period of time (like the original). One has 3 attempts. If a time has expired and I have not slain the desired number of marmots, a life point disappears. After 3 mistakes the "Death-Screen" appears.

![Mole](https://user-images.githubusercontent.com/72389468/164448619-148da3d0-cd03-49e5-bd5c-ffd5380443d4.png)

### Conclusion:
When this task has been completed, you are allowed to go to freedom (on holiday/beach) and a door opens, a man talks to you and the screen appears.
![EndeFreedom](https://user-images.githubusercontent.com/72389468/174680661-ebe8d110-18dd-45c0-a474-f43dd918f89d.JPG)



### Die:
If you die during the game, this overlay will appear.
To click the button, simply hold out your hand.
(Trigger function, tested and working)
![Over](https://user-images.githubusercontent.com/72389468/173938702-cd9989fe-8010-4182-90d0-c51e0b9bfec2.JPG)


### What you don't see/notice right away: 

1. Rain from Trigger
2. Freedom Trigger
3. Death
4. Ground in Underground appears only when first Game true
5. Waiters built in at start, end and during the game
6. The WackAMole Game was completely reprogrammed 3 times
7. Many animations designed by myself


# Required Sounds:
Easter egg number like "Five " (narrator).
Background music and fog/wind sounds
Water sounds for the underground and breathing of the player
Button sound and trapdoor sound
Hammer light sound
Groundhog/rat/...
Wreck a mole - game machine and hammer sound
Timer Light sound, door open to freedom sound
Death screen / Winner screen sounds stop and music starts

# Information about the Steps:
These were for planning purposes only.
During the final implementation, many more steps were taken.

# Steps: 
1. Incorporate game functions (make it VR ready). Can the player move?
How big do my objects need to be? VR testing.
2. Game 1: Assign Easter eggs assets with color and number with sound. Calculations
Set up and feed solutions into button function. If egg picked up, then appears
in the canvas this color of the egg with the given value.
3. Continue working on feeding in canvas. Then compare values and if true
Execute animation "trap door". Built Exe and test.
4. Fix problems game 1.
Death Screen: Restart and exit button. Music and sounds off and new song starts.
Game 2 Rechere as in the VR area.
Game 2: Timer and Score. Groundhogs which move randomly up and down. Timer
runs out: 1 life reduced from 3. One object removed above game. If lost 3 times,
then death screen.
6. Trigger function that makes score increase. If certain number of groundhogs:
Then True and door in freedom with Winner Screen. Winner Screen: "You did it."
Restart and Exit Button. Music and sounds off and new song starts.
7. Insert underground. For underground: insert hammer, insert water StandartAssets.
8. Continue working on game 2. then test in VR mode. Install timer: 15min time for game and if expired: Death screen appears.
Fix game 2 problems and finish game 2 (if needed). Test again
10. Design start: game 1: easter eggs, button, trap door, walls with tin roof, floors.
11. Download sounds, convert them correctly and integrate them into Scene.
12. Design underground and integrate water with fog. Add assets for game start and
add more decorations. Design for game 2.
13. Test game and if there is still time, add object animations for static positions.
14. Improvements and finalize design and sounds.
15. Finish game and test again.



## Why exactly this game?
The user has a unique experience of creepiness and puzzle fun. In a wonderfully creepy atmosphere in the fog, the games has to solve simple puzzles, which nevertheless have to be executed under time pressure. The underground also offers an individual highlight, which gives the player a lot of width throughout the game, especially in the VR area. The puzzles, which run through the game, also play an enormous role here: Instead of just playing the puzzle on one spot, eggs have to be collected beforehand to be able to solve the MiniGame at all. Also the hammer for the "Wrack a hole" game is located underground and has to be taken until the end of the game.
![Rosenzopf](https://user-images.githubusercontent.com/72389468/174569773-e73fdaa3-127f-49be-954d-fd2b8eeaa26b.JPG)


Copyright by Nadine :)
