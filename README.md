# VR-Project Nadine Rosenzopf
![Uebersicht](https://user-images.githubusercontent.com/72389468/164446175-9380c068-ebab-4cfd-a22a-30196b6a0213.JPG)


### Information:
Unfortunately, the WackAMole commits have been neglected due to minor problems in the beginning (connection, internet,...). I ask for your understanding.
The commits are unfortunately not in English.

### Inserted assets:
1. gaming machine https://free3d.com/3d-model/asteroids-upright-arcade-machine-20174.html 
2. hammer from CG Trader
3. dog https://www.turbosquid.com/
4. dead rabbit
5. tin https://www.turbosquid.com/de/3d-models/free-obj-model-generic-metal-sheet/538417
6. old lamp https://www.turbosquid.com/de/3d-models/3d-old-lamp-1552787

### Inserted sounds:
1. Introduction: Self recorded!
2. sourround sound https://www.youtube.com/watch?v=wrRNj9gJezA 
3. blood sound for WackAMole
5. End of the Game: Self recorded!




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


## Underground:
An earthy corridor with water (Unity Standard Assets) is in front of you. If you walk along the narrow passage, you will come to a glowing hammer, which must be taken for the next puzzle. If you continue along the corridor, you will come to an elevator, which will go up with the help of the button operation.

## Second part:

### Puzzle 2:
Here you will find the game "whack a mole". Using the hammer you found before, you have to hit a certain number of these little animals with the hammer within a certain period of time (like the original). One has 3 attempts. If a time has expired and I have not slain the desired number of marmots, a life point disappears. After 3 mistakes the "Death-Screen" appears.

![Mole](https://user-images.githubusercontent.com/72389468/164448619-148da3d0-cd03-49e5-bd5c-ffd5380443d4.png)

### Conclusion:
When this task has been completed, you are allowed to go to freedom and a door opens and the "You did it" screen appears.

### Timer:
Located in the upper right of the canvas and counts down the time. Once the time is up, a "DeathScreen" appears and the player has the option to choose between "Restart" and "Close Game".


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


Copyright by Nadine :)
