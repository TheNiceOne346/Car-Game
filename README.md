# Car-Game
 Assignment
The Car game ive created is a 1v1 game over three levels from where you start. When you start the game there is a main menu where you have following play,how to play and start.
I recommend to read how to play before pressing play because all controls of the game are laid in text in that menu. You also got powerups you can pick up that are cola cans you can shoot the other player with.
If a player hits someone with the can the other should slow down but you also start with 3 can bullets. There is also an easter egg , if you drive up to the upper corner on the right in level 2 a color change will appear.
Thats The Game!

# Intructions and info
When you have pressed play a timer will accuer that goes down 3 2 1. Then the players can drive, going through each level there will be a timer on the start. You play against another player.
The goal of the game is that the first to get to the end of the third level wins. While going through levels you will face moving objects in the way , also powerups to slow down the other playing opponent. But main is the first player to get to the third level to win! You dont need any additional package for downloading.

# An example of structure and design Ive used

When creating the shooting script I took insperation from brackeys video TOP DOWN SHOOTING because of I liked the structure and design of that. I structed up so the colabulletprefab is connected to the shooting script and since Im using firepoints where the bullet spawn. I put they below the Player 1 and Player 2 in the Hierarchy because they are actually "empty gameobjects" working as a spawn point.



# I will list some issues ive encounterd 
1. I had a problem when shooting the cola can, the player who was shooting also got slowed down. But after some debuging and tryingout diffrent methods I found out the bullet spawned in the car.
   So I went i realised that I went back to unity and moved my firepoint out of the car and it worked.
2. I wanted to do so when every new level there is a timer on 321 only problem was when I first made the code , the text would move away from the script so i made a if statement to check the starttimer and to set the counttext to false.
3.  My biggest problem was the movement. Since I hadnt coded for about 4-5 years ago and only learned very simple coding then, its easy to forget how you write code and etc. So I started to watch brackeys turtorials on how to write and also try to understand what everything does. After some reaserch and turtorials I got a working movement script. Exept for the car didnt rotate like I wanted to do. I didnt know how to fixed that so I started to google and using youtube to look on how to solve the issue. AFter some time I end upp knowing more about Quaternion and used Quaternion.Lookrotation to make it rotate. When playing I felt like it gave me a diffrent feeling on movement that I liked. It felt like Tron and something special. But I ended up feeling more I want more to be a car in rotation, so I tried used velocity and unfortenly I didnt find a solution that felt good enough for the game in my knowlodge. The Math ive used in the game is based on Quaternion. Quaterninon in simple terms helps you figure out how to turn your object (like a car, player or camera ) so that it faces a specific direction in 3D space while keeping its "up" in the right position how ever even if its more suitable for 3D i made it so It works in my 2D.

# [[unity version 2022.3.8f1](https://unity.com/releases/editor/whats-new/2022.3.8)](Unity Verison )

1# Referenses and Websites Ive used

Asset
Car and Colabullet made by Linus Lind.
Rest made by me.

Diffrent turtorials and videos Ive gone through

How To Make A Game Episode 3 , Brackeys
https://www.youtube.com/watch?v=Au8oX5pu5u4

How to create a 2D Arcade Style Top Down Car Controller in Unity, Pretty fly games
https://www.youtube.com/watch?v=DVHcOS1E5OQ

Rotating in the Direction of Movement 2D, Ketra Games
https://www.youtube.com/watch?v=gs7y2b0xthU

TOP DOWN SHOOTING in Unity, Brackeys
https://www.youtube.com/watch?v=LNLVOjbrQj4

Level up your code with game progamming patterns, Unity
https://resources.unity.com/games/level-up-your-code-with-game-programming-patterns?ungated=true

Unity Manual, Unity
https://docs.unity3d.com/Manual/Coroutines.html

Unity Manual, Unity
https://docs.unity3d.com/Manual/ExecutionOrder.html



