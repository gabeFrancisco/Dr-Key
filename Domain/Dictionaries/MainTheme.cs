using Domain.Enums;
using System.Collections.Generic;

namespace Domain.Dictionaries
{
    public class MainTheme
    {
        public Dictionary<string, Theme> Theme { get; set; } = new Dictionary<string, Theme>();
        public MainTheme()
        {
            this.Theme.Add("Claro", Enums.Theme.LIGHT);
            this.Theme.Add("Escuro", Enums.Theme.DARK);
        }
    }
}
