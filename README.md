# SoG Savegame Reader/Editor ![Icon](https://returnnull.de/images/_64.png)

![SoG_SGreader](https://returnnull.de/images/_SoG_SGreader3.png)  

This is a work in progress tool that reads the savegame from [Secrets of Grindea](https://store.steampowered.com/app/269770/Secrets_of_Grindea/).
Some key features like changing the nickname or equipment already do work and you can edit your equipment style.
You can find the structure of the save game on the [wiki page](https://github.com/tolik518/SoG_SGreader/wiki/Savegame-File-Structure).  
  
![SoG_SGreader](https://returnnull.de/images/_SoG_SGreader2.png)  
  
For safety reasons the savegame is ALWAYS saved as "8.cha" in the same directory as the executable. If you wan't to play with the  
modified savegame you'll have to copy the "8.cha" file to "%APPDATA%\Secrets of Grindea\Characters" by hand  
  
There is still a lot to do.
e.x
- Reset all variables when a new savegame is loaded
- Split "Sog_Spells"-Enum into the "_Sog_Spells"-Class
- Option to let the user decide if the population of the combobox should be filtered or not
- Do we really need to be able to edit Quickslots?
- If an Item that was equipped is not in the inventory, add to the inventory
- Color selection form
- Inventory edition functionality
- Better visualization of the inventory
- Research: e.x How pets are stored and what other stuff is left in savegame
- Research: why we cant change the equipped weapon, shied and shoes? <- something to do with inventory?
- Documentation of the functionality and of the research process

  
![SoG_SGreader](https://returnnull.de/images/_SoG_SGreader.png)

  
  

  

Keywords: "Secrets of Grindea", "Secrets of Grindea Savegame", "Editor", "Cheat", "Hack", "save game", "save file", "Character File"
