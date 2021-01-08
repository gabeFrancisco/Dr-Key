using System.Collections.Generic;

namespace Domain.Dictionaries
{
    public class ThemeColors
    {
        public Dictionary<string, string> Color { get; set; } = new Dictionary<string, string>();
        
        public ThemeColors()
        {
            this.Color.Add("Verde Claro", "LightGreen");
            this.Color.Add("Azul", "LightBlue");
            this.Color.Add("Vermelho", "LightCoral");
            this.Color.Add("Vintage", "Khaki");
        }
    }
}
