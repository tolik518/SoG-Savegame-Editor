using CommandLine;

namespace SoG_SGreader
{
    class ComandLineOptions
    {
        [Value(0, MetaName = "savegame path", HelpText = "Path to the savegame", Required = false)] 
        public string SavegamePath { get; set; }

        [Option('t', "text", HelpText = "Show a short summary of the savegame")]
        public bool ShowText { get; set; }

        //specify the json option and the path to the savegame
        [Option('j', "json", HelpText = "Show the savegame as json")]
        public bool ShowJson { get; set; }

        [Option('h', "help", HelpText = "Show help")]
        public bool ShowHelp { get; set; }
        
        [Option('p', "patch", HelpText = "Show the current supported patch version")]
        public bool ShowPatch { get; set; }
    }
}