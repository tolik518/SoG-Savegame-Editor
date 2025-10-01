<p align="center">    
	<img src="https://returnnull.de/images/_64.png">    
</p>
<h1 align="center">SoG Savegame Editor</h1>
<p align="center"> 
  <img src="https://img.shields.io/github/v/tag/tolik518/SoG_Savegame_Editor?label=latest%20version&style=flat-square">    
  <img src="https://img.shields.io/github/downloads/tolik518/SoG_Savegame_Editor/total?style=flat-square"> 
</p> 
<p align="center"> 
SoG Savegame Editor is a tool for editing <a href="https://store.steampowered.com/app/269770/Secrets_of_Grindea/">Secrets of Grindea</a> character savegames.
You can edit your nickname, skill points, gold, equipment, inventory, your pets and much more!
</p> 

## Download
Head over to the releases if you are just here for the [download link](https://github.com/tolik518/SoG_Savegame_Editor/releases), then press on `Assets`   
on the latest version and download the `SoG_Savegame_Editor.zip` file. 

Or just [press here](https://github.com/tolik518/SoG_Savegame_Editor/releases/latest/download/SoG_Savegame_Editor.zip) to download the latest version.

**Hint**: *You just want to just change your **name** and **gender** and are afraid of being tempted to cheat? Then it's better to use the stripped-down [Character Editor](https://github.com/tolik518/sog-character-editor)*

## How to use
![SoG_Savegame_Editor](.github/screenshots/SoG_Savegame_Editor_load_0.7.0.PNG)

You can just run the exe and it will open a file dialog where you can select your savegame file.
After that you can edit your savegame and save it back to the same file.

Alternatively you can drag and drop your savegame file on the exe and it will open the savegame directly.

You can also use the command line to open a savegame file directly.
```
SoG_Savegame_Editor.exe <savegame path> # Open UI with savegame, path to savegame is optional

SoG_Savegame_Editor.exe --help # Show help
SoG_Savegame_Editor.exe --patch # Show the supported game version
SoG_Savegame_Editor.exe --version # Show the version of the program

SoG_Savegame_Editor.exe --json <savegame path> # Print json of the savegame to console
SoG_Savegame_Editor.exe --text <savegame path> # Show a short summary of the savegame
```

You could for example use [jq](https://jqlang.github.io/jq/) to get a specific value from the savegame, like the level of the character.
```
/home/developer/Projects/CSharp/SoG_Savegame_Editor/SoG_Savegame_Editor/bin/Debug/SoG_Savegame_Editor.exe --json "/home/developer/.config/Secrets of Grindea/Characters/2.cha" | jq .Level
```

## More

If you are interested how the save game file is build, you can find the structure   
of the save game on the [wiki page](https://github.com/tolik518/SoG_Savegame_Editor/wiki/Savegame-File-Structure) (not actively maintained).    
  

![SoG_Savegame_Editor](.github/screenshots/SoG_Savegame_Editor_main_0.7.0.PNG)  
  
If you want your savegame to work you need to save it over to "%APPDATA%\Secrets of Grindea\Characters" and name it 0.cha to 8.cha
  
![SoG_Savegame_Editor](.github/screenshots/SoG_Savegame_Editor_pets_0.7.0.PNG)
![SoG_Savegame_Editor](.github/screenshots/SoG_Savegame_Editor_items_0.7.0.PNG)

Keywords: "Secrets of Grindea Savegame", "Secrets of Grindea Savegame Editor", "save file", "Character File"
