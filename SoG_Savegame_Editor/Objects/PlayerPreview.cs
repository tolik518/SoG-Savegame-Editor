using System.Collections.Generic;

namespace SoG_Savegame_Editor
{
    public class PlayerPreview
    {
        public bool Sex { get; set; }
        public string Nickname { get; set; }

        public string GetSex()
        {
            return Sex ? "♂" : "♀";
        }
    }
}