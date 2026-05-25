# Dodge2D Extension

✅ Complete  
❕ Module 1 Dodge Game Extension  

A simple 2D dodge game built in Unity where the player avoids falling objects and survives for as long as possible. Use **A/D** or **Left/Right Arrow Keys** to move. Press **Space** to restart after game over.

## Gameplay

The objective of the game:

- Move left and right
- Dodge the falling obstacles
- Survive as long as possible
- Try to get the highest score possible

## Required Features

This project includes the required gameplay systems for the Module 1 extension:

- Score counter
- Game over screen
- Restart system
- Player movement
- Collision detection
- Falling object spawning
- Basic game flow

## Additional Feature: Random Obstacle Sizes

The additional gameplay feature I added is **random obstacle sizes**.

Instead of every falling obstacle being the same size, I made it to where each obstacle now spawns with a random size. Some of obstacles are smaller and easier to dodge, while others are bigger and harder to avoid. This makes the game more unpredictable and challenging because the player has to react to different obstacle sizes while playing.

This feature was implemented in the `Spawner` script. When a new falling object is spawned, the script randomly chooses a size between a minimum and maximum value and applies that size to the obstacle’s scale.

## Controls

- **A** / **Left Arrow**: Move left
- **D** / **Right Arrow**: Move right
- **Space**: Restart after game over

## Built With

- Unity
- C#

## Learning Goals

- GameObjects and Components
- Transform and movement systems
- The Unity Update loop
- Collision handling
- Prefab spawning systems
- Score tracking
- UI/game over flow
- Restart/game state management
- Basic gameplay architecture

## Important

If you see a TextMesh Pro font import error when opening the project, go to:

Window → TextMeshPro → Import TMP Essential Resources

Unity will automatically re-import the required TMP assets.

After opening the project in Unity, go to:

Assets → Scenes → SampleScene

Press the Play button to run the game.