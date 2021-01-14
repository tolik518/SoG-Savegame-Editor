# SoG Savegame Reader/Editor ![Icon](https://returnnull.de/images/_64.png)

This is a work in progress tool that reads the savegame from [Secrets of Grindea](https://store.steampowered.com/app/269770/Secrets_of_Grindea/).
Some key features like changing the nickname or equipment already do work and you can edit your equipment style.
You can find the structure of the save game on the [wiki page](https://github.com/tolik518/SoG_SGreader/wiki/Savegame-File-Structure).  


For safety reasons the savegame is ALWAYS saved as "8.cha" in the same directory as the executable. If you wan't to play with the  
modified savegame you'll have to copy the "8.cha" file to "%APPDATA%\Secrets of Grindea\Characters" by hand  


There is still a lot to do.
e.x
* Filter the suggested items after by slot
* Add a feature to select colors for clothing etc, we already have an enum for that with the colors
* Inventory editing (we are already reading and storing the items in a list)
* Research: e.x How pets are stored and what outher stuff is left in savegame
* Research: what the first 4 bytes stand for, these are NOT magic bytes
* Research: why we cant change the equiped weapon, shied and shoes? <- somethign to do with inventory
* Documentation of the functionality and of the research process
* And tons of other stuff

![SoG_SGreader](https://returnnull.de/images/_SoG_SGreader.png)




Keywords: "Secrets of Grindea", "Secrets of Grindea Savegame", "Editor", "Cheat", "Hack", "save game", "save file", "Character File"
