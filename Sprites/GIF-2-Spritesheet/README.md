# Sprites
<p align="center">
  <h1 align="center">Made for Pokemon Unity</h3>
  <p align="center">
    <a href="https://discord.gg/aftYdfV"><img alt="Discord Server" src="https://img.shields.io/discord/285560546244427777.svg"></a>
    <a href="https://www.reddit.com/r/PokemonUnity/"><img alt="Reddit" src="https://img.shields.io/badge/join%20us%20on-reddit-ff5700.svg"></a>
    <a href="https://pokemonunity.gitbooks.io/pokemon-unity/content/"><img alt="GitBook" src="https://img.shields.io/badge/view%20docs%20on-gitbook-blue.svg"></a>
  </p>
</p>

The sprite GIF animations are downloaded from: https://sprites.pokecheck.org/
The 'GIF to SH' program is an edited version of: https://forum.chaos-project.com/index.php?topic=11601.0
The convert.exe file is part of the ImageMagick project: https://www.imagemagick.org/script/index.php

In the folder Executable you'll find 2 '.exe' files. You'll need to run 'Gif to Sheet' to convert your GIF files into spritesheets or to frames.
I edited the the program (https://forum.chaos-project.com/index.php?topic=11601.0) to run through an entire folder instead of file per file.
This saves time if you want to convert a large amount of GIF files. I also added an option to convert your GIF file to individual frames.
Since Pokemon Unity (the old version) requires individual frames to work, this option can help save some time. This is also why there's a file called 'convert.exe' in the same folder.
This file helps with converting the GIF files into frames.

The program is really simple and I'll give two guides:

Using Gif to Sheet to convert your GIF files into spritesheets:
1) Open Gif to Sheet and use the 'Browse' button to locate your folder with GIF files
2) When you selected the folder where your GIF files are located you can see an example in the box below
3) You can change the width and height of the sprites with the Width and Height box. (If you're using the GIF files provided in this GitHub repo I advice to use 160 x 160)
4) In the Columns section you can change in how many columns you want your sprites to be in (meaning how many images will be from left to right)
5) In the Background Color section you can change the background color that your spritesheet needs to have (IMPORTANT! It's standard on transparent, if you change this value to a different color you can't change it back to transparent)
6) If you're finished you can hit the 'Export' button and select the folder where you want your spritesheets to be saved
7) Done

Using Gif to Sheet to convet your GIF files into frames
1) Open Gif to Sheet and use the 'Browse' button to locate your folder with GIF files
2) Check the 'GIF To Frames' box in the top right corner
3) You can't change the width, height or columns if you want to convert the GIF files into frames
4) Hit the 'Export' button and select the folder where you want your frames to be saved
5) When you click 'OK' several console windows will open for a short time, this is the 'convert.exe' file doing this magic
6) GIF to Sheet will create sub-folders for each GIF that needs to be converted
7) Done

Check out Pokemon Unity
## Links

* Reddit: <https://www.reddit.com/r/PokemonUnity/>
* YouTube: <https://www.youtube.com/c/IIcolourSpectrum>
* Discord server: <https://discord.gg/aftYdfV>
* Documentation: <https://pokemonunity.gitbooks.io/pokemon-unity/content/>