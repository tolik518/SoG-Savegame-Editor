using System.Collections.Generic;

namespace SoG_SGreader
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