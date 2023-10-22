using CommandLine;

namespace SoG_SGreader
{
    class ComandLineOptions
    {
        [Value(0, MetaName = "savegame path", Required = false, HelpText = "Path to the savegame")]
        public string SavegamePath { get; set; }

        [Option('t', "text", HelpText = "Show a short summary of the savegame")]
        public bool ShowText { get; set; }

        [Option('j', "json", HelpText = "Print json of the savegame to console")]
        public bool ShowJson { get; set; }

        [Option('h', "help", HelpText = "Show help")]
        public bool ShowHelp { get; set; }
        
        [Option('p', "patch", HelpText = "Show the current supported patch version")]
        public bool ShowPatch { get; set; }
    }
}